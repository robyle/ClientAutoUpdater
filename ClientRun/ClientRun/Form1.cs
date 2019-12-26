using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace ClientRun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutoUpdater.Start("http://jwroby.imwork.net/AutoUpdaterTest.xml");
        }
        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args != null)
            {
                if (args.IsUpdateAvailable)
                {
                    DialogResult dialogResult;
                    if (args.Mandatory)
                    {
                        dialogResult =
                            MessageBox.Show(
                                $@"这里有新的版本 {args.CurrentVersion} 可用.你可以使用 {args.InstalledVersion}. 这些需要更新. 点击OK进行更新.", @"可用更新",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    }
                    else
                    {
                        dialogResult =
                            MessageBox.Show(
                                $@"这里有新的版本 {args.CurrentVersion} 可用.你所处的版本 {
                                        args.InstalledVersion
                                    }. 你现在想更新客户端吗?", @"可用更新可用更新",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
                    }
                    if (dialogResult.Equals(DialogResult.Yes) || dialogResult.Equals(DialogResult.OK))
                    {
                        try
                        {
                            if (AutoUpdater.DownloadUpdate())
                            {
                                Application.Exit();
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, exception.GetType().ToString(), MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(@"当前没有更新的版本,请晚点再重试.", @"没有可更新的.",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                        @"更新出了点问题，网络无法到达更新服务器，请检查网络后进行重试.",
                        @"更新出错！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
