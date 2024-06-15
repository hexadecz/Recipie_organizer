namespace Project
{
    partial class Category_Page
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
            category_listBox = new ListBox();
            SuspendLayout();
            // 
            // category_listBox
            // 
            category_listBox.AccessibleDescription = "Put the recipies you like into categories";
            category_listBox.AccessibleName = "List of Recipies";
            category_listBox.AccessibleRole = AccessibleRole.ScrollBar;
            category_listBox.BackColor = SystemColors.Info;
            category_listBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            category_listBox.FormattingEnabled = true;
            category_listBox.ItemHeight = 28;
            category_listBox.Location = new Point(50, 58);
            category_listBox.Name = "category_listBox";
            category_listBox.Size = new Size(302, 228);
            category_listBox.TabIndex = 0;
            // 
            // Category_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2023_12_15_at_4_36_07_PM;
            ClientSize = new Size(800, 450);
            Controls.Add(category_listBox);
            Name = "Category_Page";
            Text = "Category_Page";
            ResumeLayout(false);
        }

        #endregion

        private ListBox category_listBox;
    }
}