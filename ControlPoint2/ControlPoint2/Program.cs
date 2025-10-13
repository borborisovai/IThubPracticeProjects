using ControlPoint2;
using ControlPoint2.Heroes;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("====[ Yet Another Console RPG Game! ]====");
Console.WriteLine("Type 'help' to see available commands.");
HeroManager<Hero> heroManager = new HeroManager<Hero>();
for (; 1 > 0;)
{
    Console.Write("> ");
    string line = Console.ReadLine();
    string command = line.Split(' ')[0].ToLower();
    string[] argu = line.Split(' ').Skip(1).ToArray();

    try
    {
        switch (command)
        {
            case "addhero":
                if (argu.Length < 2)
                {
                    Console.WriteLine("Usage: addhero <HeroType> <HeroName>");
                    break;
                }
                string heroType = argu[0];
                string heroName = argu[1];
                Hero newHero = heroType.ToLower() switch
                {
                    "assasin" => new Assasin(heroName),
                    "bandit" => new Bandit(heroName),
                    "bard" => new Bard(heroName),
                    "paladin" => new Paladin(heroName),
                    "warrior" => new Warrior(heroName),
                    "wizard" => new Wizard(heroName),
                    _ => null
                };
                if (newHero == null)
                {
                    Console.WriteLine($"Unknown hero type: {heroType}");
                    break;
                }
                heroManager.AddHero(newHero);
                break;
            case "removehero":
                if (argu.Length < 1)
                {
                    Console.WriteLine("Usage: removehero <HeroName>");
                    break;
                }
                heroManager.RemoveHero(argu[0]);
                break;
            case "levelup":
                if (argu.Length < 1)
                {
                    Console.WriteLine("Usage: levelup <HeroName>");
                    break;
                }
                heroManager.LevelUpHero(argu[0]);
                break;
            case "displayheroes":
                heroManager.DisplayHeroes();
                break;
            case "useability":
                if (argu.Length < 2)
                {
                    Console.WriteLine("Usage: useability <HeroName> <AbilityName>");
                    break;
                }
                heroManager.UseHeroAbility(argu[0], argu[1]);
                break;
            case "changesettings":
                for (;;)
                {
                    Console.WriteLine("List of settings:\n" +
                    "- maxlevel <level> - Changes maximum level");
                    Console.Write("[Settings]> ");
                        line = Console.ReadLine();
                        command = line.Split(' ')[0].ToLower();
                        argu = line.Split(' ').Skip(1).ToArray();
                    switch (command)
                    {
                        case "maxlevel":
                            if (argu.Length < 1)
                            {
                                Console.WriteLine("Usage: maxlevel <level>");
                                break;
                            }
                            try
                            {
                                GameSettings.MaxLevel = int.Parse(argu[1]);
                            }
                            catch
                            {
                                Console.WriteLine("<level> must be number");
                            }
                            break;
                    }
                    break;
                }
                
                break;
            case "help":
                if (argu.Length == 0)
                {
                    Console.WriteLine("List of commands:\n" +
        "- addhero <HeroType> <HeroName> - Adds a new hero of specified type and name.\n" +
        "- removehero <HeroName> - Removes the hero with the specified name.\n" +
        "- levelup <HeroName> - Levels up the hero with the specified name.\n" +
        "- displayheroes - Displays all heroes and their levels.\n" +
        "- useability <HeroName> <AbilityName> - Makes the specified hero use an ability.\n" +
        "- exit - Exits the game.\n" +
        "\n Additional documentation:\n" +
        "- help - Displays this help message.\n" +
        "- help abilities - Dysplays list of avalable abilities\n" +
        "- help herotypes - Dysplays list of avalable hero types");
                    break;
                }
                switch (argu[0])
                {
                    case "abilities":
                        Console.WriteLine("Avalable abilities:\n" +
                        "evade\n" +
"acrobatic\n" +
"attack\n" +
"defend\n" +
"castspell\n" +
"rehcargemana\n"
);
                        break;
                    case "herotypes":
                        Console.WriteLine("Avalable hero types:\n" +
                        "assasin\n" +
"bandit\n" +
"bard\n" +
"paladin\n" +
"warrior\n" +
"wizard\n"
                        );
                        break;
                }

                break;
            case "exit":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Unknown command. Type 'help' for a list of commands.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

}

