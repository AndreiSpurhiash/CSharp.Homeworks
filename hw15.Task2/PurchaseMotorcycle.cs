using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;


namespace hw15.Task2
{

    internal class PurchaseMotorcycle
    {
        [CreditCardAttribute]
        public string? _creditCardNumber { get;  set; }
        public PurchaseMotorcycle(string? creditCardNumber)
        {
            _creditCardNumber = creditCardNumber;
        }

    }
}
