using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfEmployees_DomainModel
{
    public class Employee
    {
        public int PersonnelNumber { get; set; }

        public string FullName { get; set; }

        public string Department { get; set; }

        public string EmployeesPosition { get; set; }
    }
}
