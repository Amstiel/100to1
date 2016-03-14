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
            this.SuspendLayout();
            // 
            // answer1TextBox
            // 
            this.answer1TextBox.Location = new System.Drawing.Point(335, 73);
            this.answer1TextBox.Name = "answer1TextBox";
            this.answer1TextBox.Size = new System.Drawing.Size(289, 20);
            this.answer1TextBox.TabIndex = 0;
            // 
            // answer2TextBox
            // 
            this.answer2TextBox.Location = new System.Drawing.Point(335, 112);
            this.answer2TextBox.Name = "answer2TextBox";
            this.answer2TextBox.Size = new System.Drawing.Size(289, 20);
            this.answer2TextBox.TabIndex = 1;
            // 
            // answer3TextBox
            // 
            this.answer3TextBox.Location = new System.Drawing.Point(335, 151);
            this.answer3TextBox.Name = "answer3TextBox";
            this.answer3TextBox.Size = new System.Drawing.Size(289, 20);
            this.answer3TextBox.TabIndex = 2;
            // 
            // answer4TextBox
            // 
            this.answer4TextBox.Location = new System.Drawing.Point(335, 190);
            this.answer4TextBox.Name = "answer4TextBox";
            this.answer4TextBox.Size = new System.Drawing.Size(289, 20);
            this.answer4TextBox.TabIndex = 3;
            // 
            // answer5TextBox
            // 
            this.answer5TextBox.Location = new System.Drawing.Point(335, 229);
            this.answer5TextBox.Name = "answer5TextBox";
            this.answer5TextBox.Size = new System.Drawing.Size(289, 20);
            this.answer5TextBox.TabIndex = 4;
            // 
            // answer6TextBox
            // 
            this.answer6TextBox.Location = new System.Drawing.Point(335, 268);
            this.answer6TextBox.Name = "answer6TextBox";
            this.answer6TextBox.Size = new System.Drawing.Size(289, 20);
            this.answer6TextBox.TabIndex = 5;
            // 
            // answer1Label
            // 
            this.answer1Label.AutoSize = true;
            this.answer1Label.Location = new System.Drawing.Point(445, 57);
            this.answer1Label.Name = "answer1Label";
            this.answer1Label.Size = new System.Drawing.Size(78, 13);
            this.answer1Label.TabIndex = 6;
            this.answer1Label.Text = "Первый ответ";
            this.answer1Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // answer2Label
            // 
            this.answer2Label.AutoSize = true;
            this.answer2Label.Location = new System.Drawing.Point(445, 96);
            this.answer2Label.Name = "answer2Label";
            this.answer2Label.Size = new System.Drawing.Size(74, 13);
            this.answer2Label.TabIndex = 7;
            this.answer2Label.Text = "Второй ответ";
            // 
            // answer3Label
            // 
            this.answer3Label.AutoSize = true;
            this.answer3Label.Location = new System.Drawing.Point(447, 135);
            this.answer3Label.Name = "answer3Label";
            this.answer3Label.Size = new System.Drawing.Size(74, 13);
            this.answer3Label.TabIndex = 8;
            this.answer3Label.Text = "Третий ответ";
            // 
            // answer4Label
            // 
            this.answer4Label.AutoSize = true;
            this.answer4Label.Location = new System.Drawing.Point(445, 174);
            this.answer4Label.Name = "answer4Label";
            this.answer4Label.Size = new System.Drawing.Size(89, 13);
            this.answer4Label.TabIndex = 9;
            this.answer4Label.Text = "Четверый ответ";
            // 
            // answer5Label
            // 
            this.answer5Label.AutoSize = true;
            this.answer5Label.Location = new System.Drawing.Point(448, 213);
            this.answer5Label.Name = "answer5Label";
            this.answer5Label.Size = new System.Drawing.Size(71, 13);
            this.answer5Label.TabIndex = 10;
            this.answer5Label.Text = "Пятый ответ";
            // 
            // answer6Label
            // 
            this.answer6Label.AutoSize = true;
            this.answer6Label.Location = new System.Drawing.Point(448, 252);
            this.answer6Label.Name = "answer6Label";
            this.answer6Label.Size = new System.Drawing.Size(76, 13);
            this.answer6Label.TabIndex = 11;
            this.answer6Label.Text = "Шестой ответ";
            // 
            // firstTeamNameTextBox
            // 
            this.firstTeamNameTextBox.Location = new System.Drawing.Point(72, 96);
            this.firstTeamNameTextBox.Name = "firstTeamNameTextBox";
            this.firstTeamNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.firstTeamNameTextBox.TabIndex = 12;
            // 
            // secondTeamNameTextBox
            // 
            this.secondTeamNameTextBox.Location = new System.Drawing.Point(755, 96);
            this.secondTeamNameTextBox.Name = "secondTeamNameTextBox";
            this.secondTeamNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.secondTeamNameTextBox.TabIndex = 13;
            // 
            // firstTeamNameLabel
            // 
            this.firstTeamNameLabel.AutoSize = true;
            this.firstTeamNameLabel.Location = new System.Drawing.Point(75, 80);
            this.firstTeamNameLabel.Name = "firstTeamNameLabel";
            this.firstTeamNameLabel.Size = new System.Drawing.Size(117, 13);
            this.firstTeamNameLabel.TabIndex = 14;
            this.firstTeamNameLabel.Text = "Имя первой команды";
            // 
            // secondTeamNameLabel
            // 
            this.secondTeamNameLabel.AutoSize = true;
            this.secondTeamNameLabel.Location = new System.Drawing.Point(759, 80);
            this.secondTeamNameLabel.Name = "secondTeamNameLabel";
            this.secondTeamNameLabel.Size = new System.Drawing.Size(116, 13);
            this.secondTeamNameLabel.TabIndex = 15;
            this.secondTeamNameLabel.Text = "Имя второй команды";
            // 
            // firstTeamPointsTextBox
            // 
            this.firstTeamPointsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstTeamPointsTextBox.Location = new System.Drawing.Point(108, 188);
            this.firstTeamPointsTextBox.Name = "firstTeamPointsTextBox";
            this.firstTeamPointsTextBox.Size = new System.Drawing.Size(40, 38);
            this.firstTeamPointsTextBox.TabIndex = 16;
            // 
            // secondTeamPointsTextBox
            // 
            this.secondTeamPointsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondTeamPointsTextBox.Location = new System.Drawing.Point(791, 188);
            this.secondTeamPointsTextBox.Name = "secondTeamPointsTextBox";
            this.secondTeamPointsTextBox.Size = new System.Drawing.Size(40, 38);
            this.secondTeamPointsTextBox.TabIndex = 17;
            // 
            // firstTeamPointsLabel
            // 
            this.firstTeamPointsLabel.AutoSize = true;
            this.firstTeamPointsLabel.Location = new System.Drawing.Point(69, 172);
            this.firstTeamPointsLabel.Name = "firstTeamPointsLabel";
            this.firstTeamPointsLabel.Size = new System.Drawing.Size(120, 13);
            this.firstTeamPointsLabel.TabIndex = 18;
            this.firstTeamPointsLabel.Text = "Очки певрой команды";
            // 
            // secondTeamPointsLabel
            // 
            this.secondTeamPointsLabel.AutoSize = true;
            this.secondTeamPointsLabel.Location = new System.Drawing.Point(752, 172);
            this.secondTeamPointsLabel.Name = "secondTeamPointsLabel";
            this.secondTeamPointsLabel.Size = new System.Drawing.Size(119, 13);
            this.secondTeamPointsLabel.TabIndex = 19;
            this.secondTeamPointsLabel.Text = "Очки второй команды";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(375, 371);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(216, 70);
            this.confirmBtn.TabIndex = 20;
            this.confirmBtn.Text = "Изменить";
            this.confirmBtn.UseVisualStyleBackColor = true;
            // 
            // firstTeamMistakeOne
            // 
            this.firstTeamMistakeOne.AutoSize = true;
            this.firstTeamMistakeOne.Location = new System.Drawing.Point(78, 315);
            this.firstTeamMistakeOne.Name = "firstTeamMistakeOne";
            this.firstTeamMistakeOne.Size = new System.Drawing.Size(75, 17);
            this.firstTeamMistakeOne.TabIndex = 21;
            this.firstTeamMistakeOne.Text = "Ошибка 1";
            this.firstTeamMistakeOne.UseVisualStyleBackColor = true;
            // 
            // firstTeamMistakeTwo
            // 
            this.firstTeamMistakeTwo.AutoSize = true;
            this.firstTeamMistakeTwo.Location = new System.Drawing.Point(78, 338);
            this.firstTeamMistakeTwo.Name = "firstTeamMistakeTwo";
            this.firstTeamMistakeTwo.Size = new System.Drawing.Size(75, 17);
            this.firstTeamMistakeTwo.TabIndex = 22;
            this.firstTeamMistakeTwo.Text = "Ошибка 2";
            this.firstTeamMistakeTwo.UseVisualStyleBackColor = true;
            // 
            // firstTeamMistakeThree
            // 
            this.firstTeamMistakeThree.AutoSize = true;
            this.firstTeamMistakeThree.Location = new System.Drawing.Point(78, 361);
            this.firstTeamMistakeThree.Name = "firstTeamMistakeThree";
            this.firstTeamMistakeThree.Size = new System.Drawing.Size(75, 17);
            this.firstTeamMistakeThree.TabIndex = 23;
            this.firstTeamMistakeThree.Text = "Ошибка 3";
            this.firstTeamMistakeThree.UseVisualStyleBackColor = true;
            // 
            // secondTeamMistakeOne
            // 
            this.secondTeamMistakeOne.AutoSize = true;
            this.secondTeamMistakeOne.Location = new System.Drawing.Point(755, 325);
            this.secondTeamMistakeOne.Name = "secondTeamMistakeOne";
            this.secondTeamMistakeOne.Size = new System.Drawing.Size(75, 17);
            this.secondTeamMistakeOne.TabIndex = 24;
            this.secondTeamMistakeOne.Text = "Ошибка 1";
            this.secondTeamMistakeOne.UseVisualStyleBackColor = true;
            // 
            // secondTeamMistakeTwo
            // 
            this.secondTeamMistakeTwo.AutoSize = true;
            this.secondTeamMistakeTwo.Location = new System.Drawing.Point(755, 348);
            this.secondTeamMistakeTwo.Name = "secondTeamMistakeTwo";
            this.secondTeamMistakeTwo.Size = new System.Drawing.Size(75, 17);
            this.secondTeamMistakeTwo.TabIndex = 25;
            this.secondTeamMistakeTwo.Text = "Ошибка 2";
            this.secondTeamMistakeTwo.UseVisualStyleBackColor = true;
            // 
            // secondTeamMistakeThree
            // 
            this.secondTeamMistakeThree.AutoSize = true;
            this.secondTeamMistakeThree.Location = new System.Drawing.Point(755, 371);
            this.secondTeamMistakeThree.Name = "secondTeamMistakeThree";
            this.secondTeamMistakeThree.Size = new System.Drawing.Size(75, 17);
            this.secondTeamMistakeThree.TabIndex = 26;
            this.secondTeamMistakeThree.Text = "Ошибка 3";
            this.secondTeamMistakeThree.UseVisualStyleBackColor = true;
            this.secondTeamMistakeThree.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // firstTeamMistakesLabel
            // 
            this.firstTeamMistakesLabel.AutoSize = true;
            this.firstTeamMistakesLabel.Location = new System.Drawing.Point(75, 299);
            this.firstTeamMistakesLabel.Name = "firstTeamMistakesLabel";
            this.firstTeamMistakesLabel.Size = new System.Drawing.Size(135, 13);
            this.firstTeamMistakesLabel.TabIndex = 27;
            this.firstTeamMistakesLabel.Text = "Ошибки первой команды";
            // 
            // secondTeamMistakesLabel
            // 
            this.secondTeamMistakesLabel.AutoSize = true;
            this.secondTeamMistakesLabel.Location = new System.Drawing.Point(752, 309);
            this.secondTeamMistakesLabel.Name = "secondTeamMistakesLabel";
            this.secondTeamMistakesLabel.Size = new System.Drawing.Size(134, 13);
            this.secondTeamMistakesLabel.TabIndex = 28;
            this.secondTeamMistakesLabel.Text = "Ошибки второй команды";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 647);
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
    }
}

