using EY_CodeFirst_BusinessEntities.Entity;
using EY_CodeFirst_BusinessEntities.Interface;
using EY_CodeFirst_DatabaseLogic.DBConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EY_CodeFirst_RepositoryLayer
{
    public class EmployeeRepository : IEmployeeRepository
    {
        //This is normal way to create Object
        //EmployeeManagementContext _employeeManagementContext = new EmployeeManagementContext();

        public EmployeeManagementContext _employeeManagementContext;
        public EmployeeRepository()
        {
             _employeeManagementContext = new EmployeeManagementContext();
        }
        public bool AddEmployeeDetails(Employee employee)
        {
            _employeeManagementContext.employees.Add(employee);
            _employeeManagementContext.SaveChanges();

            return true;
        }

        public bool DeleteEmployeeDetails(int id)
        {
            Employee employee = _employeeManagementContext.employees.SingleOrDefault(e => e.ID == id);

            if (employee != null)
            {
                _employeeManagementContext.employees.Remove(employee);
                _employeeManagementContext.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Employee> GetAllEmployeeDetails()
        {
            var employee = _employeeManagementContext.employees.ToList();

            if (employee.Count == 0)
            {
                return null;
            }
            else
            {
                return employee;
            }
        }

        public List<Employee> GetEmployeeDetailsByID(int id)
        {
            List<Employee> employees = _employeeManagementContext.employees.ToList().FindAll(e => e.ID == id);

            if (employees.Count == 0)
            {
                return null;
            }
            else
            {
                return employees;
            }
        }

        public bool UpdateEmployeeDetails(Employee employee)
        {
            _employeeManagementContext.employees.Update(employee);
            _employeeManagementContext.SaveChanges();
            return true;
        }
    }
}
