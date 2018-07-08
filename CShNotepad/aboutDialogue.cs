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
    public partial class aboutDialogue : Form
    {
        public aboutDialogue()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutDialogue_Load(object sender, EventArgs e)
        {
            //labelName.Text = string.Format("Product Name: {0}", Application.ProductName);
            //labelVersion.Text = string.Format("Version {0} by johnnyn1261", Application.ProductVersion);
        }
    }
}
