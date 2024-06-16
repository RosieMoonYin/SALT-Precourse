using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Microsoft.VisualBasic;

namespace TrainingGround;

    public class Employee : Person, Iprintable//employee class will inherit Person?
    {
    public Employee() 
    {
      Addresses = new List<Address>();
    }

            public Employee (string name, string employeeId) : base(name)
      {
        EmployeeId = employeeId;
        Addresses = new List<Address>();
      } 
    public string? EmployeeId {get; private set;} //made nullable with adding ?
    public List<Address> Addresses {get; set;}




    public string GetPrintString() //get print string method
    {
        if (Address == null)
        {
        return @$"{this.Name} ({this.EmployeeId}) No address available"; //adding becaus of null problem
        }
        return @$"{this.Name} ({this.EmployeeId}) {this.Address.Street} {this.Address.StreetNo} {this.Address.City}";
    }
}




