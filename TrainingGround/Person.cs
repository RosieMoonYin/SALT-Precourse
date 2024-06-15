
using System.Data;
using System.Diagnostics;
using System.Transactions;
using Microsoft.VisualBasic;
namespace TrainingGround;

public class Person{


    public Person() {} //default parameterless constructor (written manually)
    
    public Person(int birthYear)
    {
        BirthYear = birthYear;
    }

    public Person(string name) //constructor with 1 string parameter
    {
        Name = name;
    }

    


    public string? Name {get; private set;} //the property Name becomes (read only : public, writeable within class)

    public int BirthYear {get; set;}
    public double LengthInMeters {get; set;}

    public int GetAge(int currentYear)
    {
       return currentYear - this.BirthYear;
    }


    public Address? Address {get; set;}


    public enum AgeCategory
    {
        Kid,
        Adult
    }








    // public int GetAge(int currentYear)
    // {
    //   return currentYear - this.BirthYear();
    //  }


}