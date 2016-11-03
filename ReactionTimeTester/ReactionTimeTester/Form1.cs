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

        SerialPort sPort = new SerialPort();

        string dataReceived = "";

        public Form_Main()
        {
            InitializeComponent();
            sPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceive);
            Settings();
        }

        private void Settings()
        {
            sPort.PortName = "COM1";
            sPort.BaudRate = 19200;
            sPort.DataBits = 8;
            sPort.StopBits = StopBits.One;
            sPort.Handshake = Handshake.None;
            sPort.Parity = Parity.None;
            sPort.Open();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
