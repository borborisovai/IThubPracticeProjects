using System.Diagnostics;

namespace ControlPoint2
{
    public class Race
    {
        public static void GetWinner(List<Participant> participants, int distance)
        {
            Participant winner = null;
            double bestTime = double.MaxValue;

            foreach (var participant in participants)
            {
                participant.Run();
                double time = participant.Run(distance);
                if (time < bestTime)
                {
                    bestTime = time;
                    winner = participant;
                }
            }

            if (winner != null)
            {
                switch(winner)
                {
                    case Human h:
                        Console.WriteLine($"Human {h.Name} wins with time {bestTime}");
                        break;
                    case Animal a:
                        Console.WriteLine($"Animal {a.Species} wins with time {bestTime}");
                        break;
                    case Insect i:
                        Console.WriteLine($"Insect {i.Species} wins with time {bestTime}");
                        break;
                }
            }
            else
            {
                Console.WriteLine("No participants.");
            }
        }
    }
}