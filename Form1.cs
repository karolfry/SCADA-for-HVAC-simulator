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

namespace Scada_projekt
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
            alert_filtr_1.Visible = false;
            alert_filtr_2.Visible = false;
            alert_vent_1.Visible = false;
            alert_vent_2.Visible = false;

            comboBox_Port.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_BaudRate.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Databits.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Stopbits.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Paryty.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (String s in System.IO.Ports.SerialPort.GetPortNames())
            {
                comboBox_Port.Items.Add(s);
                try
                {

                    comboBox_Port.SelectedIndex = comboBox_Port.FindString("COM13");
                    comboBox_BaudRate.SelectedIndex = 0;
                    comboBox_Paryty.SelectedIndex = 2;
                    comboBox_Databits.SelectedIndex = 4;
                    comboBox_Stopbits.SelectedIndex = 1;
                }
                catch (System.ArgumentOutOfRangeException e) { }
                
            }
            
           

        }


        public void serialport_connect(String port, int baudrate, Parity parity, int databits, StopBits stopbits)
        {
            DateTime dt = DateTime.Now;
            String dtn = dt.ToShortTimeString();

            serialPort1 = new System.IO.Ports.SerialPort(
            port, baudrate, parity, databits, stopbits);

            try
            {
                serialPort1.Open();

                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

                connect_flag = true;
                button_Connect.Text = "Disconnect";
                ComboBoxEnable(false);
                
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error"); }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

         

           // appendText(serialPort1.ReadExisting() + "\n");

            recive_bufor_int[recive_step] = serialPort1.ReadByte();
            recive_step++;

            if(recive_step == 4)
                if ((int)recive_bufor_int[recive_step] % 2 == 1)
                {
                    
                }
                else
                    alert_filtr_1.Invoke(new Action(delegate()
                    {
                        alert_filtr_1.Visible = false;
                    }));
        }

       

        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (connect_flag == false)
            {

                String port = comboBox_Port.Text;
                int baudrate = Convert.ToInt32(comboBox_BaudRate.Text);
                Parity parity = (Parity)Enum.Parse(typeof(Parity), comboBox_Paryty.Text);
                int databits = Convert.ToInt32(comboBox_Databits.Text);
                StopBits stopbits = (StopBits)Enum.Parse(typeof(StopBits), comboBox_Stopbits.Text);

                Modbus_adr = Decimal.ToInt16(numericUpDown1.Value);
                send_bufor_int[0] = Modbus_adr;

                serialport_connect(port, baudrate, parity, databits, stopbits);

                textBox1.AppendText("connect\n");
                //serialPort1.Write("A");
                transmit(true);
                

            }
            else
            {
                serialPort1.Close();
                ComboBoxEnable(true);
                connect_flag = false;
                button_Connect.Text = "Connect";
                alert_filtr_1.Visible = false;
            }

        }

        private void ComboBoxEnable(Boolean flag)
        {
            comboBox_Databits.Enabled = flag;
            comboBox_BaudRate.Enabled = flag;
            comboBox_Paryty.Enabled = flag;
            comboBox_Port.Enabled = flag;
            comboBox_Stopbits.Enabled = flag;
            numericUpDown1.Enabled = flag;
        }

        void appendText(string str)
        {
            if (textBox1.InvokeRequired)
                textBox1.Invoke(new Action<string>(appendText), str);
            else
                textBox1.AppendText(str);
        }

      



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
    
        }


        private void transmit(Boolean R_W0)
        {
            send_bufor_int[1] = 3;
            send_bufor_int[2] = 0;
            send_bufor_int[3] = 101;
            send_bufor_int[4] = 0;
            send_bufor_int[5] = 1;
            crc16_compute();

            recive_step = 0;

            for (int x=0; x < 8; x++)
            {
                send_bufor_byte[x] = (byte)send_bufor_int[x];
            }

           
            

            serialPort1.Write(send_bufor_byte, 0, 8);

        }

        private void crc16_compute()
        {
            int int_crc = 0xFFFF;
            int int_lsb;

            for (int int_i = 0; int_i < send_bufor_int.Length - 2; int_i++)
            {
                int_crc = int_crc ^ send_bufor_int[int_i];
                for (int int_j = 0; int_j < 8; int_j++)
                {
                    int_lsb = int_crc & 0x0001;  // Mask of LSB
                    int_crc = int_crc >> 1;
                    int_crc = int_crc & 0x7FFF;
                    if (int_lsb == 1) int_crc = int_crc ^ 0xA001;
                }
            }
            send_bufor_int[6] = int_crc & 0x00FF;
            send_bufor_int[7] = (int_crc >> 8) & 0x00FF;
        }
        Boolean connect_flag = false;
        int Modbus_adr = 0;
        int Step = 0;
        int[] send_bufor_int = new int[8];
        byte[] send_bufor_byte = new byte[8];
        int[] recive_bufor_int = new int[8];
        char[] recive_bufor_char = new char[8];
        int recive_step=0;

    }
}
