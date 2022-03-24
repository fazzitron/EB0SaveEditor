using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB0SaveEditor
{
    class AnaTab : CharacterTab
    {
        public AnaTab() : base()
        {
            this.CharacterID = Constants.ANA;
            this.Name = "AnaTab";
            this.Text = "Ana";

            this.spritePictureBox.Image = global::EB0SaveEditor.Properties.Resources.ana;
        }
    }
}
