using System;
using System.Collections.Generic;
namespace Company
{
  class Company
  {
    private DateTime _dateFounded;
    private string _companyName;
    private List<Employee> _employees;
    public Company(string companyName, List<Employee> employees)
    {
      _dateFounded = DateTime.Now;
      _companyName = companyName;
      _employees = employees;
    }

    public void ListEmployees()
    {
      foreach (Employee employee in _employees)
      {
        Console.WriteLine($"{employee.GetName()} works for {_companyName} as {employee.GetTitle()} since {employee.GetStartDate()}");
      }
    }
  }
}