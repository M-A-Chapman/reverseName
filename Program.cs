namespace reverseName;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        var name = Console.ReadLine();
        if (!string.IsNullOrEmpty(name))
        {
            var reverseName = new char[name.Length];
            for (var i = 0; i < name.Length; i++)
            {
                reverseName[i] = name[name.Length-1-i];
            };
            var reversedName = new string(reverseName);
            System.Console.WriteLine(reversedName);
        }
    }
}
