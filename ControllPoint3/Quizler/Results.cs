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
    public partial class Results : Form
    {
        public Results(List<Answer > answers )
        {
            int i = 0;
            foreach ( Answer answer in answers )
            {
                string right = "Верно";
                string wrong = "Неверно";
                //Я успешно забыл как это правильно пишется
                string babaika; 
                if (answer.IsCorrect) babaika = right; else babaika = wrong;
                //Я успешно забыл как это правильно пишется X2
                string userAnswers = "";
                string rightAnswers = "";
                answer.UserAnswers.ForEach(x => userAnswers = userAnswers + x + ' ');
                answer.RightAnswers .ForEach(x => rightAnswers = rightAnswers + x + ' ') ;
                Label label = new Label()
                {
                    Text = $"{i + 1}) {babaika } ({userAnswers }/ {rightAnswers })",
                    AutoSize = true,
                    Location = new Point(8, 8 + (i * 25)) 
                };
                this.Controls.Add(label);
                i++;
            }
            InitializeComponent();
        }
    }
}
