using System.Collections;

namespace Bit_Array;

/*
      Password Strength Checker
      Task: Use a BitArray to track whether a password has an uppercase letter, a lowercase letter, a digit, and a special character.
 */
public class Q5
{
    public static void Question()
    {
        // 0 : uppercase letter, 1: a lowercase letter,2: a digit, 3: a special character
        BitArray bits = new BitArray(4);

        List<string> list = new List<string>() { "uppercase letter" ,
            "lowercase letter" ,
            "digit" ,
            "special character"};

        var password = "Heelo1";

        bits[0] = password.Any(c => char.IsUpper(c));
        bits[1] = password.Any(c=> char.IsLower(c));
        bits[2] = password.Any(c=> char.IsDigit(c));
        bits[3] = password.Any(c => char.IsLetterOrDigit(c));

        var output ="";
        for (int i = 0; i < bits.Length; i++)
            output = !bits[i] ? output +"  "+ list[i] : output;
        
        Console.WriteLine($"{(output.Length > 0 ? $"Your password is missing: {output}" : "Your password is strong!")}");
    }

}
