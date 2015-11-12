using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDITextEditor
{
    public partial class textEditorForm : Form
    {
        public textEditorForm()
        {
            InitializeComponent();
        }

      

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm1 child = new childForm1("New Document");
            child.MdiParent = this;
            child.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
        }

        private void ClearColor()
        {
            redToolStripMenuItem.Checked = false;
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            redToolStripMenuItem.Checked = true;
            childForm1 child = this.ActiveMdiChild as childForm1;

            if (child != null)
            {
                child.ChangeTextColor(Color.Red);
            }

        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            blackToolStripMenuItem.Checked = true;
            childForm1 child = this.ActiveMdiChild as childForm1;

            if (child != null)
            {
                child.ChangeTextColor(Color.Black);
            }


        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            blackToolStripMenuItem.Checked = true;
            childForm1 child = this.ActiveMdiChild as childForm1;

            if (child != null)
            {
                child.ChangeTextColor(Color.Blue);
            };

        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            greenToolStripMenuItem.Checked = true;
            childForm1 child = this.ActiveMdiChild as childForm1;

            if (child != null)
            {
                child.ChangeTextColor(Color.Green);
            }
        }

        private void ptToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            childForm1 child = this.ActiveMdiChild as childForm1;
            if (child != null)
            {
                child.ChangeTextSize(10);
            }
        }

        private void ptToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            childForm1 child = this.ActiveMdiChild as childForm1;
            if (child != null)
            {
                child.ChangeTextSize(12);
            }
        }

        private void ptToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            childForm1 child = this.ActiveMdiChild as childForm1;
            if (child != null)
            {
                child.ChangeTextSize(14);
            }
        }

        private void ptToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            childForm1 child = this.ActiveMdiChild as childForm1;
            if (child != null)
            {
                child.ChangeTextSize(16);
            }
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm1 child = this.ActiveMdiChild as childForm1;
            if (child != null)
            {
                child.ChangeTextFont(7);
            }
        }

        private void baskervilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm1 child = this.ActiveMdiChild as childForm1;
            if (child != null)
            {
                child.ChangeTextFont(1);
            }
        }

        private void bauhausToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm1 child = this.ActiveMdiChild as childForm1;
            if (child != null)
            {
                child.ChangeTextFont(2);
            }
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm1 child = this.ActiveMdiChild as childForm1;
            if (child != null)
            {
                child.ChangeTextFont(3);
            }
        }

        private void futuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm1 child = this.ActiveMdiChild as childForm1;
            if (child != null)
            {
                child.ChangeTextFont(4);
            }
        }

        private void garamondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm1 child = this.ActiveMdiChild as childForm1;
            if (child != null)
            {
                child.ChangeTextFont(5);
            }
        }

        private void helveticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm1 child = this.ActiveMdiChild as childForm1;
            if (child != null)
            {
                child.ChangeTextFont(6);
            }
        }
    }
}
