using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Tüzel müşteri
    class CoorporateCustomer:Customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }//vergi numarası
    }
}
