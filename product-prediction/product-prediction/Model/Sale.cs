using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_prediction.Model
{
    class Sale
    {
        public string id { get; }
        public char branch { get; }
        public string city { get; }
        public string customerType { get; }
        public string gender { get; }
        public string productLine { get; }
        public double unitPrice { get; }
        public int quantity { get; }
        public double tax { get; }
        public double total { get; }
        public DateTime dateTime { get; }
        public string payment { get; }
        public double cogs { get; }
        public double grossMargin { get; }
        public double grossIncome { get; }
        public double rating { get; }

        public Sale()
        {

        }

    }

}
