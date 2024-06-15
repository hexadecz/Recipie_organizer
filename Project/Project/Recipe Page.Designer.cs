namespace Project
{
    partial class Recipe_Page
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
            submitbutton = new Button();
            ingredientinputTextBox = new RichTextBox();
            titledataTextBox = new RichTextBox();
            instructioninputTextBox = new RichTextBox();
            categoryinputTextBox = new RichTextBox();
            labelenterdata = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelquantity = new Label();
            labelquanntt = new Label();
            numericUpDown2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // submitbutton
            // 
            submitbutton.BackColor = SystemColors.InactiveCaption;
            submitbutton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            submitbutton.Location = new Point(284, 391);
            submitbutton.Name = "submitbutton";
            submitbutton.Size = new Size(98, 47);
            submitbutton.TabIndex = 5;
            submitbutton.Text = "Submit";
            submitbutton.UseVisualStyleBackColor = false;
            submitbutton.Click += submitbutton_Click;
            // 
            // ingredientinputTextBox
            // 
            ingredientinputTextBox.BackColor = SystemColors.Info;
            ingredientinputTextBox.Location = new Point(402, 147);
            ingredientinputTextBox.Name = "ingredientinputTextBox";
            ingredientinputTextBox.Size = new Size(169, 79);
            ingredientinputTextBox.TabIndex = 6;
            ingredientinputTextBox.Text = "";
            // 
            // titledataTextBox
            // 
            titledataTextBox.BackColor = SystemColors.Info;
            titledataTextBox.Location = new Point(31, 137);
            titledataTextBox.Name = "titledataTextBox";
            titledataTextBox.Size = new Size(258, 82);
            titledataTextBox.TabIndex = 7;
            titledataTextBox.Text = "";
            // 
            // instructioninputTextBox
            // 
            instructioninputTextBox.BackColor = SystemColors.Info;
            instructioninputTextBox.Location = new Point(31, 303);
            instructioninputTextBox.Name = "instructioninputTextBox";
            instructioninputTextBox.Size = new Size(258, 82);
            instructioninputTextBox.TabIndex = 8;
            instructioninputTextBox.Text = "";
            // 
            // categoryinputTextBox
            // 
            categoryinputTextBox.BackColor = SystemColors.Info;
            categoryinputTextBox.Location = new Point(402, 303);
            categoryinputTextBox.Name = "categoryinputTextBox";
            categoryinputTextBox.Size = new Size(258, 82);
            categoryinputTextBox.TabIndex = 9;
            categoryinputTextBox.Text = "";
            // 
            // labelenterdata
            // 
            labelenterdata.AutoSize = true;
            labelenterdata.BackColor = SystemColors.Info;
            labelenterdata.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelenterdata.Location = new Point(111, 19);
            labelenterdata.Name = "labelenterdata";
            labelenterdata.Size = new Size(400, 41);
            labelenterdata.TabIndex = 10;
            labelenterdata.Text = "Enter data for the new recipe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 89);
            label1.Name = "label1";
            label1.Size = new Size(81, 41);
            label1.TabIndex = 11;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 240);
            label2.Name = "label2";
            label2.Size = new Size(179, 41);
            label2.TabIndex = 12;
            label2.Text = "Instructions:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(402, 240);
            label3.Name = "label3";
            label3.Size = new Size(219, 41);
            label3.TabIndex = 13;
            label3.Text = "Categorization:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Info;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(402, 89);
            label4.Name = "label4";
            label4.Size = new Size(175, 41);
            label4.TabIndex = 14;
            label4.Text = "Ingredients:";
            // 
            // labelquantity
            // 
            labelquantity.Location = new Point(0, 0);
            labelquantity.Name = "labelquantity";
            labelquantity.Size = new Size(100, 23);
            labelquantity.TabIndex = 0;
            // 
            // labelquanntt
            // 
            labelquanntt.AutoSize = true;
            labelquanntt.BackColor = SystemColors.Info;
            labelquanntt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelquanntt.Location = new Point(577, 147);
            labelquanntt.Name = "labelquanntt";
            labelquanntt.Size = new Size(106, 32);
            labelquanntt.TabIndex = 18;
            labelquanntt.Text = "Quantity";
            // 
            // numericUpDown2
            // 
            numericUpDown2.BackColor = SystemColors.Info;
            numericUpDown2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown2.Location = new Point(577, 192);
            numericUpDown2.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(106, 34);
            numericUpDown2.TabIndex = 19;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            // 
            // Recipe_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2023_12_15_at_4_36_07_PM;
            ClientSize = new Size(712, 450);
            Controls.Add(numericUpDown2);
            Controls.Add(labelquanntt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelenterdata);
            Controls.Add(categoryinputTextBox);
            Controls.Add(instructioninputTextBox);
            Controls.Add(titledataTextBox);
            Controls.Add(ingredientinputTextBox);
            Controls.Add(submitbutton);
            Name = "Recipe_Page";
            Text = "Recipe_Page";
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button submitbutton;
        private RichTextBox ingredientinputTextBox;
        private RichTextBox titledataTextBox;
        private RichTextBox instructioninputTextBox;
        private RichTextBox categoryinputTextBox;
       // private TextBox textBox2;
        private Label labelenterdata;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelquantity;
        private Label labelquanntt;
        private NumericUpDown numericUpDown2;
    }
}