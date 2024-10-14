namespace Generations;

public class Operations
{
    public static int GetAge()
    {
        int age;

        while (true) {
            Console.Write("Enter your age: "); 
            string input = Console.ReadLine(); 

            try {
                age = int.Parse(input); 
                if (age < 0) {
                    Console.WriteLine("You cant enter a negative age!"); 
                }
                else {
                    return age;
                }
            }
            catch (FormatException) {
                Console.WriteLine("Invalid Format!"); 
            }
            catch (OverflowException) {
                Console.WriteLine("You cant be this old!"); 
            }
        }
    }

    public static string Generation(int age) {
        switch (age) {
            case int n when (n >= 0 && n <= 28):
                return "Generation Z";
            case int n when (n >= 29 && n <= 47):
                return "Generation Y";
            case int n when (n >= 48 && n <= 59):
                return "Generation X";
            case int n when (n >= 60 && n <= 78):
                return "Baby Boomers";
            default:
                return "Silent Generation";
        }

    }
}
    
    