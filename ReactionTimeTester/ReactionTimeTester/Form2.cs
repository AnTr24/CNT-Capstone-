using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            _ddlBaudRate.Items.Add(300);
            _ddlBaudRate.Items.Add(600);
            _ddlBaudRate.Items.Add(1200);
            _ddlBaudRate.Items.Add(2400);
            _ddlBaudRate.Items.Add(9600);
            _ddlBaudRate.Items.Add(14400);
            _ddlBaudRate.Items.Add(19200);
            _ddlBaudRate.Items.Add(38400);
            _ddlBaudRate.Items.Add(57600);
            _ddlBaudRate.Items.Add(115200);
            _ddlBaudRate.Items.ToString();
            //get first item print in text
            _ddlBaudRate.Text = _ddlBaudRate.Items[0].ToString();
        }
    }
}
