using System;
using System.IO;
using System.Configuration;
using System.Windows.Forms;

namespace GetURN
{
    public partial class GetURN : Form
    {
        string newURN = "unassigned";
        public GetURN()
        {
            InitializeComponent();
            setDefaultValues();
        }

        private void btnGetURN_Click(object sender, EventArgs e)
        {
            btnLaunchHTML.Enabled = false;
            tbxNewURN.Text = "";

            // Set the variables.
            URNCreator.FORGE_CLIENT_ID = tbxForgeClientId.Text;
            URNCreator.FORGE_CLIENT_SECRET = tbxForgeClientSecret.Text;
            URNCreator.FILE_NAME = tbxFileName.Text;
            URNCreator.FILE_PATH = tbxFilePath.Text;

            if (File.Exists(tbxFilePath.Text))
            {
                // subscribe for the updates.
                URNCreator.ProgressLogger += showProgress;
                string error = URNCreator.getURN(ref newURN);

                if(error == "OK")
                    btnLaunchHTML.Enabled = true;
                tbxNewURN.Text = newURN;
            }
            else
            {
                MessageBox.Show("Invalid file path");
            }
        }

        public void showProgress(int percent)
        {
            pbrProcessProgress.Value = percent;
            pbrProcessProgress.Update();
            pbrProcessProgress.Refresh();
            pbrProcessProgress.Invalidate();
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            // Set the variables.
            URNCreator.FORGE_CLIENT_ID = tbxForgeClientId.Text;
            URNCreator.FORGE_CLIENT_SECRET = tbxForgeClientSecret.Text;
            URNCreator.FILE_NAME = tbxFileName.Text;
            URNCreator.FILE_PATH = tbxFilePath.Text;

            string message = URNCreator.deleteFile();
            MessageBox.Show(message);
        }

        private void btnLaunchHTML_Click(object sender, EventArgs e)
        {
            string html = URNCreator.openViewer(newURN);
        }

        private void setDefaultValues()
        {
            //if (File.Exists("Defaults.txt"))
            //{
            //    string [] content = File.ReadAllLines("Defaults.txt");

            //    // There has to be five lines first being the description.
            //    URNCreator.FORGE_CLIENT_ID = content[1];
            //    URNCreator.FORGE_CLIENT_SECRET = content[2];
            //    URNCreator.FILE_NAME = content[3];
            //    URNCreator.FILE_PATH = content[4];
            //}

            tbxForgeClientId.Text = ConfigurationManager.AppSettings["FORGE_CLIENT_ID"];
            tbxForgeClientSecret.Text = ConfigurationManager.AppSettings["FORGE_CLIENT_SECRET"];
            tbxFileName.Text = ConfigurationManager.AppSettings["FILE_NAME"];
            tbxFilePath.Text = ConfigurationManager.AppSettings["FILE_PATH"];
        }

        private void writeInDefaultText()
        {
            //using (StreamWriter writetext = new StreamWriter("Defaults.txt"))
            //{
            //    // There has to be five lines first being the description.
            //    writetext.WriteLine("// Order should be Client Id, Secret, file Name, file Path");
            //    writetext.WriteLine(URNCreator.FORGE_CLIENT_ID);
            //    writetext.WriteLine(URNCreator.FORGE_CLIENT_SECRET);
            //    writetext.WriteLine(URNCreator.FILE_NAME);
            //    writetext.WriteLine(URNCreator.FILE_PATH);
            //    writetext.Close();
            //}

            
        }

        private void btnUpdateDefaults_Click(object sender, EventArgs e)
        {
            // Open App.Config of executable
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Add an Application Setting.
            config.AppSettings.Settings.Clear();
            config.AppSettings.Settings.Add("FORGE_CLIENT_ID", tbxForgeClientId.Text);
            config.AppSettings.Settings.Add("FORGE_CLIENT_SECRET", tbxForgeClientSecret.Text);
            config.AppSettings.Settings.Add("FILE_NAME", tbxFileName.Text);
            config.AppSettings.Settings.Add("FILE_PATH", tbxFilePath.Text);

            // Save the changes in App.config file.
            config.Save(ConfigurationSaveMode.Minimal);

            // Force a reload of a changed section.
            ConfigurationManager.RefreshSection("appSettings");

        }

        private void pbxCopyToClipboard_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(tbxNewURN.Text))
                Clipboard.SetText(tbxNewURN.Text);
        }
    }
}
