namespace Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Random_button = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            addpictureBox = new PictureBox();
            searchpictureBox = new PictureBox();
            listpictureBox = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)addpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Random_button
            // 
            Random_button.BackColor = SystemColors.Info;
            Random_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Random_button.Location = new Point(488, 63);
            Random_button.Name = "Random_button";
            Random_button.Size = new Size(236, 82);
            Random_button.TabIndex = 3;
            Random_button.Text = "Random recipe";
            Random_button.UseVisualStyleBackColor = false;
            Random_button.Click += Random_button_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(68, 63);
            button1.Name = "button1";
            button1.Size = new Size(243, 82);
            button1.TabIndex = 4;
            button1.Text = "Add new recipe";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(488, 260);
            button2.Name = "button2";
            button2.Size = new Size(236, 78);
            button2.TabIndex = 5;
            button2.Text = "Categories";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(68, 260);
            button3.Name = "button3";
            button3.Size = new Size(243, 78);
            button3.TabIndex = 6;
            button3.Text = "Search for a recipe";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // addpictureBox
            // 
            addpictureBox.Image = Properties.Resources.OIP;
            addpictureBox.Location = new Point(153, 156);
            addpictureBox.Name = "addpictureBox";
            addpictureBox.Size = new Size(70, 74);
            addpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            addpictureBox.TabIndex = 7;
            addpictureBox.TabStop = false;
            addpictureBox.Click += addpictureBox_Click;
            // 
            // searchpictureBox
            // 
            searchpictureBox.Image = (Image)resources.GetObject("searchpictureBox.Image");
            searchpictureBox.Location = new Point(153, 344);
            searchpictureBox.Name = "searchpictureBox";
            searchpictureBox.Size = new Size(70, 74);
            searchpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            searchpictureBox.TabIndex = 8;
            searchpictureBox.TabStop = false;
            searchpictureBox.Click += searchpictureBox_Click;
            // 
            // listpictureBox
            // 
            listpictureBox.Image = (Image)resources.GetObject("listpictureBox.Image");
            listpictureBox.Location = new Point(571, 344);
            listpictureBox.Name = "listpictureBox";
            listpictureBox.Size = new Size(70, 74);
            listpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            listpictureBox.TabIndex = 9;
            listpictureBox.TabStop = false;
            listpictureBox.Click += listpictureBox_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(571, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2023_12_15_at_4_36_07_PM;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(listpictureBox);
            Controls.Add(searchpictureBox);
            Controls.Add(addpictureBox);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Random_button);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)addpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)listpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button Random_button;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox addpictureBox;
        private PictureBox searchpictureBox;
        private PictureBox listpictureBox;
        private PictureBox pictureBox1;
    }
}