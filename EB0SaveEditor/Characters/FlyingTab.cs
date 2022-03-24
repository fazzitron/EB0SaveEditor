using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB0SaveEditor.Characters
{
    class FlyingTab : CharacterTab
    {
        public FlyingTab() : base()
        {
            this.Name = "FlyTab";
            this.Text = "Flying Man";

            this.spritePictureBox.Image = global::EB0SaveEditor.Properties.Resources.flyingman;
        }

        public void setData(byte[] fileBytes)
        {
            nameBox.Text = Functions.getName(fileBytes, Constants.FLY);
            MaxHP.Value = Functions.getStat(fileBytes, Constants.FLY, Constants.MAX_HP);
            MaxPP.Value = Functions.getStat(fileBytes, Constants.FLY, Constants.MAX_PP);
            CurHP.Value = Functions.getStat(fileBytes, Constants.FLY, Constants.CURRENT_HP);
            CurPP.Value = Functions.getStat(fileBytes, Constants.FLY, Constants.CURRENT_PP);
            Offense.Value = Functions.getStat(fileBytes, Constants.FLY, Constants.OFFENSE);
            Defense.Value = Functions.getStat(fileBytes, Constants.FLY, Constants.DEFENSE);
            Fight.Value = Functions.getStat(fileBytes, Constants.FLY, Constants.FIGHT);
            Speed.Value = Functions.getStat(fileBytes, Constants.FLY, Constants.SPEED);
            Wisdom.Value = Functions.getStat(fileBytes, Constants.FLY, Constants.WISDOM);
            Strength.Value = Functions.getStat(fileBytes, Constants.FLY, Constants.STRENGTH);
            Force.Value = Functions.getStat(fileBytes, Constants.FLY, Constants.FORCE);
            Level.Value = Functions.getStat(fileBytes, Constants.FLY, Constants.LEVEL);
            Exp.Value = Functions.getStat(fileBytes, Constants.FLY, Constants.EXPERIENCE);

            List<int> nItems = Functions.getItems(fileBytes, Constants.FLY);
            Item1.SelectedIndex = nItems[0];
            Item2.SelectedIndex = nItems[1];
            Item3.SelectedIndex = nItems[2];
            Item4.SelectedIndex = nItems[3];
            Item5.SelectedIndex = nItems[4];
            Item6.SelectedIndex = nItems[5];
            Item7.SelectedIndex = nItems[6];
            Item8.SelectedIndex = nItems[7];

            int nStatus = Functions.getStat(fileBytes, Constants.FLY, Constants.STATUS);
        }
    }
}
