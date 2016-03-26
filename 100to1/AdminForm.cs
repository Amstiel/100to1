using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace _100to1
{
    public partial class AdminForm : Form
    {
        public string basePath = @"C:\Works\test.txt"; // Пусть к базе
        public ViewForm vf;
        public ArrayList answersAdmin = new ArrayList();
        public ArrayList answersScoreAdmin = new ArrayList();
        public ArrayList answersCheckedAdmin = new ArrayList();
        int allPoints, teamOnePoints, teamTwoPoints;
        int roundCount = 1;
        public AdminForm()
        {
            InitializeComponent();
            vf = new ViewForm();
            vf.Show();
            Base.loadBase(basePath);
            answersInit();
            answersScoreInit();
            comboBoxInit();
            //questionInit(0);
        }

        // Заполнение комбобокса
        public void comboBoxInit()
        {
            for(int i = 0; i < Base.questions.Count; i++)
            {
                questionNameComboBox.Items.Add(Base.questions[i]);
            }
            questionNameComboBox.SelectedIndex = 0; // Первый вопрос по умолчанию, потом переделать.
        }
        
        public void sendToView(object Sender)
        {
            switch (((TextBox)Sender).Name)
            {
                case "firstTeamNameTextBox":
                    vf.teamOneNameLabel.Text = ((TextBox)Sender).Text;
                    break;
                case "secondTeamNameTextBox":
                    vf.teamTwoNameLabel.Text = ((TextBox)Sender).Text;
                    break;
                case "firstTeamPointsTextBox":
                    vf.teamOnePointsLabel.Text = ((TextBox)Sender).Text;
                    break;
                case "secondTeamPointsTextBox":
                    vf.teamTwoPointsLabel.Text = ((TextBox)Sender).Text;
                    break;
                case "allPointsTextBox":
                    vf.allPointsLabel.Text = ((TextBox)Sender).Text;
                    break;
                case "roundNumberTB":
                    vf.roundNumberLabel.Text = ((TextBox)Sender).Text;
                    break;
            }
            if (((TextBox)Sender).Tag == "answer")
            {
                updateAnswers();
            }
        }

        public void updateAnswers()
        {
            for (int i = 0; i < answersAdmin.Count; i++)
            {
                ((Label)vf.AnswersLB[i]).Text = ((TextBox)answersAdmin[i]).Text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void fullScreenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (fullScreenRadioButton.Checked)
            {
                //vf.FormBorderStyle = FormBorderStyle.None;
            }
        }

        private void notFullScreenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (notFullScreenRadioButton.Checked)
            {
                //vf.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }

        private void questionNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            questionInit(questionNameComboBox.SelectedIndex);
            questionNumberTB.Text = Convert.ToString(questionNameComboBox.SelectedIndex + 1);
        }

        private void textBox_DoubleClick(object sender, EventArgs e)
        {
            ((TextBox)sender).ReadOnly = false;
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ((TextBox)sender).ReadOnly = true;
                sendToView(sender);
            }
        }

        private void firstTeamMistakeOne_MouseClick(object sender, MouseEventArgs e)
        {
            
            
        }
        

        private void mistake_CheckedChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((CheckBox)sender).Tag);
            ((PictureBox)vf.teamsMistakes[id]).Visible = (((CheckBox)sender).Checked);
            if (((CheckBox)sender).Checked)
            {
                SoundPlayer a = new SoundPlayer(@"..\..\audio\wrong.wav");
                a.Play();
            }
        }

        private void answerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((CheckBox)sender).Tag);
            ((PictureBox)vf.AnswersPB[id]).Visible = (((CheckBox)sender).Checked);
            if (!((CheckBox)sender).Checked)
            {
                SoundPlayer a = new SoundPlayer(@"..\..\audio\line_open.wav");
                a.Play();
            }
        }

        private void allPointsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            teamOnePoints += allPoints;
        }

        //Инициализация и добавление элементов в массив, для более удобной работы с ними

        public void answersInit()
        {
            answersAdmin.Add(answer1TextBox);
            answersAdmin.Add(answer2TextBox);
            answersAdmin.Add(answer3TextBox);
            answersAdmin.Add(answer4TextBox);
            answersAdmin.Add(answer5TextBox);
            answersAdmin.Add(answer6TextBox);
        }

        public void answersScoreInit()
        {
            answersScoreAdmin.Add(answer1PointsTextBox);
            answersScoreAdmin.Add(answer2PointsTextBox);
            answersScoreAdmin.Add(answer3PointsTextBox);
            answersScoreAdmin.Add(answer4PointsTextBox);
            answersScoreAdmin.Add(answer5PointsTextBox);
            answersScoreAdmin.Add(answer6PointsTextBox);
        }
        // При вызове этой функции - бежим по массиву, связанному с выбранным вопросом и заполняем ответы
        public void questionInit(int id)
        {
            for (int i = 0; i < answersAdmin.Count; i++)
            {
                ((TextBox)answersAdmin[i]).Text = Base.answers[i][id].ToString();
                ((TextBox)answersScoreAdmin[i]).Text = Base.score[i][id].ToString();

            }
        }
    }
}
