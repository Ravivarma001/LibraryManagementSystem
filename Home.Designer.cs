namespace LibraryManagementSystem
{
    partial class Home
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
            Add = new Button();
            Delete = new Button();
            View = new Button();
            AddLabel = new Label();
            DeleteLabel = new Label();
            ViewLabel = new Label();
            SuspendLayout();
            // 
            // Add
            // 
            Add.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.Location = new Point(105, 45);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 0;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Delete
            // 
            Delete.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.Location = new Point(105, 129);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 1;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // View
            // 
            View.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            View.Location = new Point(105, 215);
            View.Name = "View";
            View.Size = new Size(94, 29);
            View.TabIndex = 2;
            View.Text = "View";
            View.UseVisualStyleBackColor = true;
            View.Click += View_Click;
            // 
            // AddLabel
            // 
            AddLabel.AutoSize = true;
            AddLabel.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddLabel.Location = new Point(249, 54);
            AddLabel.Name = "AddLabel";
            AddLabel.Size = new Size(229, 22);
            AddLabel.TabIndex = 3;
            AddLabel.Text = "Add data into the database.";
            // 
            // DeleteLabel
            // 
            DeleteLabel.AutoSize = true;
            DeleteLabel.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteLabel.Location = new Point(249, 136);
            DeleteLabel.Name = "DeleteLabel";
            DeleteLabel.Size = new Size(252, 22);
            DeleteLabel.TabIndex = 4;
            DeleteLabel.Text = "Delete data from the database.";
            // 
            // ViewLabel
            // 
            ViewLabel.AutoSize = true;
            ViewLabel.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewLabel.Location = new Point(249, 222);
            ViewLabel.Name = "ViewLabel";
            ViewLabel.Size = new Size(246, 22);
            ViewLabel.TabIndex = 5;
            ViewLabel.Text = "View the data in the database.";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ViewLabel);
            Controls.Add(DeleteLabel);
            Controls.Add(AddLabel);
            Controls.Add(View);
            Controls.Add(Delete);
            Controls.Add(Add);
            Name = "Home";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Add;
        private Button Delete;
        private Button View;
        private Label AddLabel;
        private Label DeleteLabel;
        private Label ViewLabel;
    }
}
