using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLCafe.BAL.Interface;
using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;

namespace QLCafe.API.Controllers
{

    [ApiController]
    public class BillDetailController : ControllerBase
    {
        private readonly IBillDetailService _billDetailService;

        public BillDetailController(IBillDetailService billDetailService)
        {
            _billDetailService = billDetailService;
        }

        [HttpGet]
        [Route("api/billdetail/get/{id}")]
        public IList<BillDetail> BillDetailGetByID(int id)
        {
            return _billDetailService.BillDetailGetByID(id);
        }

        [HttpPost]
        [Route("api/billdetail/add")]
        public bool BillDetailAdd([FromBody] BillDetailAdd request)
        {
            return _billDetailService.BillDetailAddByID(request);
        }


        [HttpDelete]
        [Route("api/billdetail/delete/{id}")]
        public bool Delete(int id)
        {
            return _billDetailService.BillDetailDelete(id);
        }

    }
}