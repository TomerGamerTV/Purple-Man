using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Purple_Man
{
    public partial class Form3 : Form
    {
        readonly ExploitAPI api = new ExploitAPI();

        public Form3()
        {
            InitializeComponent();
        }

        private void FlatButton1_Click(object sender, EventArgs e)
        {
            string script = fastColoredTextBox1.Text;
            api.SendLimitedLuaScript(script);
        }

        private void FlatButton2_Click(object sender, EventArgs e)
        {
            this.fastColoredTextBox1.Clear();
        }

        private void FlatButton3_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void FlatButton4_Click(object sender, EventArgs e)
        {
            string speed = textBox1.Text;
            api.SendLimitedLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed=" + speed);
        }

        private void FlatButton6_Click(object sender, EventArgs e)
        {
            this.api.SendLimitedLuaScript("_G.infinjump = not _G.infinjump\n\nlocal plr = game:GetService'Players'.LocalPlayer\nlocal m = plr:GetMouse()\nm.KeyDown:connect(function(k)\n\tif _G.infinjump then\n\t\tif k:byte() == 32 then\n\t\tplrh = game:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid'\n\t\tplrh:ChangeState('Jumping')\n\t\twait()\n\t\tplrh:ChangeState('Seated')\n\t\tend\n\tend\nend)");
        }

        private void FlatButton13_Click(object sender, EventArgs e)
        {
            this.api.SendLimitedLuaScript("game.Workspace.Events.TycoonItems.PurchaseGemItem:InvokeServer(-100000000, 'G12')");
        }

        private void FlatCheckBox1_CheckedChanged(object sender)
        {
            if (flatCheckBox1.Checked)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }
    }
}
