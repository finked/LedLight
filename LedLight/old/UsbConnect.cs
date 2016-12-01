using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace LedLight
{

    public class UsbConnect
    {
        private SerialPort serialPort = new SerialPort();
        private int baudRate = 115200;
        private int dataBits = 8;
        private Handshake handshake = Handshake.None;
        private Parity parity = Parity.None; // private Parity parity = Parity.Even;
        private string portName = "COM3";
        private StopBits stopBits = StopBits.One;
        
        //private byte terminator = 0x61;
        public int BaudRate { get { return this.baudRate; } set { this.baudRate = value; } }
        public int DataBits { get { return this.dataBits; } set { this.dataBits = value; } }
        public Handshake Handshake { get { return this.handshake; } set { this.handshake = value; } }
        public Parity Parity { get { return this.parity; } set { this.parity = value; } }
        public string PortName { get { return this.portName; } set { this.portName = value; } }
        public StopBits StopBits { get { return this.stopBits; } set { this.stopBits = value; } }

        public bool Open()
        {
            Console.WriteLine("open started");

            try
            {
                this.serialPort.BaudRate = this.baudRate;
                Console.WriteLine("SerialConnect - BaudRate: " + this.baudRate);
                this.serialPort.DataBits = this.dataBits;
                Console.WriteLine("SerialConnect - DataBits: " + this.dataBits);
                //this.serialPort.Handshake = this.handshake;
                //Console.WriteLine("serialport werte eingerichtet4");
                this.serialPort.Parity = this.parity;
                Console.WriteLine("SerialConnect - Parity: "+ this.parity);
                this.serialPort.PortName = this.portName;
                Console.WriteLine("SerialConnect - PortName: "+ this.portName);
                this.serialPort.StopBits = this.stopBits;
                Console.WriteLine("SerialConnect - StopBits: "+ this.stopBits);

                this.serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                Console.WriteLine("SerialConnect - Eventhandler steht!");

                if (!serialPort.IsOpen)
                {
                    this.serialPort.Open();

                    Console.WriteLine("PORT OPENED");
                }
                else { Console.WriteLine("PORT already OPEN"); }
            }
            catch
            {
                return false;
            }
            try { serialPort.DtrEnable = true; }
            catch { }
            try { serialPort.RtsEnable = true; }
            catch { }

            return true;
        }
        public string Receive()
        {
            int count = serialPort.BytesToRead;
            byte[] buffer = new byte[count];
            string s = "leer";

            serialPort.Read(buffer, 0, count);

            s = System.Text.Encoding.ASCII.GetString(buffer);
            return s;
        }
        public void Close()
        {
            if (serialPort != null)
            {
                try
                {
                    if (serialPort.IsOpen == true)
                    {
                        serialPort.DiscardInBuffer();
                        serialPort.DiscardOutBuffer();
                        serialPort.Close();
                        Console.WriteLine("Port closed...");
                    }
                }
                catch (Exception e)
                {
                }

                if (serialPort != null)
                {
                    serialPort.Dispose();
                }
            }
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;


            string indata  = sp.ReadExisting();
            Console.Write("Data Received: ");
            Console.WriteLine(indata);
           
        }
        public void Send(byte[] input) {

            if (!serialPort.IsOpen)
            {
                Console.WriteLine("PORT not yet OPEN");
            }
            else
            {
            // TODO: if input = 0 close and printout error.

                // serialPort.Write(new byte[] { 0x00, 0x00, 0x00 }, 0, 3);
                //Console.WriteLine("Data Sending: " + BitConverter.ToString(input));
                serialPort.Write(input, 0, input.Length);
            }
        }
    }
}
