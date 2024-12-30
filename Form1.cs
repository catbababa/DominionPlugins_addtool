using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace 批量添加成员
{
    public partial class Form1 : Form
    {
        private Queue<string> commandQueue = new Queue<string>();
        private bool isProcessingCommands = false;
        private int countdownTime = 5; 

        public Form1()
        {
            InitializeComponent();
            InitializeEventHandlers();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void InitializeEventHandlers()
        {
            btnAddMembers.Click += BtnAddMembers_Click;
            btnSetAdmins.Click += BtnSetAdmins_Click;
            tmrCountdown.Tick += TmrCountdown_Tick;
            tmrCommandDelay.Tick += TmrCommandDelay_Tick;
            tmrCountdown.Interval = 1000;
        }

        private void BtnAddMembers_Click(object sender, EventArgs e)
        {
            StartCommandQueue("/dominion member add", txtDominionName.Text);
        }

        private void BtnSetAdmins_Click(object sender, EventArgs e)
        {
            StartCommandQueue("/dominion member set_flag", txtDominionName.Text);
        }

        private void StartCommandQueue(string commandPrefix, string dominionName)
        {
            commandQueue.Clear();
            countdownTime = 5; 
            lblCountdown.Text = $"请在 {countdownTime} 秒内切换到 Minecraft 游戏窗口。";
            tmrCountdown.Start();
            foreach (string member in rtbMembers.Lines)
            {
                if (!string.IsNullOrWhiteSpace(member))
                {
                    string commandContent = $"{commandPrefix} {dominionName} {member}";
                    if (commandPrefix.Contains("set_flag"))
                    {
                        commandContent += " admin true";
                    }
                    commandQueue.Enqueue(commandContent.TrimStart('/')); 
                }
            }
        }

        private void TmrCountdown_Tick(object sender, EventArgs e)
        {
            countdownTime--;
            lblCountdown.Text = $"请在 {countdownTime} 秒内切换到 Minecraft 游戏窗口。";

            if (countdownTime <= 0)
            {
                tmrCountdown.Stop();
                ProcessCommandQueue();
            }
        }

        private void TmrCommandDelay_Tick(object sender, EventArgs e)
        {
            if (commandQueue.Count > 0 && !isProcessingCommands)
            {
                isProcessingCommands = true;
                string commandContent = commandQueue.Dequeue();
                SendCommandToMinecraft(commandContent);
                Task.Run(async () =>
                {
                    await Task.Delay(tmrCommandDelay.Interval);
                    isProcessingCommands = false;
                });
            }
            else
            {
                if (commandQueue.Count == 0)
                {
                    tmrCommandDelay.Stop();
                    lblCountdown.Text = "所有命令执行完毕";
                }
            }
        }

        private void SendCommandToMinecraft(string commandContent)
        {
            Clipboard.SetText(commandContent); 
            SendKeys.SendWait("/"); 
            Thread.Sleep(200); 
            SendCtrlV(); 
            SendKeys.SendWait("{ENTER}"); 
        }

        private void SendCtrlV()
        {
            keybd_event(VK_CONTROL, 0, 0, 0);
            keybd_event(VK_V, 0, 0, 0);
            keybd_event(VK_V, 0, (uint)KEYEVENTF.KEYUP, 0);
            keybd_event(VK_CONTROL, 0, (uint)KEYEVENTF.KEYUP, 0);
        }

        private void ProcessCommandQueue()
        {
            tmrCommandDelay.Start();
        }

        #region WinAPI Definitions

        const int VK_CONTROL = 0x11;
        const int VK_V = 0x56;

        enum KEYEVENTF
        {
            KEYUP = 0x0002
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        #endregion
    }
}
