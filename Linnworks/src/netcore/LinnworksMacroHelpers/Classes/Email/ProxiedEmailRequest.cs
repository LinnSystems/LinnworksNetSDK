using LinnworksMacroHelpers.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinnworksMacroHelpers.Classes.Email
{
    public sealed class ProxiedEmailRequest
    {       

        /// <summary>
        /// Email settings
        /// </summary>
        public EmailSettings Settings { get; set; }

        /// <summary>
        /// Sender
        /// </summary>
        public EmailAddress Sender { get; set; }

        /// <summary>
        /// From
        /// </summary>
        public EmailAddress From { get; set; }

        /// <summary>
        /// List of recipients
        /// </summary>
        public List<EmailAddress> To { get; set; }

        /// <summary>
        /// List of CC recipients
        /// </summary>
        public List<EmailAddress> CC { get; set; }

        /// <summary>
        /// List of BCC recipients
        /// </summary>
        public List<EmailAddress> BCC { get; set; }

        /// <summary>
        /// List of reply to
        /// </summary>
        public List<EmailAddress> ReplyToList { get; set; }

        /// <summary>
        /// Body of email
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Email body encoding, UTF-8 by default
        /// </summary>
        public string BodyEncoding { get; set; }

        /// <summary>
        /// Email subject
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Email subject encoding, UTF-8 by default
        /// </summary>
        public string SubjectEncoding { get; set; }

        /// <summary>
        /// Defines if the body of the email is HTML
        /// </summary>
        public bool IsBodyHtml { get; set; }

        /// <summary>
        /// Delivery notification options
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public DeliveryNotificationOptions? DeliveryNotificationOptions { get; set; }

        /// <summary>
        /// Email headers
        /// </summary>
        public List<EmailHeader> Headers { get; set; }

        /// <summary>
        /// Encoding used with headers.
        /// </summary>
        public string HeadersEncoding { get; set; }

        /// <summary>
        /// Priority of email.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public MailPriority? Priority { get; set; }

        /// <summary>
        /// Email attachements.
        /// </summary>
        public List<EmailAttachment> Attachments { get; set; }

        public ProxiedEmailRequest()
        {
            To = new List<EmailAddress>();
            CC = new List<EmailAddress>();
            BCC = new List<EmailAddress>();
            ReplyToList = new List<EmailAddress>();
            Headers = new List<EmailHeader>();
            Attachments = new List<EmailAttachment>();
        }

        public void Validate()
        {
            if (Settings == null)
                throw new Exception("Settings must be supplied");

            Settings.Validate();
            CleanCollections();

            if (To?.Any() == false && CC?.Any() == false && BCC?.Any() == false)
                throw new Exception("At lest one To, CC or BCC must be supplied");

            if (string.IsNullOrWhiteSpace(Body))
                throw new Exception("Body must have some content");

            if (string.IsNullOrWhiteSpace(Subject))
                throw new Exception("Subjet must be supplied");

            Sender?.Validate();
            From?.Validate();
            To?.Validate();
            CC?.Validate();
            BCC?.Validate();
            ReplyToList?.Validate();
            Headers?.Validate();
            Attachments?.Validate();

            if (Attachments?.Sum(s => s.Content.Length) > MAXIMUM_SUM_ATTACHMENTS_SIZE)
                throw new Exception($"Total size of attachments exceeds {(20971520 / 1024) / 1024}MB");

            if (Headers?.Count > 0 && Headers.Select(s => s.Name.Trim()).Distinct(StringComparer.OrdinalIgnoreCase).Count() != Headers.Count)
                throw new Exception("Duplicate email headers are not allowed");
        }

        /// <summary>
        /// Maximum sum size of attachemnts that can be sent on an email
        /// </summary>
        [JsonIgnore]
        public const int MAXIMUM_SUM_ATTACHMENTS_SIZE = 20971520;

        private void CleanCollections()
        {
            To?.RemoveAll(s => s == null);
            CC?.RemoveAll(s => s == null);
            BCC?.RemoveAll(s => s == null);
            ReplyToList?.RemoveAll(s => s == null);
            Headers?.RemoveAll(s => s == null);
            Attachments?.RemoveAll(s => s == null);
        }
    }

    public class EmailSettings : IValidation
    {
        public EmailSettings() { }

        public EmailSettings(string host, int port, string username, string password, bool enableSsl)
        {
            if (string.IsNullOrWhiteSpace(host))
                throw new ArgumentNullException(nameof(host), $"{nameof(host)} must be supplied with email settings.");

            if (port <= 0)
                throw new ArgumentOutOfRangeException(nameof(port), $"{nameof(host)} must be supplied with email settings.");

            Host = host;
            Port = port;
            Username = username;
            Password = password;
            EnableSsl = enableSsl;
        }

        /// <summary>
        /// Server host used to send email
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Port to send request over.
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Ssl required.
        /// </summary>
        public bool EnableSsl { get; set; }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Host))
                throw new ArgumentNullException(nameof(Host), $"{nameof(Host)} must be supplied with email settings.");

            if (Port <= 0)
                throw new ArgumentOutOfRangeException(nameof(Port), $"{nameof(Port)} must be supplied with email settings.");
        }
    }

    public class EmailAddress : IValidation
    {
        public EmailAddress() { }

        public EmailAddress(string address)
        {
            Address = address;
        }

        public EmailAddress(string address, string displayName)
            : this(address)
        {
            DisplayName = displayName;
        }


        /// <summary>
        /// Email address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Display name
        /// </summary>
        public string DisplayName { get; set; }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(this.Address))
                throw new Exception("Email Address must be supplied");
        }

        public static implicit operator EmailAddress(string emailAddress)
        {
            return new EmailAddress(emailAddress);
        }
    }

    public class EmailHeader : IValidation
    {
        public EmailHeader() { }
        public EmailHeader(string name, string value)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), $"{nameof(name)} must be provided for an email header");

            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value), $"{nameof(value)} must be provided for an email header");

            Name = name;
            Value = value;
        }

        /// <summary>
        /// Header name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Header value
        /// </summary>
        public string Value { get; set; }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentNullException("Name must be supplied for header");

            if (string.IsNullOrWhiteSpace(Value))
                throw new ArgumentNullException("Value must be supplied for header");
        }
    }

    /// <summary>
    /// Email attachment
    /// </summary>
    public class EmailAttachment : IValidation
    {
        public EmailAttachment() { }
        public EmailAttachment(byte[] content, string contentType, string name)
        {
            if (content == null)
                throw new ArgumentNullException(nameof(content), $"{nameof(content)} must be supplied with email attachment.");

            if (content.Length == 0)
                throw new ArgumentOutOfRangeException(nameof(content), $"{nameof(content)} must be supplied with email attachment.");

            if (string.IsNullOrWhiteSpace(contentType))
                throw new ArgumentNullException(nameof(contentType), $"{nameof(contentType)} must be supplied with email attachment.");

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), $"{nameof(name)} must be supplied with email attachment.");

            Content = content;
            ContentType = contentType;
            Name = name;
        }

        /// <summary>
        /// Byte content of the attachment
        /// </summary>
        public byte[] Content { get; set; }

        /// <summary>
        /// Content type of the attachment (e.g. 'text/plain')
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Name of the attachment
        /// </summary>
        public string Name { get; set; }

        public void Validate()
        {
            if (Content == null)
                throw new ArgumentNullException(nameof(Content), $"{nameof(Content)} must be supplied with email attachment.");

            if (Content.Length == 0)
                throw new ArgumentOutOfRangeException(nameof(Content), $"{nameof(Content)} must be supplied with email attachment.");

            if (string.IsNullOrWhiteSpace(ContentType))
                throw new ArgumentNullException(nameof(ContentType), $"{nameof(ContentType)} must be supplied with email attachment.");

            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentNullException(nameof(Name), $"{nameof(Name)} must be supplied with email attachment.");
        }
    }

    /// <summary>
    /// Describes the delivery notification options for e-mail.
    /// </summary>
    public enum DeliveryNotificationOptions
    {
        /// <summary>
        /// No notification information will be sent. The mail server will utilize its configured behavior to determine whether it should generate a delivery notification.
        /// </summary>
        None = 0,
        /// <summary>
        /// Notify if the delivery is successful.
        /// </summary>
        OnSuccess = 1,
        /// <summary>
        /// Notify if the delivery is unsuccessful.
        /// </summary>
        OnFailure = 2,
        /// <summary>
        /// Notify if the delivery is delayed.
        /// </summary>
        Delay = 4,
        /// <summary>
        /// A notification should not be generated under any circumstances.
        /// </summary>
        Never = 134217728
    }

    /// <summary>
    /// Specifies the priority of a message.
    /// </summary>
    public enum MailPriority
    {
        /// <summary>
        /// The email has normal priority.
        /// </summary>
        Normal = 0,
        /// <summary>
        /// The email has low priority.
        /// </summary>
        Low = 1,
        /// <summary>
        /// The email has high priority.
        /// </summary>
        High = 2
    }
}