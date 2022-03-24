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
            this.CharacterID = Constants.EVE;
            this.Name = "EveTab";
            this.Text = "Eve";

            this.spritePictureBox.Image = global::EB0SaveEditor.Properties.Resources.eve;
        }
    }
}
