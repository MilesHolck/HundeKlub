using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeKlub
{
    public class Member
    {

        //Instance fields 
        private int _id;
        private string _name;
        private string _address;
        private DateTime _birthDate;
        private string _phone;
        private string _email; 


        //Properties
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } } 
        public string Address { get { return _address; } set { _address = value; } }
        public DateTime BirthDate { get { return _birthDate; } set { _birthDate = value; } } 
        public string Phone { get { return _phone; } set { _phone = value; } } 
        public string Email { get { return _email; } set { _email = value; } }

        public List<Dog> DogList { get; set; } 


        //Constructor
        public Member(string name, DateTime birthdate, List <Dog> dogList)
        {
            Name = name;
            DogList = dogList;
            BirthDate = birthdate; 
        }


        //Methods 
        public override string ToString()
        {
            return $"Name: {Name}";

        }


        //CRUD
        public void RegisterDog (Dog dog)
        {
            DogList.Add(dog); 
        }

        public void PrintDogs()
        {
            foreach (Dog dogs in DogList)
            {
                Console.WriteLine(dogs); 
            }
        }

        public void RemoveDog (Dog dog)
        {
            DogList.Remove(dog); 
        }

    }
}
