namespace DefaultNamespace;

public class Program
{
    Console.Write("Enter any number (numbers only): ");
    string userInput = Console.ReadLine();

    bool inputValidation = int.TryParse(userInput, out int number);

    try
    {
        if(inputValidation == false)
            throw new Exception("You entered an incorrect value.");
        Console.WriteLine($"Result: {number}");
    }
    catch (Exception exception)
    {
        Console.WriteLine(exception.Message);
    }
}