using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.FlightSimulator.SimConnect;

namespace MotionSimulator.Main
{
    public partial class Main : Form
    {
        SimConnect simConnect = null;

        const int WM_USER_SIMCONNECT = 0x0402;

        enum DEFINITIONS
        {
            DataStructure,
        }

        enum DATA_REQUESTS
        {
            DataRequest,
        };

        // this is how you declare a data structure so that
        // simconnect knows how to fill it/read it.
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct DataStructure
        {
            public double pitch;
            public double roll;
            public double xAccel;
            public double yAccel;
            public double zAccel;
            public double gforce;
            public double rpm1;
            public double rpm2;
            public double surface;
            public double altaboveground;
            public double crashed;
            public double tas;
            public double heading;
            public double altitude;
        };

        public Main()
        {
            InitializeComponent();

            setButtons(true, false, false);
        }

        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg == WM_USER_SIMCONNECT)
            {
                if (simConnect != null)
                {
                    simConnect.ReceiveMessage();
                }
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }

        private void setButtons(bool connect, bool get, bool disconnect)
        {
            btnConnect.Enabled = connect;
            btnRequest.Enabled = get;
            btnDisconnect.Enabled = disconnect;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (simConnect == null)
            {
                try
                {
                    simConnect = new SimConnect("Managed Data Request", this.Handle, WM_USER_SIMCONNECT, null,0);
                    
                    setButtons(false, true, true);

                    initSystemEvent();
                }
                catch (COMException ex)
                {
                    DisplayText("Unable to connect to FSX " + ex.Message);
                }
            }
            else
            {
                DisplayText("Error - try again");
                closeConnection();
                setButtons(true, false, false);
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            // The following call returns identical information to:
            simConnect.RequestDataOnSimObject(DATA_REQUESTS.DataRequest, DEFINITIONS.DataStructure, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_PERIOD.SECOND,SIMCONNECT_DATA_REQUEST_FLAG.DEFAULT,0,0,0);

            //simConnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_1, DEFINITIONS.Struct1, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
            DisplayText("Request sent...");            
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            closeConnection();
            setButtons(true, false, false);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnDisconnect_Click(sender, null);
        }

        private void initSystemEvent()
        {
            try
            {
                simConnect.OnRecvOpen += new SimConnect.RecvOpenEventHandler(simConnect_OnRecvOpen);
                simConnect.OnRecvQuit += new SimConnect.RecvQuitEventHandler(simConnect_OnRecvQuit);

                simConnect.OnRecvException += new SimConnect.RecvExceptionEventHandler(simConnect_OnRecvException);

                simConnect.AddToDataDefinition(DEFINITIONS.DataStructure, "Plane Pitch Degrees", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simConnect.AddToDataDefinition(DEFINITIONS.DataStructure, "Plane Bank Degrees", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simConnect.AddToDataDefinition(DEFINITIONS.DataStructure, "Acceleration Body X", "feet per second squared", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simConnect.AddToDataDefinition(DEFINITIONS.DataStructure, "Acceleration Body Y", "feet per second squared", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simConnect.AddToDataDefinition(DEFINITIONS.DataStructure, "Acceleration Body Z", "feet per second squared", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simConnect.AddToDataDefinition(DEFINITIONS.DataStructure, "G Force", "GForce", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simConnect.AddToDataDefinition(DEFINITIONS.DataStructure, "General Eng Rpm:1", "rpm", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simConnect.AddToDataDefinition(DEFINITIONS.DataStructure, "General Eng Rpm:2", "rpm", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simConnect.AddToDataDefinition(DEFINITIONS.DataStructure, "Surface Type", "enum", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simConnect.AddToDataDefinition(DEFINITIONS.DataStructure, "Plane Alt Above Ground", "feet", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simConnect.AddToDataDefinition(DEFINITIONS.DataStructure, "Crash Flag", "enum", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simConnect.AddToDataDefinition(DEFINITIONS.DataStructure, "Airspeed True", "knots", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simConnect.AddToDataDefinition(DEFINITIONS.DataStructure, "Plane Heading Degrees Magnetic", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simConnect.AddToDataDefinition(DEFINITIONS.DataStructure, "Plane Altitude", "feet", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

                // IMPORTANT: register it with the simconnect managed wrapper marshaller
                // if you skip this step, you will only receive a uint in the .dwData field.
                simConnect.RegisterDataDefineStruct<DataStructure>(DEFINITIONS.DataStructure);
                
                // catch a simobject data request
                simConnect.OnRecvSimobjectData += new SimConnect.RecvSimobjectDataEventHandler(simConnect_OnRecvSimobjectData);

            }
            catch (COMException ex)
            {
                DisplayText(ex.Message);
            }
        }

        private void closeConnection()
        {
            if (simConnect != null)
            {
                // Dispose serves the same purpose as SimConnect_Close()
                simConnect.Dispose();
                simConnect = null;
                DisplayText("Connection closed");
            }
        }

        void simConnect_OnRecvOpen(SimConnect sender, SIMCONNECT_RECV_OPEN data)
        {
            DisplayText("Connected to FSX");
        }

        // The case where the user closes FSX
        void simConnect_OnRecvQuit(SimConnect sender, SIMCONNECT_RECV data)
        {
            DisplayText("FSX has exited");
            closeConnection();
        }

        void simConnect_OnRecvException(SimConnect sender, SIMCONNECT_RECV_EXCEPTION data)
        {
            DisplayText("Exception received: " + data.dwException);
        }

        void simConnect_OnRecvSimobjectData(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA data)
        {
            switch ((DATA_REQUESTS)data.dwRequestID)
            {
                case DATA_REQUESTS.DataRequest:
                    DataStructure s1 = (DataStructure)data.dwData[0];

                    pitch.Text = s1.pitch.ToString();
                    roll.Text = s1.roll.ToString();
                    xAccel.Text = s1.xAccel.ToString();
                    YAccel.Text = s1.yAccel.ToString();
                    ZAccel.Text = s1.zAccel.ToString();
                    GForce.Text = s1.gforce.ToString();
                    rpm1.Text = s1.rpm1.ToString();
                    rpm2.Text = s1.rpm2.ToString();
                    altAboveGround.Text = s1.altaboveground.ToString();
                    surface.Text = s1.surface.ToString();
                    crashed.Text = s1.crashed.ToString();
                    tas.Text = s1.tas.ToString();
                    heading.Text = s1.heading.ToString();
                    altitude.Text = s1.altitude.ToString();
                    break;

                default:
                    DisplayText("Unknown request ID: " + data.dwRequestID);
                    break;
            }
        }

        int response = 1;        
        string output = "\n\n\n\n\n\n\n\n\n\n";

        void DisplayText(string s)
        {
            // remove first string from output
            output = output.Substring(output.IndexOf("\n") + 1);

            // add the new string
            output += "\n" + response++ + ":" + s;

            // display it
            richResponse.Text = output;
        }

        private void tbYaw_Scroll(object sender, EventArgs e)
        {
            txtYawPosition.Text = String.Format(tbYaw.Value.ToString() + ".0{0}","°");
        }

        private void tbPitch_Scroll(object sender, EventArgs e)
        {
            txtPitchPosition.Text = String.Format(tbPitch.Value.ToString() + ".0{0}", "°");
        }

        private void tbRoll_Scroll(object sender, EventArgs e)
        {
            txtRollPosition.Text = String.Format(tbRoll.Value.ToString() + ".0{0}", "°");
        }

        private void tbSurge_Scroll(object sender, EventArgs e)
        {
            txtSurgePosition.Text = String.Format(tbSurge.Value.ToString() + ".0{0}", "°");
        }

        private void tbSway_Scroll(object sender, EventArgs e)
        {
            txtSwayPosition.Text = String.Format(tbSway.Value.ToString() + ".0{0}", "°");
        }

        private void tbHeave_Scroll(object sender, EventArgs e)
        {
            txtHeavePosition.Text = String.Format(tbHeave.Value.ToString() + ".0{0}", "°");
        }

        private void btnSimulation_Click(object sender, EventArgs e)
        {
            bool fullScreen = false;

            if (CreateGLWindow("Motion Simulator", 800, 600, 16, fullScreen))
            {
                DisplayText("Simulating");
            }
        }

        private bool CreateGLWindow(string title, int width, int height, int bits, bool fullScreen)
        {
            Simulator simForm = new Simulator();
            simForm.Show();
            return true;
        }
    }
}
