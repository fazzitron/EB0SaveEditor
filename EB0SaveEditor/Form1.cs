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

using EB0SaveEditor.Characters;

namespace EB0SaveEditor
{
    public partial class Form1 : Form
    {
        String fName = "EarthboundZeroEdit.sav";

        public Form1()
        {
            InitializeComponent();
            Constants.itemDictBuilder();

            tabControl.Controls.Remove(TemplateTab);

            NintenTab nt = new NintenTab();
            AnaTab at = new AnaTab();
            LoidTab lt = new LoidTab();
            TeddyTab tt = new TeddyTab();
            PippiTab pt = new PippiTab();
            EveTab et = new EveTab();
            FlyingTab ft = new FlyingTab();
            tabControl.Controls.Add(nt);
            tabControl.Controls.Add(at);
            tabControl.Controls.Add(lt);
            tabControl.Controls.Add(tt);
            tabControl.Controls.Add(pt);
            tabControl.Controls.Add(et);
            tabControl.Controls.Add(ft);

            nItem1.Items.AddRange(Constants.ITEM_DICT);
            nItem2.Items.AddRange(Constants.ITEM_DICT);
            nItem3.Items.AddRange(Constants.ITEM_DICT);
            nItem4.Items.AddRange(Constants.ITEM_DICT);
            nItem5.Items.AddRange(Constants.ITEM_DICT);
            nItem6.Items.AddRange(Constants.ITEM_DICT);
            nItem7.Items.AddRange(Constants.ITEM_DICT);
            nItem8.Items.AddRange(Constants.ITEM_DICT);

            byte[] fileBytes = File.ReadAllBytes(fName);

            string name = Functions.readMainName(fileBytes);
            string food = Functions.readString(fileBytes, Constants.FAV_FOOD[0], Constants.FAV_FOOD[1]);
            int money = Functions.readValue(fileBytes, 0x1410, 0x1411);
            int bank = Functions.readValue(fileBytes, 0x1412, 0x1414);
            Console.WriteLine("Hello, {0}!", name);
            Console.WriteLine("Your favorite food is {0}", food);
            Console.WriteLine("You have ${0} on you.", money);
            Console.WriteLine("You have ${0} in the bank.", bank);

            mName.Text = name;
            mFood.Text = food;
            mMoney.Value = money;
            mBank.Value = bank;

            //nName.Text = Functions.getName(fileBytes, Constants.NINTEN);
            //nMaxHP.Value = Functions.getStat(fileBytes, Constants.NINTEN, Constants.MAX_HP);
            //nMaxPP.Value = Functions.getStat(fileBytes, Constants.NINTEN, Constants.MAX_PP);
            //nCurHP.Value = Functions.getStat(fileBytes, Constants.NINTEN, Constants.CURRENT_HP);
            //nCurPP.Value = Functions.getStat(fileBytes, Constants.NINTEN, Constants.CURRENT_PP);
            //nOffense.Value = Functions.getStat(fileBytes, Constants.NINTEN, Constants.OFFENSE);
            //nDefense.Value = Functions.getStat(fileBytes, Constants.NINTEN, Constants.DEFENSE);
            //nFight.Value = Functions.getStat(fileBytes, Constants.NINTEN, Constants.FIGHT);
            //nSpeed.Value = Functions.getStat(fileBytes, Constants.NINTEN, Constants.SPEED);
            //nWisdom.Value = Functions.getStat(fileBytes, Constants.NINTEN, Constants.WISDOM);
            //nStrength.Value = Functions.getStat(fileBytes, Constants.NINTEN, Constants.STRENGTH);
            //nForce.Value = Functions.getStat(fileBytes, Constants.NINTEN, Constants.FORCE);
            //nLevel.Value = Functions.getStat(fileBytes, Constants.NINTEN, Constants.LEVEL);
            //nExp.Value = Functions.getStat(fileBytes, Constants.NINTEN, Constants.EXPERIENCE);

            //List<int> nItems = Functions.getItems(fileBytes, Constants.NINTEN);
            //nItem1.SelectedIndex = nItems[0];
            //nItem2.SelectedIndex = nItems[1];
            //nItem3.SelectedIndex = nItems[2];
            //nItem4.SelectedIndex = nItems[3];
            //nItem5.SelectedIndex = nItems[4];
            //nItem6.SelectedIndex = nItems[5];
            //nItem7.SelectedIndex = nItems[6];
            //nItem8.SelectedIndex = nItems[7];

            //int nStatus = Functions.getStat(fileBytes, Constants.NINTEN, Constants.STATUS);

            nt.initializeData(fileBytes);
            at.initializeData(fileBytes);
            lt.initializeData(fileBytes);
            tt.initializeData(fileBytes);
            pt.initializeData(fileBytes);
            et.initializeData(fileBytes);
            ft.initializeData(fileBytes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String message = "Currently in Alpha development.\n" +
                            "Requires a \"EarthboundZeroEdit.sav\" file in the executable directory to function.\n" +
                            "Does not yet export save files.\n" +
                            "Mostly hacked together from an old script while I was sick and home from work.";
            String caption = "About";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }
    }
}
