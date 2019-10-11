using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.BAL.Interface
{
    public interface IBillDetailService
    {
        //   IList<BillDetail> BillDetailGetAll();
       IList< BillDetail> BillDetailGetByID(int Id);
        bool BillDetailAddByID(BillDetailAdd request);
        //  bool BillDetailUpdate(BillDetailUpdate request);
        bool BillDetailDelete(int Id);
    }
}
