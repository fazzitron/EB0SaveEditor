using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EB0SaveEditor
{
    class CharacterTab : TabPage
    {
        private protected int CharacterID = 0;

        private protected System.Windows.Forms.Label nameLabel;
        private protected System.Windows.Forms.TextBox nameBox;

        private protected System.Windows.Forms.GroupBox spriteGroupBox;

        private protected System.Windows.Forms.GroupBox inventoryGroupBox;
        private protected System.Windows.Forms.ComboBox Item8;
        private protected System.Windows.Forms.ComboBox Item7;
        private protected System.Windows.Forms.ComboBox Item6;
        private protected System.Windows.Forms.ComboBox Item5;
        private protected System.Windows.Forms.ComboBox Item4;
        private protected System.Windows.Forms.ComboBox Item3;
        private protected System.Windows.Forms.ComboBox Item2;
        private protected System.Windows.Forms.ComboBox Item1;
        private protected System.Windows.Forms.Label item8Label;
        private protected System.Windows.Forms.Label item7Label;
        private protected System.Windows.Forms.Label item6Label;
        private protected System.Windows.Forms.Label item5Label;
        private protected System.Windows.Forms.Label item4Label;
        private protected System.Windows.Forms.Label item3Label;
        private protected System.Windows.Forms.Label item2Label;
        private protected System.Windows.Forms.Label item1Label;
        private protected System.Windows.Forms.GroupBox magicGroupBox;
        private protected System.Windows.Forms.GroupBox statGroupBox;
        private protected System.Windows.Forms.Label pendantLabel;
        private protected System.Windows.Forms.Label ringLabel;
        private protected System.Windows.Forms.Label coinLabel;
        private protected System.Windows.Forms.Label weaponLabel;
        private protected System.Windows.Forms.Label currentPPLabel;
        private protected System.Windows.Forms.Label currentHPLabel;
        private protected System.Windows.Forms.Label expLabel;
        private protected System.Windows.Forms.Label levelLabel;
        private protected System.Windows.Forms.Label forceLabel;
        private protected System.Windows.Forms.Label strengthLabel;
        private protected System.Windows.Forms.Label wisdomLabel;
        private protected System.Windows.Forms.Label speedLabel;
        private protected System.Windows.Forms.Label fightLabel;
        private protected System.Windows.Forms.Label defenseLabel;
        private protected System.Windows.Forms.Label offenseLabel;
        private protected System.Windows.Forms.Label maxPPLabel;
        private protected System.Windows.Forms.Label maxHPLabel;
        private protected System.Windows.Forms.GroupBox equipmentGroupBox;
        private protected System.Windows.Forms.ComboBox Pendant;
        private protected System.Windows.Forms.ComboBox Ring;
        private protected System.Windows.Forms.ComboBox Coin;
        private protected System.Windows.Forms.ComboBox Weapon;
        private protected System.Windows.Forms.PictureBox spritePictureBox;
        private protected System.Windows.Forms.Label rawMagicLabel;
        private protected System.Windows.Forms.NumericUpDown Exp;
        private protected System.Windows.Forms.NumericUpDown Level;
        private protected System.Windows.Forms.NumericUpDown Force;
        private protected System.Windows.Forms.NumericUpDown Strength;
        private protected System.Windows.Forms.NumericUpDown Wisdom;
        private protected System.Windows.Forms.NumericUpDown Speed;
        private protected System.Windows.Forms.NumericUpDown Fight;
        private protected System.Windows.Forms.NumericUpDown Defense;
        private protected System.Windows.Forms.NumericUpDown Offense;
        private protected System.Windows.Forms.NumericUpDown CurPP;
        private protected System.Windows.Forms.NumericUpDown MaxPP;
        private protected System.Windows.Forms.NumericUpDown CurHP;
        private protected System.Windows.Forms.NumericUpDown MaxHP;
        private protected System.Windows.Forms.CheckBox pkThunderGCheckbox;
        private protected System.Windows.Forms.CheckBox pkThunderBCheckbox;
        private protected System.Windows.Forms.CheckBox pkThunderACheckbox;
        private protected System.Windows.Forms.CheckBox pkBeamOCheckbox;
        private protected System.Windows.Forms.CheckBox pkBeamGCheckbox;
        private protected System.Windows.Forms.CheckBox pkBeamBCheckbox;
        private protected System.Windows.Forms.CheckBox pkBeamACheckbox;
        private protected System.Windows.Forms.CheckBox pkFreezeOCheckbox;
        private protected System.Windows.Forms.CheckBox pkFreezeGCheckbox;
        private protected System.Windows.Forms.CheckBox pkFreezeBCheckbox;
        private protected System.Windows.Forms.CheckBox pkFreezeACheckbox;
        private protected System.Windows.Forms.CheckBox fourDSlipCheckbox;
        private protected System.Windows.Forms.CheckBox defenseDownBCheckbox;
        private protected System.Windows.Forms.CheckBox defDownACheckbox;
        private protected System.Windows.Forms.CheckBox quickUpCheckbox;
        private protected System.Windows.Forms.CheckBox defenseUpBCheckbox;
        private protected System.Windows.Forms.CheckBox defenseUpACheckbox;
        private protected System.Windows.Forms.CheckBox offenseUpCheckbox;
        private protected System.Windows.Forms.CheckBox psiBlockCheckbox;
        private protected System.Windows.Forms.CheckBox shieldOffCheckbox;
        private protected System.Windows.Forms.CheckBox psiMagnetCheckbox;
        private protected System.Windows.Forms.CheckBox darknessCheckbox;
        private protected System.Windows.Forms.CheckBox paralysisCheckbox;
        private protected System.Windows.Forms.CheckBox hypnosisCheckbox;
        private protected System.Windows.Forms.CheckBox brainCyclonCheckbox;
        private protected System.Windows.Forms.CheckBox brainShockCheckbox;
        private protected System.Windows.Forms.CheckBox powerShieldCheckbox;
        private protected System.Windows.Forms.CheckBox psiShieldBCheckbox;
        private protected System.Windows.Forms.CheckBox psiShieldACheckbox;
        private protected System.Windows.Forms.CheckBox suprHealingCheckbox;
        private protected System.Windows.Forms.CheckBox healingPCheckbox;
        private protected System.Windows.Forms.CheckBox healingGCheckbox;
        private protected System.Windows.Forms.CheckBox healingBCheckbox;
        private protected System.Windows.Forms.CheckBox healingACheckbox;
        private protected System.Windows.Forms.CheckBox lifeupOCheckbox;
        private protected System.Windows.Forms.CheckBox lifeupPCheckbox;
        private protected System.Windows.Forms.CheckBox lifeupGCheckbox;
        private protected System.Windows.Forms.CheckBox lifeupBCheckbox;
        private protected System.Windows.Forms.CheckBox lifeupACheckbox;
        private protected System.Windows.Forms.CheckBox teleportCheckbox;
        private protected System.Windows.Forms.CheckBox telepathyCheckbox;
        private protected System.Windows.Forms.GroupBox statusGroupBox;
        private protected System.Windows.Forms.Label rawStatusLabel;
        private protected System.Windows.Forms.CheckBox faintdStatusCheckbox;
        private protected System.Windows.Forms.CheckBox stoneStatusCheckbox;
        private protected System.Windows.Forms.CheckBox paralysisStatusCheckbox;
        private protected System.Windows.Forms.CheckBox sleepStatusCheckbox;
        private protected System.Windows.Forms.CheckBox confusedStatusCheckbox;
        private protected System.Windows.Forms.CheckBox puzzledStatusCheckbox;
        private protected System.Windows.Forms.CheckBox poisonStatusCheckbox;
        private protected System.Windows.Forms.CheckBox coldStatusCheckbox;
        public CharacterTab() : base()
        {
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.rawStatusLabel = new System.Windows.Forms.Label();
            this.faintdStatusCheckbox = new System.Windows.Forms.CheckBox();
            this.stoneStatusCheckbox = new System.Windows.Forms.CheckBox();
            this.paralysisStatusCheckbox = new System.Windows.Forms.CheckBox();
            this.sleepStatusCheckbox = new System.Windows.Forms.CheckBox();
            this.confusedStatusCheckbox = new System.Windows.Forms.CheckBox();
            this.puzzledStatusCheckbox = new System.Windows.Forms.CheckBox();
            this.poisonStatusCheckbox = new System.Windows.Forms.CheckBox();
            this.coldStatusCheckbox = new System.Windows.Forms.CheckBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.equipmentGroupBox = new System.Windows.Forms.GroupBox();
            this.Pendant = new System.Windows.Forms.ComboBox();
            this.Ring = new System.Windows.Forms.ComboBox();
            this.Coin = new System.Windows.Forms.ComboBox();
            this.Weapon = new System.Windows.Forms.ComboBox();
            this.pendantLabel = new System.Windows.Forms.Label();
            this.weaponLabel = new System.Windows.Forms.Label();
            this.ringLabel = new System.Windows.Forms.Label();
            this.coinLabel = new System.Windows.Forms.Label();
            this.inventoryGroupBox = new System.Windows.Forms.GroupBox();
            this.Item8 = new System.Windows.Forms.ComboBox();
            this.Item7 = new System.Windows.Forms.ComboBox();
            this.Item6 = new System.Windows.Forms.ComboBox();
            this.Item5 = new System.Windows.Forms.ComboBox();
            this.Item4 = new System.Windows.Forms.ComboBox();
            this.Item3 = new System.Windows.Forms.ComboBox();
            this.Item2 = new System.Windows.Forms.ComboBox();
            this.item8Label = new System.Windows.Forms.Label();
            this.item7Label = new System.Windows.Forms.Label();
            this.item6Label = new System.Windows.Forms.Label();
            this.item5Label = new System.Windows.Forms.Label();
            this.item4Label = new System.Windows.Forms.Label();
            this.item3Label = new System.Windows.Forms.Label();
            this.item2Label = new System.Windows.Forms.Label();
            this.item1Label = new System.Windows.Forms.Label();
            this.Item1 = new System.Windows.Forms.ComboBox();
            this.magicGroupBox = new System.Windows.Forms.GroupBox();
            this.pkThunderGCheckbox = new System.Windows.Forms.CheckBox();
            this.pkThunderBCheckbox = new System.Windows.Forms.CheckBox();
            this.pkThunderACheckbox = new System.Windows.Forms.CheckBox();
            this.pkBeamOCheckbox = new System.Windows.Forms.CheckBox();
            this.pkBeamGCheckbox = new System.Windows.Forms.CheckBox();
            this.pkBeamBCheckbox = new System.Windows.Forms.CheckBox();
            this.pkBeamACheckbox = new System.Windows.Forms.CheckBox();
            this.pkFreezeOCheckbox = new System.Windows.Forms.CheckBox();
            this.pkFreezeGCheckbox = new System.Windows.Forms.CheckBox();
            this.pkFreezeBCheckbox = new System.Windows.Forms.CheckBox();
            this.pkFreezeACheckbox = new System.Windows.Forms.CheckBox();
            this.fourDSlipCheckbox = new System.Windows.Forms.CheckBox();
            this.defenseDownBCheckbox = new System.Windows.Forms.CheckBox();
            this.defDownACheckbox = new System.Windows.Forms.CheckBox();
            this.quickUpCheckbox = new System.Windows.Forms.CheckBox();
            this.defenseUpBCheckbox = new System.Windows.Forms.CheckBox();
            this.defenseUpACheckbox = new System.Windows.Forms.CheckBox();
            this.offenseUpCheckbox = new System.Windows.Forms.CheckBox();
            this.psiBlockCheckbox = new System.Windows.Forms.CheckBox();
            this.shieldOffCheckbox = new System.Windows.Forms.CheckBox();
            this.psiMagnetCheckbox = new System.Windows.Forms.CheckBox();
            this.darknessCheckbox = new System.Windows.Forms.CheckBox();
            this.paralysisCheckbox = new System.Windows.Forms.CheckBox();
            this.hypnosisCheckbox = new System.Windows.Forms.CheckBox();
            this.brainCyclonCheckbox = new System.Windows.Forms.CheckBox();
            this.brainShockCheckbox = new System.Windows.Forms.CheckBox();
            this.powerShieldCheckbox = new System.Windows.Forms.CheckBox();
            this.psiShieldBCheckbox = new System.Windows.Forms.CheckBox();
            this.psiShieldACheckbox = new System.Windows.Forms.CheckBox();
            this.suprHealingCheckbox = new System.Windows.Forms.CheckBox();
            this.healingPCheckbox = new System.Windows.Forms.CheckBox();
            this.healingGCheckbox = new System.Windows.Forms.CheckBox();
            this.healingBCheckbox = new System.Windows.Forms.CheckBox();
            this.healingACheckbox = new System.Windows.Forms.CheckBox();
            this.lifeupOCheckbox = new System.Windows.Forms.CheckBox();
            this.lifeupPCheckbox = new System.Windows.Forms.CheckBox();
            this.lifeupGCheckbox = new System.Windows.Forms.CheckBox();
            this.lifeupBCheckbox = new System.Windows.Forms.CheckBox();
            this.lifeupACheckbox = new System.Windows.Forms.CheckBox();
            this.teleportCheckbox = new System.Windows.Forms.CheckBox();
            this.telepathyCheckbox = new System.Windows.Forms.CheckBox();
            this.rawMagicLabel = new System.Windows.Forms.Label();
            this.statGroupBox = new System.Windows.Forms.GroupBox();
            this.Exp = new System.Windows.Forms.NumericUpDown();
            this.Level = new System.Windows.Forms.NumericUpDown();
            this.Force = new System.Windows.Forms.NumericUpDown();
            this.Strength = new System.Windows.Forms.NumericUpDown();
            this.expLabel = new System.Windows.Forms.Label();
            this.Wisdom = new System.Windows.Forms.NumericUpDown();
            this.Speed = new System.Windows.Forms.NumericUpDown();
            this.Fight = new System.Windows.Forms.NumericUpDown();
            this.Defense = new System.Windows.Forms.NumericUpDown();
            this.levelLabel = new System.Windows.Forms.Label();
            this.Offense = new System.Windows.Forms.NumericUpDown();
            this.CurPP = new System.Windows.Forms.NumericUpDown();
            this.MaxPP = new System.Windows.Forms.NumericUpDown();
            this.forceLabel = new System.Windows.Forms.Label();
            this.currentPPLabel = new System.Windows.Forms.Label();
            this.CurHP = new System.Windows.Forms.NumericUpDown();
            this.MaxHP = new System.Windows.Forms.NumericUpDown();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.currentHPLabel = new System.Windows.Forms.Label();
            this.maxPPLabel = new System.Windows.Forms.Label();
            this.maxHPLabel = new System.Windows.Forms.Label();
            this.wisdomLabel = new System.Windows.Forms.Label();
            this.offenseLabel = new System.Windows.Forms.Label();
            this.defenseLabel = new System.Windows.Forms.Label();
            this.fightLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.spriteGroupBox = new System.Windows.Forms.GroupBox();
            this.spritePictureBox = new System.Windows.Forms.PictureBox();


            this.BackColor = System.Drawing.Color.WhiteSmoke;

            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.equipmentGroupBox);
            this.Controls.Add(this.inventoryGroupBox);
            this.Controls.Add(this.magicGroupBox);
            this.Controls.Add(this.statGroupBox);
            this.Controls.Add(this.spriteGroupBox);
            this.Location = new System.Drawing.Point(4, 22);
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(824, 421);

            // 
            // spriteGroupBox
            // 
            this.spriteGroupBox.Controls.Add(this.spritePictureBox);
            this.spriteGroupBox.Location = new System.Drawing.Point(6, 6);
            this.spriteGroupBox.Name = "spriteGroupBox";
            this.spriteGroupBox.Size = new System.Drawing.Size(79, 90);
            this.spriteGroupBox.TabIndex = 0;
            this.spriteGroupBox.TabStop = false;
            this.spriteGroupBox.Text = "Sprite";

            // 
            // statGroupBox
            // 
            this.statGroupBox.Controls.Add(this.Exp);
            this.statGroupBox.Controls.Add(this.Level);
            this.statGroupBox.Controls.Add(this.Force);
            this.statGroupBox.Controls.Add(this.Strength);
            this.statGroupBox.Controls.Add(this.expLabel);
            this.statGroupBox.Controls.Add(this.Wisdom);
            this.statGroupBox.Controls.Add(this.Speed);
            this.statGroupBox.Controls.Add(this.Fight);
            this.statGroupBox.Controls.Add(this.Defense);
            this.statGroupBox.Controls.Add(this.levelLabel);
            this.statGroupBox.Controls.Add(this.Offense);
            this.statGroupBox.Controls.Add(this.CurPP);
            this.statGroupBox.Controls.Add(this.MaxPP);
            this.statGroupBox.Controls.Add(this.forceLabel);
            this.statGroupBox.Controls.Add(this.currentPPLabel);
            this.statGroupBox.Controls.Add(this.CurHP);
            this.statGroupBox.Controls.Add(this.MaxHP);
            this.statGroupBox.Controls.Add(this.strengthLabel);
            this.statGroupBox.Controls.Add(this.currentHPLabel);
            this.statGroupBox.Controls.Add(this.maxPPLabel);
            this.statGroupBox.Controls.Add(this.maxHPLabel);
            this.statGroupBox.Controls.Add(this.wisdomLabel);
            this.statGroupBox.Controls.Add(this.offenseLabel);
            this.statGroupBox.Controls.Add(this.defenseLabel);
            this.statGroupBox.Controls.Add(this.fightLabel);
            this.statGroupBox.Controls.Add(this.speedLabel);
            this.statGroupBox.Location = new System.Drawing.Point(6, 100);
            this.statGroupBox.Name = "statGroupBox";
            this.statGroupBox.Size = new System.Drawing.Size(201, 303);
            this.statGroupBox.TabIndex = 1;
            this.statGroupBox.TabStop = false;
            this.statGroupBox.Text = "Stats";
            // 
            // maxHPLabel
            // 
            this.maxHPLabel.AutoSize = true;
            this.maxHPLabel.Location = new System.Drawing.Point(4, 55);
            this.maxHPLabel.Name = "maxHPLabel";
            this.maxHPLabel.Size = new System.Drawing.Size(48, 13);
            this.maxHPLabel.TabIndex = 1;
            this.maxHPLabel.Text = "Max HP:";
            // 
            // maxPPLabel
            // 
            this.maxPPLabel.AutoSize = true;
            this.maxPPLabel.Location = new System.Drawing.Point(4, 94);
            this.maxPPLabel.Name = "maxPPLabel";
            this.maxPPLabel.Size = new System.Drawing.Size(47, 13);
            this.maxPPLabel.TabIndex = 2;
            this.maxPPLabel.Text = "Max PP:";
            // 
            // offenseLabel
            // 
            this.offenseLabel.AutoSize = true;
            this.offenseLabel.Location = new System.Drawing.Point(4, 134);
            this.offenseLabel.Name = "offenseLabel";
            this.offenseLabel.Size = new System.Drawing.Size(47, 13);
            this.offenseLabel.TabIndex = 3;
            this.offenseLabel.Text = "Offense:";
            // 
            // defenseLabel
            // 
            this.defenseLabel.AutoSize = true;
            this.defenseLabel.Location = new System.Drawing.Point(103, 134);
            this.defenseLabel.Name = "defenseLabel";
            this.defenseLabel.Size = new System.Drawing.Size(50, 13);
            this.defenseLabel.TabIndex = 4;
            this.defenseLabel.Text = "Defense:";
            // 
            // fightLabel
            // 
            this.fightLabel.AutoSize = true;
            this.fightLabel.Location = new System.Drawing.Point(4, 174);
            this.fightLabel.Name = "fightLabel";
            this.fightLabel.Size = new System.Drawing.Size(33, 13);
            this.fightLabel.TabIndex = 5;
            this.fightLabel.Text = "Fight:";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(103, 174);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(41, 13);
            this.speedLabel.TabIndex = 6;
            this.speedLabel.Text = "Speed:";
            // 
            // wisdomLabel
            // 
            this.wisdomLabel.AutoSize = true;
            this.wisdomLabel.Location = new System.Drawing.Point(4, 217);
            this.wisdomLabel.Name = "wisdomLabel";
            this.wisdomLabel.Size = new System.Drawing.Size(48, 13);
            this.wisdomLabel.TabIndex = 7;
            this.wisdomLabel.Text = "Wisdom:";
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Location = new System.Drawing.Point(103, 217);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(50, 13);
            this.strengthLabel.TabIndex = 8;
            this.strengthLabel.Text = "Strength:";
            // 
            // forceLabel
            // 
            this.forceLabel.AutoSize = true;
            this.forceLabel.Location = new System.Drawing.Point(4, 257);
            this.forceLabel.Name = "forceLabel";
            this.forceLabel.Size = new System.Drawing.Size(37, 13);
            this.forceLabel.TabIndex = 9;
            this.forceLabel.Text = "Force:";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(6, 16);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(36, 13);
            this.levelLabel.TabIndex = 10;
            this.levelLabel.Text = "Level:";
            // 
            // expLabel
            // 
            this.expLabel.AutoSize = true;
            this.expLabel.Location = new System.Drawing.Point(103, 16);
            this.expLabel.Name = "expLabel";
            this.expLabel.Size = new System.Drawing.Size(63, 13);
            this.expLabel.TabIndex = 11;
            this.expLabel.Text = "Experience:";
            // 
            // currentHPLabel
            // 
            this.currentHPLabel.AutoSize = true;
            this.currentHPLabel.Location = new System.Drawing.Point(103, 55);
            this.currentHPLabel.Name = "currentHPLabel";
            this.currentHPLabel.Size = new System.Drawing.Size(62, 13);
            this.currentHPLabel.TabIndex = 12;
            this.currentHPLabel.Text = "Current HP:";
            // 
            // currentPPLabel
            // 
            this.currentPPLabel.AutoSize = true;
            this.currentPPLabel.Location = new System.Drawing.Point(103, 94);
            this.currentPPLabel.Name = "currentPPLabel";
            this.currentPPLabel.Size = new System.Drawing.Size(61, 13);
            this.currentPPLabel.TabIndex = 13;
            this.currentPPLabel.Text = "Current PP:";
            // 
            // weaponLabel
            // 
            this.weaponLabel.AutoSize = true;
            this.weaponLabel.Location = new System.Drawing.Point(6, 18);
            this.weaponLabel.Name = "weaponLabel";
            this.weaponLabel.Size = new System.Drawing.Size(51, 13);
            this.weaponLabel.TabIndex = 14;
            this.weaponLabel.Text = "Weapon:";
            // 
            // coinLabel
            // 
            this.coinLabel.AutoSize = true;
            this.coinLabel.Location = new System.Drawing.Point(6, 60);
            this.coinLabel.Name = "coinLabel";
            this.coinLabel.Size = new System.Drawing.Size(31, 13);
            this.coinLabel.TabIndex = 15;
            this.coinLabel.Text = "Coin:";
            // 
            // ringLabel
            // 
            this.ringLabel.AutoSize = true;
            this.ringLabel.Location = new System.Drawing.Point(6, 102);
            this.ringLabel.Name = "ringLabel";
            this.ringLabel.Size = new System.Drawing.Size(32, 13);
            this.ringLabel.TabIndex = 16;
            this.ringLabel.Text = "Ring:";
            // 
            // pendantLabel
            // 
            this.pendantLabel.AutoSize = true;
            this.pendantLabel.Location = new System.Drawing.Point(6, 143);
            this.pendantLabel.Name = "pendantLabel";
            this.pendantLabel.Size = new System.Drawing.Size(50, 13);
            this.pendantLabel.TabIndex = 17;
            this.pendantLabel.Text = "Pendant:";
            // 
            // magicGroupBox
            // 
            this.magicGroupBox.Controls.Add(this.pkThunderGCheckbox);
            this.magicGroupBox.Controls.Add(this.pkThunderBCheckbox);
            this.magicGroupBox.Controls.Add(this.pkThunderACheckbox);
            this.magicGroupBox.Controls.Add(this.pkBeamOCheckbox);
            this.magicGroupBox.Controls.Add(this.pkBeamGCheckbox);
            this.magicGroupBox.Controls.Add(this.pkBeamBCheckbox);
            this.magicGroupBox.Controls.Add(this.pkBeamACheckbox);
            this.magicGroupBox.Controls.Add(this.pkFreezeOCheckbox);
            this.magicGroupBox.Controls.Add(this.pkFreezeGCheckbox);
            this.magicGroupBox.Controls.Add(this.pkFreezeBCheckbox);
            this.magicGroupBox.Controls.Add(this.pkFreezeACheckbox);
            this.magicGroupBox.Controls.Add(this.fourDSlipCheckbox);
            this.magicGroupBox.Controls.Add(this.defenseDownBCheckbox);
            this.magicGroupBox.Controls.Add(this.defDownACheckbox);
            this.magicGroupBox.Controls.Add(this.quickUpCheckbox);
            this.magicGroupBox.Controls.Add(this.defenseUpBCheckbox);
            this.magicGroupBox.Controls.Add(this.defenseUpACheckbox);
            this.magicGroupBox.Controls.Add(this.offenseUpCheckbox);
            this.magicGroupBox.Controls.Add(this.psiBlockCheckbox);
            this.magicGroupBox.Controls.Add(this.shieldOffCheckbox);
            this.magicGroupBox.Controls.Add(this.psiMagnetCheckbox);
            this.magicGroupBox.Controls.Add(this.darknessCheckbox);
            this.magicGroupBox.Controls.Add(this.paralysisCheckbox);
            this.magicGroupBox.Controls.Add(this.hypnosisCheckbox);
            this.magicGroupBox.Controls.Add(this.brainCyclonCheckbox);
            this.magicGroupBox.Controls.Add(this.brainShockCheckbox);
            this.magicGroupBox.Controls.Add(this.powerShieldCheckbox);
            this.magicGroupBox.Controls.Add(this.psiShieldBCheckbox);
            this.magicGroupBox.Controls.Add(this.psiShieldACheckbox);
            this.magicGroupBox.Controls.Add(this.suprHealingCheckbox);
            this.magicGroupBox.Controls.Add(this.healingPCheckbox);
            this.magicGroupBox.Controls.Add(this.healingGCheckbox);
            this.magicGroupBox.Controls.Add(this.healingBCheckbox);
            this.magicGroupBox.Controls.Add(this.healingACheckbox);
            this.magicGroupBox.Controls.Add(this.lifeupOCheckbox);
            this.magicGroupBox.Controls.Add(this.lifeupPCheckbox);
            this.magicGroupBox.Controls.Add(this.lifeupGCheckbox);
            this.magicGroupBox.Controls.Add(this.lifeupBCheckbox);
            this.magicGroupBox.Controls.Add(this.lifeupACheckbox);
            this.magicGroupBox.Controls.Add(this.teleportCheckbox);
            this.magicGroupBox.Controls.Add(this.telepathyCheckbox);
            this.magicGroupBox.Controls.Add(this.rawMagicLabel);
            this.magicGroupBox.Location = new System.Drawing.Point(213, 6);
            this.magicGroupBox.Name = "magicGroupBox";
            this.magicGroupBox.Size = new System.Drawing.Size(600, 194);
            this.magicGroupBox.TabIndex = 2;
            this.magicGroupBox.TabStop = false;
            this.magicGroupBox.Text = "Magic";
            // 
            // inventoryGroupBox
            // 
            this.inventoryGroupBox.Controls.Add(this.Item8);
            this.inventoryGroupBox.Controls.Add(this.Item7);
            this.inventoryGroupBox.Controls.Add(this.Item6);
            this.inventoryGroupBox.Controls.Add(this.Item5);
            this.inventoryGroupBox.Controls.Add(this.Item4);
            this.inventoryGroupBox.Controls.Add(this.Item3);
            this.inventoryGroupBox.Controls.Add(this.Item2);
            this.inventoryGroupBox.Controls.Add(this.item8Label);
            this.inventoryGroupBox.Controls.Add(this.item7Label);
            this.inventoryGroupBox.Controls.Add(this.item6Label);
            this.inventoryGroupBox.Controls.Add(this.item5Label);
            this.inventoryGroupBox.Controls.Add(this.item4Label);
            this.inventoryGroupBox.Controls.Add(this.item3Label);
            this.inventoryGroupBox.Controls.Add(this.item2Label);
            this.inventoryGroupBox.Controls.Add(this.item1Label);
            this.inventoryGroupBox.Controls.Add(this.Item1);
            this.inventoryGroupBox.Location = new System.Drawing.Point(462, 206);
            this.inventoryGroupBox.Name = "inventoryGroupBox";
            this.inventoryGroupBox.Size = new System.Drawing.Size(351, 197);
            this.inventoryGroupBox.TabIndex = 3;
            this.inventoryGroupBox.TabStop = false;
            this.inventoryGroupBox.Text = "Inventory";
            // 
            // Item1
            // 
            this.Item1.FormattingEnabled = true;
            this.Item1.Location = new System.Drawing.Point(11, 35);
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(154, 21);
            this.Item1.TabIndex = 0;
            // 
            // item1Label
            // 
            this.item1Label.AutoSize = true;
            this.item1Label.Location = new System.Drawing.Point(9, 18);
            this.item1Label.Name = "item1Label";
            this.item1Label.Size = new System.Drawing.Size(44, 13);
            this.item1Label.TabIndex = 1;
            this.item1Label.Text = "Slot #1:";
            // 
            // item2Label
            // 
            this.item2Label.AutoSize = true;
            this.item2Label.Location = new System.Drawing.Point(184, 18);
            this.item2Label.Name = "item2Label";
            this.item2Label.Size = new System.Drawing.Size(44, 13);
            this.item2Label.TabIndex = 2;
            this.item2Label.Text = "Slot #2:";
            // 
            // item3Label
            // 
            this.item3Label.AutoSize = true;
            this.item3Label.Location = new System.Drawing.Point(9, 62);
            this.item3Label.Name = "item3Label";
            this.item3Label.Size = new System.Drawing.Size(44, 13);
            this.item3Label.TabIndex = 3;
            this.item3Label.Text = "Slot #3:";
            // 
            // item4Label
            // 
            this.item4Label.AutoSize = true;
            this.item4Label.Location = new System.Drawing.Point(184, 61);
            this.item4Label.Name = "item4Label";
            this.item4Label.Size = new System.Drawing.Size(44, 13);
            this.item4Label.TabIndex = 4;
            this.item4Label.Text = "Slot #4:";
            // 
            // item5Label
            // 
            this.item5Label.AutoSize = true;
            this.item5Label.Location = new System.Drawing.Point(9, 104);
            this.item5Label.Name = "item5Label";
            this.item5Label.Size = new System.Drawing.Size(44, 13);
            this.item5Label.TabIndex = 5;
            this.item5Label.Text = "Slot #5:";
            // 
            // item6Label
            // 
            this.item6Label.AutoSize = true;
            this.item6Label.Location = new System.Drawing.Point(184, 103);
            this.item6Label.Name = "item6Label";
            this.item6Label.Size = new System.Drawing.Size(44, 13);
            this.item6Label.TabIndex = 6;
            this.item6Label.Text = "Slot #6:";
            // 
            // item7Label
            // 
            this.item7Label.AutoSize = true;
            this.item7Label.Location = new System.Drawing.Point(9, 145);
            this.item7Label.Name = "item7Label";
            this.item7Label.Size = new System.Drawing.Size(44, 13);
            this.item7Label.TabIndex = 7;
            this.item7Label.Text = "Slot #7:";
            // 
            // item8Label
            // 
            this.item8Label.AutoSize = true;
            this.item8Label.Location = new System.Drawing.Point(184, 144);
            this.item8Label.Name = "item8Label";
            this.item8Label.Size = new System.Drawing.Size(44, 13);
            this.item8Label.TabIndex = 8;
            this.item8Label.Text = "Slot #8:";
            // 
            // Item2
            // 
            this.Item2.FormattingEnabled = true;
            this.Item2.Location = new System.Drawing.Point(187, 35);
            this.Item2.Name = "nItem2";
            this.Item2.Size = new System.Drawing.Size(154, 21);
            this.Item2.TabIndex = 9;
            // 
            // Item3
            // 
            this.Item3.FormattingEnabled = true;
            this.Item3.Location = new System.Drawing.Point(11, 78);
            this.Item3.Name = "nItem3";
            this.Item3.Size = new System.Drawing.Size(154, 21);
            this.Item3.TabIndex = 10;
            // 
            // Item4
            // 
            this.Item4.FormattingEnabled = true;
            this.Item4.Location = new System.Drawing.Point(187, 78);
            this.Item4.Name = "nItem4";
            this.Item4.Size = new System.Drawing.Size(154, 21);
            this.Item4.TabIndex = 11;
            // 
            // Item5
            // 
            this.Item5.FormattingEnabled = true;
            this.Item5.Location = new System.Drawing.Point(11, 120);
            this.Item5.Name = "nItem5";
            this.Item5.Size = new System.Drawing.Size(154, 21);
            this.Item5.TabIndex = 12;
            // 
            // Item6
            // 
            this.Item6.FormattingEnabled = true;
            this.Item6.Location = new System.Drawing.Point(187, 120);
            this.Item6.Name = "nItem6";
            this.Item6.Size = new System.Drawing.Size(154, 21);
            this.Item6.TabIndex = 13;
            // 
            // Item7
            // 
            this.Item7.FormattingEnabled = true;
            this.Item7.Location = new System.Drawing.Point(11, 161);
            this.Item7.Name = "nItem7";
            this.Item7.Size = new System.Drawing.Size(154, 21);
            this.Item7.TabIndex = 14;
            // 
            // Item8
            // 
            this.Item8.FormattingEnabled = true;
            this.Item8.Location = new System.Drawing.Point(187, 161);
            this.Item8.Name = "nItem8";
            this.Item8.Size = new System.Drawing.Size(154, 21);
            this.Item8.TabIndex = 15;
            // 
            // equipmentGroupBox
            // 
            this.equipmentGroupBox.Controls.Add(this.Pendant);
            this.equipmentGroupBox.Controls.Add(this.Ring);
            this.equipmentGroupBox.Controls.Add(this.Coin);
            this.equipmentGroupBox.Controls.Add(this.Weapon);
            this.equipmentGroupBox.Controls.Add(this.pendantLabel);
            this.equipmentGroupBox.Controls.Add(this.weaponLabel);
            this.equipmentGroupBox.Controls.Add(this.ringLabel);
            this.equipmentGroupBox.Controls.Add(this.coinLabel);
            this.equipmentGroupBox.Location = new System.Drawing.Point(314, 206);
            this.equipmentGroupBox.Name = "equipmentGroupBox";
            this.equipmentGroupBox.Size = new System.Drawing.Size(142, 197);
            this.equipmentGroupBox.TabIndex = 4;
            this.equipmentGroupBox.TabStop = false;
            this.equipmentGroupBox.Text = "Equipment";
            // 
            // Weapon
            // 
            this.Weapon.FormattingEnabled = true;
            this.Weapon.Items.AddRange(new object[] {
                "Butter Knife",
                "Surv. Knife",
                "Sword",
                "Katana",
                "Stun Gun",
                "Air Gun",
                "Plastic Bat",
                "Wood Bat",
                "Alum. Bat",
                "Hank\'s Bat",
                "Frying Pan",
                "Nonstick Pan",
                "Iron Skillet",
                "Slingshot",
                "Boomerang"
            });
            this.Weapon.Location = new System.Drawing.Point(9, 35);
            this.Weapon.Name = "nWeapon";
            this.Weapon.Size = new System.Drawing.Size(121, 21);
            this.Weapon.TabIndex = 18;
            // 
            // Coin
            // 
            this.Coin.FormattingEnabled = true;
            this.Coin.Items.AddRange(new object[] {
                "Peace Coin",
                "Protect Coin",
                "Magic Coin"
            });
            this.Coin.Location = new System.Drawing.Point(9, 77);
            this.Coin.Name = "nCoin";
            this.Coin.Size = new System.Drawing.Size(121, 21);
            this.Coin.TabIndex = 19;
            // 
            // Ring
            // 
            this.Ring.FormattingEnabled = true;
            this.Ring.Items.AddRange(new object[] {
                "Repel Ring",
                "Brass Ring",
                "Silver Ring",
                "Gold Ring"
            });
            this.Ring.Location = new System.Drawing.Point(9, 119);
            this.Ring.Name = "nRing";
            this.Ring.Size = new System.Drawing.Size(121, 21);
            this.Ring.TabIndex = 20;
            // 
            // Pendant
            // 
            this.Pendant.FormattingEnabled = true;
            this.Pendant.Items.AddRange(new object[] {
                "H2O Pendant",
                "Fire Pendant",
                "Earth Pendant",
                "Sea Pendant"
            });
            this.Pendant.Location = new System.Drawing.Point(9, 160);
            this.Pendant.Name = "nPendant";
            this.Pendant.Size = new System.Drawing.Size(121, 21);
            this.Pendant.TabIndex = 21;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(91, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name:";
            // 
            // Name
            // 
            this.nameBox.Location = new System.Drawing.Point(94, 46);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 6;
            // 
            // MaxHP
            // 
            this.MaxHP.Location = new System.Drawing.Point(7, 71);
            this.MaxHP.Maximum = new decimal(new int[] {
                65535,
                0,
                0,
                0
            });
            this.MaxHP.Name = "MaxHP";
            this.MaxHP.Size = new System.Drawing.Size(77, 20);
            this.MaxHP.TabIndex = 14;
            // 
            // CurHP
            // 
            this.CurHP.Location = new System.Drawing.Point(106, 71);
            this.CurHP.Maximum = new decimal(new int[] {
                65535,
                0,
                0,
                0
            });
            this.CurHP.Name = "CurHP";
            this.CurHP.Size = new System.Drawing.Size(79, 20);
            this.CurHP.TabIndex = 16;
            // 
            // MaxPP
            // 
            this.MaxPP.Location = new System.Drawing.Point(7, 111);
            this.MaxPP.Maximum = new decimal(new int[] {
                65535,
                0,
                0,
                0
            });
            this.MaxPP.Name = "MaxPP";
            this.MaxPP.Size = new System.Drawing.Size(77, 20);
            this.MaxPP.TabIndex = 17;
            // 
            // CurPP
            // 
            this.CurPP.Location = new System.Drawing.Point(106, 111);
            this.CurPP.Maximum = new decimal(new int[] {
                65535,
                0,
                0,
                0
            });
            this.CurPP.Name = "CurPP";
            this.CurPP.Size = new System.Drawing.Size(81, 20);
            this.CurPP.TabIndex = 18;
            // 
            // nOffense
            // 
            this.Offense.Location = new System.Drawing.Point(7, 151);
            this.Offense.Maximum = new decimal(new int[] {
                65535,
                0,
                0,
                0
            });
            this.Offense.Name = "Offense";
            this.Offense.Size = new System.Drawing.Size(77, 20);
            this.Offense.TabIndex = 19;
            // 
            // Defense
            // 
            this.Defense.Location = new System.Drawing.Point(106, 151);
            this.Defense.Maximum = new decimal(new int[] {
                65535,
                0,
                0,
                0
            });
            this.Defense.Name = "Defense";
            this.Defense.Size = new System.Drawing.Size(81, 20);
            this.Defense.TabIndex = 20;
            // 
            // Fight
            // 
            this.Fight.Location = new System.Drawing.Point(7, 191);
            this.Fight.Maximum = new decimal(new int[] {
                255,
                0,
                0,
                0
            });
            this.Fight.Name = "Fight";
            this.Fight.Size = new System.Drawing.Size(77, 20);
            this.Fight.TabIndex = 21;
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(106, 190);
            this.Speed.Maximum = new decimal(new int[] {
                255,
                0,
                0,
                0
            });
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(81, 20);
            this.Speed.TabIndex = 22;
            // 
            // Wisdom
            // 
            this.Wisdom.Location = new System.Drawing.Point(7, 234);
            this.Wisdom.Maximum = new decimal(new int[] {
                255,
                0,
                0,
                0
            });
            this.Wisdom.Name = "Wisdom";
            this.Wisdom.Size = new System.Drawing.Size(77, 20);
            this.Wisdom.TabIndex = 23;
            // 
            // Strength
            // 
            this.Strength.Location = new System.Drawing.Point(106, 234);
            this.Strength.Maximum = new decimal(new int[] {
                255,
                0,
                0,
                0
            });
            this.Strength.Name = "Strength";
            this.Strength.Size = new System.Drawing.Size(81, 20);
            this.Strength.TabIndex = 24;
            // 
            // Force
            // 
            this.Force.Location = new System.Drawing.Point(7, 274);
            this.Force.Maximum = new decimal(new int[] {
                65535,
                0,
                0,
                0
            });
            this.Force.Name = "Force";
            this.Force.Size = new System.Drawing.Size(77, 20);
            this.Force.TabIndex = 25;
            // 
            // nLevel
            // 
            this.Level.Location = new System.Drawing.Point(9, 32);
            this.Level.Maximum = new decimal(new int[] {
                255,
                0,
                0,
                0
            });
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(77, 20);
            this.Level.TabIndex = 26;
            // 
            // Exp
            // 
            this.Exp.Location = new System.Drawing.Point(106, 32);
            this.Exp.Maximum = new decimal(new int[] {
                0xFFFFFF,
                0,
                0,
                0
            });
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(81, 20);
            this.Exp.TabIndex = 27;
            // 
            // rawMagicLabel
            // 
            this.rawMagicLabel.AutoSize = true;
            this.rawMagicLabel.Location = new System.Drawing.Point(7, 20);
            this.rawMagicLabel.Name = "rawMagicLabel";
            this.rawMagicLabel.Size = new System.Drawing.Size(240, 13);
            this.rawMagicLabel.TabIndex = 0;
            this.rawMagicLabel.Text = "Raw: 0x00 0x00 0x00 0x00 0x00 0x00 0x00 0x00";
            // 
            // telepathyCheckbox
            // 
            this.telepathyCheckbox.AutoSize = true;
            this.telepathyCheckbox.Location = new System.Drawing.Point(10, 43);
            this.telepathyCheckbox.Name = "telepathyCheckbox";
            this.telepathyCheckbox.Size = new System.Drawing.Size(73, 17);
            this.telepathyCheckbox.TabIndex = 43;
            this.telepathyCheckbox.Text = "Telepathy";
            this.telepathyCheckbox.UseVisualStyleBackColor = true;
            // 
            // teleportCheckbox
            // 
            this.teleportCheckbox.AutoSize = true;
            this.teleportCheckbox.Location = new System.Drawing.Point(10, 63);
            this.teleportCheckbox.Name = "teleportCheckbox";
            this.teleportCheckbox.Size = new System.Drawing.Size(65, 17);
            this.teleportCheckbox.TabIndex = 44;
            this.teleportCheckbox.Text = "Teleport";
            this.teleportCheckbox.UseVisualStyleBackColor = true;
            // 
            // lifeupACheckbox
            // 
            this.lifeupACheckbox.AutoSize = true;
            this.lifeupACheckbox.Location = new System.Drawing.Point(10, 83);
            this.lifeupACheckbox.Name = "lifeupACheckbox";
            this.lifeupACheckbox.Size = new System.Drawing.Size(67, 17);
            this.lifeupACheckbox.TabIndex = 45;
            this.lifeupACheckbox.Text = "LifeUp α";
            this.lifeupACheckbox.UseVisualStyleBackColor = true;
            // 
            // lifeupBCheckbox
            // 
            this.lifeupBCheckbox.AutoSize = true;
            this.lifeupBCheckbox.Location = new System.Drawing.Point(10, 103);
            this.lifeupBCheckbox.Name = "lifeupBCheckbox";
            this.lifeupBCheckbox.Size = new System.Drawing.Size(66, 17);
            this.lifeupBCheckbox.TabIndex = 46;
            this.lifeupBCheckbox.Text = "LifeUp β";
            this.lifeupBCheckbox.UseVisualStyleBackColor = true;
            // 
            // lifeupGCheckbox
            // 
            this.lifeupGCheckbox.AutoSize = true;
            this.lifeupGCheckbox.Location = new System.Drawing.Point(10, 123);
            this.lifeupGCheckbox.Name = "lifeupGCheckbox";
            this.lifeupGCheckbox.Size = new System.Drawing.Size(66, 17);
            this.lifeupGCheckbox.TabIndex = 47;
            this.lifeupGCheckbox.Text = "LifeUp γ";
            this.lifeupGCheckbox.UseVisualStyleBackColor = true;
            // 
            // lifeupPCheckbox
            // 
            this.lifeupPCheckbox.AutoSize = true;
            this.lifeupPCheckbox.Location = new System.Drawing.Point(10, 143);
            this.lifeupPCheckbox.Name = "lifeupPCheckbox";
            this.lifeupPCheckbox.Size = new System.Drawing.Size(66, 17);
            this.lifeupPCheckbox.TabIndex = 48;
            this.lifeupPCheckbox.Text = "LifeUp π";
            this.lifeupPCheckbox.UseVisualStyleBackColor = true;
            // 
            // lifeupOCheckbox
            // 
            this.lifeupOCheckbox.AutoSize = true;
            this.lifeupOCheckbox.Location = new System.Drawing.Point(10, 163);
            this.lifeupOCheckbox.Name = "lifeupOCheckbox";
            this.lifeupOCheckbox.Size = new System.Drawing.Size(69, 17);
            this.lifeupOCheckbox.TabIndex = 49;
            this.lifeupOCheckbox.Text = "LifeUp Ω";
            this.lifeupOCheckbox.UseVisualStyleBackColor = true;
            // 
            // healingACheckbox
            // 
            this.healingACheckbox.AutoSize = true;
            this.healingACheckbox.Location = new System.Drawing.Point(89, 43);
            this.healingACheckbox.Name = "healingACheckbox";
            this.healingACheckbox.Size = new System.Drawing.Size(75, 17);
            this.healingACheckbox.TabIndex = 50;
            this.healingACheckbox.Text = "Healing α:";
            this.healingACheckbox.UseVisualStyleBackColor = true;
            // 
            // healingBCheckbox
            // 
            this.healingBCheckbox.AutoSize = true;
            this.healingBCheckbox.Location = new System.Drawing.Point(89, 63);
            this.healingBCheckbox.Name = "healingBCheckbox";
            this.healingBCheckbox.Size = new System.Drawing.Size(74, 17);
            this.healingBCheckbox.TabIndex = 51;
            this.healingBCheckbox.Text = "Healing β:";
            this.healingBCheckbox.UseVisualStyleBackColor = true;
            // 
            // healingGCheckbox
            // 
            this.healingGCheckbox.AutoSize = true;
            this.healingGCheckbox.Location = new System.Drawing.Point(89, 83);
            this.healingGCheckbox.Name = "healingGCheckbox";
            this.healingGCheckbox.Size = new System.Drawing.Size(74, 17);
            this.healingGCheckbox.TabIndex = 52;
            this.healingGCheckbox.Text = "Healing γ:";
            this.healingGCheckbox.UseVisualStyleBackColor = true;
            // 
            // healingPCheckbox
            // 
            this.healingPCheckbox.AutoSize = true;
            this.healingPCheckbox.Location = new System.Drawing.Point(89, 103);
            this.healingPCheckbox.Name = "healingPCheckbox";
            this.healingPCheckbox.Size = new System.Drawing.Size(74, 17);
            this.healingPCheckbox.TabIndex = 53;
            this.healingPCheckbox.Text = "Healing π:";
            this.healingPCheckbox.UseVisualStyleBackColor = true;
            // 
            // suprHealingCheckbox
            // 
            this.suprHealingCheckbox.AutoSize = true;
            this.suprHealingCheckbox.Location = new System.Drawing.Point(89, 123);
            this.suprHealingCheckbox.Name = "suprHealingCheckbox";
            this.suprHealingCheckbox.Size = new System.Drawing.Size(84, 17);
            this.suprHealingCheckbox.TabIndex = 54;
            this.suprHealingCheckbox.Text = "SuprHealing";
            this.suprHealingCheckbox.UseVisualStyleBackColor = true;
            // 
            // psiShieldACheckbox
            // 
            this.psiShieldACheckbox.AutoSize = true;
            this.psiShieldACheckbox.Location = new System.Drawing.Point(89, 143);
            this.psiShieldACheckbox.Name = "psiShieldACheckbox";
            this.psiShieldACheckbox.Size = new System.Drawing.Size(88, 17);
            this.psiShieldACheckbox.TabIndex = 55;
            this.psiShieldACheckbox.Text = "PSI Shield α:";
            this.psiShieldACheckbox.UseVisualStyleBackColor = true;
            // 
            // psiShieldBCheckbox
            // 
            this.psiShieldBCheckbox.AutoSize = true;
            this.psiShieldBCheckbox.Location = new System.Drawing.Point(89, 163);
            this.psiShieldBCheckbox.Name = "psiShieldBCheckbox";
            this.psiShieldBCheckbox.Size = new System.Drawing.Size(87, 17);
            this.psiShieldBCheckbox.TabIndex = 56;
            this.psiShieldBCheckbox.Text = "PSI Shield β:";
            this.psiShieldBCheckbox.UseVisualStyleBackColor = true;
            // 
            // powerShieldCheckbox
            // 
            this.powerShieldCheckbox.AutoSize = true;
            this.powerShieldCheckbox.Location = new System.Drawing.Point(184, 43);
            this.powerShieldCheckbox.Name = "powerShieldCheckbox";
            this.powerShieldCheckbox.Size = new System.Drawing.Size(88, 17);
            this.powerShieldCheckbox.TabIndex = 57;
            this.powerShieldCheckbox.Text = "PowerShield:";
            this.powerShieldCheckbox.UseVisualStyleBackColor = true;
            // 
            // brainShockCheckbox
            // 
            this.brainShockCheckbox.AutoSize = true;
            this.brainShockCheckbox.Location = new System.Drawing.Point(184, 63);
            this.brainShockCheckbox.Name = "brainShockCheckbox";
            this.brainShockCheckbox.Size = new System.Drawing.Size(84, 17);
            this.brainShockCheckbox.TabIndex = 58;
            this.brainShockCheckbox.Text = "BrainShock:";
            this.brainShockCheckbox.UseVisualStyleBackColor = true;
            // 
            // brainCyclonCheckbox
            // 
            this.brainCyclonCheckbox.AutoSize = true;
            this.brainCyclonCheckbox.Location = new System.Drawing.Point(184, 83);
            this.brainCyclonCheckbox.Name = "brainCyclonCheckbox";
            this.brainCyclonCheckbox.Size = new System.Drawing.Size(85, 17);
            this.brainCyclonCheckbox.TabIndex = 59;
            this.brainCyclonCheckbox.Text = "BrainCyclon:";
            this.brainCyclonCheckbox.UseVisualStyleBackColor = true;
            // 
            // hypnosisCheckbox
            // 
            this.hypnosisCheckbox.AutoSize = true;
            this.hypnosisCheckbox.Location = new System.Drawing.Point(184, 103);
            this.hypnosisCheckbox.Name = "hypnosisCheckbox";
            this.hypnosisCheckbox.Size = new System.Drawing.Size(72, 17);
            this.hypnosisCheckbox.TabIndex = 60;
            this.hypnosisCheckbox.Text = "Hypnosis:";
            this.hypnosisCheckbox.UseVisualStyleBackColor = true;
            // 
            // paralysisCheckbox
            // 
            this.paralysisCheckbox.AutoSize = true;
            this.paralysisCheckbox.Location = new System.Drawing.Point(184, 123);
            this.paralysisCheckbox.Name = "paralysisCheckbox";
            this.paralysisCheckbox.Size = new System.Drawing.Size(70, 17);
            this.paralysisCheckbox.TabIndex = 61;
            this.paralysisCheckbox.Text = "Paralysis:";
            this.paralysisCheckbox.UseVisualStyleBackColor = true;
            // 
            // darknessCheckbox
            // 
            this.darknessCheckbox.AutoSize = true;
            this.darknessCheckbox.Location = new System.Drawing.Point(184, 144);
            this.darknessCheckbox.Name = "darknessCheckbox";
            this.darknessCheckbox.Size = new System.Drawing.Size(74, 17);
            this.darknessCheckbox.TabIndex = 62;
            this.darknessCheckbox.Text = "Darkness:";
            this.darknessCheckbox.UseVisualStyleBackColor = true;
            // 
            // psiMagnetCheckbox
            // 
            this.psiMagnetCheckbox.AutoSize = true;
            this.psiMagnetCheckbox.Location = new System.Drawing.Point(183, 163);
            this.psiMagnetCheckbox.Name = "psiMagnetCheckbox";
            this.psiMagnetCheckbox.Size = new System.Drawing.Size(85, 17);
            this.psiMagnetCheckbox.TabIndex = 63;
            this.psiMagnetCheckbox.Text = "PSI Magnet:";
            this.psiMagnetCheckbox.UseVisualStyleBackColor = true;
            // 
            // shieldOffCheckbox
            // 
            this.shieldOffCheckbox.AutoSize = true;
            this.shieldOffCheckbox.Location = new System.Drawing.Point(279, 43);
            this.shieldOffCheckbox.Name = "shieldOffCheckbox";
            this.shieldOffCheckbox.Size = new System.Drawing.Size(75, 17);
            this.shieldOffCheckbox.TabIndex = 64;
            this.shieldOffCheckbox.Text = "Shield Off:";
            this.shieldOffCheckbox.UseVisualStyleBackColor = true;
            // 
            // psiBlockCheckbox
            // 
            this.psiBlockCheckbox.AutoSize = true;
            this.psiBlockCheckbox.Location = new System.Drawing.Point(279, 63);
            this.psiBlockCheckbox.Name = "psiBlockCheckbox";
            this.psiBlockCheckbox.Size = new System.Drawing.Size(76, 17);
            this.psiBlockCheckbox.TabIndex = 65;
            this.psiBlockCheckbox.Text = "PSI Block:";
            this.psiBlockCheckbox.UseVisualStyleBackColor = true;
            // 
            // offenseUpCheckbox
            // 
            this.offenseUpCheckbox.AutoSize = true;
            this.offenseUpCheckbox.Location = new System.Drawing.Point(279, 83);
            this.offenseUpCheckbox.Name = "offenseUpCheckbox";
            this.offenseUpCheckbox.Size = new System.Drawing.Size(83, 17);
            this.offenseUpCheckbox.TabIndex = 66;
            this.offenseUpCheckbox.Text = "Offense Up:";
            this.offenseUpCheckbox.UseVisualStyleBackColor = true;
            // 
            // defenseUpACheckbox
            // 
            this.defenseUpACheckbox.AutoSize = true;
            this.defenseUpACheckbox.Location = new System.Drawing.Point(279, 103);
            this.defenseUpACheckbox.Name = "defenseUpACheckbox";
            this.defenseUpACheckbox.Size = new System.Drawing.Size(96, 17);
            this.defenseUpACheckbox.TabIndex = 67;
            this.defenseUpACheckbox.Text = "Defense Up α:";
            this.defenseUpACheckbox.UseVisualStyleBackColor = true;
            // 
            // defenseUpBCheckbox
            // 
            this.defenseUpBCheckbox.AutoSize = true;
            this.defenseUpBCheckbox.Location = new System.Drawing.Point(279, 123);
            this.defenseUpBCheckbox.Name = "defenseUpBCheckbox";
            this.defenseUpBCheckbox.Size = new System.Drawing.Size(95, 17);
            this.defenseUpBCheckbox.TabIndex = 68;
            this.defenseUpBCheckbox.Text = "Defense Up β:";
            this.defenseUpBCheckbox.UseVisualStyleBackColor = true;
            // 
            // quickUpCheckbox
            // 
            this.quickUpCheckbox.AutoSize = true;
            this.quickUpCheckbox.Location = new System.Drawing.Point(279, 143);
            this.quickUpCheckbox.Name = "quickUpCheckbox";
            this.quickUpCheckbox.Size = new System.Drawing.Size(74, 17);
            this.quickUpCheckbox.TabIndex = 69;
            this.quickUpCheckbox.Text = "Quick Up:";
            this.quickUpCheckbox.UseVisualStyleBackColor = true;
            // 
            // defDownACheckbox
            // 
            this.defDownACheckbox.AutoSize = true;
            this.defDownACheckbox.Location = new System.Drawing.Point(380, 43);
            this.defDownACheckbox.Name = "defDownACheckbox";
            this.defDownACheckbox.Size = new System.Drawing.Size(90, 17);
            this.defDownACheckbox.TabIndex = 70;
            this.defDownACheckbox.Text = "Def. Down α:";
            this.defDownACheckbox.UseVisualStyleBackColor = true;
            // 
            // defenseDownBCheckbox
            // 
            this.defenseDownBCheckbox.AutoSize = true;
            this.defenseDownBCheckbox.Location = new System.Drawing.Point(380, 63);
            this.defenseDownBCheckbox.Name = "defenseDownBCheckbox";
            this.defenseDownBCheckbox.Size = new System.Drawing.Size(109, 17);
            this.defenseDownBCheckbox.TabIndex = 71;
            this.defenseDownBCheckbox.Text = "Defense Down β:";
            this.defenseDownBCheckbox.UseVisualStyleBackColor = true;
            // 
            // fourDSlipCheckbox
            // 
            this.fourDSlipCheckbox.AutoSize = true;
            this.fourDSlipCheckbox.Location = new System.Drawing.Point(380, 83);
            this.fourDSlipCheckbox.Name = "fourDSlipCheckbox";
            this.fourDSlipCheckbox.Size = new System.Drawing.Size(75, 17);
            this.fourDSlipCheckbox.TabIndex = 72;
            this.fourDSlipCheckbox.Text = "4th D Slip:";
            this.fourDSlipCheckbox.UseVisualStyleBackColor = true;
            // 
            // pkFreezeACheckbox
            // 
            this.pkFreezeACheckbox.AutoSize = true;
            this.pkFreezeACheckbox.Location = new System.Drawing.Point(380, 103);
            this.pkFreezeACheckbox.Name = "pkFreezeACheckbox";
            this.pkFreezeACheckbox.Size = new System.Drawing.Size(88, 17);
            this.pkFreezeACheckbox.TabIndex = 73;
            this.pkFreezeACheckbox.Text = "PK Freeze α:";
            this.pkFreezeACheckbox.UseVisualStyleBackColor = true;
            // 
            // pkFreezeBCheckbox
            // 
            this.pkFreezeBCheckbox.AutoSize = true;
            this.pkFreezeBCheckbox.Location = new System.Drawing.Point(380, 123);
            this.pkFreezeBCheckbox.Name = "pkFreezeBCheckbox";
            this.pkFreezeBCheckbox.Size = new System.Drawing.Size(87, 17);
            this.pkFreezeBCheckbox.TabIndex = 74;
            this.pkFreezeBCheckbox.Text = "PK Freeze β:";
            this.pkFreezeBCheckbox.UseVisualStyleBackColor = true;
            // 
            // pkFreezeGCheckbox
            // 
            this.pkFreezeGCheckbox.AutoSize = true;
            this.pkFreezeGCheckbox.Location = new System.Drawing.Point(380, 143);
            this.pkFreezeGCheckbox.Name = "pkFreezeGCheckbox";
            this.pkFreezeGCheckbox.Size = new System.Drawing.Size(87, 17);
            this.pkFreezeGCheckbox.TabIndex = 75;
            this.pkFreezeGCheckbox.Text = "PK Freeze γ:";
            this.pkFreezeGCheckbox.UseVisualStyleBackColor = true;
            // 
            // pkFreezeOCheckbox
            // 
            this.pkFreezeOCheckbox.AutoSize = true;
            this.pkFreezeOCheckbox.Location = new System.Drawing.Point(380, 163);
            this.pkFreezeOCheckbox.Name = "pkFreezeOCheckbox";
            this.pkFreezeOCheckbox.Size = new System.Drawing.Size(90, 17);
            this.pkFreezeOCheckbox.TabIndex = 76;
            this.pkFreezeOCheckbox.Text = "PK Freeze Ω:";
            this.pkFreezeOCheckbox.UseVisualStyleBackColor = true;
            // 
            // pkBeamACheckbox
            // 
            this.pkBeamACheckbox.AutoSize = true;
            this.pkBeamACheckbox.Location = new System.Drawing.Point(499, 43);
            this.pkBeamACheckbox.Name = "pkBeamACheckbox";
            this.pkBeamACheckbox.Size = new System.Drawing.Size(83, 17);
            this.pkBeamACheckbox.TabIndex = 77;
            this.pkBeamACheckbox.Text = "PK Beam α:";
            this.pkBeamACheckbox.UseVisualStyleBackColor = true;
            // 
            // pkBeamBCheckbox
            // 
            this.pkBeamBCheckbox.AutoSize = true;
            this.pkBeamBCheckbox.Location = new System.Drawing.Point(499, 63);
            this.pkBeamBCheckbox.Name = "pkBeamBCheckbox";
            this.pkBeamBCheckbox.Size = new System.Drawing.Size(82, 17);
            this.pkBeamBCheckbox.TabIndex = 78;
            this.pkBeamBCheckbox.Text = "PK Beam β:";
            this.pkBeamBCheckbox.UseVisualStyleBackColor = true;
            // 
            // pkBeamGCheckbox
            // 
            this.pkBeamGCheckbox.AutoSize = true;
            this.pkBeamGCheckbox.Location = new System.Drawing.Point(499, 83);
            this.pkBeamGCheckbox.Name = "pkBeamGCheckbox";
            this.pkBeamGCheckbox.Size = new System.Drawing.Size(82, 17);
            this.pkBeamGCheckbox.TabIndex = 79;
            this.pkBeamGCheckbox.Text = "PK Beam γ:";
            this.pkBeamGCheckbox.UseVisualStyleBackColor = true;
            // 
            // pkBeamOCheckbox
            // 
            this.pkBeamOCheckbox.AutoSize = true;
            this.pkBeamOCheckbox.Location = new System.Drawing.Point(499, 103);
            this.pkBeamOCheckbox.Name = "pkBeamOCheckbox";
            this.pkBeamOCheckbox.Size = new System.Drawing.Size(85, 17);
            this.pkBeamOCheckbox.TabIndex = 80;
            this.pkBeamOCheckbox.Text = "PK Beam Ω:";
            this.pkBeamOCheckbox.UseVisualStyleBackColor = true;
            // 
            // pkThunderACheckbox
            // 
            this.pkThunderACheckbox.AutoSize = true;
            this.pkThunderACheckbox.Location = new System.Drawing.Point(499, 123);
            this.pkThunderACheckbox.Name = "pkThunderACheckbox";
            this.pkThunderACheckbox.Size = new System.Drawing.Size(96, 17);
            this.pkThunderACheckbox.TabIndex = 81;
            this.pkThunderACheckbox.Text = "PK Thunder α:";
            this.pkThunderACheckbox.UseVisualStyleBackColor = true;
            // 
            // pkThunderBCheckbox
            // 
            this.pkThunderBCheckbox.AutoSize = true;
            this.pkThunderBCheckbox.Location = new System.Drawing.Point(499, 143);
            this.pkThunderBCheckbox.Name = "pkThunderBCheckbox";
            this.pkThunderBCheckbox.Size = new System.Drawing.Size(95, 17);
            this.pkThunderBCheckbox.TabIndex = 82;
            this.pkThunderBCheckbox.Text = "PK Thunder β:";
            this.pkThunderBCheckbox.UseVisualStyleBackColor = true;
            // 
            // pkThunderGCheckbox
            // 
            this.pkThunderGCheckbox.AutoSize = true;
            this.pkThunderGCheckbox.Location = new System.Drawing.Point(499, 163);
            this.pkThunderGCheckbox.Name = "pkThunderGCheckbox";
            this.pkThunderGCheckbox.Size = new System.Drawing.Size(95, 17);
            this.pkThunderGCheckbox.TabIndex = 83;
            this.pkThunderGCheckbox.Text = "PK Thunder γ:";
            this.pkThunderGCheckbox.UseVisualStyleBackColor = true;
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Controls.Add(this.rawStatusLabel);
            this.statusGroupBox.Controls.Add(this.faintdStatusCheckbox);
            this.statusGroupBox.Controls.Add(this.stoneStatusCheckbox);
            this.statusGroupBox.Controls.Add(this.paralysisStatusCheckbox);
            this.statusGroupBox.Controls.Add(this.sleepStatusCheckbox);
            this.statusGroupBox.Controls.Add(this.confusedStatusCheckbox);
            this.statusGroupBox.Controls.Add(this.puzzledStatusCheckbox);
            this.statusGroupBox.Controls.Add(this.poisonStatusCheckbox);
            this.statusGroupBox.Controls.Add(this.coldStatusCheckbox);
            this.statusGroupBox.Location = new System.Drawing.Point(213, 206);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Size = new System.Drawing.Size(95, 197);
            this.statusGroupBox.TabIndex = 8;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Status:";
            // 
            // coldStatusCheckbox
            // 
            this.coldStatusCheckbox.AutoSize = true;
            this.coldStatusCheckbox.Location = new System.Drawing.Point(6, 38);
            this.coldStatusCheckbox.Name = "coldStatusCheckbox";
            this.coldStatusCheckbox.Size = new System.Drawing.Size(47, 17);
            this.coldStatusCheckbox.TabIndex = 0;
            this.coldStatusCheckbox.Text = "Cold";
            this.coldStatusCheckbox.UseVisualStyleBackColor = true;
            // 
            // poisonStatusCheckbox
            // 
            this.poisonStatusCheckbox.AutoSize = true;
            this.poisonStatusCheckbox.Location = new System.Drawing.Point(6, 57);
            this.poisonStatusCheckbox.Name = "poisonStatusCheckbox";
            this.poisonStatusCheckbox.Size = new System.Drawing.Size(58, 17);
            this.poisonStatusCheckbox.TabIndex = 1;
            this.poisonStatusCheckbox.Text = "Poison";
            this.poisonStatusCheckbox.UseVisualStyleBackColor = true;
            // 
            // puzzledStatusCheckbox
            // 
            this.puzzledStatusCheckbox.AutoSize = true;
            this.puzzledStatusCheckbox.Location = new System.Drawing.Point(6, 76);
            this.puzzledStatusCheckbox.Name = "puzzledStatusCheckbox";
            this.puzzledStatusCheckbox.Size = new System.Drawing.Size(63, 17);
            this.puzzledStatusCheckbox.TabIndex = 2;
            this.puzzledStatusCheckbox.Text = "Puzzled";
            this.puzzledStatusCheckbox.UseVisualStyleBackColor = true;
            // 
            // confusedStatusCheckbox
            // 
            this.confusedStatusCheckbox.AutoSize = true;
            this.confusedStatusCheckbox.Location = new System.Drawing.Point(6, 95);
            this.confusedStatusCheckbox.Name = "confusedStatusCheckbox";
            this.confusedStatusCheckbox.Size = new System.Drawing.Size(71, 17);
            this.confusedStatusCheckbox.TabIndex = 3;
            this.confusedStatusCheckbox.Text = "Confused";
            this.confusedStatusCheckbox.UseVisualStyleBackColor = true;
            // 
            // sleepStatusCheckbox
            // 
            this.sleepStatusCheckbox.AutoSize = true;
            this.sleepStatusCheckbox.Location = new System.Drawing.Point(6, 114);
            this.sleepStatusCheckbox.Name = "sleepStatusCheckbox";
            this.sleepStatusCheckbox.Size = new System.Drawing.Size(53, 17);
            this.sleepStatusCheckbox.TabIndex = 4;
            this.sleepStatusCheckbox.Text = "Sleep";
            this.sleepStatusCheckbox.UseVisualStyleBackColor = true;
            // 
            // paralysisStatusCheckbox
            // 
            this.paralysisStatusCheckbox.AutoSize = true;
            this.paralysisStatusCheckbox.Location = new System.Drawing.Point(6, 133);
            this.paralysisStatusCheckbox.Name = "paralysisStatusCheckbox";
            this.paralysisStatusCheckbox.Size = new System.Drawing.Size(67, 17);
            this.paralysisStatusCheckbox.TabIndex = 5;
            this.paralysisStatusCheckbox.Text = "Paralysis";
            this.paralysisStatusCheckbox.UseVisualStyleBackColor = true;
            // 
            // stoneStatusCheckbox
            // 
            this.stoneStatusCheckbox.AutoSize = true;
            this.stoneStatusCheckbox.Location = new System.Drawing.Point(6, 152);
            this.stoneStatusCheckbox.Name = "stoneStatusCheckbox";
            this.stoneStatusCheckbox.Size = new System.Drawing.Size(54, 17);
            this.stoneStatusCheckbox.TabIndex = 6;
            this.stoneStatusCheckbox.Text = "Stone";
            this.stoneStatusCheckbox.UseVisualStyleBackColor = true;
            // 
            // faintdStatusCheckbox
            // 
            this.faintdStatusCheckbox.AutoSize = true;
            this.faintdStatusCheckbox.Location = new System.Drawing.Point(6, 171);
            this.faintdStatusCheckbox.Name = "faintdStatusCheckbox";
            this.faintdStatusCheckbox.Size = new System.Drawing.Size(55, 17);
            this.faintdStatusCheckbox.TabIndex = 7;
            this.faintdStatusCheckbox.Text = "Faintd";
            this.faintdStatusCheckbox.UseVisualStyleBackColor = true;
            // 
            // rawStatusLabel
            // 
            this.rawStatusLabel.AutoSize = true;
            this.rawStatusLabel.Location = new System.Drawing.Point(3, 18);
            this.rawStatusLabel.Name = "rawStatusLabel";
            this.rawStatusLabel.Size = new System.Drawing.Size(58, 13);
            this.rawStatusLabel.TabIndex = 8;
            this.rawStatusLabel.Text = "Raw: 0x00";
            // 
            // spritePictureBox
            // 
            //this.spritePictureBox.Image = global::EB0SaveEditor.Properties.Resources.ninten;
            this.spritePictureBox.Location = new System.Drawing.Point(7, 20);
            this.spritePictureBox.Name = "spritePictureBox";
            this.spritePictureBox.Size = new System.Drawing.Size(64, 64);
            this.spritePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spritePictureBox.TabIndex = 0;
            this.spritePictureBox.TabStop = false;

            Item1.Items.AddRange(Constants.ITEM_DICT);
            Item2.Items.AddRange(Constants.ITEM_DICT);
            Item3.Items.AddRange(Constants.ITEM_DICT);
            Item4.Items.AddRange(Constants.ITEM_DICT);
            Item5.Items.AddRange(Constants.ITEM_DICT);
            Item6.Items.AddRange(Constants.ITEM_DICT);
            Item7.Items.AddRange(Constants.ITEM_DICT);
            Item8.Items.AddRange(Constants.ITEM_DICT);
        }

        public void initializeData(byte[] fileBytes)
        {
            string charName = Constants.CHARACTERS[this.CharacterID / 0x40];
            nameBox.Text = Functions.getName(fileBytes, this.CharacterID);
            MaxHP.Value = Functions.getStat(fileBytes, this.CharacterID, Constants.MAX_HP);
            MaxPP.Value = Functions.getStat(fileBytes, this.CharacterID, Constants.MAX_PP);
            CurHP.Value = Functions.getStat(fileBytes, this.CharacterID, Constants.CURRENT_HP);
            CurPP.Value = Functions.getStat(fileBytes, this.CharacterID, Constants.CURRENT_PP);
            Offense.Value = Functions.getStat(fileBytes, this.CharacterID, Constants.OFFENSE);
            Defense.Value = Functions.getStat(fileBytes, this.CharacterID, Constants.DEFENSE);
            Fight.Value = Functions.getStat(fileBytes, this.CharacterID, Constants.FIGHT);
            Speed.Value = Functions.getStat(fileBytes, this.CharacterID, Constants.SPEED);
            Wisdom.Value = Functions.getStat(fileBytes, this.CharacterID, Constants.WISDOM);
            Strength.Value = Functions.getStat(fileBytes, this.CharacterID, Constants.STRENGTH);
            Force.Value = Functions.getStat(fileBytes, this.CharacterID, Constants.FORCE);
            Level.Value = Functions.getStat(fileBytes, this.CharacterID, Constants.LEVEL);
            Exp.Value = Functions.getStat(fileBytes, this.CharacterID, Constants.EXPERIENCE);

            List<int> nItems = Functions.getItems(fileBytes, this.CharacterID);
            Item1.SelectedIndex = nItems[0];
            Item2.SelectedIndex = nItems[1];
            Item3.SelectedIndex = nItems[2];
            Item4.SelectedIndex = nItems[3];
            Item5.SelectedIndex = nItems[4];
            Item6.SelectedIndex = nItems[5];
            Item7.SelectedIndex = nItems[6];
            Item8.SelectedIndex = nItems[7];

            int Status = Functions.getStat(fileBytes, this.CharacterID, Constants.STATUS);

            coldStatusCheckbox.Checked = (Status & (1 << Constants.COLD)) > 0;
            poisonStatusCheckbox.Checked = (Status & (1 << Constants.POISON)) > 0;
            puzzledStatusCheckbox.Checked = (Status & (1 << Constants.PUZZLED)) > 0;
            confusedStatusCheckbox.Checked = (Status & (1 << Constants.CONFUSED)) > 0;
            sleepStatusCheckbox.Checked = (Status & (1 << Constants.SLEEP)) > 0;
            paralysisStatusCheckbox.Checked = (Status & (1 << Constants.PARALYSIS)) > 0;
            stoneStatusCheckbox.Checked = (Status & (1 << Constants.STONE)) > 0;
            faintdStatusCheckbox.Checked = (Status & (1 << Constants.FAINTED)) > 0;

            int weaponVal = Functions.getStat(fileBytes, this.CharacterID, Constants.WEAPON);
            if (weaponVal != 0)
            {
                try
                {
                    Weapon.SelectedIndex = weaponVal - 0x0A;
                }
                catch
                {
                    Console.WriteLine("Invalid Weapon Value {0}-0x{1:X}", charName, weaponVal);
                    Weapon.Text = "INVALID";
                }

                int coinVal = Functions.getStat(fileBytes, this.CharacterID, Constants.COIN);
                try
                {
                    Coin.SelectedIndex = coinVal - 0x2D;
                }
                catch
                {
                    Console.WriteLine("Invalid Coin Vaule for {0}-0x{1:X}", charName, coinVal);
                    Coin.Text = "INVALID";
                }
            }

            int ringValue = Functions.getStat(fileBytes, this.CharacterID, Constants.RING);
            if (ringValue != 0) {
                try
                {
                    if (ringValue == 4)
                    {
                        ringValue = 0;
                    }
                    else
                    {
                        ringValue -= 0x30;
                        ringValue += 1;
                    }
                    Ring.SelectedIndex = ringValue;
                }
                catch
                {
                    Console.WriteLine("Invalid Ring Vaule for {0}-0x{1:X}", charName, ringValue);
                    Ring.Text = "INVALID";
                }
            }

            int pendantValue = Functions.getStat(fileBytes, this.CharacterID, Constants.PENDANT);
            if (pendantValue != 0)
            {
                try
                {
                    Pendant.SelectedIndex = pendantValue - 0x33;
                }
                catch
                {
                    Console.WriteLine("Invalid Pendant Vaule for {0}-0x{1:X}", charName, pendantValue);
                    Pendant.Text = "INVALID";
                }
            }
        }
    }
}
