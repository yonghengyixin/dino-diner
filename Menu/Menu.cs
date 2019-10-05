using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        public List<IMenuItem> AvailableMenuTtems
        {
            get
            {
                
            }
        }

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

        public List<Side> AvailableSides
        {
            get
            {

            }
        }

        public List<Drink> AvailableDrinks
        {
            get
            {

            }
        }

        public List<CretaceousCombo> AvailableCombos
        {
            get
            {

            }
        }
    }
}
