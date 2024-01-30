namespace ReportCreater
{
    partial class MainWindow
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
            _reportGeneratorButton = new Button();
            SuspendLayout();
            // 
            // _reportGeneratorButton
            // 
            _reportGeneratorButton.BackColor = Color.LightCyan;
            _reportGeneratorButton.Location = new Point(310, 341);
            _reportGeneratorButton.Name = "_reportGeneratorButton";
            _reportGeneratorButton.Size = new Size(188, 54);
            _reportGeneratorButton.TabIndex = 0;
            _reportGeneratorButton.Text = "Сгенерировать отчёт";
            _reportGeneratorButton.UseVisualStyleBackColor = false;
            _reportGeneratorButton.Click += _reportGeneratorButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_reportGeneratorButton);
            Name = "MainWindow";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button _reportGeneratorButton;
    }
}
