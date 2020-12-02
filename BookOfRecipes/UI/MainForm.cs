using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BookOfRecipes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dgv_recipes.AutoGenerateColumns = false;
            dgv_recipes.SelectionMode = DataGridViewSelectionMode.CellSelect;

            recipes = new List<Recipe>();
            database = new RecipeDatabase("Recipes.database");
            if (database.Load())
                foreach (var recipe in database.Recipes)
                    AddRecipe(recipe);
            else
                MessageBox.Show($"Ошибка загрузки базы данных", "Error");
        }

        
        private Color rtboxRecipe_activeBgColor = SystemColors.Control;
        private Color rtboxRecipe_inactiveBgColor = SystemColors.AppWorkspace;
        private RecipeDatabase database;
        private List<Recipe> recipes;


        private void ShowRecipe(Recipe recipe)
        {
            rtbox_recipe.Text = "Инградиенты:\n";
            for (int i = 0; i < recipe.Ingradients.Count; i++)
                rtbox_recipe.Text += $" [{i + 1}]: {recipe.Ingradients[i]}\n";

            rtbox_recipe.Text += "\nИнструкция:\n";
            for (int i = 0; i < recipe.Instructions.Count; i++)
                rtbox_recipe.Text += $" [{i + 1}]: {recipe.Instructions[i]}\n";
        }

        private void Sort()
        {
            recipes.Sort();
            dgv_recipes.Sort(dgv_recipes.Columns[0], dgv_recipes.SortOrder == SortOrder.Descending ? ListSortDirection.Descending : ListSortDirection.Ascending);
        }

        private bool SaveRecipes()
        {
            if(!database.Save(recipes))
            {
                MessageBox.Show("Ошибка сохранения базы данных", "Error");
                return false;
            }

            return true;
        }

        private void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
            dgv_recipes.Rows.Add(recipe.Name);
            Sort();
        }

        private void RemoveRecipe(int index)
        {
            recipes.RemoveAt(index);
            dgv_recipes.Rows.RemoveAt(index);
        }


        private void dgv_recipes_SelectionChanged(object sender, EventArgs args)
        {
            if (dgv_recipes.SelectedCells.Count != 1)
            {
                rtbox_recipe.Text = string.Empty;
                rtbox_recipe.BackColor = rtboxRecipe_inactiveBgColor;
            }
            else
            {
                rtbox_recipe.BackColor = rtboxRecipe_activeBgColor;
                ShowRecipe(recipes[dgv_recipes.CurrentCell.RowIndex]);
            }
        }


        #region toolStrip event handlers

        private void mainToolStripBtn_add_Click(object sender, EventArgs e)
        {
            var recipeEditor = new RecipeEditorForm();
            recipeEditor.ShowDialog();

            if (recipeEditor.DialogResult == DialogResult.OK)
            {
                AddRecipe(recipeEditor.recipe);
                SaveRecipes();
            }
        }

        private void mainToolStripBtn_remove_Click(object sender, EventArgs e)
        {
            if (dgv_recipes.SelectedCells.Count < 1)
            {
                MessageBox.Show("Выберите рецепт, который хотите удалить");
                return;
            }

            var indexesToRemove = new List<int>();
            foreach (DataGridViewCell cell in dgv_recipes.SelectedCells)
                foreach (DataGridViewRow row in dgv_recipes.Rows)
                    if (row.Cells.Contains(cell))
                        indexesToRemove.Add(row.Index);

            if (DialogResult.OK == MessageBox.Show($"Вы действительно хотите удалить выбранные рецепты?", "Удаление", MessageBoxButtons.OKCancel)) 
                foreach (int index in indexesToRemove)
                    RemoveRecipe(index);
            SaveRecipes();
        }

        private void mainToolStripBtn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_recipes.SelectedCells.Count != 1)
            {
                MessageBox.Show("Выберите рецепт для редактирования");
                return;
            }

            var currentRecipe = recipes[dgv_recipes.CurrentCell.RowIndex];
            var recipeEditor = new RecipeEditorForm(currentRecipe);
            recipeEditor.ShowDialog();

            if (recipeEditor.DialogResult == DialogResult.OK)
            {
                RemoveRecipe(recipes.IndexOf(currentRecipe));
                AddRecipe(recipeEditor.recipe);
                SaveRecipes();
            }
        }

        private void mainToolStripBtn_saveSelected_Click(object sender, EventArgs e)
        {
            if (dgv_recipes.SelectedCells.Count < 1)
            {
                MessageBox.Show("Выберите рецепт, который хотите сохранить");
                return;
            }

            var indexesToSave = new List<int>();
            foreach (DataGridViewCell cell in dgv_recipes.SelectedCells)
                foreach (DataGridViewRow row in dgv_recipes.Rows)
                    if (row.Cells.Contains(cell))
                        indexesToSave.Add(row.Index);

            foreach(int index in indexesToSave)
            {
                var dialog = new SaveFileDialog();
                dialog.Filter = "Текстовые файлы (*.txt)|*.txt";
                dialog.AddExtension = true;
                dialog.FileName = recipes[index].Name;

                if (dialog.ShowDialog() == DialogResult.OK)
                    if(!RecipeDatabase.SaveSingleRecipeAsTxt(recipes[index], dialog.FileName))
                        MessageBox.Show($"Ошибка сохранения файла {Path.GetFileName(dialog.FileName)}", "Error");
            }
        }

        private void mainToolStripBtn_openRecipe_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == DialogResult.OK)
                foreach (string path in dialog.FileNames)
                {
                    Recipe recipe = new Recipe();
                    if (RecipeDatabase.LoadSingleRecipeAsTxt(out recipe, path))
                        AddRecipe(recipe);
                    else
                        MessageBox.Show($"Ошибка открытия файла {Path.GetFileName(path)}", "Error");
                }
            SaveRecipes();
        }

        #endregion

    }
}
