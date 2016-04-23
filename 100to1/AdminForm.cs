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
        public bool pressTarakaniii;
        public int xMouse, yMouse;
        public string basePath = @"test.txt"; // Пусть к базе
        public ViewForm vf;
        public ArrayList answersAdmin = new ArrayList();
        public ArrayList answersScoreAdmin = new ArrayList();
        public ArrayList answersCheckedAdmin = new ArrayList();
        int allPoints = 0, firstTeamScores = 0, secondTeamScores = 0;
        int currentRound = 1;
        public Boolean firstTeamTurn, secondTeamTurn;
        public AdminForm()
        {
            InitializeComponent();
            vf = new ViewForm();
            vf.Show();
            Base.loadBase(basePath);
            answersInit();
            answersScoreInit();
            comboBoxInit();
            questionInit(0);
            setRoundScores(0);
            vf.team1Lampa.Visible = false;
            vf.team2Lampa.Visible = false;
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
                    setFirstTeamScores(Convert.ToInt32(((TextBox)Sender).Text));
                    break;
                case "secondTeamPointsTextBox":
                    setSecondTeamScores(Convert.ToInt32(((TextBox)Sender).Text));
                    break;
                case "allPointsTextBox":
                    setRoundScores(Convert.ToInt32(((TextBox)Sender).Text));
                    break;
                case "roundNumberTB":
                    setRound(Convert.ToInt32(((TextBox)Sender).Text));
                    break;
            }
            if (((TextBox)Sender).Tag == "answer")
            {
                updateAnswers();
            }
            if (((TextBox)Sender).Tag == "score")
            {
                updateScores();
            }
        }

        public void updateAnswers()
        {
            for (int i = 0; i < answersAdmin.Count; i++)
            {
                ((Label)vf.AnswersLB[i]).Text = ((TextBox)answersAdmin[i]).Text;
            }
        }

        public void updateScores()
        {
            for (int i = 0; i < answersScoreAdmin.Count; i++)
            {
                ((Label)vf.AnswersScores[i]).Text = ((TextBox)answersScoreAdmin[i]).Text;
            }
        }

        public void setRoundScores(int scores)
        {
            allPointsTextBox.Text = scores.ToString();
            allPoints = scores;
            vf.allPointsLabel.Text = allPoints.ToString();
        }

        public void setFirstTeamScores(int scores)
        {
            firstTeamPointsTextBox.Text = scores.ToString();
            firstTeamScores = scores;
            vf.teamOnePointsLabel.Text = firstTeamScores.ToString();
        }

        public void setSecondTeamScores(int scores)
        {
            secondTeamPointsTextBox.Text = scores.ToString();
            secondTeamScores = scores;
            vf.teamTwoPointsLabel.Text = secondTeamScores.ToString();
        }

        public void setRound(int round)
        {
            roundNumberTB.Text = round.ToString();
            vf.roundNumberLabel.Text = round.ToString();
            currentRound = round;
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

        private void firstTeamRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (firstTeamRadioButton.Checked)
            {
                firstTeamTurn = true;
                vf.team2Lampa.Visible = false;
                vf.team1Lampa.Visible = true;
                secondTeamTurn = false;
            }
        }

        private void secondTeamRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (secondTeamRadioButton.Checked)
            {
                vf.team2Lampa.Visible = true;
                vf.team1Lampa.Visible = false;
                firstTeamTurn = false;
                secondTeamTurn = true;
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
            if (!((CheckBox)sender).Checked)
            {
                setRoundScores(allPoints + Convert.ToInt32(((TextBox)answersScoreAdmin[id]).Text));
            }
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

        private void nextRoundBtn_Click(object sender, EventArgs e)
        {
            if (firstTeamTurn)
            {
                setFirstTeamScores(allPoints + firstTeamScores);
                setSecondTeamScores(secondTeamScores);
            }
            else
            {
                setSecondTeamScores(allPoints + secondTeamScores);
                setFirstTeamScores(firstTeamScores);
            }

            answer1CheckBox.Checked = true;
            answer2CheckBox.Checked = true;
            answer3CheckBox.Checked = true;
            answer4CheckBox.Checked = true;
            answer5CheckBox.Checked = true;
            answer6CheckBox.Checked = true;

            firstTeamMistakeOne.Checked = false;
            firstTeamMistakeTwo.Checked = false;
            firstTeamMistakeThree.Checked = false;

            secondTeamMistakeOne.Checked = false;
            secondTeamMistakeTwo.Checked = false;
            secondTeamMistakeThree.Checked = false;

            vf.team2Lampa.Visible = false;
            vf.team1Lampa.Visible = false;

            setRoundScores(0);
            setRound(++currentRound);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left){
                panel1.BackColor = Color.Red;
                pressTarakaniii = true;
               // xMouse = Cursor.Position.X;
               // yMouse = Cursor.Position.Y;
                return;
            };
            if (e.Button == MouseButtons.Right && pressTarakaniii)
            {
                pressTarakaniii = false;
                panel1.BackColor = Color.Silver;
                return;
            };
            if (e.Button == MouseButtons.XButton1 && pressTarakaniii)
            {
                pressTarakaniii = false;
                panel1.BackColor = Color.Silver;
                secondTeamRadioButton.Checked = true;
                firstTeamRadioButton.Checked = true;
                Cursor.Position = new Point(Convert.ToInt32(0), Convert.ToInt32(0));
                SoundPlayer a = new SoundPlayer(@"..\..\audio\button.wav");
                a.Play();
                return;
            };
            if (e.Button == MouseButtons.XButton2 && pressTarakaniii)
            {
                pressTarakaniii = false;
                panel1.BackColor = Color.Silver;
                firstTeamRadioButton.Checked = true;
                secondTeamRadioButton.Checked = true;
                Cursor.Position = new Point(Convert.ToInt32(0), Convert.ToInt32(0));
                SoundPlayer a = new SoundPlayer(@"..\..\audio\button.wav");
                a.Play();
                return;
            };
            if (e.Button == MouseButtons.XButton1 && !pressTarakaniii)
            {
                pressTarakaniii = false;
                panel1.BackColor = Color.Silver;
                firstTeamRadioButton.Checked = true;
                secondTeamRadioButton.Checked = true;
                Cursor.Position = new Point(Convert.ToInt32(0), Convert.ToInt32(0));
                SoundPlayer a = new SoundPlayer(@"..\..\audio\wrong.wav");
                a.Play();
                return;
            };
            if (e.Button == MouseButtons.XButton2 && !pressTarakaniii)
            {
                pressTarakaniii = false;
                panel1.BackColor = Color.Silver;
                secondTeamRadioButton.Checked = true;
                firstTeamRadioButton.Checked = true;
                Cursor.Position = new Point(Convert.ToInt32(0), Convert.ToInt32(0));
                SoundPlayer a = new SoundPlayer(@"..\..\audio\wrong.wav");
                a.Play();
                return;
            };
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vf.team2Lampa.Visible = false;
            vf.team1Lampa.Visible = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressTarakaniii)
            {
                //Cursor.Position = new Point(Convert.ToInt32(xMouse), Convert.ToInt32(yMouse));
            }
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
            updateAnswers();
            updateScores();
        }
    }
}
