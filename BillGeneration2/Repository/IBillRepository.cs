using BillGeneration2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BillGeneration2.Repository
{
   public  interface IBillRepository
    {
        public List<BillServices> Getbill();
    }
}
