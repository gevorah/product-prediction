using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_prediction.Model
{
    class Sale
    {
        private string id;
        private char branch;
        private string city;
        private string customerType;
        private string gender;
        private string productLine;
        private double unitPrice;
        private int quantity;
        private double tax;
        private double total;
        private DateTime dateTime;
        private string payment;
        private double cogs;
        private double grossMargin;
        private double grossIncome;
        private double rating;

        public Sale(string id, char branch, string city, string customerType, string gender, string productLine, double unitPrice, int quantity,
            double tax, double total, DateTime dateTime, string payment, double cogs, double grossMargin, double grossIncome, double rating)
        {
            this.id = id;
            this.branch = branch;
            this.city = city;
            this.customerType = customerType;
            this.gender = gender;
            this.productLine = productLine;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
            this.tax = tax;
            this.total = total;
            this.dateTime = dateTime;
            this.payment = payment;
            this.cogs = cogs;
            this.grossMargin = grossMargin;
            this.grossIncome = grossIncome;
            this.rating = rating;
        }



    }

}