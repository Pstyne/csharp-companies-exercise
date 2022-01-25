using System.Collections.Generic;

namespace Company
{
  class Program
  {
    static void Main(string[] args)
    {
      Employee JohnDoe = new Employee("John", "Doe", "Sales");
      Employee SallySlappers = new Employee("Sally", "Slappers", "Marketing");
      Employee HoboBob = new Employee("Hobo", "Bob", "Hobo Manager");

      List<Employee> employees = new List<Employee>()
      {
        JohnDoe,
        SallySlappers,
        HoboBob
      };

      Company Ringer = new Company("Ringer", employees);

      Ringer.ListEmployees();
    }
  }
}
