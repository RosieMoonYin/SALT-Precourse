using System.Transactions;

public class LoopTests 
{
    

    [Fact]
    public void while_loop()
    {
        //arrange
        var ints = new int [] { 1, 2, 3, 4, 5 }; //initialise array of integers (something to loop over!)
        //act
        var i = 0;
        while(i < ints.Length)
        {
            var currentValueInTheLoop = ints[i];

            Console.WriteLine($"i is now `{i}`");
            Console.WriteLine($"currentValueInTheLoop is now `{currentValueInTheLoop}`");
        
        //assert
        Assert.Equal(i + 1, currentValueInTheLoop);
        i++;
        }
    }

    [Fact]
    public void for_loop()
    {
        //arrange
        var ints = new int[] {1, 2, 3, 4, 5};
        //act
        for (var i = 0; i < ints.Length; i++)
        {
            var currentValueInTheLoop = ints [i];

            Console.WriteLine($"i is now `{i}`");
            Console.WriteLine($"current value in the loop is now `{currentValueInTheLoop}`");

            //assert
            Assert.Equal(i + 1, currentValueInTheLoop);
        }
    }
    
    [Fact]
    public void for_each_loop()
    {
        //arrange
        var ints = new int[] {1, 2, 3, 4, 5};
        //act
        foreach (var currentValueInTheLoop in ints)
        {
            //Console.WriteLine($"i is now `{i}`"); // dont need!!?
            Console.WriteLine($"currentValueInTheLoop is now `{currentValueInTheLoop}`");

        //assert
            Assert.IsType<int>(currentValueInTheLoop);
        }
    }
    [Fact]
    public void for_each_address_loop()
    {
    //arrange 
    var addressList = new List<Address>();
    addressList.Add(new Address() { Street = "Street", StreetNo = 1 });
    addressList.Add(new Address() { Street = "Street", StreetNo = 2 });
    addressList.Add(new Address() { Street = "Street", StreetNo = 3 });
    foreach (var currentValueInTheLoop in addressList)
    {
        //act
        Console.WriteLine($"StreetNo is now `{currentValueInTheLoop.StreetNo}`");


        //assert
        Assert.IsType<Address>(currentValueInTheLoop);

    }
    }

    public void break_stops_loops()
    {
        //arrange
        var addressList = new List<Address>();
        addressList.Add(new Address() { Street = "Street", StreetNo = 1 });
        addressList.Add(new Address() { Street = "Street", StreetNo = 2 });
        addressList.Add(new Address() { Street = "Street", StreetNo = 3 });
        //act
        var foundIt = false;
        foreach (var currentValueInTheLoop in addressList)
        {
            if (currentValueInTheLoop.StreetNo == 2)
            {
                foundIt = true;
                break;
            }
        }
        //assert
        Assert.True(foundIt);
    }

//When we call break the loop halts 
//and we continue on the next line after the loop.
//continue means that we break this lap of the loop 
//and continue on to the next. 
//This is useful when you have a lot of calculations to do in each lap, 
//but for this particular element you don’t need to do it. 
//Can you come up with a case like that? Can you write a test for it?

}