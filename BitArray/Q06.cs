using System.Collections;

namespace Bit_Array;

/*
      Password Policy Enforcement
Task: Use a BitArray to enforce a password policy with 4 rules (e.g., uppercase, lowercase, digit, special character). Check if a password meets the policy.
 */
public class Q06
{
    public static void Question()
    {
        BitArray bits = new BitArray(5);

        var password = "Heelo1";

        bits[0] = password.Any(c => char.IsUpper(c));
        bits[1] = password.Any(c=> char.IsLower(c));
        bits[2] = password.Any(c=> char.IsDigit(c));
        bits[3] = password.Any(c => char.IsLetterOrDigit(c));
        bits[4] = password.Any(c => "!@#$%^&*".Contains((c)));

        Console.WriteLine($"{(!bits.HasAllSet() ? $"Your password is week " : "Your password is strong!")}");
    }

}
