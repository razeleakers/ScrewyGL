using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrewyGL
{
    public partial class Result : Form
    {
        private readonly string allResult = string.Empty;
        private readonly string actualResult = string.Empty;
        private readonly string lastResult = string.Empty;

        public Result(string allContent,string actualContent,string lastContent)
        {
            InitializeComponent();
            allResult = allContent;
            actualResult = actualContent;
            lastResult = lastContent;

            RTB_Content.Text = allResult;
        }

        private async void BTN_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RTB_Content.Text);
            BTN_Copy.Text = "Copied!";
            await Task.Delay(400);
            BTN_Copy.Text = "Copy";
        }

        private void BTN_Download_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter data = new StreamWriter(Path.Combine(dialog.SelectedPath, "ScrewyGL_Result.txt")))
                    {
                        data.Write(RTB_Content.Text);
                        MessageBox.Show("Saved in: " + dialog.SelectedPath, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void BTN_ShowAll_Click(object sender, EventArgs e)
        {
            RTB_Content.Text = allResult;
            RTB_Content.ScrollToCaret();
        }

        private void BTN_ShowActual_Click(object sender, EventArgs e)
        {
            RTB_Content.Text = actualResult;
            RTB_Content.ScrollToCaret();
        }

        private void BTN_ShowLast_Click(object sender, EventArgs e)
        {
            RTB_Content.Text = lastResult;
            RTB_Content.ScrollToCaret();
        }
    }
}
