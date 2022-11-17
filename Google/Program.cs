
using Reader;

ReadInFile readInFile = new ReadInFile();
ReadInKeyboard readInKeyboard = new ReadInKeyboard();
while (true)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Menu");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("1.Read information from the keyboard");
    Console.WriteLine();
    Console.WriteLine("2.Read information from the file");
    Console.WriteLine();
    Console.WriteLine("3.Credits");
    Console.WriteLine();
    Console.WriteLine("4.Exit");
    Console.WriteLine();
    string enter = Console.ReadLine();
    bool parse = int.TryParse(enter, out var select);
    if (parse)
    {
        switch (select)
        {
            case 1:
                readInKeyboard.Read();
                break;
                return;
            case 2:
                readInFile.Read();
                break;
                return;
            case 3:
                Console.WriteLine("3.Credits" +
        " Marat & Co toghether with Emil & Co");
                break;
                return;
            case 4:
                Environment.Exit(0);
                break;
                return;
            default:
                Console.WriteLine("Enter an item from the menu");
                break;
                return;
        }
        
    }
    else
    {
        Console.WriteLine("Please use numbers to enter");
        
    }
    
}
