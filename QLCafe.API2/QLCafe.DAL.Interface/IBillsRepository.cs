using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.DAL.Interface
{
    public interface IBillsRepository
    {
        bool BillsAddByIDTable(int Id);
        IList<Bills> BillGetAll();
        Bills BillsGetByID(int Id);
        IList<Bills> BillIsPayment();
        IList<Bills> BillIsNotPayment();
    }
}
