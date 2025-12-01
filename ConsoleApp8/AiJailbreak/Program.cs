using AiJailbreak;

switch (args[0])
{
    case "compare":
        WordCompare.Compare(args);
        break;
    case "find":
        WordsFinder.Find(args);
        break;
    default:
        Console.WriteLine("no command found");
        break;
}
