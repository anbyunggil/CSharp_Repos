﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Random random = new Random(37);
        public Form1()
        {
            InitializeComponent();

            lvDummy.Columns.Add("Name");
            lvDummy.Columns.Add("Depth");
        }
        void ChangeFont()
        {
            if (cboFont.SelectedIndex < 0)
                return;
            FontStyle style = FontStyle.Regular;
            if (chkBold.Checked)
                style |= FontStyle.Bold;
            if (chkItalic.Checked)
                style |= FontStyle.Italic;
            txtSampleText.Font =
                new Font((string)cboFont.SelectedItem, 10, style);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;
            foreach (FontFamily font in Fonts)
                cboFont.Items.Add(font.Name);
            
        }
        

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void tbDummy_Scroll(object sender, EventArgs e)
        {
            pgDummy.Value = tbDummy.Value;
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Red;
            frm.ShowDialog();
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modaless Form";
            frm.Width = 300;
            frm.Height = 300;
            frm.BackColor = Color.Green;
            frm.Show();
        }

        private void btnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSampleText.Text, "messageBox Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        void TreeToList()
        {
            lvDummy.Items.Clear();
            foreach (TreeNode node in tvDummy.Nodes)
                TreeToList(node);
        }
        void TreeToList(TreeNode Node)
        {
            lvDummy.Items.Add(
                new ListViewItem(
                    new string[] { Node.Text, Node.FullPath.Count(f => f == '\\').ToString() }));

            foreach (TreeNode node in Node.Nodes)
            {
                TreeToList(node);
            }
        }

        private void btnAddRoot_Click(object sender, EventArgs e)
        {
            tvDummy.Nodes.Add(random.Next().ToString());
            TreeToList();
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            if (tvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.", "TreeView Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            tvDummy.SelectedNode.Expand();
            TreeToList();
        }
    }
}
