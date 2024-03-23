using ListOfEmployees_BLL.Contracts;
using ListOfEmployees_DomainModel;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace ListOfEmployees_BLL.Services
{
    public class EmployeeService : IEmployeesService
    {
//	private string fileName = "Employees.json";
        //		Type listType = typeof(List<Employee>);


        List<Employee> IEmployeesService.GetEmployees()
        {
		    List<Employee> employees=new List<Employee>();
			try 
			{
			//	string jsonString = File.ReadAllText("Employees.json");
			//	employees = JsonConvert.DeserializeObject<List<Employee>>(jsonString);
                return employees;
            }
			catch {return employees; };
			
           
          
        }

		public void DeleteEmployee(Employee employee)
		{
			string fileName = "Employees.json";
			string jsonString = File.ReadAllText(fileName);
			Type listType = typeof(List<Employee>);
	//		List<Employee> employees = (List<Employee>)JsonSerializer.Deserialize(jsonString, listType);
	//		employees.Remove(employee);
		}

		public void AddEmployee(Employee employee)
		{
			List<Employee> employees = new List<Employee>();
			try { 
	    //         string jsonString = File.ReadAllText("Employees.json");
     //   employees = JsonConvert.DeserializeObject<List<Employee>>(jsonString);
	    }
			catch { }
				employees.Add(employee);
				string json= JsonConvert.SerializeObject(employees, Formatting.Indented);

		}

		public void UpdateEmployee(Employee employee)
		{
			throw new NotImplementedException();
		}
	}
}
