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
            _folderBrowserDialog = new FolderBrowserDialog();
            _selectedDirectoryTextBox = new TextBox();
            _directorySelectionButton = new Button();
            _fileSystemWatcher = new FileSystemWatcher();
            _messageTextBox = new TextBox();
            _selectedOutDirectoryTextBox = new TextBox();
            _outDirectorySelectionButton = new Button();
            _outFolderBrowserDialog = new FolderBrowserDialog();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize) _fileSystemWatcher).BeginInit();
            SuspendLayout();
            // 
            // _reportGeneratorButton
            // 
            _reportGeneratorButton.BackColor = Color.LightCyan;
            _reportGeneratorButton.Location = new Point(271, 256);
            _reportGeneratorButton.Margin = new Padding(3, 2, 3, 2);
            _reportGeneratorButton.Name = "_reportGeneratorButton";
            _reportGeneratorButton.Size = new Size(164, 40);
            _reportGeneratorButton.TabIndex = 0;
            _reportGeneratorButton.Text = "Сгенерировать отчёт";
            _reportGeneratorButton.UseVisualStyleBackColor = false;
            _reportGeneratorButton.Click += _reportGeneratorButton_Click;
            // 
            // _folderBrowserDialog
            // 
            _folderBrowserDialog.ShowHiddenFiles = true;
            // 
            // _selectedDirectoryTextBox
            // 
            _selectedDirectoryTextBox.BackColor = Color.White;
            _selectedDirectoryTextBox.Location = new Point(271, 26);
            _selectedDirectoryTextBox.Name = "_selectedDirectoryTextBox";
            _selectedDirectoryTextBox.ReadOnly = true;
            _selectedDirectoryTextBox.Size = new Size(283, 23);
            _selectedDirectoryTextBox.TabIndex = 1;
            // 
            // _directorySelectionButton
            // 
            _directorySelectionButton.Location = new Point(553, 26);
            _directorySelectionButton.Name = "_directorySelectionButton";
            _directorySelectionButton.Size = new Size(38, 24);
            _directorySelectionButton.TabIndex = 2;
            _directorySelectionButton.Text = "...";
            _directorySelectionButton.UseVisualStyleBackColor = true;
            _directorySelectionButton.Click += _directorySelectionButton_Click;
            // 
            // _fileSystemWatcher
            // 
            _fileSystemWatcher.EnableRaisingEvents = true;
            _fileSystemWatcher.SynchronizingObject = this;
            _fileSystemWatcher.Created += _fileSystemWatcher_Created;
            // 
            // _messageTextBox
            // 
            _messageTextBox.BackColor = Color.MistyRose;
            _messageTextBox.Location = new Point(-1, 314);
            _messageTextBox.Name = "_messageTextBox";
            _messageTextBox.ReadOnly = true;
            _messageTextBox.Size = new Size(702, 23);
            _messageTextBox.TabIndex = 3;
            // 
            // _selectedOutDirectoryTextBox
            // 
            _selectedOutDirectoryTextBox.BackColor = Color.White;
            _selectedOutDirectoryTextBox.Location = new Point(271, 66);
            _selectedOutDirectoryTextBox.Name = "_selectedOutDirectoryTextBox";
            _selectedOutDirectoryTextBox.ReadOnly = true;
            _selectedOutDirectoryTextBox.Size = new Size(283, 23);
            _selectedOutDirectoryTextBox.TabIndex = 4;
            _selectedOutDirectoryTextBox.TextChanged += _selectedOutDirectoryTextBox_TextChanged;
            // 
            // _outDirectorySelectionButton
            // 
            _outDirectorySelectionButton.Location = new Point(553, 64);
            _outDirectorySelectionButton.Name = "_outDirectorySelectionButton";
            _outDirectorySelectionButton.Size = new Size(38, 25);
            _outDirectorySelectionButton.TabIndex = 5;
            _outDirectorySelectionButton.Text = "...";
            _outDirectorySelectionButton.UseVisualStyleBackColor = true;
            _outDirectorySelectionButton.Click += _outDirectorySelectionButton_Click;
            // 
            // _outFolderBrowserDialog
            // 
            _outFolderBrowserDialog.ShowHiddenFiles = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 31);
            label1.Name = "label1";
            label1.Size = new Size(162, 15);
            label1.TabIndex = 6;
            label1.Text = "Отслеживаемая директория";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 66);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 7;
            label2.Text = "Директория для отчётов";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(_outDirectorySelectionButton);
            Controls.Add(_selectedOutDirectoryTextBox);
            Controls.Add(_messageTextBox);
            Controls.Add(_directorySelectionButton);
            Controls.Add(_selectedDirectoryTextBox);
            Controls.Add(_reportGeneratorButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainWindow";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) _fileSystemWatcher).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button _reportGeneratorButton;
        private FolderBrowserDialog _folderBrowserDialog;
        private TextBox _selectedDirectoryTextBox;
        private Button _directorySelectionButton;
        private FileSystemWatcher _fileSystemWatcher;
        private TextBox _messageTextBox;
        private Button _outDirectorySelectionButton;
        private TextBox _selectedOutDirectoryTextBox;
        private FolderBrowserDialog _outFolderBrowserDialog;
        private Label label1;
        private Label label2;
    }
}
