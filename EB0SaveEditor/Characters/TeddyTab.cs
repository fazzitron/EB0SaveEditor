using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB0SaveEditor.Characters
{
    class TeddyTab : CharacterTab
    {
        public TeddyTab() : base()
        {
            this.CharacterID = Constants.TEDDY;
            this.Name = "TeddyTab";
            this.Text = "Teddy";

            this.spritePictureBox.Image = global::EB0SaveEditor.Properties.Resources.teddy;
        }
    }
}
