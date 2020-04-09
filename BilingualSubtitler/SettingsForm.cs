﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilingualSubtitler
{
    public partial class SettingsForm : Form
    {
        private List<Button> m_buttons; 
        private Color m_previousButtonColor;
        private bool m_flagKeyIsInvalid = false;

        public SettingsForm()
        {
            InitializeComponent();

            m_flagKeyIsInvalid = true;

            foreach (var hotkeyString in Properties.Settings.Default.Hotkeys)
            {
                AddKeyToHotkeysDataGridView(hotkeyString);
            }

            videoPlayerPauseButtonTextBox.Text = new Hotkey(Properties.Settings.Default.VideoPlayerPauseButtonString).KeyValue;
            videoPlayerChangeToBilingualSubtitlesButtonTextBox.Text = new Hotkey(Properties.Settings.Default.VideoPlayerChangeToBilingualSubtitlesHotkeyString).ToString();
            videoPlayerChangeToOriginalSubtitlesButtonTextBox.Text = new Hotkey(Properties.Settings.Default.VideoPlayerChangeToOriginalSubtitlesHotkeyString).ToString();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            m_buttons = new List<Button>();
            m_buttons.Add(buttonOk);
            m_buttons.Add(buttonCancel);

            foreach (var btn in m_buttons)
            {
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Flat;
            }

            if (m_flagKeyIsInvalid)
                richTextBoxLabelYouNeedToGetAPIKey.Text = "Введенный ключ неверен. Для использования данного приложения необходимо ввести валидный ключ к API сервиса " + '"' + "Яндекс.Переводчик" + '"' + ".";

            richTextBoxForYandexApiKeyInSeparateForm.Text = Properties.Settings.Default.YandexTranslatorAPIKey;

            //Синий фон у кнопок при наведении курсора
            foreach (var btn in m_buttons)
            {
                btn.MouseEnter += new EventHandler(btn_MouseEnter);
                btn.MouseLeave += new EventHandler(btn_MouseLeave);
            }

            richTextBoxForYandexApiKeyInSeparateForm.Select();

        }

        private void AddKeyToHotkeysDataGridView(string hotkeyString)
        {
            var hotkey = new Hotkey(hotkeyString);

            var rowIndex = hotkeysDataGridView.Rows.Add(hotkey.KeyValue);
            hotkeysDataGridView.Rows[rowIndex].Tag = hotkeyString;
        }

        private void AddKeyToHotkeysDataGridView(Hotkey hotkey)
        {
            var rowIndex = hotkeysDataGridView.Rows.Add(hotkey.KeyValue);
            hotkeysDataGridView.Rows[rowIndex].Tag = hotkey.ToString();
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            m_previousButtonColor = ((Button)sender).BackColor;
            ((Button)sender).BackColor = Color.Gold;

        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = m_previousButtonColor;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            //Вычищаем символы переноса строки и пробелы из ключа
            int carrySymbols = richTextBoxForYandexApiKeyInSeparateForm.Text.Split('\n').Length - 1;
            int spaceSymbols = richTextBoxForYandexApiKeyInSeparateForm.Text.Split(' ').Length - 1;

            Properties.Settings.Default.Hotkeys = new StringCollection();
            foreach (DataGridViewRow hotkeyRow in hotkeysDataGridView.Rows)
            {
                Properties.Settings.Default.Hotkeys.Add((string) hotkeyRow.Tag);
            }

            Properties.Settings.Default.VideoPlayerPauseButtonString = (string)videoPlayerPauseButtonTextBox.Tag;
            Properties.Settings.Default.VideoPlayerChangeToBilingualSubtitlesHotkeyString = (string)videoPlayerChangeToBilingualSubtitlesButtonTextBox.Tag;
            Properties.Settings.Default.VideoPlayerChangeToOriginalSubtitlesHotkeyString = (string)videoPlayerChangeToOriginalSubtitlesButtonTextBox.Tag;
            Properties.Settings.Default.CreateOriginalSubtitlesFile = CreateOriginalSubtitlesFileCheckBox.Checked;
            Properties.Settings.Default.OriginalSubtitlesFileNameEnding = originalSubtitlesPathEndingTextBox.Text;
            Properties.Settings.Default.BilingualSubtitlesFileNameEnding = bilingualSubtitlesPathEndingTextBox.Text;

            Properties.Settings.Default.YandexTranslatorAPIKey = richTextBoxForYandexApiKeyInSeparateForm.Text.Substring(0,richTextBoxForYandexApiKeyInSeparateForm.Text.Length-spaceSymbols-carrySymbols);
            Properties.Settings.Default.Save();

            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void linkLabelGetAPIKey_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabelGetAPIKey.LinkVisited = true;
            System.Diagnostics.Process.Start("https://tech.yandex.ru/keys/get/?service=trnsl");
        }



        private void YandexTranslatorAPIKeyForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void buttonOk_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabelYandexAPIKeysList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabelYandexAPIKeysList.LinkVisited = true;
            System.Diagnostics.Process.Start("https://tech.yandex.ru/keys/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var hotkeySettingForm = new HotkeySettingForm();
            var dialogResult = hotkeySettingForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                AddKeyToHotkeysDataGridView(hotkeySettingForm.SettedHotkey);
            }
        }
    }

    //public partial class SettingsForm : Form
    //{
    //    [DllImport("user32.dll")]
    //    static extern bool SetKeyboardState(byte[] lpKeyState);
    //    [DllImport("user32.dll")]
    //    static extern bool GetKeyboardState(byte[] lpKeyState);

    //    public SettingsForm()
    //    {
    //        InitializeComponent();
    //    }

    //    private void KeySettingForm_KeyPress(object sender, KeyPressEventArgs e)
    //    {
    //        var shift = new byte[256];
    //        GetKeyboardState(shift);

    //        File.WriteAllBytes("C:\\Users\\jenek\\source\\repos\\0xotHik\\" +
    //                           "BilingualSubtitler\\BilingualSubtitler\\bin\\Debug\\shift.dat", shift);

    //    }

    //    private void KeySettingForm_KeyDown(object sender, KeyEventArgs e)
    //    {
    //        var shift = new byte[256];
    //        GetKeyboardState(shift);

    //        File.WriteAllBytes("C:\\Users\\jenek\\source\\repos\\0xotHik\\" +
    //                           "BilingualSubtitler\\BilingualSubtitler\\bin\\Debug\\shiftDown.dat", shift);
    //    }
    //}
}
