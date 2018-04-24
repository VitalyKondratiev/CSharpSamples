using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSample
{
    public partial class mainForm : Form
    {
        bool _runThread = false;

        public mainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            _runThread = true;
            startButton.Enabled = false;
            stopButton.Enabled = true;
            new Thread(delegate ()
            {
                while (_runThread && !this.IsDisposed)
                {
                    if (stringsListBox.Items.Count != 0)
                        AppendListBox(0);
                    Thread.Sleep(1000);
                }
                ResetButtons();
            }).Start();
        }

        private void ResetButtons()
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(ResetButtons), new object[] { });
                return;
            }
            startButton.Enabled = true;
            stopButton.Enabled = false;
        }

        public void AppendListBox(int index)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<int>(AppendListBox), new object[] { index });
                return;
            }
            threadListBox.Items.Add(stringsListBox.Items[index]);
            stringsListBox.Items.RemoveAt(index);
        }

        private void stringButton_Click(object sender, EventArgs e)
        {
            stringsListBox.Items.Add(stringTextBox.Text);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            _runThread = false;
        }
    }
}
