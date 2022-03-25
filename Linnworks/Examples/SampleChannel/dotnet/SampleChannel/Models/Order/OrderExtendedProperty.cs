﻿namespace SampleChannel.Models.Order
{
    public class OrderExtendedProperty
    {
        /// <summary>
        /// Unique per order option Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Option Value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Type of property for example "Shipping", "Tracking Number".
        /// </summary>
        public string Type { get; set; }
    }
}