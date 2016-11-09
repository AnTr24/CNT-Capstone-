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
using System.Data.SqlClient;
using System.Configuration;

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

            // Initialize the serial port, set default baud rate to 19200 (we will use this)
            sPort = new SerialPort();
            sPort.BaudRate = 19200;

            sPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceive);

        }

        private void serialPort_DataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            dataReceived = sPort.ReadExisting();
            if (dataReceived != "")
                Invoke(new SetTextCallback(OutputText), new object[] { dataReceived });
            if (dataReceived != "")
                Invoke(new SetTextCallback(InsertData), new object[] { dataReceived });
        }

        private void OutputText(string t)
        {
            _lblStatus.Text += t;
        }

        private void InsertData(string s)
        {
            SqlConnection conn = new SqlConnection("Data Source=bender.net.nait.ca,24680;Initial Catalog=atran26_Capstone2016;Persist Security Info=True;User ID=atran26;Password=CNT_123");
            conn.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = conn;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "TestProcedure";

            SqlParameter param = new SqlParameter();
            param.Direction = ParameterDirection.Input;
            param.ParameterName = "@teststring";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = s;
            command.Parameters.Add(param);

            command.ExecuteNonQuery();
        }

        private void _btnConfig_Click(object sender, EventArgs e)
        {
            // Clear status label
            _lblStatus.Text = "";

            // Initialize the config form and set the properties
            Form_Config FormConfig = new Form_Config();
            FormConfig.PortName = sPort.PortName;
            FormConfig.BaudRate = sPort.BaudRate;
            FormConfig.DataBits = sPort.DataBits;
            FormConfig.StopBits = sPort.StopBits;
            FormConfig.Handshake = sPort.Handshake;
            FormConfig.Parity = sPort.Parity;

            // Use modal dialog and if OK return the properties
            if (DialogResult.OK == FormConfig.ShowDialog())
            {
                sPort.PortName = FormConfig.PortName;
                sPort.BaudRate = FormConfig.BaudRate;
                sPort.DataBits = FormConfig.DataBits;
                sPort.StopBits = FormConfig.StopBits;
                sPort.Handshake = FormConfig.Handshake;
                sPort.Parity = FormConfig.Parity;

                _lblStatus.ForeColor = Color.Green;
                _lblStatus.Text = "Config successful.";
            }
        }

        private void _btnConn_Click(object sender, EventArgs e)
        {
            sPort.Open();
        }

        private void _cbxNew_CheckedChanged(object sender, EventArgs e)
        {
            if (!_cbxNew.Checked)
            {
                _tbxCnfmPwd.Enabled = false;
                _btnLogin.Enabled = true;
                _btnSignup.Enabled = false;
                _lblCnfmPwd.Enabled = false;

            }
            else
            {
                _tbxCnfmPwd.Enabled = true;
                _btnLogin.Enabled = false;
                _btnSignup.Enabled = true;
                _lblCnfmPwd.Enabled = true;
            }

        }
    }
}
