namespace FrogsOnSwamp
{
    partial class RulesForm
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
            button1 = new Button();
            textLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(222, 181);
            button1.Name = "button1";
            button1.Size = new Size(167, 43);
            button1.TabIndex = 0;
            button1.Text = "Закрыть";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CloseButton_Click;
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new Point(10, 10);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(0, 20);
            textLabel.TabIndex = 1;
            textLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RulesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 242);
            Controls.Add(textLabel);
            Controls.Add(button1);
            Name = "RulesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Правила игры";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label textLabel;
    }
}