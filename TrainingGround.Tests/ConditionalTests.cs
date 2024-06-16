using System.Configuration.Assemblies;
using System.Reflection.Metadata.Ecma335;
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

[Fact]
public void return_under_18_for_kid()
{
    var span = AgeCalculator.GetAgeSpan(AgeCategory.Kid);

    Assert.Equal("Under 18 years", span);
}

//writing test using [theory] and [InlineData] attributes
[Theory]
[InlineData(AgeCategory.Adult, "Above 18")]
public void return_above_18_for_adult(AgeCategory ageCategory, string expectedSpan)
{
    var span = AgeCalculator.GetAgeSpan(ageCategory);

    Assert.Equal(expectedSpan, span);
}

[Theory]
[InlineData(AgeCategory.Prime, "Exactly 50 - and proud!")]

public void return_exactly_50_for_prime(AgeCategory ageCategory, string expectedSpan)
{
    var span = AgeCalculator.GetAgeSpan(ageCategory);

    Assert.Equal(expectedSpan, span);

}

}