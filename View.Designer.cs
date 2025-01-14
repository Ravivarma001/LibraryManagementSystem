namespace LibraryManagementSystem
{
    partial class View
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
            ViewButton = new Button();
            TitleV = new Label();
            TitleVText = new TextBox();
            SuspendLayout();
            // 
            // ViewButton
            // 
            ViewButton.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewButton.Location = new Point(227, 123);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(94, 29);
            ViewButton.TabIndex = 0;
            ViewButton.Text = "View";
            ViewButton.UseVisualStyleBackColor = true;
            ViewButton.Click += ViewButton_Click;
            // 
            // TitleV
            // 
            TitleV.AutoSize = true;
            TitleV.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleV.Location = new Point(90, 64);
            TitleV.Name = "TitleV";
            TitleV.Size = new Size(42, 19);
            TitleV.TabIndex = 1;
            TitleV.Text = "Title";
            // 
            // TitleVText
            // 
            TitleVText.Location = new Point(196, 56);
            TitleVText.Name = "TitleVText";
            TitleVText.Size = new Size(125, 27);
            TitleVText.TabIndex = 2;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TitleVText);
            Controls.Add(TitleV);
            Controls.Add(ViewButton);
            Name = "View";
            Text = "View";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ViewButton;
        private Label TitleV;
        private TextBox TitleVText;
    }
}