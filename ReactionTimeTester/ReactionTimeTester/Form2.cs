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

namespace ReactionTimeTester
{
    public partial class Form_Config : Form
    {

        public Form_Config()
        {
            InitializeComponent();
        }

        private void Form_Config_Load(object sender, EventArgs e)
        {
            LoadDropDownLists();
            RestoreDefault();
        }

        private void _btnDefault_Click(object sender, EventArgs e)
        {
            RestoreDefault();
        }

        private void _btnConfirm_Click(object sender, EventArgs e)
        {
            Form_Main.sPort.PortName = _ddlPortName.Text.ToString();
            Form_Main.sPort.BaudRate = Convert.ToInt32(_ddlBaudRate.Text);
            Form_Main.sPort.DataBits = Convert.ToInt16(_ddlDataBits.Text);
            Form_Main.sPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), _ddlStopBits.Text);
            Form_Main.sPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), _ddlHandshake.Text);
            Form_Main.sPort.Parity = (Parity)Enum.Parse(typeof(Parity), _ddlParity.Text);
            
            // Close Config Form


    }

        // Load setting options into all the drop down lists 
        private void LoadDropDownLists()
        {
            // Load Port Names to the drop down list
            string[] portArr = SerialPort.GetPortNames();
            for (int i = 0; i < portArr.Length; i++)
                _ddlPortName.Items.Add(portArr[i]);

            // Load Baud Rates to drop down list
            _ddlBaudRate.Items.Add(300);
            _ddlBaudRate.Items.Add(600);
            _ddlBaudRate.Items.Add(1200);
            _ddlBaudRate.Items.Add(2400);
            _ddlBaudRate.Items.Add(4800);
            _ddlBaudRate.Items.Add(9600);
            _ddlBaudRate.Items.Add(14400);
            _ddlBaudRate.Items.Add(19200);
            _ddlBaudRate.Items.Add(38400);
            _ddlBaudRate.Items.Add(57600);
            _ddlBaudRate.Items.Add(115200);

            // Load Data Bits
            _ddlDataBits.Items.Add(7);
            _ddlDataBits.Items.Add(8);

            // Load Stop Bits
            _ddlStopBits.Items.Add("One");
            _ddlStopBits.Items.Add("OnePointFive");
            _ddlStopBits.Items.Add("Two");

            // Load Handshake
            _ddlHandshake.Items.Add("None");
            _ddlHandshake.Items.Add("XOnXOff");
            _ddlHandshake.Items.Add("RequestToSend");
            
            // Load Parity 
            _ddlParity.Items.Add("None");
            _ddlParity.Items.Add("Odd");
            _ddlParity.Items.Add("Even");
            _ddlParity.Items.Add("Mark");
            _ddlParity.Items.Add("Space");
        }

        // Restore all the drop down lists to the default settings
        private void RestoreDefault()
        {
            _ddlPortName.Text = _ddlPortName.Items[1].ToString();
            _ddlBaudRate.Text = _ddlBaudRate.Items[7].ToString();
            _ddlDataBits.Text = _ddlDataBits.Items[1].ToString();
            _ddlStopBits.Text = _ddlStopBits.Items[0].ToString();
            _ddlHandshake.Text = _ddlHandshake.Items[0].ToString();
            _ddlParity.Text = _ddlParity.Items[0].ToString();
        }

    }
}
