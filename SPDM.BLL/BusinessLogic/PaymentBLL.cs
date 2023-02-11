using SPDM.DLL.Entities;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.BLL.BusinessLogic
{
    public class PaymentBLL
    {
        public int Save(Payment payment)
        {
            try
            {
                PaymentDLL paymentDLL = new PaymentDLL();
                return paymentDLL.Save(payment);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Payment> GetAll()
        {
            try
            {
                PaymentDLL paymentDLL = new PaymentDLL();
                return paymentDLL.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Payment GetById()
        {
            try
            {
                PaymentDLL paymentDLL = new PaymentDLL();
                return paymentDLL.GetById(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetCount(Party party)
        {
            try
            {
                PaymentDLL paymentDLL = new PaymentDLL();
                return paymentDLL.GetCount();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int Delete(int id)
        {
            try
            {
                PaymentDLL paymentDLL = new PaymentDLL();
                //int d = paymentDLL.Delete(id);
                //return d;
                return paymentDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
