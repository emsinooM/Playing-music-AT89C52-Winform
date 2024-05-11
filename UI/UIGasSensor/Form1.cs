using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.IO.Ports;
using System.IO;
using System.Diagnostics;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

namespace UI
{
    public partial class Form1 : Form
    {
        string filePath, filePathMusic, lastProcessedTxtPath;
        int check=1, Pause=0;
        bool s;
        int fisn = 1, first=0;
        int restart=1;
        private readonly object lockObject = new object();
        private bool isPaused = false;
        OpenFileDialog openFileDialog1;
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        int parsepitch(string s)
        {
            switch (s)
            {
                case "C3": return 1;
                case "C#3": return 2;
                case "D3": return 3;
                case "D#3": return 4;
                case "E3": return 5;
                case "F3": return 6;
                case "F#3": return 7;
                case "G3": return 8;
                case "G#3": return 9;
                case "A3": return 10;
                case "A#3": return 11;
                case "B3": return 12;
                case "C4": return 13;
                case "C#4": return 14;
                case "D4": return 15;
                case "D#4": return 16;
                case "E4": return 17;
                case "F4": return 18;
                case "F#4": return 19;
                case "G4": return 20;
                case "G#4": return 21;
                case "A4": return 22;
                case "A#4": return 23;
                case "B4": return 24;
                case "C5": return 25;
                case "C#5": return 26;
                case "D5": return 27;
                case "D#5": return 28;
                case "E5": return 29;
                case "F5": return 30;
                case "F#5": return 31;
                case "G5": return 32;
                case "G#5": return 33;
                case "A5": return 34;
                case "A#5": return 35;
                case "B5": return 36;
                case "C6": return 37;
                case "C#6": return 38;
                case "D6": return 39;
                case "D#6": return 40;
                case "E6": return 41;
                case "F6": return 42;
                case "F#6": return 43;
                case "G6": return 44;
                case "G#6": return 45;
                case "A6": return 46;
                case "A#6": return 47;
                case "B6": return 48;
                case "C7": return 49;
                case "C#7": return 50;
                case "D7": return 51;
                case "D#7": return 52;
                case "E7": return 53;
                case "F7": return 54;
                case "F#7": return 55;
                case "G7": return 56;
                case "G#7": return 57;
                case "A7": return 58;
                case "A#7": return 59;
                case "B7": return 60;

                default: return 0;
                    // Giá trị mặc định hoặc giá trị đặc biệt để xác định trường hợp không hợp lệ
            }
        }
        int parseduration(string s)
        {
            switch (s)
            {
                case "qtrN": return 1;
                case "wholeN": return 2;
                case "halfN": return 3;
                case "eighthN": return 4;
                case "sixteenN": return 5;
                case "thirtyTwoN": return 6;
                case "sixtyFourN": return 7;
                case "sixN": return 8;
                case "twelveN": return 9;
                case "twentyFourN": return 10;
                case "phat": return 255;
                case "phat2": return 254;
                default: return 0;
            }
        }


        public Form1()
        {
            InitializeComponent();


            openFileDialog1 = new OpenFileDialog
            {
                Filter = "Audio Files (*.mp3, *.wav)|*.mp3;*.wav",
                //Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Chọn File Âm Thanh"
            };
        }
    
        private void SendDataToCOMPort(int data)
        {
            
            string hexValue = data.ToString("X");
            if (serialPort1.IsOpen)
            {
                byte[] byteValue = { Convert.ToByte(hexValue, 16) };
                serialPort1.Write(byteValue, 0, 1);
            }
            else
            {

                MessageBox.Show("Cổng COM chưa được mở.");

            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

      

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cbCom.Items.Add(port.ToString());
            }
            cbList.Items.Add("Manu");
            cbList.Items.Add("lorry");
            cbList.Items.Add("CILV");
            cbList.Items.Add("Fur_Elise");
            cbList.Items.Add("WindyHill");

        }
        private void cbList_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedValue = cbList.SelectedItem.ToString();
            if (selectedValue == "Manu") { filePath = "manu.txt"; }
            if (selectedValue == "lorry") { filePath = "music1.txt"; }
            if (selectedValue == "CILV") { filePath = "CILV.txt"; }
            if (selectedValue == "Fur_Elise") { filePath = "Fur_Elise.txt"; }
            if (selectedValue == "WindyHill") { filePath = "WindyHill.txt"; }
            //textBox1.AppendText(selectedValue);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }


        }



        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            try
            {
                serialPort1.PortName = cbCom.Text;
                serialPort1.Open();
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            
        }

