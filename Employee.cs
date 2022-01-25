using System;

namespace Company
{
  class Employee
  {
    private string _firstName;
    private string _lastName;
    private string _title;
    private DateTime _startDate;

    public Employee(string fName, string lName, string title)
    {
      _firstName = fName;
      _lastName = lName;
      _title = title;
      _startDate = DateTime.Now;
    }
  }
}