namespace Project
{
    partial class search_Page
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
            components = new System.ComponentModel.Container();
            recipeBindingSource = new BindingSource(components);
            button_search = new Button();
            textBox_searchbytitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            recipeBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // recipeBindingSource
            // 
            recipeBindingSource.DataSource = typeof(Recipe);
            // 
            // button_search
            // 
            button_search.BackColor = SystemColors.Info;
            button_search.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button_search.Location = new Point(532, 167);
            button_search.Name = "button_search";
            button_search.Size = new Size(163, 61);
            button_search.TabIndex = 1;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // textBox_searchbytitle
            // 
            textBox_searchbytitle.Location = new Point(36, 115);
            textBox_searchbytitle.Multiline = true;
            textBox_searchbytitle.Name = "textBox_searchbytitle";
            textBox_searchbytitle.Size = new Size(300, 46);
            textBox_searchbytitle.TabIndex = 2;
            textBox_searchbytitle.TextChanged += textBox_searchbytitle_TextChanged;
            textBox_searchbytitle.KeyPress += textBox_searchbytitle_KeyPress;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 42);
            label2.Name = "label2";
            label2.Size = new Size(269, 37);
            label2.TabIndex = 3;
            label2.Text = "Search by recipe title:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = recipeBindingSource1;
            dataGridView1.Location = new Point(36, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // recipeBindingSource1
            // 
            recipeBindingSource1.DataSource = typeof(Recipe);
            // 
            // search_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2023_12_15_at_4_36_07_PM;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(textBox_searchbytitle);
            Controls.Add(button_search);
            Name = "search_Page";
            Text = "search_Page";
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource recipeBindingSource;
        private Button button_search;
        private TextBox textBox_searchbytitle;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private BindingSource recipeBindingSource1;
    }
}