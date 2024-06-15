using System.Net.Sockets;
using TrainingGround;

public class PersonTests 
{
    //creating instances with constructor "new"
    [Fact]
    public void create_person_using_parameterless_constructor()
    {
        //act
        var p = new Person();
        //assert
        Assert.NotNull(p);
        
    }
    [Fact]
    public void create_person_using_constructor_with_name ()
    {
        //act
        var p = new Person("Rosie");

        //assert
        Assert.NotNull(p);
        Assert.Equal("Rosie", p.Name); //using name parameter from constructor in Person.cs

    }

    
    //third test
    [Fact]
    public void a_person_born_in_1972_is_50_2022()
    {
        var p = new Person
        {
            BirthYear = 1972
        };

        //act
        var age = p.GetAge(2022);

       //assert
      Assert.Equal(50, age);

    }

    [Fact]
    public void an_employee_is_a_person()
    {
        var emp = new Employee();
        emp.LengthInMeters = 1.95;

        Assert.IsType<Employee>(emp);
        Assert.Equal(1.95, emp.LengthInMeters);


    }

    [Fact]
    public void an_employee_has_an_employeeId()
    {
        var emp = new Employee("Marcus" , "234-BDAS");
        Assert.IsType<Employee>(emp);

        Assert.Equal("Marcus", emp.Name);
        Assert.NotNull(emp.EmployeeId);
        Assert.Equal("234-BDAS", emp.EmployeeId);
    }



    [Fact]
    public void a_person_has_an_address() //composition
    {
        var p = new Person("Marcus")
        {
            //act
            Address = new Address()
        };
        p.Address.Street = "A Street";
        p.Address.StreetNo = 23;
        p.Address.City = "Stockholm";

        // assert
        Assert.NotNull(p.Address);
        Assert.IsType<Address>(p.Address);

        Assert.Equal("A Street", p.Address.Street);
        Assert.Equal(23, p.Address.StreetNo);
        Assert.Equal("Stockholm", p.Address.City);

    }

    [Fact]
    public void an_employee_has_a_nice_printed_address()
    {
        //arrange
        var emp = new Employee ("Marcus", "234-BDAS");
        emp.Address = new Address();
        emp.Address.Street = "A street";
        emp.Address.StreetNo = 23;
        emp.Address.City = "Stockholm";

        // act
        var printString = emp.GetPrintString();

        // assert
        Assert.Equal(@"Marcus (234-BDAS) A street 23 Stockholm", printString);
}

    }


