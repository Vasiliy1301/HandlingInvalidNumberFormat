namespace HandkingInvalidNumberFormat;

public class Program
{
    Console.Write("Enter any number (numbers only): ");
    string userInput = Console.ReadLine();
        
    try
    {
        int number = int.Parse(userInput);
        Console.WriteLine($"Result: {number}");
    }
    catch (Exception exception)
    {
        Console.WriteLine(exception.Message);
    }
}