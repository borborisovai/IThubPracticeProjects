namespace AiJailbreak
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class WordsFinder
    {
        public static void Find(string[] args)
        {
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

            List<string> result = new List<string>();

            List<string> line1 = word1.Split(' ').ToList();
            List<string> line2 = word2.Split(' ').ToList();

            foreach (string word in line1)
            {
                if (word == line2.FirstOrDefault(x => x == word)) result.Add(word);
            }

            Console.WriteLine(result.Count);
        }
    }
}

// List<string> line1 = word1.Split(' ').ToList();
// List<string> line2 = word2.Split(' ').ToList();



// foreach (string word in line1)
// {
//     if (word == line2.FirstOrDefault(x => x == word)) result.Add(word);
// }

// Console.WriteLine(result.Count);