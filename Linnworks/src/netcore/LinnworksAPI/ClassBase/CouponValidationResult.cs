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
		public String ValidationText;

        /// <summary>
        /// If deduction is visible 
        /// </summary>
		public Boolean DeductVisible;

        /// <summary>
        /// Deduction note 
        /// </summary>
		public String DeductText;

        /// <summary>
        /// If balance is visible 
        /// </summary>
		public Boolean BalanceVisible;

        /// <summary>
        /// Balance record 
        /// </summary>
		public String BalanceText;

        /// <summary>
        /// Value 
        /// </summary>
		public String ValueText;

        /// <summary>
        /// Discount type 
        /// </summary>
		public String DiscountType;
	} 
}