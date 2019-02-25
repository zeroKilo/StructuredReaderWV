using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Be.Windows.Forms;

namespace StructuredReaderWV
{
    public partial class Form1 : Form
    {
        List<StructDefine> structs;
        public byte[] binary;
        public Form1()
        {
            InitializeComponent();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Token> token = Parser.ParseString(rtb1.Text);
            structs = Lexer.Parse(token);
            if (Lexer.ErrorOut != "")
            {
                status.Text = "Error on parsing : " + Lexer.ErrorOut;
                return;
            }
            if (!Verifier.Verify(structs))
            {
                status.Text = "Error on verifying types : " + Verifier.ErrorOut;
                return;
            }
            status.Text = "Done";
            StructuredReader.littleEndian = littleToolStripMenuItem.Checked;
            if (binary != null)
                rtb2.Text = StructuredReader.Read(structs, binary);

        }

        private void loadBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "*.bin|*.bin";
            if (d.ShowDialog() == DialogResult.OK)
            {
                binary = File.ReadAllBytes(d.FileName);
                hb1.ByteProvider = new DynamicByteProvider(binary);
            }
        }

        private void loadStructuresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "*.txt|*.txt";
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rtb1.Text = File.ReadAllText(d.FileName);
        }

        private void saveStructuresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "*.txt|*.txt";
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(d.FileName, rtb1.Text);
                MessageBox.Show("Done.");
            }
        }

        private void littleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            littleToolStripMenuItem.Checked = true;
            bigToolStripMenuItem.Checked = !littleToolStripMenuItem.Checked;
        }

        private void bigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bigToolStripMenuItem.Checked = true;
            littleToolStripMenuItem.Checked = !bigToolStripMenuItem.Checked;
        }

		private void hb1_CurrentLineChanged(object sender, EventArgs e)
		{
			label1.ResetText();
			for (int i = 0; i < hb1.HorizontalByteCount; i++)
				label1.Text += String.Format("0{0:X} ", i);
		}
	}
}
