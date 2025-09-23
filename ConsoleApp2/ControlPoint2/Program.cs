// See https://aka.ms/new-console-template for more information
using System.Net.Security;
using ControlPoint2;

Console.WriteLine("Hello, World!");
List<Participant> participants = new List<Participant>
{
    new Human { Name = "Alice", Age = 30},
    new Human { Name = "Bob", Age = 25},
    //new Animal { Species = AnimalType.Dog },
    new Animal { Species = AnimalType.Cat },
    new Insect { Species = "Dragonfly", WingSpan = 2.0 },
    new Insect { Species = "Ant", WingSpan = 0.1 }
};

Race.GetWinner(participants, 100);
