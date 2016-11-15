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

// Driver Main Form:    Provides user login/sign up options. Serial port configuration will create a config form.
// Author:              YunJie Li
// Date:                November 2016
namespace ReactionTimeTester
{
    // Delegates
    delegate void SetTextCallback(string text);

    public partial class Form_Main : Form
    {
        private string connString = "Data Source=bender.net.nait.ca,24680;Initial Catalog=atran26_Capstone2016;Persist Security Info=True;User ID=atran26;Password=CNT_123";
        public static SerialPort sPort { get; set; }

        string dataReceived = "";

        public Form_Main()
        {
            InitializeComponent();

            // Initialize the serial port, set default baud rate to 19200 (we will use this)
            sPort = new SerialPort();
            sPort.BaudRate = 19200;
        }

        // Data receive event handler
        private void _sPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Read the existing data from port
            dataReceived = sPort.ReadExisting();

            // If we receive data from serial, invoke the call back method (InsertData)
            if (dataReceived != "")
                Invoke(new SetTextCallback(InsertData), new object[] { dataReceived });
        }

        // Call back method to insert serial data into database
        private void InsertData(string s)
        {
            // Connect with sql using the connecting string
            SqlConnection conn = new SqlConnection(connString);
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

        // Connect button handler
        private void _btnConn_Click(object sender, EventArgs e)
        {
            // If port is open
            if (sPort.IsOpen)
            {
                sPort.Close();
                _btnConfig.Enabled = true;
                _lblStatus.ForeColor = Color.Red;
                _lblStatus.Text = "Disconnected.";
                _btnConn.Text = "Connect";
            }
            // If port is closed
            else
            {
                sPort.Open();
                _btnConfig.Enabled = false;              
                _lblStatus.ForeColor = Color.Green;
                _lblStatus.Text = "Connected.";
                _btnConn.Text = "Disconnect";
            }

        }

        // New user check box changed handler
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
