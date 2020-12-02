using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookOfRecipes
{
    public partial class RecipeEditorForm : Form
    {
        public RecipeEditorForm(Recipe recipe) : this()
        {
            this.recipe = recipe;
            tbox_name.Text = recipe.Name;

            foreach (var item in recipe.Ingradients)
                rtbox_ingradients.Text += item + "\n";

            foreach (var item in recipe.Instructions)
                rtbox_instructions.Text += item + "\n";
        }
        public RecipeEditorForm()
        {
            InitializeComponent();
            recipe = new Recipe();
        }
        

        public Recipe recipe;


        private void btn_ok_Click(object sender, EventArgs e)
        {
            recipe.Name = tbox_name.Text;
            recipe.Ingradients = new List<string>(rtbox_ingradients.Text.Split('\n'));
            recipe.Instructions = new List<string>(rtbox_instructions.Text.Split('\n'));

            if (recipe.Ingradients.Last() == string.Empty) recipe.Ingradients.RemoveAt(recipe.Ingradients.Count - 1);
            if (recipe.Instructions.Last() == string.Empty) recipe.Instructions.RemoveAt(recipe.Instructions.Count - 1);
        }
    }
}
