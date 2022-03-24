using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB0SaveEditor
{
    public partial class CharacterPanel : Component
    {
        public CharacterPanel()
        {
            InitializeComponent();
        }

        public CharacterPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}
