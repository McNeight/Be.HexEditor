namespace Be.HexEditor
{
    public partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.btnOK = new System.Windows.Forms.Button();
            this.ucAbout1 = new Be.HexEditor.UCAbout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ucAbout1
            // 
            resources.ApplyResources(this.ucAbout1, "ucAbout1");
            this.ucAbout1.Name = "ucAbout1";
            // 
            // FormAbout
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ucAbout1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormAbout_CorrectWidth);
            this.Resize += new System.EventHandler(this.FormAbout_CorrectWidth);
            this.ResumeLayout(false);

        }
        #endregion

        private Be.HexEditor.UCAbout ucAbout1;
        private System.Windows.Forms.Button btnOK;
    }
}
