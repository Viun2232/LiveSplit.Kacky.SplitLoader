using LiveSplit.UI;
using System;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.Kacky.SplitLoader
{
    public partial class SplitLoaderSettings : UserControl
    {
        public string BasePath { get; set; }
        public bool AlwaysOnTop { get; set; }
        public SplitLoaderForm LinkedForm { get; set; }

        public SplitLoaderSettings()
        {
            InitializeComponent();
            BasePath = @"D:\My Documents\LiveSplit";
            AlwaysOnTop = false;

            txtBasePath.DataBindings.Add("Text", this, nameof(BasePath), false, DataSourceUpdateMode.OnPropertyChanged);
            chkAlwaysOnTop.DataBindings.Add("Checked", this, nameof(AlwaysOnTop), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select the folder where your split files are located.";
                dialog.SelectedPath = BasePath;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    BasePath = dialog.SelectedPath;
                    txtBasePath.Text = BasePath;
                }
            }
        }

        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement)node;
            BasePath = element["BasePath"].InnerText;

            if (element["AlwaysOnTop"] != null)
                AlwaysOnTop = bool.Parse(element["AlwaysOnTop"].InnerText);

            LinkedForm?.ApplyTopMost();
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            SettingsHelper.CreateSetting(document, parent, "BasePath", BasePath);
            SettingsHelper.CreateSetting(document, parent, "AlwaysOnTop", AlwaysOnTop);
            return parent;
        }

        private void chkAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            AlwaysOnTop = chkAlwaysOnTop.Checked;
            LinkedForm?.ApplyTopMost();
        }

        public int GetSettingsHashCode()
        {
            return BasePath.GetHashCode() ^ AlwaysOnTop.GetHashCode();
        }
    }
}
