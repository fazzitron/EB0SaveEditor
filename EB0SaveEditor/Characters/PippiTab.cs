using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB0SaveEditor.Characters
{
    class PippiTab : CharacterTab
    {
        public PippiTab() : base()
        {
            this.Name = "PippiTab";
            this.Text = "Pippi";

            this.spritePictureBox.Image = global::EB0SaveEditor.Properties.Resources.pippi;
        }

        public void setData(byte[] fileBytes)
        {
            nameBox.Text = Functions.getName(fileBytes, Constants.PIPPI);
            MaxHP.Value = Functions.getStat(fileBytes, Constants.PIPPI, Constants.MAX_HP);
            MaxPP.Value = Functions.getStat(fileBytes, Constants.PIPPI, Constants.MAX_PP);
            CurHP.Value = Functions.getStat(fileBytes, Constants.PIPPI, Constants.CURRENT_HP);
            CurPP.Value = Functions.getStat(fileBytes, Constants.PIPPI, Constants.CURRENT_PP);
            Offense.Value = Functions.getStat(fileBytes, Constants.PIPPI, Constants.OFFENSE);
            Defense.Value = Functions.getStat(fileBytes, Constants.PIPPI, Constants.DEFENSE);
            Fight.Value = Functions.getStat(fileBytes, Constants.PIPPI, Constants.FIGHT);
            Speed.Value = Functions.getStat(fileBytes, Constants.PIPPI, Constants.SPEED);
            Wisdom.Value = Functions.getStat(fileBytes, Constants.PIPPI, Constants.WISDOM);
            Strength.Value = Functions.getStat(fileBytes, Constants.PIPPI, Constants.STRENGTH);
            Force.Value = Functions.getStat(fileBytes, Constants.PIPPI, Constants.FORCE);
            Level.Value = Functions.getStat(fileBytes, Constants.PIPPI, Constants.LEVEL);
            Exp.Value = Functions.getStat(fileBytes, Constants.PIPPI, Constants.EXPERIENCE);

            List<int> nItems = Functions.getItems(fileBytes, Constants.PIPPI);
            Item1.SelectedIndex = nItems[0];
            Item2.SelectedIndex = nItems[1];
            Item3.SelectedIndex = nItems[2];
            Item4.SelectedIndex = nItems[3];
            Item5.SelectedIndex = nItems[4];
            Item6.SelectedIndex = nItems[5];
            Item7.SelectedIndex = nItems[6];
            Item8.SelectedIndex = nItems[7];

            int nStatus = Functions.getStat(fileBytes, Constants.PIPPI, Constants.STATUS);
        }
    }
}
