using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryFinal.DAL;
namespace ClassLibraryFinal.BUI
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }

        public bool AddEmployee(Employee emp)
        {
            return EmployeeDB.SaveEmployee(emp);
        }
        public Employee SearchRecordByEmpid(int empId)
        {
            return EmployeeDB.searchRecord(empId);
        }
        public void UpdateEmployeeById(Employee emp)
        {

            EmployeeDB.UpdateEmployee(emp);
        }
        public void DeleteEmp(Employee emp)
        {
            EmployeeDB.DeleteEmployee(emp);
        }
        public List<Employee> ListEmployee()
        {
            return EmployeeDB.ListRecords();
        }
    }
}
