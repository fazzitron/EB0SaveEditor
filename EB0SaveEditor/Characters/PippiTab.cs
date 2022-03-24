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
            this.CharacterID = Constants.PIPPI;
            this.Name = "PippiTab";
            this.Text = "Pippi";

            this.spritePictureBox.Image = global::EB0SaveEditor.Properties.Resources.pippi;
        }
    }
}
