using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IceCreamAPI.Models.mView
{
    public class PaymentAccountDTO
    {
        [Required(ErrorMessage = "Kiểu truyền vào sai")]
        public int PaymentAccId { get; set; }
        public Int64 CardNumber { get; set; }
        public string CardHolder { get; set; }
    }
}