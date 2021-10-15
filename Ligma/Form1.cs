using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sxlib;
using sxlib.Specialized;

namespace Ligma
{
    public partial class Ligma : Form
    {
        public bool Attached;
        public bool loaded = false;
        public static string Direct = Directory.GetCurrentDirectory();
        public Ligma()
        {
            InitializeComponent();
            Functions.Lib = SxLib.InitializeWinForms(this, Direct);
        }

        private void SynLoadEvent(SxLibBase.SynLoadEvents Event, object Param)
        {
            switch (Event)
            {
                case SxLibBase.SynLoadEvents.CHECKING_WL:
                    this.Output.Items.Clear();
                    this.Output.Items.Add("Checking Whitelist");
                    return;
                case SxLibBase.SynLoadEvents.CHECKING_DATA:
                    this.Output.Items.Add("Checking Data");
                    return;
                case SxLibBase.SynLoadEvents.DOWNLOADING_DATA:
                    this.Output.Items.Add("Downloading Data");
                    return;
                case SxLibBase.SynLoadEvents.CHANGING_WL:
                    this.Output.Items.Add("Changing Whitelist");
                    return;
                case SxLibBase.SynLoadEvents.DOWNLOADING_DLLS:
                    this.Output.Items.Add("Downloading DLLS");
                    return;
                case SxLibBase.SynLoadEvents.NOT_UPDATED:
                    MessageBox.Show("Ligma is currently not up to date, we will usually update within the next 24 hours.");
                    Environment.Exit(0);
                    return;
                case SxLibBase.SynLoadEvents.READY:
                    this.Output.Items.Add("Ready");
                    loaded = true;
                    return;
            }
        }

        private void SynAttachEvent(SxLibBase.SynAttachEvents Event, object Param)
        {
            switch (Event)
            {
                case SxLibBase.SynAttachEvents.CHECKING:
                    this.Output.Items.Clear();
                    this.Output.Items.Add("Checking");
                    return;
                case SxLibBase.SynAttachEvents.CHECKING_WHITELIST:
                    this.Output.Items.Add("Checking Whitelist");
                    return;
                case SxLibBase.SynAttachEvents.INJECTING:
                    this.Output.Items.Add("Injecting");
                    return;
                case SxLibBase.SynAttachEvents.PROC_DELETION:
                    this.Output.Items.Clear();
                    return;
                case SxLibBase.SynAttachEvents.SCANNING:
                    this.Output.Items.Add("Scanning");
                    return;
                case SxLibBase.SynAttachEvents.FAILED_TO_FIND:
                    this.Output.Items.Add("Failed to find ROBLOX");
                    return;
                case SxLibBase.SynAttachEvents.READY:
                    this.Output.Items.Add("Injected");
                    return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loaded != true) return;
            Functions.Lib.Execute(this.richTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Functions.Lib.Attach();
        }

        private void Ligma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Ligma_Load(object sender, EventArgs e)
        {
            Functions.Lib.LoadEvent += SynLoadEvent;
            Functions.Lib.Load();
            Functions.Lib.AttachEvent += SynAttachEvent;
        }
    }
}
