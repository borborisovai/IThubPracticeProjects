using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizler
{
    public partial class Form1 : Form
    {
        List<Answer> answers = new List<Answer>();
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Config.LoadConfig();
            int i = 0;
            questionTabs.TabPages.Clear();
            foreach (var q in Config.configs)
            {
                questionTabs.TabPages.Add(q.title);
                Label questionLabel = new Label()
                {
                    Text = q.description,
                    AutoSize = true,
                    Location = new Point(8, 8)
                };
                questionTabs.TabPages[i].Controls.Add(questionLabel);
                int b = 0;
                switch (q.type)
                {
                    case "radio":
                        b = 0;
                        foreach (var v in q.variables)
                        {
                            RadioButton variable = new RadioButton()
                            {
                                Text = v,
                                AutoSize = true,
                                Location = new Point(10, 50 + (b * 30))
                            };
                            questionTabs.TabPages[i].Controls.Add(variable);
                            b++;
                        }
                        break;
                    case "check":
                        b = 0;
                        foreach (var v in q.variables)
                        {
                            CheckBox variable = new CheckBox()
                            {
                                Text = v,
                                AutoSize = true,
                                Location = new Point(10, 50 + (b * 30))
                            };
                            questionTabs.TabPages[i].Controls.Add(variable);
                            b++;
                        }
                        break;
                    case "textbox":
                        b = 0;
                        if (q.variables.Count > 0)
                        {
                            ComboBox variable = new ComboBox() { Location = new Point(8, 50), Size = new Size(300, 31) };
                            foreach (var v in q.variables) variable.Items.AddRange(new object[] { v });
                            questionTabs.TabPages[i].Controls.Add(variable);
                        }
                        else
                        {
                            TextBox variable = new TextBox() { Text = "", Location = new Point(8, 50), Size = new Size(300, 31) };
                            questionTabs.TabPages[i].Controls.Add(variable);
                        }
                        b++;
                        break;
                }

                Button answer = new Button()
                {
                    Text = "Подтвердить",
                    Size = new Size(100, 32),
                    Location = new Point(8, 50 + (b * 30)),
                    Name = "answer"
                };
                questionTabs.TabPages[i].Controls.Add(answer);
                answer.Click += answer_Click;
                answers.Add(new Answer() { Id = i, RightAnswers = Config.configs[i].answers, UserAnswers = new (), IsCorrect = true });  
                i++;
            }
        }

        private void answer_Click(object sender, EventArgs e)
        {
            int curentTab = questionTabs.SelectedIndex ;
            switch (Config.configs[curentTab].type)
            {
                case "radio":
                    foreach (var a in questionTabs.TabPages[curentTab].Controls)
                    {
                        if (a is RadioButton )
                        {
                            RadioButton b = (RadioButton)a;
                            if (b.Checked) answers[curentTab].UserAnswers.Add(b.Text);  
                        }
                    }
  
                    break; 
                case "check":
                    foreach (var a in questionTabs.TabPages[curentTab ].Controls)
                    {
                        if (a is CheckBox )
                        {
                            CheckBox b = (CheckBox)a;
                            if (b.Checked) answers[curentTab].UserAnswers.Add(b.Text);    
                        }
                    }

                    break;
                case "textbox":
                    foreach (var a in questionTabs.TabPages[curentTab].Controls)
                    {
                        if (a is TextBox )
                        {
                            TextBox  b = (TextBox )a; answers[curentTab].UserAnswers.Add(b.Text);
                        }
                    }
                    break;
            }
            if (answers[curentTab].UserAnswers.Count  == answers[curentTab].RightAnswers.Count ) 
                for (int i = 0; i!= answers[curentTab ].UserAnswers.Count; i++)
                {
                    if (answers[curentTab].UserAnswers[i] != answers[curentTab].RightAnswers[i]) answers[curentTab].IsCorrect = false;  
                }
            if (questionTabs.SelectedIndex == questionTabs.TabCount - 1 ) new Results(answers).ShowDialog();
            questionTabs.SelectedIndex = curentTab + 1; 
  

 
 

        }
    }
    public class Answer {
        public int Id { get; set; }
        public List< string> UserAnswers { get; set; }
        public List<string> RightAnswers { get; set; }
        public bool IsCorrect { get; set; }
    }
}
