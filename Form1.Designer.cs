namespace pr5._2
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
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            txtSeconds = new TextBox();
            txtMinutes = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tmrSecundomer = new System.Windows.Forms.Timer(components);
            Data = new Button();
            Clear = new Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(220, 139);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "Старт";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtSeconds
            // 
            txtSeconds.Location = new Point(124, 34);
            txtSeconds.Name = "txtSeconds";
            txtSeconds.Size = new Size(56, 23);
            txtSeconds.TabIndex = 1;
            // 
            // txtMinutes
            // 
            txtMinutes.Location = new Point(12, 34);
            txtMinutes.Name = "txtMinutes";
            txtMinutes.Size = new Size(56, 23);
            txtMinutes.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 42);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 3;
            label1.Text = "мин.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 42);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "сек.";
            // 
            // tmrSecundomer
            // 
            tmrSecundomer.Enabled = true;
            tmrSecundomer.Interval = 1000;
            tmrSecundomer.Tick += tmrSecundomer_Tick;
            // 
            // Data
            // 
            Data.Location = new Point(48, 139);
            Data.Name = "Data";
            Data.Size = new Size(75, 23);
            Data.TabIndex = 5;
            Data.Text = "Data";
            Data.UseVisualStyleBackColor = true;
            Data.Click += Data_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(139, 139);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 23);
            Clear.TabIndex = 6;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 193);
            Controls.Add(Clear);
            Controls.Add(Data);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMinutes);
            Controls.Add(txtSeconds);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Секундомер";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private TextBox txtSeconds;
        private TextBox txtMinutes;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer tmrSecundomer;
        private Button Data;
        private Button Clear;
    }
}