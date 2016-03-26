namespace _100to1
{
    partial class AdminForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private DataBase Base = new DataBase();
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.answer1TextBox = new System.Windows.Forms.TextBox();
            this.answer2TextBox = new System.Windows.Forms.TextBox();
            this.answer3TextBox = new System.Windows.Forms.TextBox();
            this.answer4TextBox = new System.Windows.Forms.TextBox();
            this.answer5TextBox = new System.Windows.Forms.TextBox();
            this.answer6TextBox = new System.Windows.Forms.TextBox();
            this.answer1Label = new System.Windows.Forms.Label();
            this.answer2Label = new System.Windows.Forms.Label();
            this.answer3Label = new System.Windows.Forms.Label();
            this.answer4Label = new System.Windows.Forms.Label();
            this.answer5Label = new System.Windows.Forms.Label();
            this.answer6Label = new System.Windows.Forms.Label();
            this.firstTeamNameTextBox = new System.Windows.Forms.TextBox();
            this.secondTeamNameTextBox = new System.Windows.Forms.TextBox();
            this.firstTeamNameLabel = new System.Windows.Forms.Label();
            this.secondTeamNameLabel = new System.Windows.Forms.Label();
            this.firstTeamPointsTextBox = new System.Windows.Forms.TextBox();
            this.secondTeamPointsTextBox = new System.Windows.Forms.TextBox();
            this.firstTeamPointsLabel = new System.Windows.Forms.Label();
            this.secondTeamPointsLabel = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.firstTeamMistakeOne = new System.Windows.Forms.CheckBox();
            this.firstTeamMistakeTwo = new System.Windows.Forms.CheckBox();
            this.firstTeamMistakeThree = new System.Windows.Forms.CheckBox();
            this.secondTeamMistakeOne = new System.Windows.Forms.CheckBox();
            this.secondTeamMistakeTwo = new System.Windows.Forms.CheckBox();
            this.secondTeamMistakeThree = new System.Windows.Forms.CheckBox();
            this.firstTeamMistakesLabel = new System.Windows.Forms.Label();
            this.secondTeamMistakesLabel = new System.Windows.Forms.Label();
            this.questionNameComboBox = new System.Windows.Forms.ComboBox();
            this.questionNameLabel = new System.Windows.Forms.Label();
            this.fullScreenRadioButton = new System.Windows.Forms.RadioButton();
            this.notFullScreenRadioButton = new System.Windows.Forms.RadioButton();
            this.fullscreenOrNotLabel = new System.Windows.Forms.Label();
            this.allPointsTextBox = new System.Windows.Forms.TextBox();
            this.allPointsLabel = new System.Windows.Forms.Label();
            this.answer1PointsTextBox = new System.Windows.Forms.TextBox();
            this.answer2PointsTextBox = new System.Windows.Forms.TextBox();
            this.answer3PointsTextBox = new System.Windows.Forms.TextBox();
            this.answer4PointsTextBox = new System.Windows.Forms.TextBox();
            this.answer5PointsTextBox = new System.Windows.Forms.TextBox();
            this.answer6PointsTextBox = new System.Windows.Forms.TextBox();
            this.answer1CheckBox = new System.Windows.Forms.CheckBox();
            this.answer2CheckBox = new System.Windows.Forms.CheckBox();
            this.answer3CheckBox = new System.Windows.Forms.CheckBox();
            this.answer4CheckBox = new System.Windows.Forms.CheckBox();
            this.answer5CheckBox = new System.Windows.Forms.CheckBox();
            this.answer6CheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundNumberTB = new System.Windows.Forms.TextBox();
            this.questionNumberTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // answer1TextBox
            // 
            this.answer1TextBox.Location = new System.Drawing.Point(336, 293);
            this.answer1TextBox.Name = "answer1TextBox";
            this.answer1TextBox.ReadOnly = true;
            this.answer1TextBox.Size = new System.Drawing.Size(289, 20);
            this.answer1TextBox.TabIndex = 100;
            this.answer1TextBox.Tag = "answer";
            this.answer1TextBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            this.answer1TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            this.answer1TextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox_DoubleClick);
            // 
            // answer2TextBox
            // 
            this.answer2TextBox.Location = new System.Drawing.Point(336, 332);
            this.answer2TextBox.Name = "answer2TextBox";
            this.answer2TextBox.ReadOnly = true;
            this.answer2TextBox.Size = new System.Drawing.Size(289, 20);
            this.answer2TextBox.TabIndex = 1;
            this.answer2TextBox.Tag = "answer";
            this.answer2TextBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            this.answer2TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // answer3TextBox
            // 
            this.answer3TextBox.Location = new System.Drawing.Point(336, 371);
            this.answer3TextBox.Name = "answer3TextBox";
            this.answer3TextBox.ReadOnly = true;
            this.answer3TextBox.Size = new System.Drawing.Size(289, 20);
            this.answer3TextBox.TabIndex = 2;
            this.answer3TextBox.Tag = "answer";
            this.answer3TextBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            this.answer3TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // answer4TextBox
            // 
            this.answer4TextBox.Location = new System.Drawing.Point(336, 410);
            this.answer4TextBox.Name = "answer4TextBox";
            this.answer4TextBox.ReadOnly = true;
            this.answer4TextBox.Size = new System.Drawing.Size(289, 20);
            this.answer4TextBox.TabIndex = 3;
            this.answer4TextBox.Tag = "answer";
            this.answer4TextBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            this.answer4TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // answer5TextBox
            // 
            this.answer5TextBox.Location = new System.Drawing.Point(336, 449);
            this.answer5TextBox.Name = "answer5TextBox";
            this.answer5TextBox.ReadOnly = true;
            this.answer5TextBox.Size = new System.Drawing.Size(289, 20);
            this.answer5TextBox.TabIndex = 4;
            this.answer5TextBox.Tag = "answer";
            this.answer5TextBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            this.answer5TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // answer6TextBox
            // 
            this.answer6TextBox.Location = new System.Drawing.Point(336, 488);
            this.answer6TextBox.Name = "answer6TextBox";
            this.answer6TextBox.ReadOnly = true;
            this.answer6TextBox.Size = new System.Drawing.Size(289, 20);
            this.answer6TextBox.TabIndex = 5;
            this.answer6TextBox.Tag = "answer";
            this.answer6TextBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            this.answer6TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // answer1Label
            // 
            this.answer1Label.AutoSize = true;
            this.answer1Label.Location = new System.Drawing.Point(449, 277);
            this.answer1Label.Name = "answer1Label";
            this.answer1Label.Size = new System.Drawing.Size(78, 13);
            this.answer1Label.TabIndex = 6;
            this.answer1Label.Text = "Первый ответ";
            this.answer1Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // answer2Label
            // 
            this.answer2Label.AutoSize = true;
            this.answer2Label.Location = new System.Drawing.Point(446, 316);
            this.answer2Label.Name = "answer2Label";
            this.answer2Label.Size = new System.Drawing.Size(74, 13);
            this.answer2Label.TabIndex = 7;
            this.answer2Label.Text = "Второй ответ";
            // 
            // answer3Label
            // 
            this.answer3Label.AutoSize = true;
            this.answer3Label.Location = new System.Drawing.Point(448, 355);
            this.answer3Label.Name = "answer3Label";
            this.answer3Label.Size = new System.Drawing.Size(74, 13);
            this.answer3Label.TabIndex = 8;
            this.answer3Label.Text = "Третий ответ";
            // 
            // answer4Label
            // 
            this.answer4Label.AutoSize = true;
            this.answer4Label.Location = new System.Drawing.Point(446, 394);
            this.answer4Label.Name = "answer4Label";
            this.answer4Label.Size = new System.Drawing.Size(89, 13);
            this.answer4Label.TabIndex = 9;
            this.answer4Label.Text = "Четверый ответ";
            // 
            // answer5Label
            // 
            this.answer5Label.AutoSize = true;
            this.answer5Label.Location = new System.Drawing.Point(449, 433);
            this.answer5Label.Name = "answer5Label";
            this.answer5Label.Size = new System.Drawing.Size(71, 13);
            this.answer5Label.TabIndex = 10;
            this.answer5Label.Text = "Пятый ответ";
            // 
            // answer6Label
            // 
            this.answer6Label.AutoSize = true;
            this.answer6Label.Location = new System.Drawing.Point(449, 472);
            this.answer6Label.Name = "answer6Label";
            this.answer6Label.Size = new System.Drawing.Size(76, 13);
            this.answer6Label.TabIndex = 11;
            this.answer6Label.Text = "Шестой ответ";
            // 
            // firstTeamNameTextBox
            // 
            this.firstTeamNameTextBox.Location = new System.Drawing.Point(74, 96);
            this.firstTeamNameTextBox.Name = "firstTeamNameTextBox";
            this.firstTeamNameTextBox.ReadOnly = true;
            this.firstTeamNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.firstTeamNameTextBox.TabIndex = 12;
            this.firstTeamNameTextBox.Text = "матфак";
            this.firstTeamNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstTeamNameTextBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            this.firstTeamNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // secondTeamNameTextBox
            // 
            this.secondTeamNameTextBox.Location = new System.Drawing.Point(771, 96);
            this.secondTeamNameTextBox.Name = "secondTeamNameTextBox";
            this.secondTeamNameTextBox.ReadOnly = true;
            this.secondTeamNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.secondTeamNameTextBox.TabIndex = 13;
            this.secondTeamNameTextBox.Text = "матфак";
            this.secondTeamNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.secondTeamNameTextBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            this.secondTeamNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // firstTeamNameLabel
            // 
            this.firstTeamNameLabel.AutoSize = true;
            this.firstTeamNameLabel.Location = new System.Drawing.Point(77, 80);
            this.firstTeamNameLabel.Name = "firstTeamNameLabel";
            this.firstTeamNameLabel.Size = new System.Drawing.Size(117, 13);
            this.firstTeamNameLabel.TabIndex = 14;
            this.firstTeamNameLabel.Text = "Имя первой команды";
            // 
            // secondTeamNameLabel
            // 
            this.secondTeamNameLabel.AutoSize = true;
            this.secondTeamNameLabel.Location = new System.Drawing.Point(775, 80);
            this.secondTeamNameLabel.Name = "secondTeamNameLabel";
            this.secondTeamNameLabel.Size = new System.Drawing.Size(116, 13);
            this.secondTeamNameLabel.TabIndex = 15;
            this.secondTeamNameLabel.Text = "Имя второй команды";
            // 
            // firstTeamPointsTextBox
            // 
            this.firstTeamPointsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstTeamPointsTextBox.Location = new System.Drawing.Point(97, 188);
            this.firstTeamPointsTextBox.Name = "firstTeamPointsTextBox";
            this.firstTeamPointsTextBox.ReadOnly = true;
            this.firstTeamPointsTextBox.Size = new System.Drawing.Size(65, 38);
            this.firstTeamPointsTextBox.TabIndex = 16;
            this.firstTeamPointsTextBox.Text = "1234";
            this.firstTeamPointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstTeamPointsTextBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            this.firstTeamPointsTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // secondTeamPointsTextBox
            // 
            this.secondTeamPointsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondTeamPointsTextBox.Location = new System.Drawing.Point(797, 188);
            this.secondTeamPointsTextBox.Name = "secondTeamPointsTextBox";
            this.secondTeamPointsTextBox.ReadOnly = true;
            this.secondTeamPointsTextBox.Size = new System.Drawing.Size(69, 38);
            this.secondTeamPointsTextBox.TabIndex = 17;
            this.secondTeamPointsTextBox.Text = "1234";
            this.secondTeamPointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.secondTeamPointsTextBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            this.secondTeamPointsTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // firstTeamPointsLabel
            // 
            this.firstTeamPointsLabel.AutoSize = true;
            this.firstTeamPointsLabel.Location = new System.Drawing.Point(71, 172);
            this.firstTeamPointsLabel.Name = "firstTeamPointsLabel";
            this.firstTeamPointsLabel.Size = new System.Drawing.Size(120, 13);
            this.firstTeamPointsLabel.TabIndex = 18;
            this.firstTeamPointsLabel.Text = "Очки первой команды";
            // 
            // secondTeamPointsLabel
            // 
            this.secondTeamPointsLabel.AutoSize = true;
            this.secondTeamPointsLabel.Location = new System.Drawing.Point(768, 172);
            this.secondTeamPointsLabel.Name = "secondTeamPointsLabel";
            this.secondTeamPointsLabel.Size = new System.Drawing.Size(119, 13);
            this.secondTeamPointsLabel.TabIndex = 19;
            this.secondTeamPointsLabel.Text = "Очки второй команды";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(378, 538);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(216, 70);
            this.confirmBtn.TabIndex = 20;
            this.confirmBtn.Text = "Следующий раунд";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // firstTeamMistakeOne
            // 
            this.firstTeamMistakeOne.AutoSize = true;
            this.firstTeamMistakeOne.Location = new System.Drawing.Point(74, 325);
            this.firstTeamMistakeOne.Name = "firstTeamMistakeOne";
            this.firstTeamMistakeOne.Size = new System.Drawing.Size(75, 17);
            this.firstTeamMistakeOne.TabIndex = 21;
            this.firstTeamMistakeOne.Tag = "0";
            this.firstTeamMistakeOne.Text = "Ошибка 1";
            this.firstTeamMistakeOne.UseVisualStyleBackColor = true;
            this.firstTeamMistakeOne.CheckedChanged += new System.EventHandler(this.mistake_CheckedChanged);
            this.firstTeamMistakeOne.MouseClick += new System.Windows.Forms.MouseEventHandler(this.firstTeamMistakeOne_MouseClick);
            // 
            // firstTeamMistakeTwo
            // 
            this.firstTeamMistakeTwo.AutoSize = true;
            this.firstTeamMistakeTwo.Location = new System.Drawing.Point(74, 348);
            this.firstTeamMistakeTwo.Name = "firstTeamMistakeTwo";
            this.firstTeamMistakeTwo.Size = new System.Drawing.Size(75, 17);
            this.firstTeamMistakeTwo.TabIndex = 22;
            this.firstTeamMistakeTwo.Tag = "1";
            this.firstTeamMistakeTwo.Text = "Ошибка 2";
            this.firstTeamMistakeTwo.UseVisualStyleBackColor = true;
            this.firstTeamMistakeTwo.CheckedChanged += new System.EventHandler(this.mistake_CheckedChanged);
            // 
            // firstTeamMistakeThree
            // 
            this.firstTeamMistakeThree.AutoSize = true;
            this.firstTeamMistakeThree.Location = new System.Drawing.Point(74, 371);
            this.firstTeamMistakeThree.Name = "firstTeamMistakeThree";
            this.firstTeamMistakeThree.Size = new System.Drawing.Size(75, 17);
            this.firstTeamMistakeThree.TabIndex = 23;
            this.firstTeamMistakeThree.Tag = "2";
            this.firstTeamMistakeThree.Text = "Ошибка 3";
            this.firstTeamMistakeThree.UseVisualStyleBackColor = true;
            this.firstTeamMistakeThree.CheckedChanged += new System.EventHandler(this.mistake_CheckedChanged);
            // 
            // secondTeamMistakeOne
            // 
            this.secondTeamMistakeOne.AutoSize = true;
            this.secondTeamMistakeOne.Location = new System.Drawing.Point(771, 325);
            this.secondTeamMistakeOne.Name = "secondTeamMistakeOne";
            this.secondTeamMistakeOne.Size = new System.Drawing.Size(75, 17);
            this.secondTeamMistakeOne.TabIndex = 24;
            this.secondTeamMistakeOne.Tag = "3";
            this.secondTeamMistakeOne.Text = "Ошибка 1";
            this.secondTeamMistakeOne.UseVisualStyleBackColor = true;
            this.secondTeamMistakeOne.CheckedChanged += new System.EventHandler(this.mistake_CheckedChanged);
            // 
            // secondTeamMistakeTwo
            // 
            this.secondTeamMistakeTwo.AutoSize = true;
            this.secondTeamMistakeTwo.Location = new System.Drawing.Point(771, 348);
            this.secondTeamMistakeTwo.Name = "secondTeamMistakeTwo";
            this.secondTeamMistakeTwo.Size = new System.Drawing.Size(75, 17);
            this.secondTeamMistakeTwo.TabIndex = 25;
            this.secondTeamMistakeTwo.Tag = "4";
            this.secondTeamMistakeTwo.Text = "Ошибка 2";
            this.secondTeamMistakeTwo.UseVisualStyleBackColor = true;
            this.secondTeamMistakeTwo.CheckedChanged += new System.EventHandler(this.mistake_CheckedChanged);
            // 
            // secondTeamMistakeThree
            // 
            this.secondTeamMistakeThree.AutoSize = true;
            this.secondTeamMistakeThree.Location = new System.Drawing.Point(771, 371);
            this.secondTeamMistakeThree.Name = "secondTeamMistakeThree";
            this.secondTeamMistakeThree.Size = new System.Drawing.Size(75, 17);
            this.secondTeamMistakeThree.TabIndex = 26;
            this.secondTeamMistakeThree.Tag = "5";
            this.secondTeamMistakeThree.Text = "Ошибка 3";
            this.secondTeamMistakeThree.UseVisualStyleBackColor = true;
            this.secondTeamMistakeThree.CheckedChanged += new System.EventHandler(this.mistake_CheckedChanged);
            // 
            // firstTeamMistakesLabel
            // 
            this.firstTeamMistakesLabel.AutoSize = true;
            this.firstTeamMistakesLabel.Location = new System.Drawing.Point(71, 309);
            this.firstTeamMistakesLabel.Name = "firstTeamMistakesLabel";
            this.firstTeamMistakesLabel.Size = new System.Drawing.Size(135, 13);
            this.firstTeamMistakesLabel.TabIndex = 27;
            this.firstTeamMistakesLabel.Text = "Ошибки первой команды";
            // 
            // secondTeamMistakesLabel
            // 
            this.secondTeamMistakesLabel.AutoSize = true;
            this.secondTeamMistakesLabel.Location = new System.Drawing.Point(768, 309);
            this.secondTeamMistakesLabel.Name = "secondTeamMistakesLabel";
            this.secondTeamMistakesLabel.Size = new System.Drawing.Size(134, 13);
            this.secondTeamMistakesLabel.TabIndex = 28;
            this.secondTeamMistakesLabel.Text = "Ошибки второй команды";
            // 
            // questionNameComboBox
            // 
            this.questionNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questionNameComboBox.FormattingEnabled = true;
            this.questionNameComboBox.Location = new System.Drawing.Point(226, 48);
            this.questionNameComboBox.Name = "questionNameComboBox";
            this.questionNameComboBox.Size = new System.Drawing.Size(523, 21);
            this.questionNameComboBox.TabIndex = 29;
            this.questionNameComboBox.SelectedIndexChanged += new System.EventHandler(this.questionNameComboBox_SelectedIndexChanged);
            // 
            // questionNameLabel
            // 
            this.questionNameLabel.AutoSize = true;
            this.questionNameLabel.Location = new System.Drawing.Point(436, 32);
            this.questionNameLabel.Name = "questionNameLabel";
            this.questionNameLabel.Size = new System.Drawing.Size(91, 13);
            this.questionNameLabel.TabIndex = 30;
            this.questionNameLabel.Text = "Текущий вопрос";
            // 
            // fullScreenRadioButton
            // 
            this.fullScreenRadioButton.AutoSize = true;
            this.fullScreenRadioButton.Location = new System.Drawing.Point(778, 496);
            this.fullScreenRadioButton.Name = "fullScreenRadioButton";
            this.fullScreenRadioButton.Size = new System.Drawing.Size(98, 17);
            this.fullScreenRadioButton.TabIndex = 31;
            this.fullScreenRadioButton.TabStop = true;
            this.fullScreenRadioButton.Text = "Полный экран";
            this.fullScreenRadioButton.UseVisualStyleBackColor = true;
            this.fullScreenRadioButton.CheckedChanged += new System.EventHandler(this.fullScreenRadioButton_CheckedChanged);
            // 
            // notFullScreenRadioButton
            // 
            this.notFullScreenRadioButton.AutoSize = true;
            this.notFullScreenRadioButton.Checked = true;
            this.notFullScreenRadioButton.Location = new System.Drawing.Point(778, 519);
            this.notFullScreenRadioButton.Name = "notFullScreenRadioButton";
            this.notFullScreenRadioButton.Size = new System.Drawing.Size(108, 17);
            this.notFullScreenRadioButton.TabIndex = 32;
            this.notFullScreenRadioButton.TabStop = true;
            this.notFullScreenRadioButton.Text = "Оконный режим";
            this.notFullScreenRadioButton.UseVisualStyleBackColor = true;
            this.notFullScreenRadioButton.CheckedChanged += new System.EventHandler(this.notFullScreenRadioButton_CheckedChanged);
            // 
            // fullscreenOrNotLabel
            // 
            this.fullscreenOrNotLabel.AutoSize = true;
            this.fullscreenOrNotLabel.Location = new System.Drawing.Point(775, 480);
            this.fullscreenOrNotLabel.Name = "fullscreenOrNotLabel";
            this.fullscreenOrNotLabel.Size = new System.Drawing.Size(81, 13);
            this.fullscreenOrNotLabel.TabIndex = 33;
            this.fullscreenOrNotLabel.Text = "Вид окна игры";
            // 
            // allPointsTextBox
            // 
            this.allPointsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.allPointsTextBox.Location = new System.Drawing.Point(452, 204);
            this.allPointsTextBox.Name = "allPointsTextBox";
            this.allPointsTextBox.ReadOnly = true;
            this.allPointsTextBox.Size = new System.Drawing.Size(68, 38);
            this.allPointsTextBox.TabIndex = 34;
            this.allPointsTextBox.TextChanged += new System.EventHandler(this.allPointsTextBox_TextChanged);
            this.allPointsTextBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            this.allPointsTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // allPointsLabel
            // 
            this.allPointsLabel.AutoSize = true;
            this.allPointsLabel.Location = new System.Drawing.Point(436, 188);
            this.allPointsLabel.Name = "allPointsLabel";
            this.allPointsLabel.Size = new System.Drawing.Size(105, 13);
            this.allPointsLabel.TabIndex = 35;
            this.allPointsLabel.Text = "Общий счет раунда";
            // 
            // answer1PointsTextBox
            // 
            this.answer1PointsTextBox.Location = new System.Drawing.Point(631, 293);
            this.answer1PointsTextBox.Name = "answer1PointsTextBox";
            this.answer1PointsTextBox.ReadOnly = true;
            this.answer1PointsTextBox.Size = new System.Drawing.Size(32, 20);
            this.answer1PointsTextBox.TabIndex = 36;
            this.answer1PointsTextBox.Tag = "score";
            this.answer1PointsTextBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            this.answer1PointsTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // answer2PointsTextBox
            // 
            this.answer2PointsTextBox.Location = new System.Drawing.Point(631, 332);
            this.answer2PointsTextBox.Name = "answer2PointsTextBox";
            this.answer2PointsTextBox.ReadOnly = true;
            this.answer2PointsTextBox.Size = new System.Drawing.Size(32, 20);
            this.answer2PointsTextBox.TabIndex = 37;
            this.answer2PointsTextBox.Tag = "score";
            this.answer2PointsTextBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            this.answer2PointsTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // answer3PointsTextBox
            // 
            this.answer3PointsTextBox.Location = new System.Drawing.Point(631, 371);
            this.answer3PointsTextBox.Name = "answer3PointsTextBox";
            this.answer3PointsTextBox.ReadOnly = true;
            this.answer3PointsTextBox.Size = new System.Drawing.Size(32, 20);
            this.answer3PointsTextBox.TabIndex = 38;
            this.answer3PointsTextBox.Tag = "score";
            this.answer3PointsTextBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            this.answer3PointsTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // answer4PointsTextBox
            // 
            this.answer4PointsTextBox.Location = new System.Drawing.Point(631, 410);
            this.answer4PointsTextBox.Name = "answer4PointsTextBox";
            this.answer4PointsTextBox.ReadOnly = true;
            this.answer4PointsTextBox.Size = new System.Drawing.Size(32, 20);
            this.answer4PointsTextBox.TabIndex = 39;
            this.answer4PointsTextBox.Tag = "score";
            this.answer4PointsTextBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            this.answer4PointsTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // answer5PointsTextBox
            // 
            this.answer5PointsTextBox.Location = new System.Drawing.Point(631, 449);
            this.answer5PointsTextBox.Name = "answer5PointsTextBox";
            this.answer5PointsTextBox.ReadOnly = true;
            this.answer5PointsTextBox.Size = new System.Drawing.Size(32, 20);
            this.answer5PointsTextBox.TabIndex = 40;
            this.answer5PointsTextBox.Tag = "score";
            this.answer5PointsTextBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            this.answer5PointsTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // answer6PointsTextBox
            // 
            this.answer6PointsTextBox.Location = new System.Drawing.Point(631, 488);
            this.answer6PointsTextBox.Name = "answer6PointsTextBox";
            this.answer6PointsTextBox.ReadOnly = true;
            this.answer6PointsTextBox.Size = new System.Drawing.Size(32, 20);
            this.answer6PointsTextBox.TabIndex = 41;
            this.answer6PointsTextBox.Tag = "score";
            this.answer6PointsTextBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            this.answer6PointsTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // answer1CheckBox
            // 
            this.answer1CheckBox.AutoSize = true;
            this.answer1CheckBox.Checked = true;
            this.answer1CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.answer1CheckBox.Location = new System.Drawing.Point(315, 296);
            this.answer1CheckBox.Name = "answer1CheckBox";
            this.answer1CheckBox.Size = new System.Drawing.Size(15, 14);
            this.answer1CheckBox.TabIndex = 101;
            this.answer1CheckBox.Tag = "0";
            this.answer1CheckBox.UseVisualStyleBackColor = true;
            this.answer1CheckBox.CheckedChanged += new System.EventHandler(this.answerCheckBox_CheckedChanged);
            // 
            // answer2CheckBox
            // 
            this.answer2CheckBox.AutoSize = true;
            this.answer2CheckBox.Checked = true;
            this.answer2CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.answer2CheckBox.Location = new System.Drawing.Point(315, 335);
            this.answer2CheckBox.Name = "answer2CheckBox";
            this.answer2CheckBox.Size = new System.Drawing.Size(15, 14);
            this.answer2CheckBox.TabIndex = 102;
            this.answer2CheckBox.Tag = "1";
            this.answer2CheckBox.UseVisualStyleBackColor = true;
            this.answer2CheckBox.CheckedChanged += new System.EventHandler(this.answerCheckBox_CheckedChanged);
            // 
            // answer3CheckBox
            // 
            this.answer3CheckBox.AutoSize = true;
            this.answer3CheckBox.Checked = true;
            this.answer3CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.answer3CheckBox.Location = new System.Drawing.Point(315, 374);
            this.answer3CheckBox.Name = "answer3CheckBox";
            this.answer3CheckBox.Size = new System.Drawing.Size(15, 14);
            this.answer3CheckBox.TabIndex = 103;
            this.answer3CheckBox.Tag = "2";
            this.answer3CheckBox.UseVisualStyleBackColor = true;
            this.answer3CheckBox.CheckedChanged += new System.EventHandler(this.answerCheckBox_CheckedChanged);
            // 
            // answer4CheckBox
            // 
            this.answer4CheckBox.AutoSize = true;
            this.answer4CheckBox.Checked = true;
            this.answer4CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.answer4CheckBox.Location = new System.Drawing.Point(315, 413);
            this.answer4CheckBox.Name = "answer4CheckBox";
            this.answer4CheckBox.Size = new System.Drawing.Size(15, 14);
            this.answer4CheckBox.TabIndex = 104;
            this.answer4CheckBox.Tag = "3";
            this.answer4CheckBox.UseVisualStyleBackColor = true;
            this.answer4CheckBox.CheckedChanged += new System.EventHandler(this.answerCheckBox_CheckedChanged);
            // 
            // answer5CheckBox
            // 
            this.answer5CheckBox.AutoSize = true;
            this.answer5CheckBox.Checked = true;
            this.answer5CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.answer5CheckBox.Location = new System.Drawing.Point(315, 452);
            this.answer5CheckBox.Name = "answer5CheckBox";
            this.answer5CheckBox.Size = new System.Drawing.Size(15, 14);
            this.answer5CheckBox.TabIndex = 105;
            this.answer5CheckBox.Tag = "4";
            this.answer5CheckBox.UseVisualStyleBackColor = true;
            this.answer5CheckBox.CheckedChanged += new System.EventHandler(this.answerCheckBox_CheckedChanged);
            // 
            // answer6CheckBox
            // 
            this.answer6CheckBox.AutoSize = true;
            this.answer6CheckBox.Checked = true;
            this.answer6CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.answer6CheckBox.Location = new System.Drawing.Point(315, 491);
            this.answer6CheckBox.Name = "answer6CheckBox";
            this.answer6CheckBox.Size = new System.Drawing.Size(15, 14);
            this.answer6CheckBox.TabIndex = 106;
            this.answer6CheckBox.Tag = "5";
            this.answer6CheckBox.UseVisualStyleBackColor = true;
            this.answer6CheckBox.CheckedChanged += new System.EventHandler(this.answerCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 107;
            this.label1.Text = "Номер раунда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 108;
            this.label2.Text = "Номер вопроса";
            // 
            // roundNumberTB
            // 
            this.roundNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundNumberTB.Location = new System.Drawing.Point(336, 124);
            this.roundNumberTB.Name = "roundNumberTB";
            this.roundNumberTB.ReadOnly = true;
            this.roundNumberTB.Size = new System.Drawing.Size(40, 38);
            this.roundNumberTB.TabIndex = 109;
            // 
            // questionNumberTB
            // 
            this.questionNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionNumberTB.Location = new System.Drawing.Point(608, 124);
            this.questionNumberTB.Name = "questionNumberTB";
            this.questionNumberTB.ReadOnly = true;
            this.questionNumberTB.Size = new System.Drawing.Size(40, 38);
            this.questionNumberTB.TabIndex = 110;
            this.questionNumberTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 647);
            this.Controls.Add(this.questionNumberTB);
            this.Controls.Add(this.roundNumberTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answer6CheckBox);
            this.Controls.Add(this.answer5CheckBox);
            this.Controls.Add(this.answer4CheckBox);
            this.Controls.Add(this.answer3CheckBox);
            this.Controls.Add(this.answer2CheckBox);
            this.Controls.Add(this.answer1CheckBox);
            this.Controls.Add(this.answer6PointsTextBox);
            this.Controls.Add(this.answer5PointsTextBox);
            this.Controls.Add(this.answer4PointsTextBox);
            this.Controls.Add(this.answer3PointsTextBox);
            this.Controls.Add(this.answer2PointsTextBox);
            this.Controls.Add(this.answer1PointsTextBox);
            this.Controls.Add(this.allPointsLabel);
            this.Controls.Add(this.allPointsTextBox);
            this.Controls.Add(this.fullscreenOrNotLabel);
            this.Controls.Add(this.notFullScreenRadioButton);
            this.Controls.Add(this.fullScreenRadioButton);
            this.Controls.Add(this.questionNameLabel);
            this.Controls.Add(this.questionNameComboBox);
            this.Controls.Add(this.secondTeamMistakesLabel);
            this.Controls.Add(this.firstTeamMistakesLabel);
            this.Controls.Add(this.secondTeamMistakeThree);
            this.Controls.Add(this.secondTeamMistakeTwo);
            this.Controls.Add(this.secondTeamMistakeOne);
            this.Controls.Add(this.firstTeamMistakeThree);
            this.Controls.Add(this.firstTeamMistakeTwo);
            this.Controls.Add(this.firstTeamMistakeOne);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.secondTeamPointsLabel);
            this.Controls.Add(this.firstTeamPointsLabel);
            this.Controls.Add(this.secondTeamPointsTextBox);
            this.Controls.Add(this.firstTeamPointsTextBox);
            this.Controls.Add(this.secondTeamNameLabel);
            this.Controls.Add(this.firstTeamNameLabel);
            this.Controls.Add(this.secondTeamNameTextBox);
            this.Controls.Add(this.firstTeamNameTextBox);
            this.Controls.Add(this.answer6Label);
            this.Controls.Add(this.answer5Label);
            this.Controls.Add(this.answer4Label);
            this.Controls.Add(this.answer3Label);
            this.Controls.Add(this.answer2Label);
            this.Controls.Add(this.answer1Label);
            this.Controls.Add(this.answer6TextBox);
            this.Controls.Add(this.answer5TextBox);
            this.Controls.Add(this.answer4TextBox);
            this.Controls.Add(this.answer3TextBox);
            this.Controls.Add(this.answer2TextBox);
            this.Controls.Add(this.answer1TextBox);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answer1TextBox;
        private System.Windows.Forms.TextBox answer2TextBox;
        private System.Windows.Forms.TextBox answer3TextBox;
        private System.Windows.Forms.TextBox answer4TextBox;
        private System.Windows.Forms.TextBox answer5TextBox;
        private System.Windows.Forms.TextBox answer6TextBox;
        private System.Windows.Forms.Label answer1Label;
        private System.Windows.Forms.Label answer2Label;
        private System.Windows.Forms.Label answer3Label;
        private System.Windows.Forms.Label answer4Label;
        private System.Windows.Forms.Label answer5Label;
        private System.Windows.Forms.Label answer6Label;
        private System.Windows.Forms.TextBox firstTeamNameTextBox;
        private System.Windows.Forms.TextBox secondTeamNameTextBox;
        private System.Windows.Forms.Label firstTeamNameLabel;
        private System.Windows.Forms.Label secondTeamNameLabel;
        private System.Windows.Forms.TextBox firstTeamPointsTextBox;
        private System.Windows.Forms.TextBox secondTeamPointsTextBox;
        private System.Windows.Forms.Label firstTeamPointsLabel;
        private System.Windows.Forms.Label secondTeamPointsLabel;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.CheckBox firstTeamMistakeOne;
        private System.Windows.Forms.CheckBox firstTeamMistakeTwo;
        private System.Windows.Forms.CheckBox firstTeamMistakeThree;
        private System.Windows.Forms.CheckBox secondTeamMistakeOne;
        private System.Windows.Forms.CheckBox secondTeamMistakeTwo;
        private System.Windows.Forms.CheckBox secondTeamMistakeThree;
        private System.Windows.Forms.Label firstTeamMistakesLabel;
        private System.Windows.Forms.Label secondTeamMistakesLabel;
        private System.Windows.Forms.ComboBox questionNameComboBox;
        private System.Windows.Forms.Label questionNameLabel;
        private System.Windows.Forms.RadioButton fullScreenRadioButton;
        private System.Windows.Forms.RadioButton notFullScreenRadioButton;
        private System.Windows.Forms.Label fullscreenOrNotLabel;
        private System.Windows.Forms.TextBox allPointsTextBox;
        private System.Windows.Forms.Label allPointsLabel;
        private System.Windows.Forms.TextBox answer1PointsTextBox;
        private System.Windows.Forms.TextBox answer2PointsTextBox;
        private System.Windows.Forms.TextBox answer3PointsTextBox;
        private System.Windows.Forms.TextBox answer4PointsTextBox;
        private System.Windows.Forms.TextBox answer5PointsTextBox;
        private System.Windows.Forms.TextBox answer6PointsTextBox;
        private System.Windows.Forms.CheckBox answer1CheckBox;
        private System.Windows.Forms.CheckBox answer2CheckBox;
        private System.Windows.Forms.CheckBox answer3CheckBox;
        private System.Windows.Forms.CheckBox answer4CheckBox;
        private System.Windows.Forms.CheckBox answer5CheckBox;
        private System.Windows.Forms.CheckBox answer6CheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roundNumberTB;
        private System.Windows.Forms.TextBox questionNumberTB;
    }
}

