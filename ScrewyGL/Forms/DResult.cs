using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ScrewyGL
{
    public partial class DResult : Form
    {
        public DResult(string content)
        {
            InitializeComponent();

            RTB_Content.Text = content;
        }

        private async void BTN_Copy_Click(object sender, System.EventArgs e)
        {
            Clipboard.SetText(RTB_Content.Text);

            BTN_Copy.Text = "Copied!";
            await Task.Delay(350);
            BTN_Copy.Text = "Copy";
        }

        private void BTN_Download_Click(object sender, System.EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string savePath = Path.Combine(fbd.SelectedPath, "ScrewyDraw.txt");

                    File.WriteAllText(savePath, RTB_Content.Text);

                    MessageBox.Show($"Saved in: \n\n{savePath}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}