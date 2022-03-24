using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB0SaveEditor
{
    class NintenTab : CharacterTab
    {
        public NintenTab() : base()
        {
            this.CharacterID = Constants.NINTEN;
            this.Name = "NintenTab";
            this.Text = "Ninten";

            this.spritePictureBox.Image = global::EB0SaveEditor.Properties.Resources.ninten;
        }
    }
}
