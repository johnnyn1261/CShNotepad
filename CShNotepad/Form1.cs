using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShNotepad
{
    public partial class CShNotepad : Form
    {
        string path;

        public CShNotepad()
        {
            InitializeComponent();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            textBox.Clear();
        }

        private void newStripMenu_Click(object sender, EventArgs e)
        {
            path = string.Empty;
            textBox.Clear();
        }

        private void openStripMenu_Click(object sender, EventArgs e)
        {

        }

        private void saveStripMenu_Click(object sender, EventArgs e)
        {

        }

        private void saveAsStripMenu_Click(object sender, EventArgs e)
        {

        }

        private void exitStripMenu_Click(object sender, EventArgs e)
        {

        }

        private void aboutStripMenu_Click(object sender, EventArgs e)
        {
            using(aboutDialogue about = new aboutDialogue())
            {
                about.ShowDialog();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
