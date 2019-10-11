using Dapper;
using QLCafe.DAL.Interface;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QLCafe.DAL
{
    public class BillsRepository : BaseRepository, IBillsRepository
    {
        public IList<Bills> BillGetAll()
        {
            IList<Bills> billsGetAll = SqlMapper.Query<Bills>(con, "Bill_GetAll", commandType: CommandType.StoredProcedure).ToList();
            return billsGetAll;
        }

        public IList<Bills> BillIsNotPayment()
        {
            IList<Bills> billIsNotPayment = SqlMapper.Query<Bills>(con, "Bills_IsNotPayment", commandType: CommandType.StoredProcedure).ToList();
            return billIsNotPayment;
        }

        public IList<Bills> BillIsPayment()
        {
            IList<Bills> billIsPayment = SqlMapper.Query<Bills>(con, "Bills_IsPayment", commandType: CommandType.StoredProcedure).ToList();
            return billIsPayment;
        }

        public bool BillsAddByIDTable(int Id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TableID", Id);
                SqlMapper.Execute(con, "Bills_AddByIDTable", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Bills BillsGetByID(int Id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);

                Bills billsGetByID = SqlMapper.Query<Bills>(con, "Bills_GetByID", commandType: CommandType.StoredProcedure).FirstOrDefault();
                return billsGetByID;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
