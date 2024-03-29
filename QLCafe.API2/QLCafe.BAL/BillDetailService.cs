﻿using QLCafe.BAL.Interface;
using QLCafe.DAL;
using QLCafe.DAL.Interface;
using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.BAL
{
    public class BillDetailService : IBillDetailService
    {
        private IBillDetailReponsitory _billDetailReponsitory;
        public BillDetailService(IBillDetailReponsitory billDetailReponsitory)
        {
            _billDetailReponsitory = billDetailReponsitory;
        }
        public bool BillDetailAddByID(BillDetailAdd request)
        {
            return _billDetailReponsitory.BillDetailAddByID(request);
        }

        public bool BillDetailDelete(int Id)
        {
            return _billDetailReponsitory.BillDetailDelete(Id);
        }

        public IList<BillDetail> BillDetailGetByID(int Id)
        {
            return _billDetailReponsitory.BillDetailGetByID(Id);
        }
    }
}
