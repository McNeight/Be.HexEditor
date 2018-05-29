using System.ComponentModel;
using System.Windows.Forms;

namespace Be.HexEditor.Core
{
    public class ToolStripMenuItemEx : ToolStripMenuItem, IScalingItem
    {
        [DefaultValue(null)]
        public System.Drawing.Image Image16 { get; set; }
        [DefaultValue(null)]
        public System.Drawing.Image Image24 { get; set; }
        [DefaultValue(null)]
        public System.Drawing.Image Image32 { get; set; }
    }
}
