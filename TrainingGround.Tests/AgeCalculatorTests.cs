using Microsoft.VisualBasic;

namespace TrainingGround.Tests;

public class AgeCalculatorTests
{
    //instance of the class AgeCalculator

    
    [Fact]
    public void someone_born_1972_is_50_in_2022()
    {
    //act      
    var age = AgeCalculator.GetAge(1972, 2022);
    //assert 
    Assert.Equal(50, age);
    }


//second test
    [Fact]
    public void someone_born_2022_is_0_in_2022()
    {

    var age = AgeCalculator.GetAge(2022, 2022);

    Assert.Equal(0, age);

    }

    //third test
        [Fact]
    public void a_person_born_in_1972_is_50_2022()
    {
        var p = new Person();
        p.BirthYear = 1972;
    
       //act
       var age = p.GetAge(2022);

       //assert
      Assert.Equal(50, age);
    }
}