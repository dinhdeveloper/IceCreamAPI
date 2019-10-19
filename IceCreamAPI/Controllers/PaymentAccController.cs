using IceCreamAPI.Models.mDAO;
using IceCreamAPI.Models.mView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IceCreamAPI.Controllers
{
    public class PaymentAccController : ApiController
    {
        [HttpGet]
        [ActionName("getAllPaymentAcc")]
        public IEnumerable<PaymentAccountDTO> getAllPayment()
        {

            return PaymentAccountDAO.GetInstance().GetAll();
        }
        [HttpGet]
        [ActionName("GetOnePaymentAcc")]
        public PaymentAccountDTO GetOnePayment(int Id)
        {
            return PaymentAccountDAO.GetInstance().GetId(Id);
        }
        [HttpPost]
        [ActionName("InsertPaymentAcc")]
        public PaymentAccountDTO InsertPaymentAcc(PaymentAccountDTO accountDTO)
        {
            return PaymentAccountDAO.GetInstance().Insert(accountDTO);
        }

        [HttpPut]
        [ActionName("UpdatePaymentAcc")]
        public PaymentAccountDTO UpdatePaymentAcc(PaymentAccountDTO accountDTO)
        {
            return PaymentAccountDAO.GetInstance().Update(accountDTO);
        }
        [HttpDelete]
        [ActionName("DeletPaymentAcc")]
        public bool DeletPaymentAcc(string Id)
        {
          
           return PaymentAccountDAO.GetInstance().Delete(Id);
        }
    }
}
