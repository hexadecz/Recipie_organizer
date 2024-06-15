using System.Web;

namespace Project
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recipe_Page secondpage = new Recipe_Page();
            secondpage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category_Page thirdpage = new Category_Page();
            thirdpage.Show();
        }

        private void Random_button_Click(object sender, EventArgs e)
        {
            Random_Page fifthpage = new Random_Page();
            fifthpage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            search_Page fourthpage = new search_Page();
            fourthpage.Show();
        }

        private void addpictureBox_Click(object sender, EventArgs e)
        {
        }

        private void searchpictureBox_Click(object sender, EventArgs e)
        {
        }

        private void listpictureBox_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }



    public class Recipe
    {
        public int RecipeID; 
        public string Title;
        public string Instructions;
        public List<BaseItem> Ingredients;
        public List<BaseItem> Categories;

        public Recipe()
        {
            RecipeID = 00;
            Title = "abc";
            Instructions = "abc";
        }
        public override string ToString()
        {
            return Title; // Display the title in the ListBox
        }
        public Recipe(int recipeID, string title, string instructions)
        {
            RecipeID = recipeID;
            Title = title;
            Instructions = instructions;
            Ingredients = new List<BaseItem>();
            Categories = new List<BaseItem>();
        }
    
}



    public class BaseItem
    {
        private int itemID;
        private string name;

        public string Name
        {
            set
            {
                if (value != null)
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }

        public int Itemid
        {
            set
            {
                if (value != 0)
                {
                    itemID = value;
                }
            }
            get
            {
                return itemID;
            }
        }

        public BaseItem(string name, int itemID)
        {
            name = "item";
            itemID = -1;
        }
        public override string ToString() 
        { return "base"; }

    }


    public class Ingredient : BaseItem
    {
        float quantity;
        public Ingredient(string name, int itemID, float quantity) : base(name, itemID)
        {
            Console.WriteLine("in the Ingredient constructor");
            this.quantity = quantity;
        }

        public override string ToString()
        {
            return "Ingredient Inserted";
        }

    }




    public class Category : BaseItem
    {
        private string color;
        public Category(string name, int itemID, string color) : base(name, itemID)
        {
            Console.WriteLine("in the Category class ");
            this.color = color;
        }
        public override string ToString()
        {
            return "Category Inserted";
        }
    }


    
}