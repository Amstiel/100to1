using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _100to1
{
    public partial class AdminForm : Form
    {
        public string basePath = @"C:\Works\test.txt"; // Пусть к базе
        public ViewForm vf;
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
            questionNameComboBox.SelectedIndex = 0; // Убрать эту хуйню при генерации вопроса, потом. =)
        }


        // При вызове этой функции - бежим по массиву, связанному с выбранным вопросом и заполняем ответы
        public void questionInit(int id)
        {
            answer1TextBox.Text = Base.answers[0][id].ToString(); // Прости за эту стену текста, но мне было лень делать массив)
            answer2TextBox.Text = Base.answers[1][id].ToString(); // Да и всего 6 строчек, не сильно и говнокод
            answer3TextBox.Text = Base.answers[2][id].ToString();
            answer4TextBox.Text = Base.answers[0][id].ToString();
            answer5TextBox.Text = Base.answers[1][id].ToString();
            answer6TextBox.Text = Base.answers[2][id].ToString();
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
                vf.FormBorderStyle = FormBorderStyle.None;
            }
        }

        private void notFullScreenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (notFullScreenRadioButton.Checked)
            {
                vf.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void questionNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            questionInit(questionNameComboBox.SelectedIndex);
        }
    }
}
