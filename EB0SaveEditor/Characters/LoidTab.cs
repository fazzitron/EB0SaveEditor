using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB0SaveEditor.Characters
{
    class LoidTab : CharacterTab
    {
        public LoidTab() : base()
        {
            this.Name = "LoidTab";
            this.Text = "Loid";

            this.spritePictureBox.Image = global::EB0SaveEditor.Properties.Resources.lloyd;
        }

        public void setData(byte[] fileBytes)
        {
            nameBox.Text = Functions.getName(fileBytes, Constants.LOID);
            MaxHP.Value = Functions.getStat(fileBytes, Constants.LOID, Constants.MAX_HP);
            MaxPP.Value = Functions.getStat(fileBytes, Constants.LOID, Constants.MAX_PP);
            CurHP.Value = Functions.getStat(fileBytes, Constants.LOID, Constants.CURRENT_HP);
            CurPP.Value = Functions.getStat(fileBytes, Constants.LOID, Constants.CURRENT_PP);
            Offense.Value = Functions.getStat(fileBytes, Constants.LOID, Constants.OFFENSE);
            Defense.Value = Functions.getStat(fileBytes, Constants.LOID, Constants.DEFENSE);
            Fight.Value = Functions.getStat(fileBytes, Constants.LOID, Constants.FIGHT);
            Speed.Value = Functions.getStat(fileBytes, Constants.LOID, Constants.SPEED);
            Wisdom.Value = Functions.getStat(fileBytes, Constants.LOID, Constants.WISDOM);
            Strength.Value = Functions.getStat(fileBytes, Constants.LOID, Constants.STRENGTH);
            Force.Value = Functions.getStat(fileBytes, Constants.LOID, Constants.FORCE);
            Level.Value = Functions.getStat(fileBytes, Constants.LOID, Constants.LEVEL);
            Exp.Value = Functions.getStat(fileBytes, Constants.LOID, Constants.EXPERIENCE);

            List<int> nItems = Functions.getItems(fileBytes, Constants.LOID);
            Item1.SelectedIndex = nItems[0];
            Item2.SelectedIndex = nItems[1];
            Item3.SelectedIndex = nItems[2];
            Item4.SelectedIndex = nItems[3];
            Item5.SelectedIndex = nItems[4];
            Item6.SelectedIndex = nItems[5];
            Item7.SelectedIndex = nItems[6];
            Item8.SelectedIndex = nItems[7];

            int nStatus = Functions.getStat(fileBytes, Constants.LOID, Constants.STATUS);
        }
    }
}
