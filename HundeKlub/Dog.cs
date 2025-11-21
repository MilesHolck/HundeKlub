using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeKlub
{
    public class Dog
    {
        private int _id;
        private string _name;
        private string _race;
        private int _dateofBirth;
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Race { get { return _race; } set { _race = value; } }
        public int DateOfBirth { get { return _dateofBirth; } set { _dateofBirth = value; } }

        public Dog(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public override string ToString()
        {
            return $"Dog number: {_id}\nName: {_name}";
        }
    }
} 
