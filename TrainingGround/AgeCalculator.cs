using System.Reflection.Metadata.Ecma335;

namespace TrainingGround;
public class AgeCalculator
{
    
    public enum AgeCategory
    {
        Kid,
        Adult,
        Prime
    }
    //changed to staic could change back!
    public static int GetAge(int birthYear, int currentYear)
    {
        return currentYear - birthYear;
    }

    public static AgeCategory GetAgeCategory(Person person, int currentYear)
    {
        var age = person.GetAge(currentYear);
        //succinct method using "ternery" for if else
        return (age > 49 && age < 51) ? AgeCategory.Prime :
        (age <= 18) ? AgeCategory.Kid :
        AgeCategory.Adult;
    }
}
