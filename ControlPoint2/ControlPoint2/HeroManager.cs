namespace ControlPoint2
{
    class HeroManager<T> where T : Hero
    {
        List<T> heroes = new List<T>();
        public void AddHero(T hero)
        {
            if (heroes.Any(h => h.Name == hero.Name))
            {
                Console.WriteLine($"Hero with name {hero.Name} already exists.");
                return;
            }
            heroes.Add(hero);
            Console.WriteLine($"Hero {hero.Name} added to the game.");
        }

        public void RemoveHero(string name)
        {
            var hero = heroes.First(h => h.Name == name);
            if (hero == null)
            {
                Console.WriteLine($"Hero with name {name} does not exist.");
                return;
            }
            heroes.Remove(hero);
            Console.WriteLine($"Hero {name} removed from the game.");
        }

        public void LevelUpHero(string name)
        {
            var hero = heroes.FirstOrDefault(h => h.Name == name);
            if (hero == null)
            {
                Console.WriteLine($"Hero with name {name} does not exist.");
                return;
            }
            Hero.LevelUp(hero);
        }
        public void DisplayHeroes()
        {
            foreach (var hero in heroes)
            {
                Console.WriteLine($"Hero: {hero.Name}, Level: {hero.Level}");
            }
        }
        public void UseHeroAbility(string name, string ability)
        {
            var hero = heroes.FirstOrDefault(h => h.Name == name);
            if (hero == null)
            {
                Console.WriteLine($"Hero with name {name} does not exist.");
                return;
            }
            hero.UseAbility(ability);
        }

    }
}