namespace TrainingGround;

public class TypesTest
{ 
[Fact]
public void reference_types_can_be_changed_via_reference()
{
    //arrange
    Person a = new Person("Person A");
    a.LengthInMeters = 1.95;
    Person b = a;

    //act
    b.LengthInMeters = 1.96;

    //assert
    Assert.Equal(1.96, b.LengthInMeters);
    Assert.Equal(1.96, a.LengthInMeters);
}

[Fact]
public void value_types_cannot_be_changed_via_reference()
{
    //arrage
    double aLengthInMeters = 1.95;
    double bLengthInMeters = aLengthInMeters;

    //act
    bLengthInMeters = 1.96;

    //assert
    Assert.Equal(1.96, bLengthInMeters);
    Assert.Equal(1.95, aLengthInMeters);

}

//[Fact]
//public void getting_age_from_person()
//{
   // int p = new Person(1972);

   // var age = p.GetAge(2022);

  // Assert.Equal(50, age);
  // Assert.IsType<Person>(p);
  //  Assert.IsType<int>(age);

//}

}

