namespace TooLazyToKeepDoingItByHand
{
    partial class TLTDIBH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.wheelsName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wheelsSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.XFL = new System.Windows.Forms.NumericUpDown();
            this.YFL = new System.Windows.Forms.NumericUpDown();
            this.ZFL = new System.Windows.Forms.NumericUpDown();
            this.ZFR = new System.Windows.Forms.NumericUpDown();
            this.YFR = new System.Windows.Forms.NumericUpDown();
            this.XFR = new System.Windows.Forms.NumericUpDown();
            this.ZBL = new System.Windows.Forms.NumericUpDown();
            this.YBL = new System.Windows.Forms.NumericUpDown();
            this.XBL = new System.Windows.Forms.NumericUpDown();
            this.ZBR = new System.Windows.Forms.NumericUpDown();
            this.YBR = new System.Windows.Forms.NumericUpDown();
            this.XBR = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.charBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.charX = new System.Windows.Forms.NumericUpDown();
            this.charY = new System.Windows.Forms.NumericUpDown();
            this.charZ = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.motivationText = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.clock = new System.Windows.Forms.Label();
            this.clockUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.kartID = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wheelsSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XFL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YFL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZFL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZFR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YFR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XFR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZBR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YBR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XBR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charZ)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kart ID";
            // 
            // wheelsName
            // 
            this.wheelsName.Location = new System.Drawing.Point(90, 11);
            this.wheelsName.MaxLength = 11;
            this.wheelsName.Name = "wheelsName";
            this.wheelsName.Size = new System.Drawing.Size(100, 20);
            this.wheelsName.TabIndex = 2;
            this.wheelsName.TextChanged += new System.EventHandler(this.wheelsName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wheels name";
            // 
            // wheelsSize
            // 
            this.wheelsSize.Location = new System.Drawing.Point(274, 12);
            this.wheelsSize.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.wheelsSize.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.wheelsSize.Name = "wheelsSize";
            this.wheelsSize.Size = new System.Drawing.Size(83, 20);
            this.wheelsSize.TabIndex = 4;
            this.wheelsSize.ValueChanged += new System.EventHandler(this.wheelsSize_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wheels size";
            // 
            // XFL
            // 
            this.XFL.Location = new System.Drawing.Point(90, 49);
            this.XFL.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.XFL.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.XFL.Name = "XFL";
            this.XFL.Size = new System.Drawing.Size(71, 20);
            this.XFL.TabIndex = 6;
            this.XFL.ValueChanged += new System.EventHandler(this.XFL_ValueChanged);
            // 
            // YFL
            // 
            this.YFL.Location = new System.Drawing.Point(167, 49);
            this.YFL.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.YFL.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.YFL.Name = "YFL";
            this.YFL.Size = new System.Drawing.Size(71, 20);
            this.YFL.TabIndex = 7;
            this.YFL.ValueChanged += new System.EventHandler(this.YFL_ValueChanged);
            // 
            // ZFL
            // 
            this.ZFL.Location = new System.Drawing.Point(244, 49);
            this.ZFL.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ZFL.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.ZFL.Name = "ZFL";
            this.ZFL.Size = new System.Drawing.Size(71, 20);
            this.ZFL.TabIndex = 8;
            this.ZFL.ValueChanged += new System.EventHandler(this.ZFL_ValueChanged);
            // 
            // ZFR
            // 
            this.ZFR.Location = new System.Drawing.Point(244, 75);
            this.ZFR.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ZFR.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ZFR.Name = "ZFR";
            this.ZFR.Size = new System.Drawing.Size(71, 20);
            this.ZFR.TabIndex = 11;
            this.ZFR.ValueChanged += new System.EventHandler(this.ZFR_ValueChanged);
            // 
            // YFR
            // 
            this.YFR.Location = new System.Drawing.Point(167, 75);
            this.YFR.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.YFR.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.YFR.Name = "YFR";
            this.YFR.Size = new System.Drawing.Size(71, 20);
            this.YFR.TabIndex = 10;
            this.YFR.ValueChanged += new System.EventHandler(this.YFR_ValueChanged);
            // 
            // XFR
            // 
            this.XFR.Location = new System.Drawing.Point(90, 75);
            this.XFR.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.XFR.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.XFR.Name = "XFR";
            this.XFR.Size = new System.Drawing.Size(71, 20);
            this.XFR.TabIndex = 9;
            this.XFR.ValueChanged += new System.EventHandler(this.XFR_ValueChanged);
            // 
            // ZBL
            // 
            this.ZBL.Location = new System.Drawing.Point(244, 101);
            this.ZBL.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ZBL.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ZBL.Name = "ZBL";
            this.ZBL.Size = new System.Drawing.Size(71, 20);
            this.ZBL.TabIndex = 14;
            this.ZBL.ValueChanged += new System.EventHandler(this.ZBL_ValueChanged);
            // 
            // YBL
            // 
            this.YBL.Location = new System.Drawing.Point(167, 101);
            this.YBL.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.YBL.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.YBL.Name = "YBL";
            this.YBL.Size = new System.Drawing.Size(71, 20);
            this.YBL.TabIndex = 13;
            this.YBL.ValueChanged += new System.EventHandler(this.YBL_ValueChanged);
            // 
            // XBL
            // 
            this.XBL.Location = new System.Drawing.Point(90, 101);
            this.XBL.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.XBL.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.XBL.Name = "XBL";
            this.XBL.Size = new System.Drawing.Size(71, 20);
            this.XBL.TabIndex = 12;
            this.XBL.ValueChanged += new System.EventHandler(this.XBL_ValueChanged);
            // 
            // ZBR
            // 
            this.ZBR.Location = new System.Drawing.Point(244, 127);
            this.ZBR.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ZBR.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ZBR.Name = "ZBR";
            this.ZBR.Size = new System.Drawing.Size(71, 20);
            this.ZBR.TabIndex = 17;
            this.ZBR.ValueChanged += new System.EventHandler(this.ZBR_ValueChanged);
            // 
            // YBR
            // 
            this.YBR.Location = new System.Drawing.Point(167, 127);
            this.YBR.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.YBR.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.YBR.Name = "YBR";
            this.YBR.Size = new System.Drawing.Size(71, 20);
            this.YBR.TabIndex = 16;
            this.YBR.ValueChanged += new System.EventHandler(this.YBR_ValueChanged);
            // 
            // XBR
            // 
            this.XBR.Location = new System.Drawing.Point(90, 127);
            this.XBR.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.XBR.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.XBR.Name = "XBR";
            this.XBR.Size = new System.Drawing.Size(71, 20);
            this.XBR.TabIndex = 15;
            this.XBR.ValueChanged += new System.EventHandler(this.XBR_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Front-Left";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Front-Right";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Back-Left";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Back-Right";
            // 
            // charBox
            // 
            this.charBox.FormattingEnabled = true;
            this.charBox.Items.AddRange(new object[] {
            "0x00\tMario",
            "0x01\tDonkey Kong",
            "0x02\tToad",
            "0x03\tBowser",
            "0x04\tPeach",
            "0x05\tWario",
            "0x06\tYoshi",
            "0x07\tLuigi",
            "0x08\tDry Bones",
            "0x09\tDaisy",
            "0x0A\tWaluigi",
            "0x0B\tROB",
            "0x0C\tShy Guy"});
            this.charBox.Location = new System.Drawing.Point(416, 48);
            this.charBox.Name = "charBox";
            this.charBox.Size = new System.Drawing.Size(164, 21);
            this.charBox.TabIndex = 22;
            this.charBox.SelectedIndexChanged += new System.EventHandler(this.charBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Character name";
            // 
            // charX
            // 
            this.charX.Location = new System.Drawing.Point(331, 75);
            this.charX.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.charX.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.charX.Name = "charX";
            this.charX.Size = new System.Drawing.Size(79, 20);
            this.charX.TabIndex = 24;
            this.charX.ValueChanged += new System.EventHandler(this.charX_ValueChanged);
            // 
            // charY
            // 
            this.charY.Location = new System.Drawing.Point(416, 75);
            this.charY.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.charY.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.charY.Name = "charY";
            this.charY.Size = new System.Drawing.Size(79, 20);
            this.charY.TabIndex = 25;
            this.charY.ValueChanged += new System.EventHandler(this.charY_ValueChanged);
            // 
            // charZ
            // 
            this.charZ.Location = new System.Drawing.Point(501, 75);
            this.charZ.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.charZ.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.charZ.Name = "charZ";
            this.charZ.Size = new System.Drawing.Size(79, 20);
            this.charZ.TabIndex = 26;
            this.charZ.ValueChanged += new System.EventHandler(this.charZ_ValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(331, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 39);
            this.button1.TabIndex = 27;
            this.button1.Text = "SAVE :D";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // motivationText
            // 
            this.motivationText.AutoSize = true;
            this.motivationText.Location = new System.Drawing.Point(24, 157);
            this.motivationText.Name = "motivationText";
            this.motivationText.Size = new System.Drawing.Size(177, 13);
            this.motivationText.TabIndex = 28;
            this.motivationText.Text = "Hello pal, what are you up to today?";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "kartoffsetdata.bin";
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Location = new System.Drawing.Point(445, 156);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(49, 13);
            this.clock.TabIndex = 29;
            this.clock.Text = "22:22:22";
            // 
            // kartID
            // 
            this.kartID.FormattingEnabled = true;
            this.kartID.Items.AddRange(new object[] {
            "0x00\tStandard MR",
            "0x01\tShooting Star",
            "0x02\tB Dasher",
            "0x03\tStandard DK",
            "0x04\tWhild Life",
            "0x05\tRambi Rider",
            "0x06\tStandard TD",
            "0x07\tMushmellow",
            "0x08\t4 Wheel Cradle",
            "0x09\tStandard BW",
            "0x0A\tHurricane",
            "0x0B\tTyrant",
            "0x0C\tStandard PC",
            "0x0D\tLight Tripper",
            "0x0E\tRoyale",
            "0x0F\tStandard WR",
            "0x10\tBrute",
            "0x11\tDragonfly",
            "0x12\tStandard YS",
            "0x13\tEgg 1",
            "0x14\tCucumber",
            "0x15\tStandard LG",
            "0x16\tPoltergust 4000",
            "0x17\tStreamliner",
            "0x18\tStandard DB",
            "0x19\tDry Bomber",
            "0x1A\tBanisher",
            "0x1B\tStandard DS",
            "0x1C\tLight Dancer",
            "0x1D\tPower Flower",
            "0x1E\tStandard WL",
            "0x1F\tGold Mantis",
            "0x20\tZipper",
            "0x21\tStandard RB",
            "0x22\tROB-BLS",
            "0x23\tROB-LGS",
            "0x24\tStandard HH"});
            this.kartID.Location = new System.Drawing.Point(426, 10);
            this.kartID.Name = "kartID";
            this.kartID.Size = new System.Drawing.Size(154, 21);
            this.kartID.TabIndex = 30;
            this.kartID.SelectedIndexChanged += new System.EventHandler(this.kartID_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveButton.Location = new System.Drawing.Point(331, 101);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(248, 46);
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "SAVE :D";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // TLTDIBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 181);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.kartID);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.motivationText);
            this.Controls.Add(this.charZ);
            this.Controls.Add(this.charY);
            this.Controls.Add(this.charX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.charBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ZBR);
            this.Controls.Add(this.YBR);
            this.Controls.Add(this.XBR);
            this.Controls.Add(this.ZBL);
            this.Controls.Add(this.YBL);
            this.Controls.Add(this.XBL);
            this.Controls.Add(this.ZFR);
            this.Controls.Add(this.YFR);
            this.Controls.Add(this.XFR);
            this.Controls.Add(this.ZFL);
            this.Controls.Add(this.YFL);
            this.Controls.Add(this.XFL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wheelsSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wheelsName);
            this.Controls.Add(this.label1);
            this.Name = "TLTDIBH";
            this.Text = "TLTKDIBH";
            ((System.ComponentModel.ISupportInitialize)(this.wheelsSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XFL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YFL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZFL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZFR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YFR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XFR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZBL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YBL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XBL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZBR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YBR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XBR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wheelsName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown wheelsSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown XFL;
        private System.Windows.Forms.NumericUpDown YFL;
        private System.Windows.Forms.NumericUpDown ZFL;
        private System.Windows.Forms.NumericUpDown ZFR;
        private System.Windows.Forms.NumericUpDown YFR;
        private System.Windows.Forms.NumericUpDown XFR;
        private System.Windows.Forms.NumericUpDown ZBL;
        private System.Windows.Forms.NumericUpDown YBL;
        private System.Windows.Forms.NumericUpDown XBL;
        private System.Windows.Forms.NumericUpDown ZBR;
        private System.Windows.Forms.NumericUpDown YBR;
        private System.Windows.Forms.NumericUpDown XBR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox charBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown charX;
        private System.Windows.Forms.NumericUpDown charY;
        private System.Windows.Forms.NumericUpDown charZ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label motivationText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Timer clockUpdateTimer;
        private System.Windows.Forms.ComboBox kartID;
        private System.Windows.Forms.Button saveButton;
    }
}

