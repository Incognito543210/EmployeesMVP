using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Pracownicy.Model
{
    internal class MainModel : ISave, ILoad
    {
        public List<Employee> employees = new List<Employee>();
      

        private string locationForOpen()
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                    return openFileDialog1.FileName;
               
            }

            else
            {
                return "";
            }

        }

        private string locationForSave()
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                return saveFileDialog1.FileName;

            }

            else
            {
                return "";
            }

        }





        public string validatingdata(string name, string lastName, string date, string salary, string position, string arragment)
        {
            if (name.Equals("")) { return "erName"; }

            if (lastName.Equals("")) { return "erLastName"; }

            if (date.Equals("")) { return "erDate"; }

            if (salary.Equals("")) { return "erSalary"; }

            if (position.Equals("")) { return "erPosition"; }

            if (arragment.Equals("")) { return "erArragment"; }

            return "noError";
        }

        public Employee newEmploye(string name, string lastName, string date, string salary, string position, string arragment)
        {

            Employee employee = new Employee();

            employee.Name = name;

            employee.LastName = lastName;

            employee.Data = date;

            employee.Salary = salary;

            employee.Position = position;

            employee.Arragment = arragment;

            return employee;
        }

        public void Save()
        {


            XmlSerializer serialiser = new XmlSerializer(typeof(List<Employee>));


            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineChars = "\n";
            settings.NewLineHandling = NewLineHandling.Replace;


            TextWriter filestream = new StreamWriter(locationForSave());


            XmlWriter writer = XmlWriter.Create(filestream, settings);


            serialiser.Serialize(writer, employees);


            filestream.Close();


        }

        public void Load()
        {
            if (File.Exists(locationForOpen()))
            {





                XmlSerializer serialiser = new XmlSerializer(typeof(List<Employee>));


                TextReader filestream = new StreamReader(locationForOpen());


                employees = (List<Employee>)serialiser.Deserialize(filestream);


                filestream.Close();



            }

        }




        public Employee edit(string editElement)
        {
            int count = 0;
            for (int i = 0; i < employees.Count; i++)
            {
                if (editElement.Equals(employees[i].ToString()))
                {
                    break;
                }

                count++;

            }



            return employees[count];

        }



        public void change(string editElement, string name, string lastName, string date, string salary, string position, string arragment)
        {
            int count = 0;
            for (int i = 0; i < employees.Count; i++)
            {
                if (editElement.Equals(employees[i].ToString()))
                {
                    break;
                }

                count++;
            }

            employees[count].Name = name;

            employees[count].LastName = lastName;

            employees[count].Data = date;

            employees[count].Salary = salary;

            employees[count].Position = position;

            employees[count].Arragment = arragment;




        }
    }
}
