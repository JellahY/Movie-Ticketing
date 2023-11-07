namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cityBox = new ComboBox();
            locationBox = new ComboBox();
            movieBox = new ComboBox();
            timeBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            proceedBtn = new Button();
            resetBtn = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // cityBox
            // 
            cityBox.AutoCompleteCustomSource.AddRange(new string[] { "Cebu City", "Mandaue City", "Lapu-Lapu City" });
            cityBox.FormattingEnabled = true;
            cityBox.Location = new Point(378, 146);
            cityBox.Name = "cityBox";
            cityBox.Size = new Size(151, 28);
            cityBox.TabIndex = 0;
            // 
            // locationBox
            // 
            locationBox.AutoCompleteCustomSource.AddRange(new string[] { "Mandaue Branch", "Pusok Branch", "Mactan Branch" });
            locationBox.FormattingEnabled = true;
            locationBox.Location = new Point(378, 207);
            locationBox.Name = "locationBox";
            locationBox.Size = new Size(151, 28);
            locationBox.TabIndex = 0;
            // 
            // movieBox
            // 
            movieBox.FormattingEnabled = true;
            movieBox.Location = new Point(378, 271);
            movieBox.Name = "movieBox";
            movieBox.Size = new Size(151, 28);
            movieBox.TabIndex = 0;
            // 
            // timeBox
            // 
            timeBox.FormattingEnabled = true;
            timeBox.Location = new Point(378, 333);
            timeBox.Name = "timeBox";
            timeBox.Size = new Size(151, 28);
            timeBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(255, 154);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 1;
            label1.Text = "City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(255, 215);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Location";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(255, 274);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 1;
            label3.Text = "Movie Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(255, 336);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 1;
            label4.Text = "Time";
            // 
            // proceedBtn
            // 
            proceedBtn.Location = new Point(320, 403);
            proceedBtn.Name = "proceedBtn";
            proceedBtn.Size = new Size(94, 29);
            proceedBtn.TabIndex = 2;
            proceedBtn.Text = "Proceed";
            proceedBtn.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(455, 403);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(94, 29);
            resetBtn.TabIndex = 2;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Script", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(176, 47);
            label5.Name = "label5";
            label5.Size = new Size(479, 70);
            label5.TabIndex = 3;
            label5.Text = "Jella's Movies Haus";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(819, 499);
            Controls.Add(label5);
            Controls.Add(resetBtn);
            Controls.Add(proceedBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(timeBox);
            Controls.Add(movieBox);
            Controls.Add(locationBox);
            Controls.Add(cityBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cityBox;
        private ComboBox locationBox;
        private ComboBox movieBox;
        private ComboBox timeBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button proceedBtn;
        private Button resetBtn;
        private Label label5;
    }
}