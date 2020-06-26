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
using System.Timers;
using System.Diagnostics;

namespace ProgramSupraveghereVideo
{
    public partial class MainForm : Form
    {
        
        SerialPort myport = new SerialPort();
        string data_rx;


        private void CheckPort()
        {
            try
            {
                myport.Open();
                data_rx = myport.ReadLine();

                //SUFRAGERIE
                if (data_rx.Contains("SUFRAGERIE"))
                {
                    if (data_rx.Contains("detectat"))
                    {
                        //miscare detectata
                        panelSufragerie.BackColor = Color.Red;
                    }
                    else
                    {
                        //miscare incetata
                        panelSufragerie.BackColor = Color.Green;   
                    }
                    panelSufragerie.Refresh();
                }

                //DORMITOR
                if (data_rx.Contains("DORMITOR"))
                {
                    if (data_rx.Contains("detectat"))
                    {
                        //miscare detectata
                        panelDormitor.BackColor = Color.Red;
                    }
                    else
                    {
                        //miscare incetata
                        panelDormitor.BackColor = Color.Green;
                    }
                    panelDormitor.Refresh();
                }

                //BUCATARIE
                if (data_rx.Contains("BUCATARIE"))
                {
                    if (data_rx.Contains("detectat"))
                    {
                        //miscare detectata
                        panelBucatarie.BackColor = Color.Red;
                        labelBucatarie.Text = "ATENTIE - MISCARE IN BUCATARIE!";
                    }
                    else
                    {
                        //miscare incetata
                        panelBucatarie.BackColor = Color.Green;
                    }
                    panelBucatarie.Refresh();
                }

                // label1.Text = data_rx;
                myport.Close();
                butonVideo.Refresh();
            }
            catch (UnauthorizedAccessException unauthorizedAccessException)
            {
                ///facem ceva = problema
                myport.Close();
            }
            catch (Exception exception)
            {
                // exception.Message
                myport.Close();
            }

        }

        BackgroundWorker m_oWorker = new BackgroundWorker();

        // System.Threading.Timer timer = new System.Threading.Timer(_ => CheckPort(), null, 0, 500);

        public MainForm()
        {
            InitializeComponent();
            m_oWorker.DoWork += new DoWorkEventHandler(m_oWorker_DoWork);
            m_oWorker.WorkerSupportsCancellation = true;
        }

        void m_oWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckPort();
            if (m_oWorker.IsBusy)
            {
                m_oWorker.CancelAsync();
            }
        }

            private void Form1_Load(object sender, EventArgs e)
        {
            myport.BaudRate = 9600;
            myport.PortName = "COM3";
            labelSufragerie.Left = 0;
            labelSufragerie.Width = panelSufragerie.Width;
            labelDormitor.Left = 0;
            labelDormitor.Width = panelDormitor.Width;
            labelBucatarie.Left = 0;
            labelBucatarie.Width = panelBucatarie.Width;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //Application.DoEvents();
            // CheckPort();
            if (!m_oWorker.IsBusy)
            {
                m_oWorker.RunWorkerAsync();
            }
        }

        private void butonVideo_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "file:///C:/Users/40728/Documents/ArduinoData/packages/ArduCAM_ESP8266_UNO/hardware/ArduCAM_ESP8266_UNO/2.2.4/libraries/ArduCAM/examples/ESP8266/ArduCAM_ESP8266_UNO_Capture/html_2640/video.html");

        }
    }
}
