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
        /// EV3への送信(停止指示)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stop_Click(object sender, EventArgs e)
        {
            myPort.Write("0");
            this.DisplayLabel.Text = "STOP";
        }

        /// <summary>
        /// EV3への送信(前進指示)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Forward_Click(object sender, EventArgs e)
        {
            myPort.Write("1");
            this.DisplayLabel.Text = "FORWARD";
        }

        /// <summary>
        /// EV3への送信(後退指示)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Click(object sender, EventArgs e)
        {
            myPort.Write("2");
            this.DisplayLabel.Text = "BACK";
        }

        /// <summary>
        /// EV3への送信(左旋回指示)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Left_Click(object sender, EventArgs e)
        {
            myPort.Write("3");
            this.DisplayLabel.Text = "LEFT";
        }

        /// <summary>
        /// EV3への送信(右旋回指示)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Right_Click(object sender, EventArgs e)
        {
            myPort.Write("4");
            this.DisplayLabel.Text = "RIGHT";
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
                    this.Stop.Enabled = false;
                    this.Forward.Enabled = false;
                    this.Back.Enabled = false;
                    this.Left.Enabled = false;
                    this.Right.Enabled = false;
                    this.Close.Enabled = false;
                    break;
                case ConnectStatus.Connect : 
                    this.Connect.Enabled = false;
                    this.PortNameTaxtBox.Enabled = false;
                    this.Stop.Enabled = true;
                    this.Forward.Enabled = true;
                    this.Back.Enabled = true;
                    this.Left.Enabled = true;
                    this.Right.Enabled = true;
                    this.Close.Enabled = true;
                    break;
                default:
                    break;
            }
        }

    }
}
