using ReactNative;
using ReactNative.Modules.Core;
using ReactNative.Shell;
using ReactWindowsMap;
using System.Collections.Generic;

namespace myapp
{
    class MainPage : ReactPage
    {
        public override string MainComponentName
        {
            get
            {
                return "myapp";
            }
        }

#if BUNDLE
        public override string JavaScriptBundleFile
        {
            get
            {
                return "ms-appx:///ReactAssets/index.windows.bundle";
            }
        }
#endif

        public override List<IReactPackage> Packages
        {
            get
            {
                return new List<IReactPackage>
                {
                    new MainReactPackage(),
                    new ReactWindowsMapPackage(),
                };
            }
        }

        public override bool UseDeveloperSupport
        {
            get
            {
                return true;
            }
        }
    }

}
