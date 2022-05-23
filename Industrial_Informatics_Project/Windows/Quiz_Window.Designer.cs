
namespace Industrial_Informatics_Project.Windows
{
    partial class Quiz_Window
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
            this.components = new System.ComponentModel.Container();
            this.category_select_panel = new System.Windows.Forms.Panel();
            this.category_buttons_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.categories = new System.Windows.Forms.Label();
            this.quiz_panel = new System.Windows.Forms.Panel();
            this.qusetion_selection_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.question_panel = new System.Windows.Forms.Panel();
            this.answer_button = new System.Windows.Forms.Button();
            this.option_four = new System.Windows.Forms.RadioButton();
            this.option_three = new System.Windows.Forms.RadioButton();
            this.option_two = new System.Windows.Forms.RadioButton();
            this.option_one = new System.Windows.Forms.RadioButton();
            this.question_text_label = new System.Windows.Forms.Label();
            this.timer_label = new System.Windows.Forms.Label();
            this.category_label = new System.Windows.Forms.Label();
            this.countdown_timer = new System.Windows.Forms.Timer(this.components);
            this.category_select_panel.SuspendLayout();
            this.quiz_panel.SuspendLayout();
            this.question_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // category_select_panel
            // 
            this.category_select_panel.Controls.Add(this.category_buttons_panel);
            this.category_select_panel.Controls.Add(this.categories);
            this.category_select_panel.Location = new System.Drawing.Point(65, 53);
            this.category_select_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.category_select_panel.Name = "category_select_panel";
            this.category_select_panel.Size = new System.Drawing.Size(484, 255);
            this.category_select_panel.TabIndex = 0;
            // 
            // category_buttons_panel
            // 
            this.category_buttons_panel.AutoScroll = true;
            this.category_buttons_panel.Location = new System.Drawing.Point(20, 63);
            this.category_buttons_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.category_buttons_panel.Name = "category_buttons_panel";
            this.category_buttons_panel.Size = new System.Drawing.Size(449, 166);
            this.category_buttons_panel.TabIndex = 2;
            // 
            // categories
            // 
            this.categories.AutoSize = true;
            this.categories.Location = new System.Drawing.Point(34, 23);
            this.categories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(93, 13);
            this.categories.TabIndex = 0;
            this.categories.Text = "Select a category:";
            // 
            // quiz_panel
            // 
            this.quiz_panel.Controls.Add(this.qusetion_selection_panel);
            this.quiz_panel.Controls.Add(this.question_panel);
            this.quiz_panel.Controls.Add(this.timer_label);
            this.quiz_panel.Controls.Add(this.category_label);
            this.quiz_panel.Location = new System.Drawing.Point(9, 10);
            this.quiz_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quiz_panel.Name = "quiz_panel";
            this.quiz_panel.Size = new System.Drawing.Size(582, 346);
            this.quiz_panel.TabIndex = 1;
            this.quiz_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.quiz_panel_Paint);
            // 
            // qusetion_selection_panel
            // 
            this.qusetion_selection_panel.AutoScroll = true;
            this.qusetion_selection_panel.Location = new System.Drawing.Point(22, 81);
            this.qusetion_selection_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qusetion_selection_panel.Name = "qusetion_selection_panel";
            this.qusetion_selection_panel.Size = new System.Drawing.Size(97, 242);
            this.qusetion_selection_panel.TabIndex = 3;
            // 
            // question_panel
            // 
            this.question_panel.Controls.Add(this.answer_button);
            this.question_panel.Controls.Add(this.option_four);
            this.question_panel.Controls.Add(this.option_three);
            this.question_panel.Controls.Add(this.option_two);
            this.question_panel.Controls.Add(this.option_one);
            this.question_panel.Controls.Add(this.question_text_label);
            this.question_panel.Location = new System.Drawing.Point(148, 81);
            this.question_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.question_panel.Name = "question_panel";
            this.question_panel.Size = new System.Drawing.Size(413, 242);
            this.question_panel.TabIndex = 2;
            // 
            // answer_button
            // 
            this.answer_button.Location = new System.Drawing.Point(309, 198);
            this.answer_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answer_button.Name = "answer_button";
            this.answer_button.Size = new System.Drawing.Size(69, 28);
            this.answer_button.TabIndex = 5;
            this.answer_button.Text = "Lock";
            this.answer_button.UseVisualStyleBackColor = true;
            this.answer_button.Click += new System.EventHandler(this.answer_button_Click);
            // 
            // option_four
            // 
            this.option_four.AutoSize = true;
            this.option_four.Location = new System.Drawing.Point(44, 150);
            this.option_four.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.option_four.Name = "option_four";
            this.option_four.Size = new System.Drawing.Size(85, 17);
            this.option_four.TabIndex = 4;
            this.option_four.TabStop = true;
            this.option_four.Text = "radioButton4";
            this.option_four.UseVisualStyleBackColor = true;
            // 
            // option_three
            // 
            this.option_three.AutoSize = true;
            this.option_three.Location = new System.Drawing.Point(44, 128);
            this.option_three.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.option_three.Name = "option_three";
            this.option_three.Size = new System.Drawing.Size(85, 17);
            this.option_three.TabIndex = 3;
            this.option_three.TabStop = true;
            this.option_three.Text = "radioButton3";
            this.option_three.UseVisualStyleBackColor = true;
            // 
            // option_two
            // 
            this.option_two.AutoSize = true;
            this.option_two.Location = new System.Drawing.Point(44, 105);
            this.option_two.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.option_two.Name = "option_two";
            this.option_two.Size = new System.Drawing.Size(85, 17);
            this.option_two.TabIndex = 2;
            this.option_two.TabStop = true;
            this.option_two.Text = "radioButton2";
            this.option_two.UseVisualStyleBackColor = true;
            // 
            // option_one
            // 
            this.option_one.AutoSize = true;
            this.option_one.Location = new System.Drawing.Point(44, 82);
            this.option_one.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.option_one.Name = "option_one";
            this.option_one.Size = new System.Drawing.Size(85, 17);
            this.option_one.TabIndex = 1;
            this.option_one.TabStop = true;
            this.option_one.Text = "radioButton1";
            this.option_one.UseVisualStyleBackColor = true;
            // 
            // question_text_label
            // 
            this.question_text_label.AutoSize = true;
            this.question_text_label.Location = new System.Drawing.Point(28, 25);
            this.question_text_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.question_text_label.Name = "question_text_label";
            this.question_text_label.Size = new System.Drawing.Size(49, 13);
            this.question_text_label.TabIndex = 0;
            this.question_text_label.Text = "Question";
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Location = new System.Drawing.Point(496, 20);
            this.timer_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(29, 13);
            this.timer_label.TabIndex = 1;
            this.timer_label.Text = "timer";
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Location = new System.Drawing.Point(20, 20);
            this.category_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(38, 13);
            this.category_label.TabIndex = 0;
            this.category_label.Text = "Space";
            // 
            // countdown_timer
            // 
            this.countdown_timer.Interval = 1000;
            this.countdown_timer.Tick += new System.EventHandler(this.countdown_timer_Tick);
            // 
            // Quiz_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.quiz_panel);
            this.Controls.Add(this.category_select_panel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Quiz_Window";
            this.Text = "Quiz_Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Quiz_Window_FormClosing);
            this.category_select_panel.ResumeLayout(false);
            this.category_select_panel.PerformLayout();
            this.quiz_panel.ResumeLayout(false);
            this.quiz_panel.PerformLayout();
            this.question_panel.ResumeLayout(false);
            this.question_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel category_select_panel;
        private System.Windows.Forms.Label categories;
        private System.Windows.Forms.Panel quiz_panel;
        private System.Windows.Forms.Panel question_panel;
        private System.Windows.Forms.Label question_text_label;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.FlowLayoutPanel category_buttons_panel;
        private System.Windows.Forms.FlowLayoutPanel qusetion_selection_panel;
        private System.Windows.Forms.Button answer_button;
        private System.Windows.Forms.RadioButton option_four;
        private System.Windows.Forms.RadioButton option_three;
        private System.Windows.Forms.RadioButton option_two;
        private System.Windows.Forms.RadioButton option_one;
        private System.Windows.Forms.Timer countdown_timer;
    }
}