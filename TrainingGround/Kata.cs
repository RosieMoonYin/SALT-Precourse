using System.Net.Mail;
using System.Text;
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
        //code repeats itself but || operator doesnt work?!
    }
    
    public static string LetterChanges(string myString)
    {
        //char[] arr = myString.Select(c => (char) (c + 1)).ToArray(); 

        char[] myArr = myString.ToCharArray();
//StringBuilder myStringResult = new StringBuilder();
        //string myStringResult = new string(myArr);

        for (int i = 0; i < myString.Length; i++)
        {   
            if ((myArr[i] >= 'A' && myArr[i] <= 'Z') || (myArr[i] >= 'a' && myArr[i] <='z'))
            { 
                myArr[i]++;
                //checking vowels
                //("aeiou".Contains(myArr[i]))
                //{
                //  char.ToUpper(myArr[i]);
               // }
                //char lowerCase = char.ToLower(myArr[i]);
                //checking vowels
                //("aeiou".Contains(myArr[i]))
                //{
                //  char.ToUpper(myArr[i]);
               // }
               switch (myArr[i])
               {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    myArr[i] = char.ToUpper(myArr[i]);
                    break;
                }
            }
            myString = myArr[i].ToString();
            //myStringResult.Append(myArr[i]);
        }
        //myString = myStringResult.ToString();
        return myString;
    }

}
