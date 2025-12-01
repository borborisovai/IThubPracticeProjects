namespace AiJailbreak
{
    public static  class WordCompare
    {
        public static  void Compare(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor= ConsoleColor.White;
string word1;
string word2;

try
{
    word1 = File.ReadAllText(args[1]);
    word2 = File.ReadAllText(args[2]);
}
catch (Exception ex)
{
    word1 = File.ReadAllText("word1.txt");
    word2 = File.ReadAllText("word2.txt");
    Console.WriteLine("using default files: " + ex.Message);
}
int maxWordLenght;
maxWordLenght = word1.Length;
if (word1.Length < word2.Length) maxWordLenght = word2.Length;

List<char> matchChars = new();
List<int> matchNums = new();
int i = 0;
Console.WriteLine();
foreach (char a in word1)
{
    try
    {
        if (a == word2[i])
        {
            matchChars.Add(a);
            matchNums.Add(i);
                        Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(a);
                        Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor= ConsoleColor.White;
        }
        else
        {
            Console.Write(a);
        }
    }
    catch { Console.Write(a); }
    i++;
}
i = 0;
Console.WriteLine();
foreach (char a in word2)
{
    try
    {
        if (a == word1[i])
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(a);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        else
        {
            Console.Write(a);
        }
    }
    catch { Console.Write(a); }
    i++;
}

Console.WriteLine();
Console.WriteLine((matchChars.Count * 100 / maxWordLenght) + "%");
            Console.ReadLine();

        }
    } 
}