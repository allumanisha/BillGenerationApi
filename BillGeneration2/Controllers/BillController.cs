using BillGeneration2.Models;
using BillGeneration2.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BillGeneration2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IBillRepository _repo;
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(BillController));

        public BillController(IBillRepository repo)
        {
            this._repo = repo;
        }
        [HttpGet]
        
        public  ActionResult<List<BillServices>> GetDetails()
        {
            
                
                var details =  _repo.Getbill();
                

                return details;
           
          
        }

    }
}
