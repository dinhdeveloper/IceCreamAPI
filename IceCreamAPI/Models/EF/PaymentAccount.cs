//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IceCreamAPI.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class PaymentAccount
    {
        public int PaymentAccId { get; set; }
        public Nullable<long> CardNumber { get; set; }
        public string CardHolder { get; set; }
    }
}