using PasswordGenerator.Console;

string password;

RandomPasswordGenerator randomPasswordGenerator = new();

string[] questionArray = {"Include Numbers? (y/n)", "Include upperCase? (y/n)", "Include lowerCase ? (y / n)", "Include specialChar? (y/n)", "What is the lenght of password?" };
bool[] valueArray= new bool[4];
int lenght=0;
for(int i = 0; i<questionArray.Length; i++)
    {
    if (i == questionArray.Length-2)
    {
        Console.WriteLine(questionArray[i]);
        var _lenght = Console.ReadLine();
        lenght=Convert.ToInt32(_lenght);
    }
    else { 
        Console.WriteLine(questionArray[i]);
        string _value = Console.ReadLine();
        bool value = inputController(_value);
        valueArray[i] = value;}
    }

password = randomPasswordGenerator.GeneratePassword(valueArray[0], valueArray[1], valueArray[2], valueArray[3], lenght);

Console.WriteLine($"your password is: {password}");
Boolean inputController(string input) {
    input.ToLower();

    switch (input)
    {
        case "y":
        case "yes":
            return true;
        case "n":
        case "no":
            return false;
        default:
            Console.WriteLine("answer must be like y/n or yes/no");
            return false;
    }

};

