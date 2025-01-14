namespace LibraryManagementSystem
{
    partial class Delete
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
            TitleD = new Label();
            TitleDText = new TextBox();
            DeleteButton = new Button();
            DeleteAllButton = new Button();
            SuspendLayout();
            // 
            // TitleD
            // 
            TitleD.AutoSize = true;
            TitleD.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleD.Location = new Point(154, 65);
            TitleD.Name = "TitleD";
            TitleD.Size = new Size(42, 19);
            TitleD.TabIndex = 0;
            TitleD.Text = "Title";
            // 
            // TitleDText
            // 
            TitleDText.Location = new Point(248, 57);
            TitleDText.Name = "TitleDText";
            TitleDText.Size = new Size(125, 27);
            TitleDText.TabIndex = 1;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(254, 120);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // DeleteAllButton
            // 
            DeleteAllButton.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteAllButton.Location = new Point(254, 180);
            DeleteAllButton.Name = "DeleteAllButton";
            DeleteAllButton.Size = new Size(94, 29);
            DeleteAllButton.TabIndex = 3;
            DeleteAllButton.Text = "Delete All";
            DeleteAllButton.UseVisualStyleBackColor = true;
            DeleteAllButton.Click += DeleteAllButton_Click;
            // 
            // Delete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteAllButton);
            Controls.Add(DeleteButton);
            Controls.Add(TitleDText);
            Controls.Add(TitleD);
            Name = "Delete";
            Text = "Delete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleD;
        private TextBox TitleDText;
        private Button DeleteButton;
        private Button DeleteAllButton;
    }
}