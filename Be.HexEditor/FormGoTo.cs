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
            lblDec = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            btnOK = new System.Windows.Forms.Button();
            nup = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            line = new System.Windows.Forms.Panel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            rbHex = new System.Windows.Forms.RadioButton();
            rbDec = new System.Windows.Forms.RadioButton();
            lblHex = new System.Windows.Forms.Label();
            txtHex = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(nup)).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDec
            // 
            resources.ApplyResources(lblDec, "lblDec");
            lblDec.Name = "lblDec";
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Name = "btnCancel";
            btnCancel.Click += new System.EventHandler(btnCancel_Click);
            // 
            // btnOK
            // 
            resources.ApplyResources(btnOK, "btnOK");
            btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnOK.Name = "btnOK";
            btnOK.Click += new System.EventHandler(btnOK_Click);
            // 
            // nup
            // 
            resources.ApplyResources(nup, "nup");
            nup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            nup.Name = "nup";
            nup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            label2.ForeColor = System.Drawing.Color.Blue;
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // line
            // 
            resources.ApplyResources(line, "line");
            line.BackColor = System.Drawing.Color.LightGray;
            line.Name = "line";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnOK);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // rbHex
            // 
            resources.ApplyResources(rbHex, "rbHex");
            rbHex.Checked = true;
            rbHex.Name = "rbHex";
            rbHex.TabStop = true;
            rbHex.UseVisualStyleBackColor = true;
            rbHex.Click += new System.EventHandler(rbDec_Click);
            // 
            // rbDec
            // 
            resources.ApplyResources(rbDec, "rbDec");
            rbDec.Name = "rbDec";
            rbDec.UseVisualStyleBackColor = true;
            rbDec.Click += new System.EventHandler(rbDec_Click);
            // 
            // lblHex
            // 
            resources.ApplyResources(lblHex, "lblHex");
            lblHex.Name = "lblHex";
            // 
            // txtHex
            // 
            resources.ApplyResources(txtHex, "txtHex");
            txtHex.Name = "txtHex";
            // 
            // FormGoTo
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.SystemColors.Control;
            Controls.Add(txtHex);
            Controls.Add(lblHex);
            Controls.Add(rbDec);
            Controls.Add(rbHex);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(line);
            Controls.Add(label2);
            Controls.Add(nup);
            Controls.Add(lblDec);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGoTo";
            ShowInTaskbar = false;
            Activated += new System.EventHandler(FormGoTo_Activated);
            Shown += new System.EventHandler(FormGoTo_Shown);
            ((System.ComponentModel.ISupportInitialize)(nup)).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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
