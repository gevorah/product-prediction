using System;
using System.Collections.Generic;
using System.Text;

namespace product_prediction.Model
{
    class Company
    {
        private List<Sale> sales; 

        public Company()
        {
            sales = new List<Sale>();
        }
    }
}
