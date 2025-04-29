using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using UpdateManager;

[assembly: ComponentFactory(typeof(LiveSplit.Kacky.SplitLoader.SplitLoaderFactory))]

namespace LiveSplit.Kacky.SplitLoader
{
    public class SplitLoaderFactory : IComponentFactory, IUpdateable
    {
        public string ComponentName => "Kacky Split Loader";

        public string Description => "Loads split files automatically by entering map numbers.";

        public ComponentCategory Category => ComponentCategory.Control;

        public IComponent Create(LiveSplitState state)
        {
            return new SplitLoaderComponent(state);
        }

        public string UpdateName => ComponentName;

        public string XMLURL => string.Empty;

        public string UpdateURL => string.Empty;

        public Version Version => Version.Parse("1.0.0");
    }
}
