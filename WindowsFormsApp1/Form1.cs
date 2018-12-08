using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       

        private void calculator(object sender, TreeViewEventArgs e)
        {
            
        }
        public Form r;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            switch (node.Text)
            {
                case "Calculator":

                  //  r.Dispose();
                    calck.Controls.Clear();
                    Form2 simple = new Form2();
                    simple.TopLevel = false;
                    calck.Controls.Add(simple);
                    simple.Show();

                    break;
                case "Reg.no":

                  //  r.Dispose();
                    calck.Controls.Clear();
                    Form3 w = new Form3();
                    w.TopLevel = false;
                    calck.Controls.Add(w);
                    w.Show();

                    break;
                case "Names":

                    //r.Dispose();
                    calck.Controls.Clear();
                    Form4 qw = new Form4();
                    qw.TopLevel = false;
                    calck.Controls.Add(qw);
                    qw.Show();

                    break;
                case "Department":

                   // r.Dispose();
                    calck.Controls.Clear();
                    Form5 d = new Form5();
                    d.TopLevel = false;
                    calck.Controls.Add(d);
                    d.Show();

                    break;
                case "Link1":

                    // r.Dispose();
                    calck.Controls.Clear();
                    Form5 y = new Form5();
                    y.TopLevel = false;
                    calck.Controls.Add(y);
                    y.Show();

                    break;
                case "Members":

                    // r.Dispose();
                    calck.Controls.Clear();
                    Form7 t = new Form7();
                    t.TopLevel = false;
                    calck.Controls.Add(t);
                    t.Show();

                    break;
                case "Level":

                    // r.Dispose();
                    calck.Controls.Clear();
                    Form8 l = new Form8();
                    l.TopLevel = false;
                    calck.Controls.Add(l);
                    l.Show();

                    break;


            }
        
        }

        private void Calculator(object sender, EventArgs e)
        {
           
        }

        private void node1(object sender, TreeNodeMouseClickEventArgs e)
        {
           /*calck.Controls.Clear();
            Form2 simple = new Form2();
            simple.TopLevel = false;
            calck.Controls.Add(simple);
            simple.Show();*/
        }

        private void Node1(object sender, TreeViewEventArgs e)
        {
            
            
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
