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
        private double _membershipFee = 1000;
        public int MembershipNumber { get { return _membershipNumber; } set { _membershipNumber = value; } }
        public double RentingFee { get { return _rentingFee; } set { _rentingFee = value; } }
        public double MembershipFee { get { return _membershipFee; } set { _membershipFee = value; } }
        public Membership(int membershipNumber)
        {
            _membershipNumber = membershipNumber;
        }
        public override string ToString()
        {
            return $"Membership number: {_membershipNumber}\nRenting Fee: {_rentingFee}\nMembership Fee: {_membershipFee}";
        }
        public double CalculateTotalFee(int numberOfRentings)
        {
            return _membershipFee + (_rentingFee * numberOfRentings);
        }
        public double CalculateWeekendFee(int weekendRenting)
        {
            double weekendRentingFee = _rentingFee * 1.5;
            return weekendRentingFee;
        }

        public double CalculateMembershipFee() 
        { 
            if (hej)
        return _membershipFee + 500;
        }


    }
}
