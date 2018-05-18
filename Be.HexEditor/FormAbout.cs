using System;

namespace Be.HexEditor
{
    /// <summary>
    /// Summary description for FormAbout.
    /// </summary>
    public partial class FormAbout : Core.FormEx
    {
        public FormAbout()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void FormAbout_CorrectWidth(object sender, EventArgs e)
        {
            //var factor = this.DpiNew / Core.FormEx.DpiAtDesign;
            //this.ucAbout1.Width = (int)((this.Width - 40) * factor);
        }
    }
}
