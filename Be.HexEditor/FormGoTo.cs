using System;
using System.Windows.Forms;

namespace Be.HexEditor
{
    /// <summary>
    /// Summary description for FormGoTo.
    /// </summary>
    public class FormGoTo : Core.FormEx
    {
        private System.Windows.Forms.Label lblDec;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown nup;
        private System.Windows.Forms.Label label2;
        private Panel line;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton rbHex;
        private RadioButton rbDec;
        private Label lblHex;
        private TextBox txtHex;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public FormGoTo()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoTo));
            this.lblDec = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.nup = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.rbDec = new System.Windows.Forms.RadioButton();
            this.lblHex = new System.Windows.Forms.Label();
            this.txtHex = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nup)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDec
            // 
            resources.ApplyResources(this.lblDec, "lblDec");
            this.lblDec.Name = "lblDec";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Name = "btnOK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // nup
            // 
            resources.ApplyResources(this.nup, "nup");
            this.nup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup.Name = "nup";
            this.nup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // line
            // 
            resources.ApplyResources(this.line, "line");
            this.line.BackColor = System.Drawing.Color.LightGray;
            this.line.Name = "line";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // rbHex
            // 
            resources.ApplyResources(this.rbHex, "rbHex");
            this.rbHex.Checked = true;
            this.rbHex.Name = "rbHex";
            this.rbHex.TabStop = true;
            this.rbHex.UseVisualStyleBackColor = true;
            this.rbHex.Click += new System.EventHandler(this.rbDec_Click);
            // 
            // rbDec
            // 
            resources.ApplyResources(this.rbDec, "rbDec");
            this.rbDec.Name = "rbDec";
            this.rbDec.UseVisualStyleBackColor = true;
            this.rbDec.Click += new System.EventHandler(this.rbDec_Click);
            // 
            // lblHex
            // 
            resources.ApplyResources(this.lblHex, "lblHex");
            this.lblHex.Name = "lblHex";
            // 
            // txtHex
            // 
            resources.ApplyResources(this.txtHex, "txtHex");
            this.txtHex.Name = "txtHex";
            // 
            // FormGoTo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.rbDec);
            this.Controls.Add(this.rbHex);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.line);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nup);
            this.Controls.Add(this.lblDec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGoTo";
            this.ShowInTaskbar = false;
            this.Activated += new System.EventHandler(this.FormGoTo_Activated);
            this.Shown += new System.EventHandler(this.FormGoTo_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nup)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public void SetDefaultValue(long byteIndex)
        {
            nup.Value = byteIndex + 1;
        }

        public void SetMaxByteIndex(long maxByteIndex)
        {
            nup.Maximum = maxByteIndex + 1;
        }

        public long GetByteIndex()
        {
            if (rbHex.Checked)
            {
                return Convert.ToInt64(txtHex.Text, 16);
            }
            else
            {
                return Convert.ToInt64(nup.Value) - 1;
            }
        }

        private void FormGoTo_Activated(object sender, System.EventArgs e)
        {
            nup.Focus();
            nup.Select(0, nup.Value.ToString().Length);
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void rbDec_Click(object sender, EventArgs e)
        {
            bool isHex = rbHex.Checked;

            lblHex.Enabled = isHex;
            txtHex.Enabled = isHex;
            lblDec.Enabled = !isHex;
            nup.Enabled = !isHex;
        }

        private void FormGoTo_Shown(object sender, EventArgs e)
        {
            if (rbHex.Checked)
            {
                txtHex.Focus();
            }
            else
            {
                nup.Focus();
            }
        }
    }
}
