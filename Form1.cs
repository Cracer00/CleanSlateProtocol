using System;
using IniParser;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser.Model;
using System.Runtime.InteropServices;
using KeysUtilities;

namespace CleanSlateProtocol
{
    public partial class MainForm : Form
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        globalKeyboardHook gkh = new globalKeyboardHook(); // Создаем hook для клавиатуры

        public string EternityCode { get; set; } = "ВЕЧНОСТЬ";
        public string ApocalypseCode { get; set; } = "УНИЧТОЖЕНИЕ";
        public string apocalypseCodeTriggerString { get; set; } = "";
        public bool ConsoleVisible { get; set; } = false;
        public MainForm()
        {
            InitializeComponent();
            Console.OutputEncoding = Encoding.UTF8; // Устанавливаем кодировку текста в консоли
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Проверяем текст-бокс на изменения. Если текст совпадает с EternityCode - выводим окно опций
            string currentText = textEdit.Text;
            if (currentText.Contains(EternityCode))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(textEdit.Text + " = " + EternityCode);
                Console.ResetColor();
                EternityForm eternityForm = new EternityForm();
                eternityForm.Show();
                textEdit.Clear();
            }
            else if (currentText.Contains("console"))
            {
                if (!ConsoleVisible)
                {
                    var consoleWindow = GetConsoleWindow();
                    // Показать консоль
                    ShowWindow(consoleWindow, SW_SHOW);
                    ConsoleVisible = true;
                    textEdit.Clear();
                }
                else
                {
                    var consoleWindow = GetConsoleWindow();
                    // Скрыть консоль
                    ShowWindow(consoleWindow, SW_HIDE);
                    ConsoleVisible = false;
                    textEdit.Clear();
                }
            }
            else
            {
                Console.WriteLine(textEdit.Text + " ≠ " + EternityCode);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // При загрузке формы считываем данные из файла settings.ini
            var parser = new FileIniDataParser();
            IniData settingsINI = parser.ReadFile("settings.ini", Encoding.UTF8);
            EternityCode = settingsINI["CodesGroup"]["EternityCode"]; // Получаем код активации окна опций
            ApocalypseCode = settingsINI["CodesGroup"]["ApocalypseCode"]; // Получаем код активации режима апокалипсиса
            #region Настройка клавиш для хука и создание события для обработки нажатия клавиш
            // Настройка клавиш для хука и создание события для обработки нажатия клавиш
            char[] apocalypseChars = ApocalypseCode.ToLower().ToCharArray();
            foreach (char ch in apocalypseChars) // Посимвольно создаем хуки для кодового слова
            {
                switch (ch)
                {
                    default:
                        break;
                    case 'a':
                        gkh.HookedKeys.Add(Keys.A);
                        break;
                    case 'b':
                        gkh.HookedKeys.Add(Keys.B);
                        break;
                    case 'c':
                        gkh.HookedKeys.Add(Keys.C);
                        break;
                    case 'd':
                        gkh.HookedKeys.Add(Keys.D);
                        break;
                    case 'e':
                        gkh.HookedKeys.Add(Keys.E);
                        break;
                    case 'f':
                        gkh.HookedKeys.Add(Keys.F);
                        break;
                    case 'g':
                        gkh.HookedKeys.Add(Keys.G);
                        break;
                    case 'h':
                        gkh.HookedKeys.Add(Keys.H);
                        break;
                    case 'i':
                        gkh.HookedKeys.Add(Keys.I);
                        break;
                    case 'j':
                        gkh.HookedKeys.Add(Keys.J);
                        break;
                    case 'k':
                        gkh.HookedKeys.Add(Keys.K);
                        break;
                    case 'l':
                        gkh.HookedKeys.Add(Keys.L);
                        break;
                    case 'm':
                        gkh.HookedKeys.Add(Keys.M);
                        break;
                    case 'n':
                        gkh.HookedKeys.Add(Keys.N);
                        break;
                    case 'o':
                        gkh.HookedKeys.Add(Keys.O);
                        break;
                    case 'p':
                        gkh.HookedKeys.Add(Keys.P);
                        break;
                    case 'q':
                        gkh.HookedKeys.Add(Keys.Q);
                        break;
                    case 'r':
                        gkh.HookedKeys.Add(Keys.R);
                        break;
                    case 's':
                        gkh.HookedKeys.Add(Keys.S);
                        break;
                    case 't':
                        gkh.HookedKeys.Add(Keys.T);
                        break;
                    case 'u':
                        gkh.HookedKeys.Add(Keys.U);
                        break;
                    case 'v':
                        gkh.HookedKeys.Add(Keys.V);
                        break;
                    case 'w':
                        gkh.HookedKeys.Add(Keys.W);
                        break;
                    case 'x':
                        gkh.HookedKeys.Add(Keys.X);
                        break;
                    case 'y':
                        gkh.HookedKeys.Add(Keys.Y);
                        break;
                    case 'z':
                        gkh.HookedKeys.Add(Keys.Z);
                        break;
                    case '1':
                        gkh.HookedKeys.Add(Keys.D1);
                        gkh.HookedKeys.Add(Keys.NumPad1);
                        break;
                    case '2':
                        gkh.HookedKeys.Add(Keys.D2);
                        gkh.HookedKeys.Add(Keys.NumPad2);
                        break;
                    case '3':
                        gkh.HookedKeys.Add(Keys.D3);
                        gkh.HookedKeys.Add(Keys.NumPad3);
                        break;
                    case '4':
                        gkh.HookedKeys.Add(Keys.D4);
                        gkh.HookedKeys.Add(Keys.NumPad4);
                        break;
                    case '5':
                        gkh.HookedKeys.Add(Keys.D5);
                        gkh.HookedKeys.Add(Keys.NumPad5);
                        break;
                    case '6':
                        gkh.HookedKeys.Add(Keys.D6);
                        gkh.HookedKeys.Add(Keys.NumPad6);
                        break;
                    case '7':
                        gkh.HookedKeys.Add(Keys.D7);
                        gkh.HookedKeys.Add(Keys.NumPad7);
                        break;
                    case '8':
                        gkh.HookedKeys.Add(Keys.D8);
                        gkh.HookedKeys.Add(Keys.NumPad8);
                        break;
                    case '9':
                        gkh.HookedKeys.Add(Keys.D9);
                        gkh.HookedKeys.Add(Keys.NumPad9);
                        break;
                    case '0':
                        gkh.HookedKeys.Add(Keys.D0);
                        break;
                }
            }
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
            #endregion
        }

        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            #region Инициализация кодов кнопок
            //Инициализация кодов кнопок
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                apocalypseCodeTriggerString += "1";
            } else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                apocalypseCodeTriggerString += "2";
            } else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                apocalypseCodeTriggerString += "3";
            } else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                apocalypseCodeTriggerString += "4";
            } else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                apocalypseCodeTriggerString += "5";
            } else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                apocalypseCodeTriggerString += "6";
            } else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                apocalypseCodeTriggerString += "7";
            } else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                apocalypseCodeTriggerString += "8";
            } else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                apocalypseCodeTriggerString += "9";
            } else if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                apocalypseCodeTriggerString += "0";
            }
            #endregion
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Строка триггер: " + apocalypseCodeTriggerString);
            Console.ResetColor();
            if (apocalypseCodeTriggerString.Contains(ApocalypseCode))
            {
                // TODO: Активация скрипта апокалипсиса
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("##########################################");
                Console.WriteLine("##########################################");
                Console.WriteLine("Получен код апокалипсиса. Активация.");
                Console.WriteLine("##########################################");
                Console.WriteLine("##########################################");
                Console.ResetColor();
                apocalypseCodeTriggerString = null;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Dispose();
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
        }
    }
}
