using ListOfEmployees_BLL.Contracts;
using ListOfEmployees_DomainModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfEmployees_BLL.Services
{
    public class StubEmployeeService : IEmployeesService
    {
		public void AddEmployee(Employee employee)
		{
			throw new NotImplementedException();
		}

		public void DeleteEmployee(Employee employee)
		{
			throw new NotImplementedException();
		}

		public void UpdateEmployee(Employee employee)
		{
			throw new NotImplementedException();
		}

		List<Employee> IEmployeesService.GetEmployees()
        {
            return new List<Employee>();
        }
	}
}
