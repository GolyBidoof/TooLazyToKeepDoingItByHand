using System;
using System.Windows.Forms;
using System.IO;

namespace TooLazyToKeepDoingItByHand
{
    public partial class TLTDIBH : Form
    {
        string path = System.IO.Path.Combine(Environment.GetFolderPath(
               Environment.SpecialFolder.MyDoc‌​uments), "EKDSID.ini");
        byte[] bytes;
        bool loaded = false;

        public TLTDIBH()
        {
            InitializeComponent();
            DialogResult theFreakingFile = openFileDialog1.ShowDialog();
            if(theFreakingFile == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    bytes = File.ReadAllBytes(file);
                }
                catch (IOException)
                {
                    MessageBox.Show("Import the file first.");
                }

            }
            clockUpdateTimer = new Timer();
            clockUpdateTimer.Tick += new EventHandler(clockTimer_Elapsed);
            clockUpdateTimer.Interval = 100;
            clockUpdateTimer.Start();
            if (!(File.Exists(path)))
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("What's your nick, fellow EKDS dev?", "Name input", "Ermelber", -1, -1);
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write(input.ToString());
                }
            }
            string[] motivatingTextsHeader = { "Hola", "Hiya", "Sup", "Aloha", "<yawn> oh hey", "Nice to see you" };
            string[] motivatingTextsFooter = { "what you're up to today?", "are you readjusting karts today?", "keep doing awesomeness!", "been a while.", "like the ol' good days, huh?", "what you're doing looks interesting..." };
            Random randomisedNumber = new Random();
            motivationText.Text = motivatingTextsHeader[randomisedNumber.Next(6)] + " " + File.ReadAllLines(path)[0] + ", " + motivatingTextsFooter[randomisedNumber.Next(6)];
            kartID.SelectedIndex = 0;
            charBox.SelectedIndex = 0;
            processFile();
            loaded = true;

        }

        private void clockTimer_Elapsed(object sender, EventArgs e)
        {
            clock.Text = DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss")
                    + " UTC";
        }
        int blockLength = 224;

        private void processFile()
        {
            int currentID = (int) kartID.SelectedIndex;
            byte[] tempString = new byte[11];
            Array.Copy(bytes, 0 + blockLength * currentID, tempString, 0, 11);
            wheelsName.Text = System.Text.Encoding.ASCII.GetString(tempString);
            wheelsSize.Value = BitConverter.ToInt32(bytes, 16 + blockLength * currentID);
            XFL.Value = BitConverter.ToInt32(bytes, 20 + blockLength * currentID);
            YFL.Value = BitConverter.ToInt32(bytes, 24 + blockLength * currentID);
            ZFL.Value = BitConverter.ToInt32(bytes, 28 + blockLength * currentID);
            XFR.Value = BitConverter.ToInt32(bytes, 32 + blockLength * currentID);
            YFR.Value = BitConverter.ToInt32(bytes, 36 + blockLength * currentID);
            ZFR.Value = BitConverter.ToInt32(bytes, 40 + blockLength * currentID);
            XBL.Value = BitConverter.ToInt32(bytes, 44 + blockLength * currentID);
            YBL.Value = BitConverter.ToInt32(bytes, 48 + blockLength * currentID);
            ZBL.Value = BitConverter.ToInt32(bytes, 52 + blockLength * currentID);
            XBR.Value = BitConverter.ToInt32(bytes, 56 + blockLength * currentID);
            YBR.Value = BitConverter.ToInt32(bytes, 60 + blockLength * currentID);
            ZBR.Value = BitConverter.ToInt32(bytes, 64 + blockLength * currentID);
            int currentCharID = (int) charBox.SelectedIndex;
            charX.Value = BitConverter.ToInt32(bytes, 68 + charBox.SelectedIndex * 12 + blockLength * currentID);
            charY.Value = BitConverter.ToInt32(bytes, 72 + charBox.SelectedIndex * 12 + blockLength * currentID);
            charZ.Value = BitConverter.ToInt32(bytes, 76 + charBox.SelectedIndex * 12 + blockLength * currentID);
        }

        private void charBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaded = false;
            processFile();
            loaded = true;
        }

        private void numUpDown_ValueChanged(object sender, EventArgs e) { if (loaded) saveBackTehFile(); }

        private void saveBackTehFile()
        {
            int currentID = (int)kartID.SelectedIndex;
            byte[] textArray = System.Text.Encoding.ASCII.GetBytes(wheelsName.Text);
            Array.Resize(ref textArray, 11);
            Array.Copy(textArray, 0, bytes, 0 + blockLength * currentID, 11);
            Array.Copy(BitConverter.GetBytes((int)wheelsSize.Value), 0, bytes, 16 + blockLength * currentID, 4);
            Array.Copy(BitConverter.GetBytes((int)XFL.Value), 0, bytes, 20 + blockLength * currentID, 4);
            Array.Copy(BitConverter.GetBytes((int)YFL.Value), 0, bytes, 24 + blockLength * currentID, 4);
            Array.Copy(BitConverter.GetBytes((int)ZFL.Value), 0, bytes, 28 + blockLength * currentID, 4);
            Array.Copy(BitConverter.GetBytes((int)XFR.Value), 0, bytes, 32 + blockLength * currentID, 4);
            Array.Copy(BitConverter.GetBytes((int)YFR.Value), 0, bytes, 36 + blockLength * currentID, 4);
            Array.Copy(BitConverter.GetBytes((int)ZFR.Value), 0, bytes, 40 + blockLength * currentID, 4);
            Array.Copy(BitConverter.GetBytes((int)XBL.Value), 0, bytes, 44 + blockLength * currentID, 4);
            Array.Copy(BitConverter.GetBytes((int)YBL.Value), 0, bytes, 48 + blockLength * currentID, 4);
            Array.Copy(BitConverter.GetBytes((int)ZBL.Value), 0, bytes, 52 + blockLength * currentID, 4);
            Array.Copy(BitConverter.GetBytes((int)XBR.Value), 0, bytes, 56 + blockLength * currentID, 4);
            Array.Copy(BitConverter.GetBytes((int)YBR.Value), 0, bytes, 60 + blockLength * currentID, 4);
            Array.Copy(BitConverter.GetBytes((int)ZBR.Value), 0, bytes, 64 + blockLength * currentID, 4);
            int currentCharID = (int)charBox.SelectedIndex;
            Array.Copy(BitConverter.GetBytes((int)charX.Value), 0, bytes, 68 + charBox.SelectedIndex * 12 + blockLength * currentID, 4);
            Array.Copy(BitConverter.GetBytes((int)charY.Value), 0, bytes, 72 + charBox.SelectedIndex * 12 + blockLength * currentID, 4);
            Array.Copy(BitConverter.GetBytes((int)charZ.Value), 0, bytes, 76 + charBox.SelectedIndex * 12 + blockLength * currentID, 4);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "kartoffsetdata.bin";
            DialogResult resultsave = saveFileDialog1.ShowDialog(); // Show the dialog.
            if (resultsave == DialogResult.OK) // Test result.
            {
                string file = saveFileDialog1.FileName;
                try
                {
                    File.WriteAllBytes(file, bytes);
                }
                catch (IOException)
                {
                    MessageBox.Show("You didn't save any file.");
                }

            }
        }
    }
}
