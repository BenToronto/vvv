using System;
namespace CsharpStruct {
 
  // defining struct
  struct Employee {
    public int id;
    
    public string name;

    // parameterized constructor
    public Employee(int employeeId, string employeeName) {
   
      id = employeeId;
      name = employeeName;
    }
  }
 
  class Program {
    static void Main(string[] args) {
 
      // calls constructor of struct
      Employee emp = new Employee(1, "Brian");

      Console.WriteLine("Employee Name: " + emp.name);
      Console.WriteLine("Employee Id: " + emp.id);

      Console.ReadLine();
    }
  }
}
