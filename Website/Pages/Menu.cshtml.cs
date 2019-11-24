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
        /// <summary>
        /// bind propety for search
        /// </summary>
        [BindProperty]
        public string search { get; set; }

        /// <summary>
        /// bind property for Meun choose
        /// </summary>
        [BindProperty]
        public List<string> MChoose { get; set; } = new List<string>();

        /// <summary>
        /// bind property for ingredient choose
        /// </summary>
        [BindProperty]
        public List<string> IChoose { get; set; } = new List<string>();

        /// <summary>
        /// bind property for min price filter
        /// </summary>
        [BindProperty]
        public float? minIMDB { get; set; }

        /// <summary>
        /// bind property for max price filter
        /// </summary>
        [BindProperty]
        public float? maxIMDB { get; set; }

        /// <summary>
        /// hold combos
        /// </summary>
        public List<IMenuItem> Combos { get; set; } = new List<IMenuItem>();

        /// <summary>
        /// hold entree
        /// </summary>
        public List<IMenuItem> Entree { get; set; } = new List<IMenuItem>();

        /// <summary>
        /// hold drink
        /// </summary>
        public List<IMenuItem> Drink { get; set; } = new List<IMenuItem>();

        /// <summary>
        /// hold side
        /// </summary>
        public List<IMenuItem> Side { get; set; } = new List<IMenuItem>();

        /// <summary>
        /// hold all ingredients
        /// </summary>
        public HashSet<string> Ingre { get; set; } = new HashSet<string>();

        /// <summary>
        /// hold whold menu
        /// </summary>
        Menu menu = new Menu();
        public Menu Menu
        {
            get { return menu; }
        }

        /// <summary>
        /// initialize Menu Page
        /// </summary>
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

        /// <summary>
        /// UI method
        /// </summary>
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
            
        }

        /// <summary>
        /// hold the search part
        /// </summary>
        /// <param name="menus"></param>
        /// <param name="searchString"></param>
        /// <returns></returns>
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

        /// <summary>
        /// check Menu choose checkbox
        /// </summary>
        /// <param name="mpaa"></param>
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

        /// <summary>
        /// handle min price filter
        /// </summary>
        /// <param name="menus"></param>
        /// <param name="minIMDB"></param>
        /// <returns></returns>
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

        /// <summary>
        /// handle max price filter
        /// </summary>
        /// <param name="menus"></param>
        /// <param name="maxIMDB"></param>
        /// <returns></returns>
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