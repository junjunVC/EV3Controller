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

namespace EV3Controller
{
    public partial class Controller : Form
    {
        /// <summary>
        /// 画面表示状態
        /// </summary>
        enum ConnectStatus
        {
            NoConnect ,Connect
        }

        private SerialPort myPort;
        private ConnectStatus connectStatus;

        public Controller()
        {
            InitializeComponent();
        }

        /// <summary>
        /// EV3とのBluetooth接続
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                string PortName = this.PortNameTaxtBox.Text;
                int BaudRate = 9600;
                Parity Parity = Parity.None;
                int DataBits = 8;
                StopBits StopBits = StopBits.One;
                myPort = new SerialPort(PortName, BaudRate, Parity, DataBits, StopBits);
                myPort.Open();

                this.connectStatus = ConnectStatus.Connect;
                ChangeStatus();
            }
            catch(Exception ex)
            {
                MessageBox.Show("connect failed.");
            }
        }

        /// <summary>
        /// EV3とのBluetooth切断
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            try
            {
                myPort.Close();

                this.connectStatus = ConnectStatus.NoConnect;
                ChangeStatus();
            }
            catch(Exception ex)
            {
                MessageBox.Show("close failed.");
            }
        }

        /// <summary>
        /// EV3への送信(発信指示)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Send_Click(object sender, EventArgs e)
        {
            myPort.Write("1");
        }

        /// <summary>
        /// 初期表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Controller_Load(object sender, EventArgs e)
        {
            this.connectStatus = ConnectStatus.NoConnect;
            ChangeStatus();
        }

        /// <summary>
        /// 状態遷移
        /// </summary>
        private void ChangeStatus()
        {
            switch (this.connectStatus)
            {
                case ConnectStatus.NoConnect :
                    this.Connect.Enabled = true;
                    this.PortNameTaxtBox.Enabled = true;
                    this.Send.Enabled = false;
                    this.Close.Enabled = false;
                    break;
                case ConnectStatus.Connect : 
                    this.Connect.Enabled = false;
                    this.PortNameTaxtBox.Enabled = false;
                    this.Send.Enabled = true;
                    this.Close.Enabled = true;
                    break;
                default:
                    break;
            }
        }
    }
}
