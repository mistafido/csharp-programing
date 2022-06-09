using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        private string Name;
        private int Age;
        public int GetAge()
        {
            return Age;
        }
        public void SetAge(int age)
        {
            if(age>60)
            {
                Console.WriteLine("Employee age cannot be more than 60");
            }
            else
            {
                this.Age = age;
            }
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            if(name.IndexOf('?') > 0)
            {
                Console.WriteLine("Illegal Character cannot be in the name");
            }
            else
            {
                this.Name = name;
            }
        }
    }
    
    public class MethodEmployee
    {
        private string name;
        private int age;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                { name = value; }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                { age = value; }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee first = new Employee();
            MethodEmployee second = new MethodEmployee();
            second.Name = "James Bond";
            second.Age = 50;
            first.SetAge(50);
            first.SetName("Amir Khan");
            Console.WriteLine("Employee Name:" + first.GetName());
            Console.WriteLine("Employee Age:" + first.GetAge());
            Console.WriteLine("Employee Name:" + second.Name);
            Console.WriteLine("Employee Age:" + second.Age);
            Console.ReadKey();

        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
    }
}