        Action<string> serialPortReceiverAction;
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            serialPortReceiverAction = serialPortReceiver;
            try
            {
                this.BeginInvoke(serialPortReceiverAction, serialPort1.ReadExisting());
            }
            catch
            {

            }
        }

        private async void btnLed1_Click(object sender, EventArgs e)
        {
           

            button1_Click(sender, e);
            await Task.Delay(1000);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePathMusic = openFileDialog1.FileName;
                // Gọi script Python

                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = "C:\\Users\\Nguyen\\AppData\\Local\\Microsoft\\WindowsApps\\PythonSoftwareFoundation.Python.3.10_qbz5n2kfra8p0\\python.exe"; // hoặc đường dẫn tới Python trên máy của bạn
                start.Arguments = string.Format("\"{0}\" \"{1}\"", "D:\\Study\\STUdied\\Kien truc may tinh\\CUOI_Ky_Thuc_Tap\\CUOI_KY\\music.py", filePathMusic);
                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;

                
                using (Process process = Process.Start(start))
                {
                    
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        Console.Write(result);
                    }

                    process.WaitForExit();
                }
                filePath = "D:\\Study\\STUdied\\Kien truc may tinh\\py_music\\CUOI_KY\\notes_Music.txt";
                Interlocked.Exchange(ref restart, 0);
                textBox1.AppendText("1");
                //isPaused = true;
            }

            

            cancellationTokenSource = new CancellationTokenSource();


        }

        private void play()
        {
            isPaused = false;
            StreamReader reader = null;
            string line = null;

            string outputFolderPath = "D:\\Study\\STUdied\\Kien truc may tinh\\py_music\\notes_Music.txt";
            
   

 


            if (!File.Exists(filePath))
            {
                MessageBox.Show("File văn bản không tồn tại. Vui lòng chọn file âm thanh và chờ xử lý.");
                return;
            }

            else
            {
                textBox1.Clear();
                textBox1.AppendText("Đang phát");
                bool restartLoop;

                do
                {
                    restartLoop = false;

                    using (reader = new StreamReader(filePath))
                    {
                        

                        while ((line = reader.ReadLine()) != null)
                        {
                            while (isPaused) // Kiểm tra nếu đang ở trạng thái pause
                            {
                                Application.DoEvents();
                            }
                            /*if (token.IsCancellationRequested)
                            {
                                MessageBox.Show("Quá trình đã bị dừng.");
                                return; // Dừng quá trình hiện tại
                            }*/
                            if (cancellationTokenSource.Token.IsCancellationRequested)
                            {
                                return;
                            }

                            string[] parts = line.Split(',');
                            if (parts.Length == 2)
                            {
                                check = 0;
                                int pitch = parsepitch(parts[0].Trim());
                                int duration = parseduration(parts[1].Trim());
                                SendDataToCOMPort(pitch);
                                SendDataToCOMPort(duration);

                                while (check == 0)
                                {
                                    Application.DoEvents();
                                }

                                if (Interlocked.CompareExchange(ref restart, 0, 0) == 0 || check == 2)
                                {
                                    restartLoop = true;
                                    restart = 1;
                                    break;
                                }
                            }
                        }
                    }
                } while (restartLoop);
                textBox1.Clear();
                textBox1.AppendText("xong");
                //Task.Run(() => ProcessTextFile(outputFolderPath, cancellationTokenSource.Token));
            }
            cancellationTokenSource = new CancellationTokenSource();
        }
        

        private void btnLed2_Click(object sender, EventArgs e)
        {
            if (cancellationTokenSource.IsCancellationRequested)
            {  
                return;
            }
            
            fisn = 0;
            textBoxFilePath.Text = Path.GetFileName(filePath);
            play();
            fisn = 1;

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            isPaused = !isPaused;
            if (isPaused == true ) textBox1.AppendText("Tạm dừng"); 
            else textBox1.AppendText("Đang phát");
        }
        // Thực hiện thay đổi giữa 0 và 1



        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (first == 2) first = 0;
            if (first ==0)
                {
                first = 1;
                btnLed2_Click(sender, e);
                return;
                }
            else 
            {
                first = 2;
                if (cancellationTokenSource.IsCancellationRequested)
                {

                    return;
                }
                textBox1.Clear();
                textBox1.AppendText(".....Restart");
                textBoxFilePath.Text = Path.GetFileName(filePath);
                if (fisn == 0)
                    Interlocked.Exchange(ref restart, 0);
                else play();
            }
            
           
        }
        // Hàm xử lí dữ liệu nhận về
        private void serialPortReceiver(string input)
        {
              //  textBox1.AppendText(".");
                check = int.Parse(input);
            //Interlocked.Exchange(ref check, int.Parse(input));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
            //textBox1.AppendText("STop");
            //await Task.Delay(1500);
            //btnLed1_Click(sender, e);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
        }


    }
}
