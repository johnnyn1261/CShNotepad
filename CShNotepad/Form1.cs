using System;
using System.IO;
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
            
        }

        private void newStripMenu_Click(object sender, EventArgs e)
        {
            path = string.Empty;
            textBox.Clear();
        }

        private void openStripMenu_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "Text Documents|*.txt", ValidateNames = true, Multiselect = false
            })
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamReader reader = new StreamReader(openFile.FileName))
                        {
                            path = openFile.FileName;
                            Task<string> text = reader.ReadToEndAsync();
                            textBox.Text = text.Result;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void saveStripMenu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(path))
            {
                using(SaveFileDialog saveFile = new SaveFileDialog()
                {
                    Filter = "Text Document|*.txt", ValidateNames = true
                })
                {
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            path = saveFile.FileName;
                            using (StreamWriter writer = new StreamWriter(saveFile.FileName))
                            {
                                await writer.WriteLineAsync(textBox.Text);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        await writer.WriteLineAsync(textBox.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void saveAsStripMenu_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFile = new SaveFileDialog()
            {
                Filter = "Text Document|*.txt",
                ValidateNames = true
            })
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(saveFile.FileName))
                        {
                            await writer.WriteLineAsync(textBox.Text);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void exitStripMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutStripMenu_Click(object sender, EventArgs e)
        {
            using(aboutDialogue about = new aboutDialogue())
            {
                about.ShowDialog();
            }
        }
    }
}
