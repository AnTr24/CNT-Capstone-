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
    delegate void ReadDataCallback(string text);

    public partial class Form_Main : Form
    {
        SqlConnection sqlConn = null;
        SqlCommand sqlCmd = null;
        private string connString = "Data Source=bender.net.nait.ca,24680;Initial Catalog=atran26_Capstone2016;Persist Security Info=True;User ID=atran26;Password=CNT_123";

        string username = null;
        string dataReceived = "";

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            sqlConn = new SqlConnection(connString);
            sqlConn.Open();
        }

        // Data receive event handler
        private void _sPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Read the existing data from port
                dataReceived = _sPort.ReadExisting();

                // If we receive data from serial, invoke the call back method (InsertData)
                if (dataReceived != "")
                    Invoke(new ReadDataCallback(InsertData), new object[] { dataReceived });
            }
            catch (Exception err)
            {
                Console.WriteLine("Error reading from serial port: " + err);
            }
        }



        private void _btnConfig_Click(object sender, EventArgs e)
        {
            // Clear status label
            _lblStatus.Text = "";

            // Initialize the config form and set the properties
            Form_Config FormConfig = new Form_Config();
            FormConfig.PortName = _sPort.PortName;
            FormConfig.BaudRate = _sPort.BaudRate;
            FormConfig.DataBits = _sPort.DataBits;
            FormConfig.StopBits = _sPort.StopBits;
            FormConfig.Handshake = _sPort.Handshake;
            FormConfig.Parity = _sPort.Parity;

            // Use modal dialog and if OK return the properties
            if (DialogResult.OK == FormConfig.ShowDialog())
            {
                _sPort.PortName = FormConfig.PortName;
                _sPort.BaudRate = FormConfig.BaudRate;
                _sPort.DataBits = FormConfig.DataBits;
                _sPort.StopBits = FormConfig.StopBits;
                _sPort.Handshake = FormConfig.Handshake;
                _sPort.Parity = FormConfig.Parity;

                _lblStatus.ForeColor = Color.Green;
                _lblStatus.Text = "Config successful.";
            }
        }

        // Connect button handler
        private void _btnConn_Click(object sender, EventArgs e)
        {
            // If port is open
            if (_sPort.IsOpen)
            {
                _sPort.Close();
                _btnConfig.Enabled = true;
                _lblStatus.ForeColor = Color.Red;
                _lblStatus.Text = "Disconnected.";
                _btnConn.Text = "Connect";
            }
            // If port is closed
            else
            {
                _sPort.Open();
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

        private void _btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void _btnSignup_Click(object sender, EventArgs e)
        {
            // Check if user has entered a username and password
            if (_tbxUsrn.Text == "" || _tbxPwd.Text == "")
            {
                _lblStatus.ForeColor = Color.Red;
                _lblStatus.Text = "Please enter your username and password.";
            }
            else if (_tbxPwd.Text != _tbxCnfmPwd.Text)
            {
                _lblStatus.ForeColor = Color.Red;
                _lblStatus.Text = "Password do not match. Please enter again.";
            }
            else
            {
                string usrN = _tbxUsrn.Text;
                string pswd = _tbxPwd.Text;

                sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlConn;

                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "AddUser";

                SqlParameter param = new SqlParameter();
                param.Direction = ParameterDirection.Input;
                param.ParameterName = "@username";
                param.SqlDbType = SqlDbType.NVarChar;
                param.Value = usrN;
                sqlCmd.Parameters.Add(param);

                param = new SqlParameter();
                param.Direction = ParameterDirection.Input;
                param.ParameterName = "@password";
                param.SqlDbType = SqlDbType.NVarChar;
                param.Value = pswd;
                sqlCmd.Parameters.Add(param);

                try
                {
                    if (sqlCmd.ExecuteNonQuery() == 0)
                    {
                        username = usrN;
                        _lblStatus.ForeColor = Color.Green;
                        _lblStatus.Text = "You have successfully logged in.";
                    }
                    else if (sqlCmd.ExecuteNonQuery() == 1)
                    {
                        _lblStatus.ForeColor = Color.Red;
                        _lblStatus.Text = "The username has been taken.";
                    }
                    else
                        Console.WriteLine(sqlCmd.ExecuteNonQuery());
                }
                catch (Exception err)
                {
                    Console.WriteLine("Error adding user: " + err.Message);
                }
            }
        }        
        
        // Call back method to insert serial data into database
        private void InsertData(string s)
        {
            float num = 0;
            if (float.TryParse(s, out num))
            {

                // Connect with sql using the connecting string
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlConn;

                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "TestProcedure";

                SqlParameter param = new SqlParameter();
                param.Direction = ParameterDirection.Input;
                param.ParameterName = "@teststring";
                param.SqlDbType = SqlDbType.NVarChar;
                param.Value = num.ToString();
                sqlCmd.Parameters.Add(param);

                sqlCmd.ExecuteNonQuery();
            }
            else
                Text = "Not float";
        }

    }
}
