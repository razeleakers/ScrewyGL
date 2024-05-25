using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrewyGL
{
    public partial class Result : Form
    {
        private readonly string allResult;
        private readonly string actualResult;
        private readonly string lastResult;

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
            using (FolderBrowserDialog browserDG = new FolderBrowserDialog())
            {
                if (browserDG.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter data = new StreamWriter(Path.Combine(browserDG.SelectedPath, "ScrewyDraw2D_Result.txt")))
                    {
                        data.Write(RTB_Content.Text);
                        MessageBox.Show("Saved in: \n" + Path.Combine(browserDG.SelectedPath, "ScrewyDraw2D_Result.txt"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
