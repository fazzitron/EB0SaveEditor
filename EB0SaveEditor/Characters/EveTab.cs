using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB0SaveEditor.Characters
{
    class EveTab : CharacterTab
    {
        public EveTab() : base()
        {
            this.Name = "EveTab";
            this.Text = "Eve";

            this.spritePictureBox.Image = global::EB0SaveEditor.Properties.Resources.eve;
        }

        public void setData(byte[] fileBytes)
        {
            nameBox.Text = Functions.getName(fileBytes, Constants.EVE);
            MaxHP.Value = Functions.getStat(fileBytes, Constants.EVE, Constants.MAX_HP);
            MaxPP.Value = Functions.getStat(fileBytes, Constants.EVE, Constants.MAX_PP);
            CurHP.Value = Functions.getStat(fileBytes, Constants.EVE, Constants.CURRENT_HP);
            CurPP.Value = Functions.getStat(fileBytes, Constants.EVE, Constants.CURRENT_PP);
            Offense.Value = Functions.getStat(fileBytes, Constants.EVE, Constants.OFFENSE);
            Defense.Value = Functions.getStat(fileBytes, Constants.EVE, Constants.DEFENSE);
            Fight.Value = Functions.getStat(fileBytes, Constants.EVE, Constants.FIGHT);
            Speed.Value = Functions.getStat(fileBytes, Constants.EVE, Constants.SPEED);
            Wisdom.Value = Functions.getStat(fileBytes, Constants.EVE, Constants.WISDOM);
            Strength.Value = Functions.getStat(fileBytes, Constants.EVE, Constants.STRENGTH);
            Force.Value = Functions.getStat(fileBytes, Constants.EVE, Constants.FORCE);
            Level.Value = Functions.getStat(fileBytes, Constants.EVE, Constants.LEVEL);
            Exp.Value = Functions.getStat(fileBytes, Constants.EVE, Constants.EXPERIENCE);

            List<int> nItems = Functions.getItems(fileBytes, Constants.EVE);
            Item1.SelectedIndex = nItems[0];
            Item2.SelectedIndex = nItems[1];
            Item3.SelectedIndex = nItems[2];
            Item4.SelectedIndex = nItems[3];
            Item5.SelectedIndex = nItems[4];
            Item6.SelectedIndex = nItems[5];
            Item7.SelectedIndex = nItems[6];
            Item8.SelectedIndex = nItems[7];

            int nStatus = Functions.getStat(fileBytes, Constants.EVE, Constants.STATUS);
        }
    }
}
