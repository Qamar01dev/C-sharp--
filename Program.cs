Console.Write("What's your name? ");
string? name = Console.ReadLine();

Console.Write("What's your age? ");
if (!int.TryParse(Console.ReadLine(), out int age))
{
    Console.WriteLine("Please enter a valid age.");
    return;
}

Console.WriteLine($"Hello, {name}! You are {age} years old.");
