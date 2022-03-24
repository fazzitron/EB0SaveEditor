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
            this.CharacterID = Constants.LOID;
            this.Name = "LoidTab";
            this.Text = "Loid";

            this.spritePictureBox.Image = global::EB0SaveEditor.Properties.Resources.lloyd;
        }
    }
}
