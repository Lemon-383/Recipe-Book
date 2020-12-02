using System;
using System.Collections.Generic;

namespace BookOfRecipes 
{
    public class Recipe : IComparable
    {
        public string Name { get; set; }
        public List<string> Ingradients { get; set; }
        public List<string> Instructions { get; set; }


        public Recipe() 
        {
            Ingradients = new List<string>();
            Instructions = new List<string>();
        }
        public Recipe(string name) : this()
        {
            Name = name;
        }
        public Recipe(string name, List<string> ingradients, List<string> instructions) : this(name)
        {
            Ingradients = ingradients;
            Instructions = instructions;
        }


        public int CompareTo(object obj)
        {
            return string.Compare(Name, (obj as Recipe).Name);
        }
    }
}
