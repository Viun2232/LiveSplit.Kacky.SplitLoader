using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.Kacky.SplitLoader
{
    public class SplitLoaderComponent : LogicComponent
    {
        public override string ComponentName => "Kacky Split Loader";

        private SplitLoaderSettings Settings { get; }
        private SplitLoaderForm Form { get; set; }
        private LiveSplitState CurrentState { get; }

        public SplitLoaderComponent(LiveSplitState state)
        {
            CurrentState = state;
            Settings = new SplitLoaderSettings();
            Form = new SplitLoaderForm(CurrentState, Settings);
            Settings.LinkedForm = Form;

            Form.Show();
            Form.FocusInput();
        }

        public override void Dispose()
        {
            if (Form != null && !Form.IsDisposed)
                Form.Dispose();
        }

        public override Control GetSettingsControl(LayoutMode mode) => Settings;

        public override XmlNode GetSettings(XmlDocument document) => Settings.GetSettings(document);

        public override void SetSettings(XmlNode settings) => Settings.SetSettings(settings);

        public int GetSettingsHashCode() => Settings.GetSettingsHashCode();

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            // No update logic needed
        }
    }
}
