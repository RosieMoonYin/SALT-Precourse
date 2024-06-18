using System.Text.RegularExpressions;

public class Kata
{
    
    //Golf Kata
    public static string OpenOrSenior(int memberAge, int handicap)
    {
        //if {memberAge} over 55 && {handicap} > 7
        //-2 to +26
       return (handicap > 7 && memberAge > 54) ? "Senior" :
       (handicap < 7 && memberAge < 54) ? "Open":
       "not eligeable";
    }
    //Validate Pin Kata
    public static bool ValidatePin(string pin)
    {
        int pinNumber;       
        return (pin.Length == 4 && int.TryParse(pin, out pinNumber) && Regex.IsMatch(pin, @"^\d+$")) ||
        (pin.Length == 6 && int.TryParse(pin, out pinNumber) && Regex.IsMatch(pin, @"^\d+$"));

        //problem with significant white space edge case not handled
    }}
