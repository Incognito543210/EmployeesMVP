using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pracownicy.Model
{
        public class Employee
    {
        private string? _name;
        private string? _lastName;
        private string? _position;
        private string? _salary;
        private string? _data;
        private string? _arragment;


        public string? Name { get; set; }

        public string? LastName { get; set; }

        public string? Position { get; set; }

        public string? Salary { get; set; }

        public string? Data { get; set; }

        public string? Arragment { get; set; }


        public override string ToString()
        {
            return Name +" "+ LastName + " " + Data + " " + Salary + " " + Position + " " + Arragment;
        }








    }
}
