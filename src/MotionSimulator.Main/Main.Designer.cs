namespace MotionSimulator.Main
{
    partial class Main
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.richResponse = new System.Windows.Forms.RichTextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.pitch = new System.Windows.Forms.TextBox();
            this.altitude = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.heading = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.crashed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.surface = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rpm1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rpm2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GForce = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ZAccel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.YAccel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.xAccel = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.roll = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.altAboveGround = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrTest = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYawPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbYaw = new System.Windows.Forms.TrackBar();
            this.tbPitch = new System.Windows.Forms.TrackBar();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPitchPosition = new System.Windows.Forms.TextBox();
            this.tbRoll = new System.Windows.Forms.TrackBar();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRollPosition = new System.Windows.Forms.TextBox();
            this.tbSurge = new System.Windows.Forms.TrackBar();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSurgePosition = new System.Windows.Forms.TextBox();
            this.tbSway = new System.Windows.Forms.TrackBar();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSwayPosition = new System.Windows.Forms.TextBox();
            this.tbHeave = new System.Windows.Forms.TrackBar();
            this.label20 = new System.Windows.Forms.Label();
            this.txtHeavePosition = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtServo5Position = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtServo4Position = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtServo3Position = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtServo2Position = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtServo1Position = new System.Windows.Forms.TextBox();
            this.txtServo0Position = new System.Windows.Forms.TextBox();
            this.btnSimulation = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbYaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSurge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeave)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 37);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(128, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect to FSX";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(12, 225);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(128, 23);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect from FSX";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(12, 115);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(128, 47);
            this.btnRequest.TabIndex = 2;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // richResponse
            // 
            this.richResponse.BackColor = System.Drawing.SystemColors.Control;
            this.richResponse.Location = new System.Drawing.Point(148, 37);
            this.richResponse.Name = "richResponse";
            this.richResponse.Size = new System.Drawing.Size(207, 211);
            this.richResponse.TabIndex = 3;
            this.richResponse.Text = "";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(798, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(31, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Pitch";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pitch
            // 
            this.pitch.Enabled = false;
            this.pitch.Location = new System.Drawing.Point(801, 40);
            this.pitch.Name = "pitch";
            this.pitch.Size = new System.Drawing.Size(79, 20);
            this.pitch.TabIndex = 5;
            this.pitch.Text = "0";
            this.pitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // altitude
            // 
            this.altitude.Enabled = false;
            this.altitude.Location = new System.Drawing.Point(801, 510);
            this.altitude.Name = "altitude";
            this.altitude.Size = new System.Drawing.Size(79, 20);
            this.altitude.TabIndex = 11;
            this.altitude.Text = "0";
            this.altitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(798, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Altitude";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heading
            // 
            this.heading.Enabled = false;
            this.heading.Location = new System.Drawing.Point(801, 471);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(79, 20);
            this.heading.TabIndex = 13;
            this.heading.Text = "0";
            this.heading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(798, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Heading";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tas
            // 
            this.tas.Enabled = false;
            this.tas.Location = new System.Drawing.Point(801, 432);
            this.tas.Name = "tas";
            this.tas.Size = new System.Drawing.Size(79, 20);
            this.tas.TabIndex = 15;
            this.tas.Text = "0";
            this.tas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(798, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "TAS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // crashed
            // 
            this.crashed.Enabled = false;
            this.crashed.Location = new System.Drawing.Point(801, 393);
            this.crashed.Name = "crashed";
            this.crashed.Size = new System.Drawing.Size(79, 20);
            this.crashed.TabIndex = 17;
            this.crashed.Text = "0";
            this.crashed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(798, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Crashed";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // surface
            // 
            this.surface.Enabled = false;
            this.surface.Location = new System.Drawing.Point(801, 354);
            this.surface.Name = "surface";
            this.surface.Size = new System.Drawing.Size(79, 20);
            this.surface.TabIndex = 19;
            this.surface.Text = "0";
            this.surface.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(798, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Surface Type";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rpm1
            // 
            this.rpm1.Enabled = false;
            this.rpm1.Location = new System.Drawing.Point(801, 274);
            this.rpm1.Name = "rpm1";
            this.rpm1.Size = new System.Drawing.Size(79, 20);
            this.rpm1.TabIndex = 21;
            this.rpm1.Text = "0";
            this.rpm1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(798, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "RPM 1";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rpm2
            // 
            this.rpm2.Enabled = false;
            this.rpm2.Location = new System.Drawing.Point(801, 313);
            this.rpm2.Name = "rpm2";
            this.rpm2.Size = new System.Drawing.Size(79, 20);
            this.rpm2.TabIndex = 23;
            this.rpm2.Text = "0";
            this.rpm2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(798, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "RPM 2";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GForce
            // 
            this.GForce.Enabled = false;
            this.GForce.Location = new System.Drawing.Point(801, 235);
            this.GForce.Name = "GForce";
            this.GForce.Size = new System.Drawing.Size(79, 20);
            this.GForce.TabIndex = 25;
            this.GForce.Text = "0";
            this.GForce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(798, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "G Force";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ZAccel
            // 
            this.ZAccel.Enabled = false;
            this.ZAccel.Location = new System.Drawing.Point(801, 196);
            this.ZAccel.Name = "ZAccel";
            this.ZAccel.Size = new System.Drawing.Size(79, 20);
            this.ZAccel.TabIndex = 27;
            this.ZAccel.Text = "0";
            this.ZAccel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(798, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Z Accel";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YAccel
            // 
            this.YAccel.Enabled = false;
            this.YAccel.Location = new System.Drawing.Point(801, 157);
            this.YAccel.Name = "YAccel";
            this.YAccel.Size = new System.Drawing.Size(79, 20);
            this.YAccel.TabIndex = 29;
            this.YAccel.Text = "0";
            this.YAccel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(798, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Y Accel";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xAccel
            // 
            this.xAccel.Enabled = false;
            this.xAccel.Location = new System.Drawing.Point(801, 118);
            this.xAccel.Name = "xAccel";
            this.xAccel.Size = new System.Drawing.Size(79, 20);
            this.xAccel.TabIndex = 31;
            this.xAccel.Text = "0";
            this.xAccel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(798, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "X Accel";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roll
            // 
            this.roll.Enabled = false;
            this.roll.Location = new System.Drawing.Point(801, 79);
            this.roll.Name = "roll";
            this.roll.Size = new System.Drawing.Size(79, 20);
            this.roll.TabIndex = 33;
            this.roll.Text = "0";
            this.roll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(798, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Roll";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // altAboveGround
            // 
            this.altAboveGround.Enabled = false;
            this.altAboveGround.Location = new System.Drawing.Point(801, 549);
            this.altAboveGround.Name = "altAboveGround";
            this.altAboveGround.Size = new System.Drawing.Size(79, 20);
            this.altAboveGround.TabIndex = 34;
            this.altAboveGround.Text = "0";
            this.altAboveGround.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Altitude Abv Ground";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrTest
            // 
            this.tmrTest.Interval = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbHeave);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtHeavePosition);
            this.groupBox1.Controls.Add(this.tbSway);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtSwayPosition);
            this.groupBox1.Controls.Add(this.tbSurge);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtSurgePosition);
            this.groupBox1.Controls.Add(this.tbRoll);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtRollPosition);
            this.groupBox1.Controls.Add(this.tbPitch);
            this.groupBox1.Controls.Add(this.tbYaw);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPitchPosition);
            this.groupBox1.Controls.Add(this.txtYawPosition);
            this.groupBox1.Location = new System.Drawing.Point(12, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 256);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Platform Position";
            // 
            // txtYawPosition
            // 
            this.txtYawPosition.Location = new System.Drawing.Point(50, 21);
            this.txtYawPosition.Name = "txtYawPosition";
            this.txtYawPosition.Size = new System.Drawing.Size(38, 20);
            this.txtYawPosition.TabIndex = 0;
            this.txtYawPosition.Text = "0.0°";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yaw:";
            // 
            // tbYaw
            // 
            this.tbYaw.LargeChange = 1;
            this.tbYaw.Location = new System.Drawing.Point(88, 13);
            this.tbYaw.Maximum = 50;
            this.tbYaw.Minimum = -50;
            this.tbYaw.Name = "tbYaw";
            this.tbYaw.Size = new System.Drawing.Size(134, 45);
            this.tbYaw.TabIndex = 2;
            this.tbYaw.TickFrequency = 0;
            this.tbYaw.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbYaw.Scroll += new System.EventHandler(this.tbYaw_Scroll);
            // 
            // tbPitch
            // 
            this.tbPitch.LargeChange = 1;
            this.tbPitch.Location = new System.Drawing.Point(88, 50);
            this.tbPitch.Maximum = 50;
            this.tbPitch.Minimum = -50;
            this.tbPitch.Name = "tbPitch";
            this.tbPitch.Size = new System.Drawing.Size(134, 45);
            this.tbPitch.TabIndex = 39;
            this.tbPitch.TickFrequency = 0;
            this.tbPitch.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbPitch.Scroll += new System.EventHandler(this.tbPitch_Scroll);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Pitch:";
            // 
            // txtPitchPosition
            // 
            this.txtPitchPosition.Location = new System.Drawing.Point(50, 57);
            this.txtPitchPosition.Name = "txtPitchPosition";
            this.txtPitchPosition.Size = new System.Drawing.Size(38, 20);
            this.txtPitchPosition.TabIndex = 37;
            this.txtPitchPosition.Text = "0.0°";
            // 
            // tbRoll
            // 
            this.tbRoll.LargeChange = 1;
            this.tbRoll.Location = new System.Drawing.Point(88, 87);
            this.tbRoll.Maximum = 50;
            this.tbRoll.Minimum = -50;
            this.tbRoll.Name = "tbRoll";
            this.tbRoll.Size = new System.Drawing.Size(134, 45);
            this.tbRoll.TabIndex = 42;
            this.tbRoll.TickFrequency = 0;
            this.tbRoll.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbRoll.Scroll += new System.EventHandler(this.tbRoll_Scroll);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "Roll:";
            // 
            // txtRollPosition
            // 
            this.txtRollPosition.Location = new System.Drawing.Point(50, 94);
            this.txtRollPosition.Name = "txtRollPosition";
            this.txtRollPosition.Size = new System.Drawing.Size(38, 20);
            this.txtRollPosition.TabIndex = 40;
            this.txtRollPosition.Text = "0.0°";
            // 
            // tbSurge
            // 
            this.tbSurge.LargeChange = 1;
            this.tbSurge.Location = new System.Drawing.Point(88, 127);
            this.tbSurge.Maximum = 50;
            this.tbSurge.Minimum = -50;
            this.tbSurge.Name = "tbSurge";
            this.tbSurge.Size = new System.Drawing.Size(134, 45);
            this.tbSurge.TabIndex = 45;
            this.tbSurge.TickFrequency = 0;
            this.tbSurge.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbSurge.Scroll += new System.EventHandler(this.tbSurge_Scroll);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 137);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 44;
            this.label18.Text = "Surge:";
            // 
            // txtSurgePosition
            // 
            this.txtSurgePosition.Location = new System.Drawing.Point(50, 134);
            this.txtSurgePosition.Name = "txtSurgePosition";
            this.txtSurgePosition.Size = new System.Drawing.Size(38, 20);
            this.txtSurgePosition.TabIndex = 43;
            this.txtSurgePosition.Text = "0.0°";
            // 
            // tbSway
            // 
            this.tbSway.LargeChange = 1;
            this.tbSway.Location = new System.Drawing.Point(88, 165);
            this.tbSway.Maximum = 50;
            this.tbSway.Minimum = -50;
            this.tbSway.Name = "tbSway";
            this.tbSway.Size = new System.Drawing.Size(134, 45);
            this.tbSway.TabIndex = 48;
            this.tbSway.TickFrequency = 0;
            this.tbSway.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbSway.Scroll += new System.EventHandler(this.tbSway_Scroll);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 175);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 47;
            this.label19.Text = "Sway:";
            // 
            // txtSwayPosition
            // 
            this.txtSwayPosition.Location = new System.Drawing.Point(50, 173);
            this.txtSwayPosition.Name = "txtSwayPosition";
            this.txtSwayPosition.Size = new System.Drawing.Size(38, 20);
            this.txtSwayPosition.TabIndex = 46;
            this.txtSwayPosition.Text = "0.0°";
            // 
            // tbHeave
            // 
            this.tbHeave.LargeChange = 1;
            this.tbHeave.Location = new System.Drawing.Point(88, 204);
            this.tbHeave.Maximum = 50;
            this.tbHeave.Minimum = -50;
            this.tbHeave.Name = "tbHeave";
            this.tbHeave.Size = new System.Drawing.Size(134, 45);
            this.tbHeave.TabIndex = 51;
            this.tbHeave.TickFrequency = 0;
            this.tbHeave.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbHeave.Scroll += new System.EventHandler(this.tbHeave_Scroll);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 214);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 13);
            this.label20.TabIndex = 50;
            this.label20.Text = "Heave:";
            // 
            // txtHeavePosition
            // 
            this.txtHeavePosition.Location = new System.Drawing.Point(50, 211);
            this.txtHeavePosition.Name = "txtHeavePosition";
            this.txtHeavePosition.Size = new System.Drawing.Size(38, 20);
            this.txtHeavePosition.TabIndex = 49;
            this.txtHeavePosition.Text = "0.0°";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtServo5Position);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.txtServo4Position);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.txtServo3Position);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.txtServo2Position);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.txtServo1Position);
            this.groupBox2.Controls.Add(this.txtServo0Position);
            this.groupBox2.Location = new System.Drawing.Point(248, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 256);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servo Position";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 214);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 13);
            this.label21.TabIndex = 50;
            this.label21.Text = "Servo 5:";
            // 
            // txtServo5Position
            // 
            this.txtServo5Position.Location = new System.Drawing.Point(56, 211);
            this.txtServo5Position.Name = "txtServo5Position";
            this.txtServo5Position.Size = new System.Drawing.Size(38, 20);
            this.txtServo5Position.TabIndex = 49;
            this.txtServo5Position.Text = "0.0°";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 175);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 13);
            this.label22.TabIndex = 47;
            this.label22.Text = "Servo 4:";
            // 
            // txtServo4Position
            // 
            this.txtServo4Position.Location = new System.Drawing.Point(56, 173);
            this.txtServo4Position.Name = "txtServo4Position";
            this.txtServo4Position.Size = new System.Drawing.Size(38, 20);
            this.txtServo4Position.TabIndex = 46;
            this.txtServo4Position.Text = "0.0°";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 137);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(47, 13);
            this.label23.TabIndex = 44;
            this.label23.Text = "Servo 3:";
            // 
            // txtServo3Position
            // 
            this.txtServo3Position.Location = new System.Drawing.Point(56, 134);
            this.txtServo3Position.Name = "txtServo3Position";
            this.txtServo3Position.Size = new System.Drawing.Size(38, 20);
            this.txtServo3Position.TabIndex = 43;
            this.txtServo3Position.Text = "0.0°";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 97);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 13);
            this.label24.TabIndex = 41;
            this.label24.Text = "Servo 2:";
            // 
            // txtServo2Position
            // 
            this.txtServo2Position.Location = new System.Drawing.Point(56, 94);
            this.txtServo2Position.Name = "txtServo2Position";
            this.txtServo2Position.Size = new System.Drawing.Size(38, 20);
            this.txtServo2Position.TabIndex = 40;
            this.txtServo2Position.Text = "0.0°";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 60);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 13);
            this.label25.TabIndex = 38;
            this.label25.Text = "Servo 1:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 23);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(47, 13);
            this.label26.TabIndex = 1;
            this.label26.Text = "Servo 0:";
            // 
            // txtServo1Position
            // 
            this.txtServo1Position.Location = new System.Drawing.Point(56, 57);
            this.txtServo1Position.Name = "txtServo1Position";
            this.txtServo1Position.Size = new System.Drawing.Size(38, 20);
            this.txtServo1Position.TabIndex = 37;
            this.txtServo1Position.Text = "0.0°";
            // 
            // txtServo0Position
            // 
            this.txtServo0Position.Location = new System.Drawing.Point(56, 21);
            this.txtServo0Position.Name = "txtServo0Position";
            this.txtServo0Position.Size = new System.Drawing.Size(38, 20);
            this.txtServo0Position.TabIndex = 0;
            this.txtServo0Position.Text = "0.0°";
            // 
            // btnSimulation
            // 
            this.btnSimulation.Location = new System.Drawing.Point(12, 76);
            this.btnSimulation.Name = "btnSimulation";
            this.btnSimulation.Size = new System.Drawing.Size(128, 23);
            this.btnSimulation.TabIndex = 38;
            this.btnSimulation.Text = "Simulation";
            this.btnSimulation.UseVisualStyleBackColor = true;
            this.btnSimulation.Click += new System.EventHandler(this.btnSimulation_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 631);
            this.Controls.Add(this.btnSimulation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.altAboveGround);
            this.Controls.Add(this.roll);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.xAccel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.YAccel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ZAccel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.GForce);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rpm2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rpm1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.surface);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.crashed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.altitude);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pitch);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.richResponse);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "Main";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbYaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSurge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeave)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.RichTextBox richResponse;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox pitch;
        private System.Windows.Forms.TextBox altitude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox heading;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox crashed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox surface;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox rpm1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rpm2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox GForce;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ZAccel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox YAccel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox xAccel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox roll;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox altAboveGround;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tbYaw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYawPosition;
        private System.Windows.Forms.TrackBar tbHeave;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtHeavePosition;
        private System.Windows.Forms.TrackBar tbSway;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSwayPosition;
        private System.Windows.Forms.TrackBar tbSurge;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSurgePosition;
        private System.Windows.Forms.TrackBar tbRoll;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtRollPosition;
        private System.Windows.Forms.TrackBar tbPitch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPitchPosition;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtServo5Position;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtServo4Position;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtServo3Position;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtServo2Position;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtServo1Position;
        private System.Windows.Forms.TextBox txtServo0Position;
        private System.Windows.Forms.Button btnSimulation;
    }
}

