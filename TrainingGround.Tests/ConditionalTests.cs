using TrainingGround;
using static TrainingGround.AgeCalculator;
public class ConditionalTests 

{ 


[Fact]
public void should_be_kid_when_younger_than_18 ()
{
    var p = new Person(2005);

    var category = AgeCalculator.GetAgeCategory(p, 2022);

    Assert.Equal(AgeCategory.Kid, category);
}

[Fact]
public void should_be_adult_when_older_than_18 ()

{
var p = new Person(2002);

var category = AgeCalculator.GetAgeCategory(p, 2022);

Assert.Equal(AgeCategory.Adult, category);

}
[Fact]
public void when_50_then_prime_Age()
{
    var p = new Person(1972);

    var category = AgeCalculator.GetAgeCategory(p, 2022);

    Assert.Equal(AgeCategory.Prime, category);

}

}