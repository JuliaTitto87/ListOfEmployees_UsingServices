using ListOfEmployees__DomainModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfEmployees_BLL.Contracts
{
    public interface IEmployeesService
    {
        List<Employee> GetEmployees();
        void DeleteEmployee (Employee employee);
		void AddEmployee (Employee employee);

        void UpdateEmployee (Employee employee);
	}
}
