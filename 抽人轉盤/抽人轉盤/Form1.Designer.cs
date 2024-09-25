namespace 抽人轉盤
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
            Start = new Button();
            Result = new Label();
            SettingsButton = new Button();
            SuspendLayout();
            // 
            // Start
            // 
            Start.BackColor = SystemColors.Control;
            Start.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Start.Location = new Point(576, 378);
            Start.Name = "Start";
            Start.Size = new Size(191, 47);
            Start.TabIndex = 0;
            Start.Text = "開始";
            Start.UseVisualStyleBackColor = false;
            Start.Click += button1_Click;
            // 
            // Result
            // 
            Result.BorderStyle = BorderStyle.FixedSingle;
            Result.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Result.Location = new Point(267, 52);
            Result.Name = "Result";
            Result.Size = new Size(500, 250);
            Result.TabIndex = 1;
            Result.Text = "輸出結果 : ";
            Result.Click += label1_Click;
            // 
            // SettingsButton
            // 
            SettingsButton.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            SettingsButton.Location = new Point(12, 402);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(80, 30);
            SettingsButton.TabIndex = 2;
            SettingsButton.Text = "設定";
            SettingsButton.UseVisualStyleBackColor = true;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SettingsButton);
            Controls.Add(Result);
            Controls.Add(Start);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Start;
        private Label Result;
        private Button SettingsButton;
    }
}
