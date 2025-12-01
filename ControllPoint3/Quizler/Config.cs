using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Quizler
{
    public static class Config 
    {
        public static int activeConfig;
        public static List<QuestionNode> configs;

        public static bool isGood = false;

        public static event EventHandler ConfigChanged;
        public static void CreateConfig()
        {
            configs = new List<QuestionNode>();
            //configs.Add (new QuestionNode() { title = "test", answers = new List<string>(), variable = new List<string>(), description = "test", type = ["radio"] }) ;
            activeConfig = 0;
            SaveConfig(); 
        }

        public static void LoadConfig()
        {
            configs = new (); 
            isGood = false;
            if (!File.Exists("config.json")) { return; }  

            FileStream stream = new FileStream(path: "config.json", FileMode .Open ); 
            MasterQuestionNode config = JsonSerializer.Deserialize<MasterQuestionNode>(stream);
            stream.Close();  
 
            if (config.questions == null) return ;
            bool isBad = false;
            config.questions.ForEach(config =>
            {
                if (string .IsNullOrEmpty (config.type  )) isBad = true;
 
            });
            if (isBad) { CreateConfig();  return; };

            isGood = true; 
            activeConfig = config.currentQuestion;
            configs = config.questions;
 
        }
        public static void SaveConfig()
        {
            MasterQuestionNode node = new MasterQuestionNode();
            node.currentQuestion = activeConfig;
            node.questions = configs;

            //ConfigChanged.Invoke(node, new ConfigChangedEventArgs());   
            string json = JsonSerializer.Serialize(node );
            File.WriteAllText("config.json", json); 
        }
        
    } 
    public class ConfigChangedEventArgs : EventArgs
    {
 
    }
    public class MasterQuestionNode
    {
        public int currentQuestion { get; set; }
        public List<QuestionNode> questions { get; set; }
    }
    public class QuestionNode
    {
        public string title { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public List<string> answers { get; set; }
        public List<string> variables { get; set; }

    }
}
