using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Employee
    {
        int Id;
        string Name;
        public decimal salary;
        #region Constructor
        public Employee(int _Id,string _Name,decimal _Salary)
        {
            Id = _Id;
            Name = _Name;
            Salary = _Salary;
        }

        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Id={Id},name={Name},salary={salary}";
        }
        #endregion
        #region Encapsulation
        public string Getter()
        {
            return Name;
        }
        public void SetName(string value)
        {
            Name = value;
        }
        //property
        //Full Property:
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        //Automatic Property:

        //public int Age;
        public int Age { get; set; }

        #endregion
    }
}
