using SPDM.DLL.Entities;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.BLL.BusinessLogic
{
    public class PaymentDetailBLL
    {
        public int Save(PaymentDetail paymentdetail)
        {
            try
            {
                PaymentDetailDLL paymentdetailDLL = new PaymentDetailDLL();
                return paymentdetailDLL.Save(paymentdetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<PaymentDetail> GetAll()
        {
            try
            {
                PaymentDetailDLL paymentdetailDLL = new PaymentDetailDLL();
                return paymentdetailDLL.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PaymentDetail GetById()
        {
            try
            {
                PaymentDetailDLL paymentdetailDLL = new PaymentDetailDLL();
                return paymentdetailDLL.GetById(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int GetCount(PaymentDetail partydetail)
        {
            try
            {
                PaymentDetailDLL paymentdetailDLL = new PaymentDetailDLL();
                return paymentdetailDLL.GetCount();
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
                PaymentDetailDLL paymentdetailDLL = new PaymentDetailDLL();
                return paymentdetailDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
