namespace ControlPoint2
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public abstract void UseAbility(string ability);
        public static void LevelUp(Hero hero)
        {
            if (!GameSettings.IsLevelValid(hero.Level + 1)) return;
            hero.Level++;
            System.Console.WriteLine($"{hero.Name} leveled up to {hero.Level}!");
        }
    }
}