namespace Scada_projekt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.alert_filtr_1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.alert_vent_1 = new System.Windows.Forms.PictureBox();
            this.alert_filtr_2 = new System.Windows.Forms.PictureBox();
            this.alert_vent_2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.comboBox_Paryty = new System.Windows.Forms.ComboBox();
            this.comboBox_Databits = new System.Windows.Forms.ComboBox();
            this.comboBox_Stopbits = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.alert_filtr_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alert_vent_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alert_filtr_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alert_vent_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // alert_filtr_1
            // 
            this.alert_filtr_1.BackColor = System.Drawing.Color.White;
            this.alert_filtr_1.Image = global::Scada_projekt.Properties.Resources._600px_Warning_svg;
            this.alert_filtr_1.Location = new System.Drawing.Point(172, 246);
            this.alert_filtr_1.Name = "alert_filtr_1";
            this.alert_filtr_1.Size = new System.Drawing.Size(55, 50);
            this.alert_filtr_1.TabIndex = 1;
            this.alert_filtr_1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Scada_projekt.Properties.Resources.SCADA;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(928, 472);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // alert_vent_1
            // 
            this.alert_vent_1.BackColor = System.Drawing.Color.White;
            this.alert_vent_1.Image = global::Scada_projekt.Properties.Resources._600px_Warning_svg;
            this.alert_vent_1.Location = new System.Drawing.Point(493, 92);
            this.alert_vent_1.Name = "alert_vent_1";
            this.alert_vent_1.Size = new System.Drawing.Size(55, 50);
            this.alert_vent_1.TabIndex = 2;
            this.alert_vent_1.TabStop = false;
            // 
            // alert_filtr_2
            // 
            this.alert_filtr_2.BackColor = System.Drawing.Color.White;
            this.alert_filtr_2.Image = global::Scada_projekt.Properties.Resources._600px_Warning_svg;
            this.alert_filtr_2.Location = new System.Drawing.Point(758, 12);
            this.alert_filtr_2.Name = "alert_filtr_2";
            this.alert_filtr_2.Size = new System.Drawing.Size(55, 50);
            this.alert_filtr_2.TabIndex = 3;
            this.alert_filtr_2.TabStop = false;
            // 
            // alert_vent_2
            // 
            this.alert_vent_2.BackColor = System.Drawing.Color.White;
            this.alert_vent_2.Image = global::Scada_projekt.Properties.Resources._600px_Warning_svg;
            this.alert_vent_2.Location = new System.Drawing.Point(798, 145);
            this.alert_vent_2.Name = "alert_vent_2";
            this.alert_vent_2.Size = new System.Drawing.Size(55, 50);
            this.alert_vent_2.TabIndex = 4;
            this.alert_vent_2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(935, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port:";
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.Location = new System.Drawing.Point(938, 28);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Port.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(935, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Baud Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(935, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stopbits:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(935, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Databits:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(935, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Paryty:";
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Items.AddRange(new object[] {
            "9600"});
            this.comboBox_BaudRate.Location = new System.Drawing.Point(938, 80);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBox_BaudRate.TabIndex = 11;
            // 
            // comboBox_Paryty
            // 
            this.comboBox_Paryty.FormattingEnabled = true;
            this.comboBox_Paryty.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None",
            "Mark",
            "Space"});
            this.comboBox_Paryty.Location = new System.Drawing.Point(938, 131);
            this.comboBox_Paryty.Name = "comboBox_Paryty";
            this.comboBox_Paryty.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Paryty.TabIndex = 12;
            // 
            // comboBox_Databits
            // 
            this.comboBox_Databits.FormattingEnabled = true;
            this.comboBox_Databits.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_Databits.Location = new System.Drawing.Point(938, 186);
            this.comboBox_Databits.Name = "comboBox_Databits";
            this.comboBox_Databits.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Databits.TabIndex = 13;
            // 
            // comboBox_Stopbits
            // 
            this.comboBox_Stopbits.FormattingEnabled = true;
            this.comboBox_Stopbits.Items.AddRange(new object[] {
            "None",
            "One",
            "OnePointFive",
            "Two"});
            this.comboBox_Stopbits.Location = new System.Drawing.Point(938, 237);
            this.comboBox_Stopbits.Name = "comboBox_Stopbits";
            this.comboBox_Stopbits.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Stopbits.TabIndex = 14;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(949, 370);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(163, 91);
            this.textBox1.TabIndex = 15;
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(949, 332);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(98, 23);
            this.button_Connect.TabIndex = 16;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(935, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Modbus Adres:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(938, 287);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 473);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox_Stopbits);
            this.Controls.Add(this.comboBox_Databits);
            this.Controls.Add(this.comboBox_Paryty);
            this.Controls.Add(this.comboBox_BaudRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alert_vent_2);
            this.Controls.Add(this.alert_filtr_2);
            this.Controls.Add(this.alert_vent_1);
            this.Controls.Add(this.alert_filtr_1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.alert_filtr_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alert_vent_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alert_filtr_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alert_vent_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox alert_filtr_1;
        private System.Windows.Forms.PictureBox alert_vent_1;
        private System.Windows.Forms.PictureBox alert_filtr_2;
        private System.Windows.Forms.PictureBox alert_vent_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.ComboBox comboBox_Paryty;
        private System.Windows.Forms.ComboBox comboBox_Databits;
        private System.Windows.Forms.ComboBox comboBox_Stopbits;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

