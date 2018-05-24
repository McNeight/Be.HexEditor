using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Be.Windows.Forms;
using Be.Byte;

namespace SimplifiedHexEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.hexBox1.ByteProvider = new DynamicByteProvider(new byte[10]);
        }

        internal static void Visualize(byte[] p)
        {
            //hexBox1.ByteProvider = new DynamicByteProvider(p);

            //hexBox1.ByteProvider.
        }

        private byte[] getSelectedBytes(int len)
        {
            var p = hexBox1.ByteProvider;

            var b = new byte[len];

            for (int i = 0; i < len; i++)
            {
                b[i] = p.ReadByte(hexBox1.SelectionStart + i);
            }

            return b;
        }

        private void UpdateStatusBar()
        {
            var sb = new StringBuilder();

            if (hexBox1.SelectionLength > 0)
            {
                sb.AppendFormat("Selected index {0} to {1}, ", hexBox1.SelectionStart, hexBox1.SelectionStart + hexBox1.SelectionLength - 1);
            }
            sb.AppendFormat("Current index {0} (Line {1} Column {2})", (hexBox1.CurrentLine - 1) * 16 + hexBox1.CurrentPositionInLine - 1, hexBox1.CurrentLine, hexBox1.CurrentPositionInLine);

            //uiPosition.Text = sb.ToString();
            toolStripStatusLabel1.Text = sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = hexBox1.Font;
            fontDialog1.Color = hexBox1.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                hexBox1.Font = fontDialog1.Font;
                hexBox1.ForeColor = fontDialog1.Color;
            }
        }


        private void btnForeColor_Click(object sender, EventArgs e)
        {
            // Keeps the user from selecting a custom color.
            colorDialog1.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            colorDialog1.ShowHelp = true;
            // Sets the initial color select to the current text color.
            colorDialog1.Color = hexBox1.ForeColor;

            // Update the text box color if the user clicks OK 
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                hexBox1.ForeColor = colorDialog1.Color;
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            // Keeps the user from selecting a custom color.
            colorDialog1.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            colorDialog1.ShowHelp = true;
            // Sets the initial color select to the current text color.
            colorDialog1.Color = hexBox1.BackColor;

            // Update the text box color if the user clicks OK 
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                hexBox1.BackColor = colorDialog1.Color;
        }

        private void btnBackColorDisabled_Click(object sender, EventArgs e)
        {
            // Keeps the user from selecting a custom color.
            colorDialog1.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            colorDialog1.ShowHelp = true;
            // Sets the initial color select to the current text color.
            colorDialog1.Color = hexBox1.BackColorDisabled;

            // Update the text box color if the user clicks OK 
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                hexBox1.BackColorDisabled = colorDialog1.Color;
        }

        private void btnInfoForeColor_Click(object sender, EventArgs e)
        {
            // Keeps the user from selecting a custom color.
            colorDialog1.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            colorDialog1.ShowHelp = true;
            // Sets the initial color select to the current text color.
            colorDialog1.Color = hexBox1.InfoForeColor;

            // Update the text box color if the user clicks OK 
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                hexBox1.InfoForeColor = colorDialog1.Color;
        }

        private void btnSelectionBackColor_Click(object sender, EventArgs e)
        {
            // Keeps the user from selecting a custom color.
            colorDialog1.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            colorDialog1.ShowHelp = true;
            // Sets the initial color select to the current text color.
            colorDialog1.Color = hexBox1.SelectionBackColor;

            // Update the text box color if the user clicks OK 
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                hexBox1.SelectionBackColor = colorDialog1.Color;
        }

        private void btnSelectionForeColor_Click(object sender, EventArgs e)
        {
            // Keeps the user from selecting a custom color.
            colorDialog1.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            colorDialog1.ShowHelp = true;
            // Sets the initial color select to the current text color.
            colorDialog1.Color = hexBox1.SelectionForeColor;

            // Update the text box color if the user clicks OK 
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                hexBox1.SelectionForeColor = colorDialog1.Color;
        }

        private void btnShadowSelectionColor_Click(object sender, EventArgs e)
        {
            // Keeps the user from selecting a custom color.
            colorDialog1.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            colorDialog1.ShowHelp = true;
            // Sets the initial color select to the current text color.
            colorDialog1.Color = hexBox1.ShadowSelectionColor;

            // Update the text box color if the user clicks OK 
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                hexBox1.ShadowSelectionColor = colorDialog1.Color;
        }
        private void hexBox1_CurrentLineChanged(object sender, EventArgs e)
        {
            UpdateStatusBar();
        }

        private void hexBox1_CurrentPositionInLineChanged(object sender, EventArgs e)
        {
            UpdateStatusBar();
        }

        private void hexBox1_SelectionLengthChanged(object sender, EventArgs e)
        {
            UpdateStatusBar();
            //ShowInfo();
        }

        private void hexBox1_SelectionStartChanged(object sender, EventArgs e)
        {
            UpdateStatusBar();
            //ShowInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] b;
            var r = new Random();

            b = new byte[r.Next(1024 * 512)];

            for (int i = 0; i < b.Length; i++)
            {
                b[i] = (byte)r.Next(0, 256);
            }

            Visualize(b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hexBoxBindingSource.DataSource = hexBox1;

            cbHexCasing.DataSource = Enum.GetValues(typeof(HexCasing));
        }
    }
}
