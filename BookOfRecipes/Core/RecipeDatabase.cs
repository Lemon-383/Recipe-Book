using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace BookOfRecipes
{
    public class RecipeDatabase
    {
        public RecipeDatabase(string path)
        {
            Recipes = new List<Recipe>();
            Path = path;
        }


        private static string recipeNameTag = "<RecipeName/>";
        private static string ingradientsTag = "<Ingradients/>";
        private static string instructionsTag = "<Instructions/>";

        public string Path { get; set; }
        public List<Recipe> Recipes { get; set; }


        public bool Load()
        {
            BinaryReader reader; 

            try
            {
                reader = new BinaryReader(new FileStream(Path, FileMode.Open));
            }
            catch
            {
                return false;
            }

            string currentTag = string.Empty;
            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                string str = reader.ReadString();

                if (str == recipeNameTag) { currentTag = recipeNameTag; continue; }
                if (str == ingradientsTag) { currentTag = ingradientsTag; continue; }
                if (str == instructionsTag) { currentTag = instructionsTag; continue; }

                if (currentTag == recipeNameTag) Recipes.Add(new Recipe(str));
                if (currentTag == ingradientsTag) Recipes.Last().Ingradients.Add(str);
                if (currentTag == instructionsTag) Recipes.Last().Instructions.Add(str);
            }

            reader.Close();
            return true;
        }

        public bool Save() => Save(Recipes);
        public bool Save(List<Recipe> recipes)
        {
            BinaryWriter writer;
            Recipes = recipes;

            try
            {
                writer = new BinaryWriter(new FileStream(Path, FileMode.Create));
            }
            catch
            {
                return false;
            }

            foreach (var recipe in Recipes)
            {
                writer.Write(recipeNameTag);
                writer.Write(recipe.Name);

                writer.Write(ingradientsTag);
                foreach (var item in recipe.Ingradients)
                    writer.Write(item);

                writer.Write(instructionsTag);
                foreach (var item in recipe.Instructions)
                    writer.Write(item);
            }

            writer.Close();
            return true;
        }


        public static bool LoadSingleRecipeAsTxt(out Recipe recipe, string path)
        {
            StreamReader reader;
            recipe = new Recipe();

            try
            {
                reader = new StreamReader(new FileStream(path, FileMode.Open));
            }
            catch
            {
                return false;
            }

            string currentTag = string.Empty;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (line == recipeNameTag) { currentTag = recipeNameTag; continue; }
                if (line == ingradientsTag) { currentTag = ingradientsTag; continue; }
                if (line == instructionsTag) { currentTag = instructionsTag; continue; }

                if (currentTag == recipeNameTag) recipe.Name = line;
                if (currentTag == ingradientsTag) recipe.Ingradients.Add(line);
                if (currentTag == instructionsTag) recipe.Instructions.Add(line);
            }

            reader.Close();
            return true;
        }

        public static bool SaveSingleRecipeAsTxt(Recipe recipe, string path)
        {
            StreamWriter writer;

            try
            {
                writer = new StreamWriter(new FileStream(path, FileMode.Create));
            }
            catch
            {
                return false;
            }

            writer.Write(recipeNameTag);
            writer.Write('\n' + recipe.Name);

            writer.Write('\n' + ingradientsTag);
            foreach (var item in recipe.Ingradients)
                writer.Write('\n' + item);

            writer.Write('\n' + instructionsTag);
            foreach (var item in recipe.Instructions)
                writer.Write('\n' + item);

            writer.Close();
            return true;
        }
    }
}
