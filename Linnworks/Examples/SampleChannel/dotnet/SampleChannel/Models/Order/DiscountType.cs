using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleChannel.Models.Order
{
    /// <summary>
    /// This type allows the user to define what "direction" a top level order discount will be applied in
    /// </summary>
    public enum DiscountType
    {
        /// <summary>
        /// The given discount amount will be split evenly across all items and any applicable postage
        /// </summary>
        AllEvenly,
        /// <summary>
        /// The discount amount will be split evenly across all items. Any remaining discount will be applied to the postage where applicable
        /// </summary>
        ItemsThenPostage,
        /// <summary>
        /// The discount amount will be applied to the postage cost where applicable. Any remaining discount will be split evenly across all items
        /// </summary>
        PostageThenItems
    }
}
