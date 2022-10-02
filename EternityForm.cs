using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanSlateProtocol
{
    public partial class EternityForm : Form
    {
        public string EternityCode { get; set; } = "ВЕЧНОСТЬ";
        public string ApocalypseCode { get; set; } = "УНИЧТОЖЕНИЕ";
        public EternityForm()
        {
            InitializeComponent();
        }

        private void EternityForm_Load(object sender, EventArgs e)
        {
            // При загрузке формы считываем данные из файла settings.ini в кодировке UTF8
            var parser = new FileIniDataParser();
            IniData settingsINI = parser.ReadFile("settings.ini", Encoding.UTF8);
            EternityCode = settingsINI["CodesGroup"]["EternityCode"];
            ApocalypseCode = settingsINI["CodesGroup"]["ApocalypseCode"];
            codePhraseTextBox.Text = EternityCode;
            codePhraseApocalypse.Text = ApocalypseCode;
        }

        private void EternityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // При закрытии формы сохраняем данные в файл settings.ini в кодировке UTF8
            var parser = new FileIniDataParser();
            IniData settingsINI = parser.ReadFile("settings.ini", Encoding.UTF8);
            settingsINI["CodesGroup"]["EternityCode"] = codePhraseTextBox.Text;
            settingsINI["CodesGroup"]["ApocalypseCode"] = codePhraseApocalypse.Text;
            parser.WriteFile("settings.ini", settingsINI, Encoding.UTF8);
        }
    }
}
