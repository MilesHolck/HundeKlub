using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeKlub
{
    public class Membership
    {
        private int _membershipNumber;
        private double _rentingFee = 100;
        private double _baseFee = 1000;
        private int _numberOfDogs;
        private static Membership _instance = null;
        private static int _instanceCounter = 0;
        private int _instanceNumber;


        public int MembershipNumber { get { return _membershipNumber; } set { _membershipNumber = value; } }
        public double RentingFee { get { return _rentingFee; } set { _rentingFee = value; } }
        public double MembershipFee { get { return _baseFee; } set { _baseFee = value; } }
        public int Age { get; set; }
        public Membership(int membershipNumber)
        {
            _membershipNumber = membershipNumber;
        }
        private Membership()
        {
            _instanceCounter++;
            _instanceNumber = _instanceCounter;
        }
        public override string ToString()
        {
            return $"Membership number: {_membershipNumber}\nRenting Fee: {_rentingFee}\nMembership Fee: {_baseFee}";
        }
        public double CalculateTotalFee(int numberOfRentings)
        {
            return _baseFee + (_rentingFee * numberOfRentings);
        }
        public double MemberFee(double baseFee) 
        { if (Age > 65)
            {
                baseFee = baseFee * 1.5;
            }
            return baseFee;
        }
        public double CalculateWeekendFee(int weekendRenting)
        {
            double weekendRentingFee = _rentingFee * 1.5;
            return weekendRentingFee;
        }

        public double CalculateMembershipFee() 
        {
            if (_instanceCounter > 1)
                return _baseFee + 500; 
        { 
            if (hej)
        return _membershipFee + 500;
        }



    }
}
