using ListOfEmployees__BLL.Contracts;
using ListOfEmployees__DomainModel;
using Newtonsoft.Json;

namespace ListOfEmployees__BLL.Services
{
    public class EmployeeService : IEmployeesService
        {
        private readonly string fileName = "Employees.json";
        List<Employee> employees = new List<Employee>();

        List<Employee> IEmployeesService.GetEmployees()
        {
            GetEmployeesFromFile();
            return employees;
        }

        public void DeleteEmployee(Employee employee)
        {
            GetEmployeesFromFile();
            employees.Remove(employees.FirstOrDefault(x => x.PersonnelNumber == employee.PersonnelNumber));
            SaveEmployeesToFile();
        }

        public void AddEmployee(Employee employee)
        {
            GetEmployeesFromFile();
            employees.Add(employee);
            SaveEmployeesToFile();
        }
        public void UpdateEmployee(Employee employee)
        {
            GetEmployeesFromFile();
            employees[employees.IndexOf(employees.FirstOrDefault(x => x.PersonnelNumber == employee.PersonnelNumber))]=employee;
            SaveEmployeesToFile();
        }

        private void GetEmployeesFromFile()
        {
            if (File.Exists(fileName))
            {
                string jsonString = File.ReadAllText(fileName);
                employees = JsonConvert.DeserializeObject<List<Employee>>(jsonString);
            }
        }

        private void SaveEmployeesToFile()
        {
            string jsonString = JsonConvert.SerializeObject(employees, Formatting.Indented);
            StreamWriter file = File.CreateText("Employees.json");
            file.Write(jsonString);
            file.Close();
        }
    }
    }
