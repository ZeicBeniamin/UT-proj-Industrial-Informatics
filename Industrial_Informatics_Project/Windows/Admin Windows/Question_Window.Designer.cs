
namespace Industrial_Informatics_Project.Windows.Admin_Windows
{
    partial class Question_Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.add_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.add_question_label = new System.Windows.Forms.Label();
            this.catrgory_label = new System.Windows.Forms.Label();
            this.question_richTextBox = new System.Windows.Forms.RichTextBox();
            this.question_label = new System.Windows.Forms.Label();
            this.option_one_radio = new System.Windows.Forms.RadioButton();
            this.option_two_radio = new System.Windows.Forms.RadioButton();
            this.option_three_radio = new System.Windows.Forms.RadioButton();
            this.option_four_radio = new System.Windows.Forms.RadioButton();
            this.option_one_richTextBox = new System.Windows.Forms.RichTextBox();
            this.option_two_richTextBox = new System.Windows.Forms.RichTextBox();
            this.option_three_richTextBox = new System.Windows.Forms.RichTextBox();
            this.option_four_richTextBox = new System.Windows.Forms.RichTextBox();
            this.category_comboBox = new System.Windows.Forms.ComboBox();
            this.difficulty_label = new System.Windows.Forms.Label();
            this.difficulty_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(532, 505);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(96, 42);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(14, 505);
            this.clear_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(96, 42);
            this.clear_button.TabIndex = 1;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // add_question_label
            // 
            this.add_question_label.AutoSize = true;
            this.add_question_label.Location = new System.Drawing.Point(14, 16);
            this.add_question_label.Name = "add_question_label";
            this.add_question_label.Size = new System.Drawing.Size(103, 20);
            this.add_question_label.TabIndex = 2;
            this.add_question_label.Text = "Add question";
            // 
            // catrgory_label
            // 
            this.catrgory_label.AutoSize = true;
            this.catrgory_label.Location = new System.Drawing.Point(736, 16);
            this.catrgory_label.Name = "catrgory_label";
            this.catrgory_label.Size = new System.Drawing.Size(77, 20);
            this.catrgory_label.TabIndex = 3;
            this.catrgory_label.Text = "Category ";
            // 
            // question_richTextBox
            // 
            this.question_richTextBox.Location = new System.Drawing.Point(27, 91);
            this.question_richTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.question_richTextBox.Name = "question_richTextBox";
            this.question_richTextBox.Size = new System.Drawing.Size(501, 69);
            this.question_richTextBox.TabIndex = 4;
            this.question_richTextBox.Text = "";
            // 
            // question_label
            // 
            this.question_label.AutoSize = true;
            this.question_label.Location = new System.Drawing.Point(27, 62);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(73, 20);
            this.question_label.TabIndex = 5;
            this.question_label.Text = "Question";
            // 
            // option_one_radio
            // 
            this.option_one_radio.AutoSize = true;
            this.option_one_radio.Location = new System.Drawing.Point(76, 206);
            this.option_one_radio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.option_one_radio.Name = "option_one_radio";
            this.option_one_radio.Size = new System.Drawing.Size(21, 20);
            this.option_one_radio.TabIndex = 6;
            this.option_one_radio.TabStop = true;
            this.option_one_radio.UseVisualStyleBackColor = true;
            // 
            // option_two_radio
            // 
            this.option_two_radio.AutoSize = true;
            this.option_two_radio.Location = new System.Drawing.Point(76, 274);
            this.option_two_radio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.option_two_radio.Name = "option_two_radio";
            this.option_two_radio.Size = new System.Drawing.Size(21, 20);
            this.option_two_radio.TabIndex = 7;
            this.option_two_radio.TabStop = true;
            this.option_two_radio.UseVisualStyleBackColor = true;
            // 
            // option_three_radio
            // 
            this.option_three_radio.AutoSize = true;
            this.option_three_radio.Location = new System.Drawing.Point(76, 346);
            this.option_three_radio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.option_three_radio.Name = "option_three_radio";
            this.option_three_radio.Size = new System.Drawing.Size(21, 20);
            this.option_three_radio.TabIndex = 8;
            this.option_three_radio.TabStop = true;
            this.option_three_radio.UseVisualStyleBackColor = true;
            // 
            // option_four_radio
            // 
            this.option_four_radio.AutoSize = true;
            this.option_four_radio.Location = new System.Drawing.Point(76, 412);
            this.option_four_radio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.option_four_radio.Name = "option_four_radio";
            this.option_four_radio.Size = new System.Drawing.Size(21, 20);
            this.option_four_radio.TabIndex = 9;
            this.option_four_radio.TabStop = true;
            this.option_four_radio.UseVisualStyleBackColor = true;
            // 
            // option_one_richTextBox
            // 
            this.option_one_richTextBox.Location = new System.Drawing.Point(102, 206);
            this.option_one_richTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.option_one_richTextBox.Name = "option_one_richTextBox";
            this.option_one_richTextBox.Size = new System.Drawing.Size(373, 46);
            this.option_one_richTextBox.TabIndex = 10;
            this.option_one_richTextBox.Text = "";
            // 
            // option_two_richTextBox
            // 
            this.option_two_richTextBox.Location = new System.Drawing.Point(102, 274);
            this.option_two_richTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.option_two_richTextBox.Name = "option_two_richTextBox";
            this.option_two_richTextBox.Size = new System.Drawing.Size(373, 46);
            this.option_two_richTextBox.TabIndex = 11;
            this.option_two_richTextBox.Text = "";
            // 
            // option_three_richTextBox
            // 
            this.option_three_richTextBox.Location = new System.Drawing.Point(102, 346);
            this.option_three_richTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.option_three_richTextBox.Name = "option_three_richTextBox";
            this.option_three_richTextBox.Size = new System.Drawing.Size(373, 46);
            this.option_three_richTextBox.TabIndex = 12;
            this.option_three_richTextBox.Text = "";
            // 
            // option_four_richTextBox
            // 
            this.option_four_richTextBox.Location = new System.Drawing.Point(102, 412);
            this.option_four_richTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.option_four_richTextBox.Name = "option_four_richTextBox";
            this.option_four_richTextBox.Size = new System.Drawing.Size(373, 46);
            this.option_four_richTextBox.TabIndex = 13;
            this.option_four_richTextBox.Text = "";
            // 
            // category_comboBox
            // 
            this.category_comboBox.FormattingEnabled = true;
            this.category_comboBox.Location = new System.Drawing.Point(754, 62);
            this.category_comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.category_comboBox.Name = "category_comboBox";
            this.category_comboBox.Size = new System.Drawing.Size(304, 28);
            this.category_comboBox.TabIndex = 14;
            // 
            // difficulty_label
            // 
            this.difficulty_label.AutoSize = true;
            this.difficulty_label.Location = new System.Drawing.Point(739, 139);
            this.difficulty_label.Name = "difficulty_label";
            this.difficulty_label.Size = new System.Drawing.Size(69, 20);
            this.difficulty_label.TabIndex = 15;
            this.difficulty_label.Text = "Difficulty";
            // 
            // difficulty_comboBox
            // 
            this.difficulty_comboBox.FormattingEnabled = true;
            this.difficulty_comboBox.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.difficulty_comboBox.Location = new System.Drawing.Point(754, 175);
            this.difficulty_comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.difficulty_comboBox.Name = "difficulty_comboBox";
            this.difficulty_comboBox.Size = new System.Drawing.Size(304, 28);
            this.difficulty_comboBox.TabIndex = 16;
            // 
            // Question_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 562);
            this.Controls.Add(this.difficulty_comboBox);
            this.Controls.Add(this.difficulty_label);
            this.Controls.Add(this.category_comboBox);
            this.Controls.Add(this.option_four_richTextBox);
            this.Controls.Add(this.option_three_richTextBox);
            this.Controls.Add(this.option_two_richTextBox);
            this.Controls.Add(this.option_one_richTextBox);
            this.Controls.Add(this.option_four_radio);
            this.Controls.Add(this.option_three_radio);
            this.Controls.Add(this.option_two_radio);
            this.Controls.Add(this.option_one_radio);
            this.Controls.Add(this.question_label);
            this.Controls.Add(this.question_richTextBox);
            this.Controls.Add(this.catrgory_label);
            this.Controls.Add(this.add_question_label);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.add_button);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Question_Window";
            this.Text = "Question_Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Question_Window_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label add_question_label;
        private System.Windows.Forms.Label catrgory_label;
        private System.Windows.Forms.RichTextBox question_richTextBox;
        private System.Windows.Forms.Label question_label;
        private System.Windows.Forms.RadioButton option_one_radio;
        private System.Windows.Forms.RadioButton option_two_radio;
        private System.Windows.Forms.RadioButton option_three_radio;
        private System.Windows.Forms.RadioButton option_four_radio;
        private System.Windows.Forms.RichTextBox option_one_richTextBox;
        private System.Windows.Forms.RichTextBox option_two_richTextBox;
        private System.Windows.Forms.RichTextBox option_three_richTextBox;
        private System.Windows.Forms.RichTextBox option_four_richTextBox;
        private System.Windows.Forms.ComboBox category_comboBox;
        private System.Windows.Forms.Label difficulty_label;
        private System.Windows.Forms.ComboBox difficulty_comboBox;
    }
}