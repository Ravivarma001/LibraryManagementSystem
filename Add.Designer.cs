namespace LibraryManagementSystem
{
    partial class Add
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
            TitleA = new Label();
            AuthorA = new Label();
            TitleAText = new TextBox();
            AuthorAText = new TextBox();
            AddButton = new Button();
            SuspendLayout();
            // 
            // TitleA
            // 
            TitleA.AutoSize = true;
            TitleA.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleA.Location = new Point(131, 62);
            TitleA.Name = "TitleA";
            TitleA.Size = new Size(42, 19);
            TitleA.TabIndex = 0;
            TitleA.Text = "Title";
            // 
            // AuthorA
            // 
            AuthorA.AutoSize = true;
            AuthorA.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AuthorA.Location = new Point(131, 125);
            AuthorA.Name = "AuthorA";
            AuthorA.Size = new Size(61, 19);
            AuthorA.TabIndex = 1;
            AuthorA.Text = "Author";
            // 
            // TitleAText
            // 
            TitleAText.Location = new Point(244, 54);
            TitleAText.Name = "TitleAText";
            TitleAText.Size = new Size(125, 27);
            TitleAText.TabIndex = 2;
            // 
            // AuthorAText
            // 
            AuthorAText.Location = new Point(244, 120);
            AuthorAText.Name = "AuthorAText";
            AuthorAText.Size = new Size(125, 27);
            AuthorAText.TabIndex = 3;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(275, 197);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 4;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddButton);
            Controls.Add(AuthorAText);
            Controls.Add(TitleAText);
            Controls.Add(AuthorA);
            Controls.Add(TitleA);
            Name = "Add";
            Text = "Add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleA;
        private Label AuthorA;
        private TextBox TitleAText;
        private TextBox AuthorAText;
        private Button AddButton;
    }
}