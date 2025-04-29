using LiveSplit.Model;
using LiveSplit.Model.Comparisons;
using LiveSplit.Model.RunFactories;
using LiveSplit.Model.RunSavers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.Kacky.SplitLoader
{
    public partial class SplitLoaderForm : Form
    {
        private LiveSplitState State;
        private SplitLoaderSettings Settings;
        private TimerModel TimerModel;

        public SplitLoaderForm(LiveSplitState state, SplitLoaderSettings settings)
        {
            InitializeComponent();
            State = state;
            Settings = settings;
            TimerModel = new TimerModel() { CurrentState = state };
            TopMost = Settings.AlwaysOnTop;
            ApplyTopMost();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            TryLoadSplit();
        }

        private void txtMapNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                TryLoadSplit();
                e.Handled = true;
            }
        }

        private void TryLoadSplit()
        {
            if (!int.TryParse(txtMapNumber.Text, out int number))
                return;

            string splitFilePath = GetSplitFilePath(number);
            if (File.Exists(splitFilePath))
            {
                if (State.CurrentPhase == TimerPhase.Running)
                    TimerModel.Pause();

                if (!string.IsNullOrEmpty(State.Run.FilePath))
                    SaveSplits(State.Run.FilePath);

                TimerModel.Reset();

                var run = LoadStandardLSS(splitFilePath, out TimeSpan offset);

                State.Run = run;
                State.CallRunManuallyModified();
                State.SetGameTime(offset);

                lblCurrentFile.Text = $"Loaded: {Path.GetFileName(splitFilePath)}";
                txtMapNumber.Focus();
                txtMapNumber.Clear();
            }
            else
            {
                MessageBox.Show("File not found.\nPlease make sure the folder path is correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveSplits(string path)
        {
            using (var stream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                var saver = new XMLRunSaver();
                saver.Save(State.Run, stream);
            }
        }

        private IRun LoadStandardLSS(string path, out TimeSpan offset)
        {
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                var factory = new StandardFormatsRunFactory(stream, path);
                var run = factory.Create(new SimpleComparisonGeneratorsFactory());
                offset = run.Offset;
                return run;
            }
        }

        private string GetSplitFilePath(int number)
        {
            if (number == 0)
                return "";

            string searchPattern = $"*- {number}.lss";
            string basePath = Settings.BasePath;

            if (!Directory.Exists(basePath))
                return "";

            var files = Directory.GetFiles(basePath, searchPattern);
            return files.FirstOrDefault() ?? "";
        }

        public void FocusInput()
        {
            txtMapNumber.Focus();
        }

        public void ApplyTopMost()
        {
            this.TopMost = Settings.AlwaysOnTop;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private class SimpleComparisonGeneratorsFactory : IComparisonGeneratorsFactory
        {
            public IEnumerable<IComparisonGenerator> Create(IRun run) => new List<IComparisonGenerator>();
        }
    }
}
