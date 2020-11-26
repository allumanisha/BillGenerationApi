using BillGeneration2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BillGeneration2.Repository
{
    public class BillRepository : IBillRepository
    {
       static List<BillServices> bill = new List<BillServices>() { new BillServices{BillNo=1234,CustomerName="Manisha", BillAmt =680},
                                                                new BillServices{BillNo=1235,CustomerName="Mounika", BillAmt =980},
                                                                new BillServices{BillNo=1236,CustomerName="Usha", BillAmt =280} };

       
            public List<BillServices> Getbill()
            {
                return bill;
            }
        
    }
}
