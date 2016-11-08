using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

// 
namespace ReactionTimeTester
{
    public partial class Form_Main : Form
    {
        delegate void SerialDataReceivedEventHandlerDel(object sender, SerialDataReceivedEventArgs e);
        delegate void SetTextCallback(string text);

        public static SerialPort sPort { get; set; }



        string dataReceived = "";

        public Form_Main()
        {
            InitializeComponent();
            sPort = new SerialPort();
            sPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceive);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void serialPort_DataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            dataReceived = sPort.ReadExisting();
            if (dataReceived != "")
                Invoke(new SetTextCallback(OutputText), new object[] { dataReceived });
        }

        private void OutputText(string t)
        {
            // rtbOut.Text += t;
        }

        private void _btnConfig_Click(object sender, EventArgs e)
        {
            Form_Config FormConfig = new Form_Config();
            FormConfig.Show();
        }
    }
}
