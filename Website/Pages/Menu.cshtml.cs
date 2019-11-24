using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> MChoose { get; set; } = new List<string>();

        [BindProperty]
        public List<string> IChoose { get; set; } = new List<string>();

        [BindProperty]
        public float? minIMDB { get; set; }

        [BindProperty]
        public float? maxIMDB { get; set; }

        public List<IMenuItem> Combos { get; set; } = new List<IMenuItem>();

        public List<IMenuItem> Entree { get; set; } = new List<IMenuItem>();

        public List<IMenuItem> Drink { get; set; } = new List<IMenuItem>();

        public List<IMenuItem> Side { get; set; } = new List<IMenuItem>();

        public HashSet<string> Ingre { get; set; } = new HashSet<string>();

        Menu menu = new Menu();
        public Menu Menu
        {
            get { return menu; }
        }

        public void OnGet()
        {
            Combos.AddRange(Menu.AvailableCombos);
            Entree.AddRange(Menu.AvailableEntrees);
            Drink.AddRange(Menu.AvailableDrinks);
            Side.AddRange(Menu.AvailableSides);
            Menu.AllIngredient(Combos);
            Menu.AllIngredient(Entree);
            Menu.AllIngredient(Drink);
            Menu.AllIngredient(Side);
            Ingre = Menu.PossibleIngredients;
        }

        public void OnPost()
        {
            Combos.AddRange(Menu.AvailableCombos);
            Entree.AddRange(Menu.AvailableEntrees);
            Drink.AddRange(Menu.AvailableDrinks);
            Side.AddRange(Menu.AvailableSides);
            Menu.AllIngredient(Combos);
            Menu.AllIngredient(Entree);
            Menu.AllIngredient(Drink);
            Menu.AllIngredient(Side);
            Ingre = Menu.PossibleIngredients;

            if (search != null)
            {
                Combos = Search(Combos, search);
                Entree = Search(Entree, search);
                Drink = Search(Drink, search);
                Side = Search(Side, search);
            }

            if (MChoose.Count != 0)
            {
                FilterByMPAA(MChoose);
            }

            if (minIMDB != null)
            {
                Combos = FilterByMinIMDB(Combos, (float)minIMDB);
                Entree = FilterByMinIMDB(Entree, (float)minIMDB);
                Drink = FilterByMinIMDB(Drink, (float)minIMDB);
                Side = FilterByMinIMDB(Side, (float)minIMDB);
            }
            if (maxIMDB != null)
            {
                Combos = FilterByMaxIMDB(Combos, (float)maxIMDB);
                Entree = FilterByMaxIMDB(Entree, (float)maxIMDB);
                Drink = FilterByMaxIMDB(Drink, (float)maxIMDB);
                Side = FilterByMaxIMDB(Side, (float)maxIMDB);
            }

            if(IChoose.Count != 0)
            {
                foreach (string str in Ingre)
                {
                    if (IChoose.Contains(str))
                    {
                        foreach(IMenuItem menu in Combos)
                        {
                            foreach(string ing in menu.Ingredients)
                            {
                                if (str.Contains(ing))
                                {
                                    menu.Ingredients.Remove(ing);
                                }
                            }
                        }

                        foreach (IMenuItem menu in Entree)
                        {
                            foreach (string ing in menu.Ingredients)
                            {
                                if (str.Contains(ing))
                                {
                                    menu.Ingredients.Remove(ing);
                                }
                            }
                        }

                        foreach (IMenuItem menu in Drink)
                        {
                            foreach (string ing in menu.Ingredients)
                            {
                                if (str.Contains(ing))
                                {
                                    menu.Ingredients.Remove(ing);
                                }
                            }
                        }

                        foreach (IMenuItem menu in Side)
                        {
                            foreach (string ing in menu.Ingredients)
                            {
                                if (str.Contains(ing))
                                {
                                    menu.Ingredients.Remove(ing);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static List<IMenuItem> Search(List<IMenuItem> menus, string searchString)
        {
            List<IMenuItem> result = new List<IMenuItem>();

            foreach (IMenuItem m in menus)
            {
                if (m.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(m);
                }
            }

            return result;
        }

        public void FilterByMPAA(List<string> mpaa)
        {
            if (!mpaa.Contains("Combo"))
            {
                Combos = new List<IMenuItem>();
            }
            if (!mpaa.Contains("Entree"))
            {
                Entree = new List<IMenuItem>();
            }
            if (!mpaa.Contains("Drink"))
            {
                Drink = new List<IMenuItem>();
            }
            if (!mpaa.Contains("Side"))
            {
                Side = new List<IMenuItem>();
            }
            
        }

        public static List<IMenuItem> FilterByMinIMDB(List<IMenuItem> menus, float? minIMDB)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem m in menus)
            {
                if (m.Price >= minIMDB)
                {
                    results.Add(m);
                }
            }
            return results;
        }

        public static List<IMenuItem> FilterByMaxIMDB(List<IMenuItem> menus, float? maxIMDB)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem m in menus)
            {
                if (m.Price <= maxIMDB)
                {
                    results.Add(m);
                }
            }
            return results;
        }

    }
}