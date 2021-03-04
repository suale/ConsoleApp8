using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Customer
    {
        //Fields
        //Auto-Property
        public Customer()
        {

        }
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            _city = city;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }



        //Manuel-Property

        private string _city;

        public string City
        {
            get
            {
                return "(TR)"+_city;
            }
            set
            {
                _city = value;
            }
        }



    }
}
