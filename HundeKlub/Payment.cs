using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeKlub
{
    public class Payment
    {
        private int _id;
        

        public int Id { get { return _id; } set { _id = value; } }


        public Payment(int id)
        {
            _id = id;
        }

        public void Recipt()
        {
            Console.WriteLine("Receipt printed");
        }

        public enum PaymentMethod
        {
            card,
            cash,
            mobilePay,
            autoBankTransfer

        }
        public enum PaymentType
        {
            monthlyPayment,
            payPerEvent,
            yearlyPayment
        }



    }
}
