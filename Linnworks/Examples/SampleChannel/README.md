#What is this
This is a sample application to be used as a Channel Integration for Linnworks.net. Channel Integrations can be created to provide a fully functional, embedded channel directly within Linnworks.net

# Setup Guide

1. Upload the application to your web server.  Be careful not to overwrite your UserStore folder during deployment, or previously installed versions of the channel may fail.
2. Add the manifest.json to your application pointing to your webserver (changing the variables to point to your server).
3. Go to 'Linnworks.net -> Channel Integration' and begin to integrate your channel.
4. Linnworks will poll your channel for sync updates every 10-15 minutes per user.

If you have any issues with this please raise a ticket at http://help.linnworks.com

# Channel Integration Endpoint Guide

An overview of Channel Integration can be found here: https://apidocs.linnworks.net/docs/channel-integration

Description of Channel Endpoints and expected return objects expected and can be found here: https://apidocs.linnworks.net/docs/endpoints-general

# OAuth

Employing OAuth is optional.  If you want the Linnworks Channel Installation wizard to prompt the user for OAuth Key and Secret, and call this Channel implementation to carry out the OAuth handshake, provide values for the OAuthAuthorizationEndpoint and OAuthScopesRequested parameters in the Manifest (see Manifest.txt).

```json
    {
        "name": "OAuthAuthorizationEndpoint",
        "value": "http://www.mychannelapi.com/api/oauth/authorize"
    },
    {
        "name": "OAuthScopesRequested",
        "value": "read write"
    }
```

# Development Tips

## Tunnelling for Local Development

The URLs specified in the Manifest must be publically accessible over the internet in order for Linnworks to call your channel.  During development you can tunnel from several publically available tools, e.g. `ngrok` or `localtunnel`, so that Linnworks calls your development environment.

For example, with `localtunnel`:

```bash
    $ npm install -g localtunnel
    $ npx localtunnel -p 5000      # SampleChannel listens on port 5000,5001 by default
```

`localtunnel` assigns a domain name using three random words, e.g. https://one-two-three.loca.lt, so you must use that domain name in your Manifest for all endpoints, e.g.:

```json
    {
        "name" :"AddNewUserEndpoint",
        "value" :"https://one-two-three.loca.lt/api/Config/AddNewUser"
    },
```

To keep that tunnel name between invocations of `localtunnel`, specify it on the command line:

```bash
    $ npx localtunnel -p 5000 --subdomain one-two-three
```

Ensure that your tunnel and dev server stay up while the channel is Enabled on your account, or Linnworks may automatically disable it due to repeated error responses.
