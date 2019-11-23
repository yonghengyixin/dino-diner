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
        public float? minIMDB { get; set; }

        [BindProperty]
        public float? maxIMDB { get; set; }

        public List<IMenuItem> item;

        public List<IMenuItem> Combos { get; set; }

        public List<IMenuItem> Entree { get; set; }

        public List<IMenuItem> Drink { get; set; }

        public List<IMenuItem> Side { get; set; }

        Menu menu = new Menu();
        public Menu Menu
        {
            get { return menu; }
        }

        public void OnGet()
        {
            item = Menu.AvailableMenuTtems;
        }

        public void OnPost()
        {
            item = Menu.AvailableMenuTtems;

            if (search != null)
            {
                Combos = Search(Combos, search);
                Entree = Search(Entree, search);
                Drink = Search(Drink, search);
                Side = Search(Side, search);
            }

            if (MChoose.Count != 0)
            {
                item = FilterByMPAA(MChoose);
            }

            if (minIMDB != null)
            {
                item = FilterByMinIMDB(item, (float)minIMDB);
            }
            if (maxIMDB != null)
            {
                item = FilterByMaxIMDB(item, (float)maxIMDB);
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

        public List<IMenuItem> FilterByMPAA(List<string> mpaa)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            if (mpaa.Contains("Combo"))
            {
                results.AddRange(Menu.AvailableCombos);
            }
            if (mpaa.Contains("Entree"))
            {
                results.AddRange(Menu.AvailableEntrees);
            }
            if (mpaa.Contains("Drink"))
            {
                results.AddRange(Menu.AvailableDrinks);
            }
            if (mpaa.Contains("Side"))
            {
                results.AddRange(Menu.AvailableSides);
            }
            return results;
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