using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EB0SaveEditor
{
    public partial class Form1 : Form
    {
        String fName = "EarthboundZeroEdit.sav";

        public Form1()
        {
            InitializeComponent();

            byte[] fileBytes = File.ReadAllBytes(fName);

            string name = Functions.readString(fileBytes, 0x1420, 0x1430);
            int money = Functions.readValue(fileBytes, 0x1410, 0x1411);
            int bank = Functions.readValue(fileBytes, 0x1412, 0x1414);
            Console.WriteLine("Hello, {0}!", name);
            Console.WriteLine("You have ${0} on you.", money);
            Console.WriteLine("You have ${0} in the bank.", bank);
        }
    }
}
