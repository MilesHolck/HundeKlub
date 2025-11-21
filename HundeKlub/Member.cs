using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeKlub
{
    public class Member
    {
        private int _id;
        private string _name;
        private string _address;
        private DateTime _birthDate;
        private string _phone;
        private string _email; 


        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } } 
        public string Address { get { return _address; } set { _address = value; } }
        public DateTime BirthDate { get { return _birthDate; } set { _birthDate = value; } } 
        public string Phone { get { return _phone; } set { _phone = value; } } 
        public string Email { get { return _email; } set { _email = value; } }

        public List<Dog> DogList { get; set; } //String ændres til dog, også i konstruktøren.


        public Member(string name, DateTime birthdate, List <Dog> dogList)
        {
            Name = name;
            DogList = dogList;
            BirthDate = birthdate; 
        }

        public override string ToString()
        {
            return $"Name: {Name} \nDog: Dogs go here";

        }



    }
}
