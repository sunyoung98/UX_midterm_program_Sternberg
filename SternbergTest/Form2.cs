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
using System.Diagnostics;
using System.IO;
using System.Security.Permissions;

namespace SternbergTest
{
    public partial class Form2 : Form
    {
        Button[] num_buttons;
        Boolean userTestTime = false;
        int[] userInput;
        Boolean[] saveTF;
        double[] TimeCheck;
        int[] realTF;
        int[,] RandomNumberSet;
        int[] RandomNumber;
        int num = -1;
        int userIndex = -1;
        Worker workerObject = new Worker();
        Stopwatch sw;
        String fileName;
        public Form2()
        {
            InitializeComponent();
            num_buttons = new Button[] { btn3, btn4, btn5, btn6 };
            label2.Hide();
            startBtn.Hide();
            KeyPreview = true;
            Console.WriteLine(System.Windows.Forms.Application.StartupPath);
            CloseBtn.Hide();
        }

        private async void StartTest()
        {
            label2.Show();
            label1.Hide();
            TimeCheck = new double[20];
            saveTF = new Boolean[20];
            startBtn.Hide();
            for (int i = 0; i < 20; i++)
            {
                await Task.Run(async () =>
                {
                    sw = new Stopwatch();
                    workerObject.RequestStart();
                    userTestTime = false;
                    userIndex = i;
                    label2.Text = "";
                    for (int j = 0; j < num; j++)
                    {
                        label2.Text += RandomNumberSet[i, j].ToString() + "  ";
                    }
                    label2.Update();
                    Task.Delay(5000).Wait();
                    sw.Start();
                    label2.Text = "   "+ RandomNumber[i].ToString();
                    label2.Update();
                    userTestTime = true;
                    workerObject.DelayAsync(sw);
                  
                });

                
            }
            //label2.Hide();
            //label2.Update();
            DirectoryInfo dtif = new DirectoryInfo(Application.StartupPath +"\\log");
            if (!dtif.Exists)
            {
                dtif.Create();
            }
            fileName ="\\log\\"+DateTime.Now.ToString("MM-dd-HH-mm-ss")+"_num"+num.ToString()+ ".txt";
            Console.WriteLine(fileName);
            FileInfo file = new FileInfo(Application.StartupPath + fileName);
            if (!file.Exists)
            {
                FileStream f = file.Create();
                f.Close();
            }
            FileStream fs = file.OpenWrite();
            TextWriter tw = new StreamWriter(fs);
            tw.WriteLine("Index, Number Set(), Number, User Input, T/F, Time(ms)");
            for (int i=0; i<20; i++)
            {
                tw.Write(i.ToString()+" (");
                for (int j = 0; j < num; j++)
                    tw.Write(RandomNumberSet[i, j].ToString()+" ");
                tw.Write("),"+ RandomNumber[i].ToString() + ",");
                string ru;
                if (userInput[i] == 0)
                    ru = "False";
                else if (userInput[i] == 1)
                    ru = "True";
                else
                    ru = "TimeOut";
                tw.Write(ru + ",");
                tw.Write(saveTF[i].ToString() + ",");
                tw.WriteLine(TimeCheck[i].ToString());
            }
            tw.Close();
            fs.Close();
            label2.Hide();
            label1.Text = fileName +Environment.NewLine+"에 저장되었습니다.";
            label1.Update();
            label1.Show();
            CloseBtn.Show();
            

        }

        public T[] Shuffle<T>(T[] array)
        {
            var random = new Random();
            for (int i = array.Length; i > 1; i--)
            {
                // Pick random element to swap.
                int j = random.Next(i); // 0 <= j <= i-1
                                        // Swap.
                T tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
            }
            return array;
        }

        public void RandomNumberGenerate(int num)
        {
            this.num = num;
            Console.WriteLine("num:" + num.ToString());
            var rand = new Random();
            RandomNumberSet = new int[20,num+1];
            RandomNumber = new int[20];
            userInput = new int[20];
            realTF = new int[20];
            int[] RandomTF = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            RandomTF = Shuffle<int>(RandomTF);
            for (int index = 0; index < 20; index++) {
                bool isSame;
                for (int i = 0; i < num+1; i++)
                {
                    while (true)
                    {
                            RandomNumberSet[index, i] = rand.Next(1, 10);
                        isSame = false;
                        for (int j = 0; j < i; ++j)
                        {
                            if (RandomNumberSet[index, j] == RandomNumberSet[index, i])
                            {
                                isSame = true;
                                break;
                            }
                        }
                        if (!isSame) break;
                    }
                }
            }
            for (int i = 0; i < 20; i++)
                RandomNumber[i] = RandomNumberSet[i,num];
            for (int i = 0; i < 20; i++)
            {
                if (i < 10)
                {
                    RandomNumber[RandomTF[i]] = RandomNumberSet[RandomTF[i], rand.Next(0, num-1)];
                    realTF[RandomTF[i]] = 1;
                }
                else
                    realTF[RandomTF[i]] = 0;
            }
            for (int i = 0; i < 20; i++)
                for (int j = 0; j < num; j++)
                    Console.Write(RandomNumberSet[i, j]+" " );

        }

        private void startPage(int n)
        {
               foreach(Button b in num_buttons)
                b.Hide();
            label1.Text = "set "+n.ToString()+"을 선택하셨습니다. 화면에 보이는" + Environment.NewLine + "스타트 버튼을 누르면 실험이 시작됩니다" + Environment.NewLine;
            label1.TextAlign = ContentAlignment.MiddleCenter;
           //label2.Show();
            startBtn.Show();
            RandomNumberGenerate(n);
        }
        private void input_btn_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var btn_name = button.Name;
            switch (btn_name)
            {
                case "btn3":
                    startPage(3);
                    break;
                case "btn4":
                    startPage(4);
                    break;
                case "btn5":
                    startPage(5);
                    break;
                case "btn6":
                    startPage(6);
                    break;
                case "startBtn":
                    StartTest();
                    break;
                case "CloseBtn":
                    this.Close();
                    break;

            } 
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.V:
                    if (userTestTime)
                    {
                        workerObject.RequestStop();
                        sw.Stop();
                        TimeCheck[userIndex] = sw.ElapsedMilliseconds;
                        userInput[userIndex] = 1;
                        if (userInput[userIndex] == realTF[userIndex])
                            saveTF[userIndex] = true;
                        else
                            saveTF[userIndex] = false;
                        Console.WriteLine(TimeCheck[userIndex].ToString());
                    }
                    break;
                case Keys.N:
                    if (userTestTime)
                    {
                        workerObject.RequestStop();
                        sw.Stop();
                        TimeCheck[userIndex] = sw.ElapsedMilliseconds;
                        userInput[userIndex] = 0;
                        if (userInput[userIndex] == realTF[userIndex])
                            saveTF[userIndex] = true;
                        else
                            saveTF[userIndex] = false;
                        Console.WriteLine(TimeCheck[userIndex].ToString());
                    }
                    break;
                case Keys.Z:
                    if (userTestTime)
                    {
                        workerObject.RequestStop();
                        sw.Stop();
                        Console.WriteLine("Nothing");
                        userInput[userIndex] = -1;
                        saveTF[userIndex] = false;
                        TimeCheck[userIndex] = 5000;
                    }
                    break;

            }
        }
    }
}
