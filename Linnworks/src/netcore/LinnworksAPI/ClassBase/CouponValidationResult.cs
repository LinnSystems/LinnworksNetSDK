using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CouponValidationResult
	{
        /// <summary>
        /// Validation note 
        /// </summary>
		public String ValidationText { get; set; }

        /// <summary>
        /// If deduction is visible 
        /// </summary>
		public Boolean DeductVisible { get; set; }

        /// <summary>
        /// Deduction note 
        /// </summary>
		public String DeductText { get; set; }

        /// <summary>
        /// If balance is visible 
        /// </summary>
		public Boolean BalanceVisible { get; set; }

        /// <summary>
        /// Balance record 
        /// </summary>
		public String BalanceText { get; set; }

        /// <summary>
        /// Value 
        /// </summary>
		public String ValueText { get; set; }

        /// <summary>
        /// Discount type 
        /// </summary>
		public String DiscountType { get; set; }
	} 
}