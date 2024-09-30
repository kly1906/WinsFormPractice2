using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTH2_2
{
    public partial class Bai6_BTH2 : Form
    {
        public Bai6_BTH2()
        {
            InitializeComponent();

        }

        private void Bai6_BTH2_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                foreach (TreeNode child1 in e.Node.Nodes)
                {
                    foreach (TreeNode child2 in child1.Nodes)
                    {
                        ListViewItem lti = new ListViewItem(child2.Text);
                        lti.SubItems.Add(child1.Text);

                        listView1.Items.Add(lti);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = textBox1.Text.ToLower();
            listView1.Clear();
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Level == 1)  
            {
                foreach (TreeNode child1 in treeView1.Nodes[0].Nodes)
                {
                    foreach (TreeNode child2 in child1.Nodes)
                    {
                        if (child2.Text.ToLower().Contains(ten))
                        {
                            
                            ListViewItem lti = new ListViewItem(child2.Text);
                            lti.SubItems.Add(child1.Text);

                            listView1.Items.Add(lti);
                        }
                    }
                }
            }
        }

    }
}
