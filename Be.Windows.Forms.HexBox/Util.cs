using System.Collections.Generic;
using System.Globalization;

namespace Be.Windows.Forms
{
    static class Util
    {

        /// <summary>
        /// Initializes an instance of Util class
        /// </summary>
        static Util()
        {
            // design mode is true if host process is: Visual Studio, Visual Studio Express Versions (C#, VB, C++) or SharpDevelop
            List<string> designerHosts = new List<string>() { "devenv", "vcsexpress", "vbexpress", "vcexpress", "sharpdevelop" };
            using (System.Diagnostics.Process process = System.Diagnostics.Process.GetCurrentProcess())
            {
                string processName = process.ProcessName.ToLower(CultureInfo.CurrentCulture);
                DesignMode = designerHosts.Contains(processName);
            }
        }

        /// <summary>
        /// Gets true, if we are in design mode of Visual Studio
        /// </summary>
        /// <remarks>
        /// In Visual Studio 2008 SP1 the designer is crashing sometimes on windows forms. 
        /// The DesignMode property of Control class is buggy and cannot be used, so use our own implementation instead.
        /// </remarks>
        public static bool DesignMode { get; private set; }

    }
}
