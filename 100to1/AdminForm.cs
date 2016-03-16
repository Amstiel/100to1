using System;
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
        int roundCount = 1;
        public AdminForm()
        {
            InitializeComponent();
            vf = new ViewForm();
            vf.Show();
            Base.loadBase(basePath);
            comboBoxInit();
            questionInit(0);
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


        // При вызове этой функции - бежим по массиву, связанному с выбранным вопросом и заполняем ответы
        public void questionInit(int id)
        {
            answer1TextBox.Text = Base.answers[0][id].ToString(); // Прости за эту стену текста, но мне было лень делать массив)
            answer2TextBox.Text = Base.answers[1][id].ToString(); // Да и всего 6 строчек, не сильно и говнокод
            answer3TextBox.Text = Base.answers[2][id].ToString();
            answer4TextBox.Text = Base.answers[3][id].ToString();
            answer5TextBox.Text = Base.answers[4][id].ToString();
            answer6TextBox.Text = Base.answers[5][id].ToString();

            answer1PointsTextBox.Text = Base.score[0][id].ToString(); //Ладно, переписать это в виде цикла было бы нормальной идеей)
            answer2PointsTextBox.Text = Base.score[1][id].ToString();
            answer3PointsTextBox.Text = Base.score[2][id].ToString();
            answer4PointsTextBox.Text = Base.score[3][id].ToString();
            answer5PointsTextBox.Text = Base.score[4][id].ToString();
            answer6PointsTextBox.Text = Base.score[5][id].ToString();
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
            //MessageBox.Show("help");
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ((TextBox)sender).ReadOnly = true;
                //Добавить функцию отправки данных на ViewForm
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
        }
    }
}
