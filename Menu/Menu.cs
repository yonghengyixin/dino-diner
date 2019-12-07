using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        /// <summary>
        /// handle all ingerdients
        /// </summary>
        public HashSet<string> PossibleIngredients = new HashSet<string>();

        /// <summary>
        /// return all items
        /// </summary>
        public List<IMenuItem> AvailableMenuTtems
        {
            get
            {
                List<IMenuItem> list = new List<IMenuItem>();
                list.AddRange(AvailableEntrees);
                list.AddRange(AvailableSides);
                list.AddRange(AvailableDrinks);
                list.AddRange(AvailableCombos);

                return list;
            }
        }
        
        /// <summary>
        /// return all entrees
        /// </summary>
        public List<Entree> AvailableEntrees
        {
            get
            {
                Brontowurst bt = new Brontowurst();
                DinoNuggets dn = new DinoNuggets();
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                PterodactylWings pw = new PterodactylWings();
                SteakosaurusBurger sb = new SteakosaurusBurger();
                TRexKingBurger tkb = new TRexKingBurger();
                VelociWrap vw = new VelociWrap();

                List<Entree> list = new List<Entree>();

                list.Add(bt);
                list.Add(dn);
                list.Add(pbj);
                list.Add(pw);
                list.Add(sb);
                list.Add(tkb);
                list.Add(vw);

                return list;
            }
        }

        /// <summary>
        /// return all sides
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                Fryceritops fry = new Fryceritops();
                MeteorMacAndCheese mmc = new MeteorMacAndCheese();
                MezzorellaSticks ms = new MezzorellaSticks();
                Triceritots t = new Triceritots();

                List<Side> list = new List<Side>();

                list.Add(fry);
                list.Add(mmc);
                list.Add(ms);
                list.Add(t);

                return list;
            }
        }


        /// <summary>
        /// return all drinks
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                Sodasaurus soda = new Sodasaurus();
                Tyrannotea tea = new Tyrannotea();
                JurassicJava java = new JurassicJava();
                Water w = new Water();

                List<Drink> list = new List<Drink>();

                list.Add(soda);
                list.Add(tea);
                list.Add(java);
                list.Add(w);

                return list;
            }
        }

        /// <summary>
        /// return all combos
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                Brontowurst bt = new Brontowurst();
                DinoNuggets dn = new DinoNuggets();
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                PterodactylWings pw = new PterodactylWings();
                SteakosaurusBurger sb = new SteakosaurusBurger();
                TRexKingBurger tkb = new TRexKingBurger();
                VelociWrap vw = new VelociWrap();

                CretaceousCombo cbt = new CretaceousCombo(bt);
                CretaceousCombo cdn = new CretaceousCombo(dn);
                CretaceousCombo cpbj = new CretaceousCombo(pbj);
                CretaceousCombo cpw = new CretaceousCombo(pw);
                CretaceousCombo csb = new CretaceousCombo(sb);
                CretaceousCombo ctkb = new CretaceousCombo(tkb);
                CretaceousCombo cvw = new CretaceousCombo(vw);

                List<CretaceousCombo> list = new List<CretaceousCombo>();

                list.Add(cbt);
                list.Add(cdn);
                list.Add(cpbj);
                list.Add(cpw);
                list.Add(csb);
                list.Add(ctkb);
                list.Add(cvw);

                return list;
            }
        }

        /// <summary>
        /// put all kinds of ingerdients into PossibleIngredients
        /// </summary>
        /// <param name="AllItems"></param>
        public void AllIngredient(IEnumerable<IMenuItem> AllItems)
        {
            foreach(IMenuItem item in AllItems)
            {
                foreach(string ingredient in item.Ingredients)
                {
                    PossibleIngredients.Add(ingredient);
                }
            }
            //return
        }

        /// <summary>
        /// add all items into string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(object i in AvailableMenuTtems)
            {
                sb.Append(i.ToString() + "\n");
            }
            return sb.ToString();
        }
    }
}
