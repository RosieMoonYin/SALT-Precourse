using System.Net;
using Microsoft.VisualBasic;
using TrainingGround;

public class LinqTests 

{
    [Fact]
    public void loop_to_filter_numbers()
    {
    //arrange
    var numbers = new List<int> {1, 53, 2, 62, 2, 12, 17, 15, 16 };
    //act
    var numbersLargerThan15 = new List<int>();
    foreach (var number in numbers)
    {
        if (number > 15)
        {
            numbersLargerThan15.Add(number);
            continue;
        }
    }
    //Assert
    Assert.Equal(4, numbersLargerThan15.Count);

    }

    [Fact]
    public void linq_to_filter_numbers()
    {
        //arrange
        var numbers = new List<int> {1, 53, 2, 62, 2, 12, 17, 15, 16 };
        //act
        var numbersLargerThan15 = numbers.FindAll(number => number > 15); //lambda
        //assert
        Assert.Equal(4, numbersLargerThan15.Count);
    }
    //super useful for finding high scores for example!
    //(number => number > 15) is Lambda expression

    [Fact]
    public void linq_to_find_first()
    {
        //arrage
        var numbers = new List<int> {1, 53, 2, 62, 2, 12, 17, 15, 16};
        //act
        var firstNumberLargerThan15 = numbers.Find(number => number > 15);
        //assert
        Assert.Equal(53, firstNumberLargerThan15);

    }

    [Fact]
    public void linq_to_check_if_any_matches()
    {
        //arrange
        var numbers = new List<int> {1, 53, 2, 62, 2, 12, 17, 15, 16 };

        //act
        var anyOver100 = numbers.Any(number => number > 100);

        //assert
        Assert.False(anyOver100);
    }

    [Fact]
    public void linq_to_check_if_all_positive()
    {
        //arrange
        var numbers = new List<int> {1, 53, 2, 62, 2, 12, 17, 15, 16 };

        //act
        var allPositive = numbers.All(number => number > 0);
        //assert
        Assert.True(allPositive);
    }

    [Fact]
    public void filter_people_by_age()
    {
        //arrange
        var people = new List<Person> 
        { 
            new Person ("Aaaron"),
            new Person ("Bea"),
            new Person ("Caesar"),
            new Person ("Dave"),
        };
        //act
        var allWitLongNames = people
         .Where(p =>
         {
             return p.Name.Length > 4;
         })
         .ToList();
        //assert
        Assert.Equal(2, allWitLongNames.Count);
        Assert.Equal("Aaaron", allWitLongNames[0].Name);

    }
    //.select
    [Fact]
    public void filter_people_by_age_only_names()
    {
        //arrange
        var people = new List<Person>
        {
            new Person ("Aaaron"),
            new Person ("Bea"),
            new Person ("Caesar"),
            new Person ("Dave"),
            
        };
        //act
         var allWithLongNames = people
        .Where(p => p.Name.Length > 4)
        .Select(p => p.Name) //we onlty want the name property returned
        .ToList();

        //assert
        Assert.Equal(2, allWithLongNames.Count);
        Assert.Equal("Aaaron", allWithLongNames[0]);
        Assert.Equal("Caesar", allWithLongNames[1]);
    }

}
