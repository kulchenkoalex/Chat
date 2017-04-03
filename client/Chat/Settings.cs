using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Chat
{
    public partial class Settings : Form
    {
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        Param parameters = new Param();
        private Main_Window f1 = new Main_Window();

        public Settings()
        {
            InitializeComponent();
            try
            {
               ReadXML();
            }
            catch
            {
                MessageBox.Show("Не получилось загрузить настройки.");
            }
            if (rkApp.GetValue("MyApp") == null)
            {
                chkRun.Checked = false;
            }
            else
            {
                chkRun.Checked = true;
            }

            if (rbNewKeys.Checked == true)
            {
                new Main_Window().CreateKeys();
            }
            else
            {
                new Main_Window().LoadKeys();
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {


      

        }
        //запись параметров
        public void WriteXML()
        {
            parameters.autorun = chkRun.Checked;
            parameters.save_user = chkName.Checked;
            parameters.save_ip = chkIp.Checked;
            parameters.newkeys = rbNewKeys.Checked;
            parameters.keys = rbKeys.Checked;
            parameters.autoconnect = chk_autoconnect.Checked;
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Param));
            var path = "parameters.xml";
            System.IO.FileStream file = System.IO.File.Create(path);
            writer.Serialize(file, parameters);
            file.Close();
        }

        //считывание параметров
        public void ReadXML()
        {
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Param));
            System.IO.StreamReader file = new System.IO.StreamReader(
                "parameters.xml");
            parameters = (Param)reader.Deserialize(file);
            chkRun.Checked = parameters.autorun;
            chkName.Checked = parameters.save_user;
            chkIp.Checked = parameters.save_ip;
            rbNewKeys.Checked = parameters.newkeys;
            rbKeys.Checked = parameters.keys;
            chk_autoconnect.Checked = parameters.autoconnect;
            file.Close();
        }

        //сохранение настроек
        private void button1_Click(object sender, EventArgs e)
        {
            WriteXML();
            if (chkRun.Checked)
            {
                rkApp.SetValue("MyApp", Application.ExecutablePath.ToString());
            }
            else
            {
                rkApp.DeleteValue("MyApp", false);
            }
            Close();
        }

        //Отмена
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            ReadXML();
        }

        //"Сохранение ip-адреса"
        private void chkIp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIp.Checked != true && chkIp.Checked != true)
            {
                chk_autoconnect.Enabled = false;
                chk_autoconnect.Checked = false;
            }
            else
            {
                chk_autoconnect.Enabled = true;    
            }
        }

        private void chkName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkName.Checked != true && chkIp.Checked != true)
            {
                chk_autoconnect.Enabled = false;
                chk_autoconnect.Checked = false;
            }
            else
            {
                chk_autoconnect.Enabled = true;

            }
        }

        //возможность выбрать "автоподключение"
        private void Settings_EnabledChanged(object sender, EventArgs e)
        {
            if (chkName.Checked != true && chkIp.Checked != true)
            {
                chk_autoconnect.Enabled = false;
            }
            else
            {
                chk_autoconnect.Enabled = true;
            }
        }

    }

    //класс для сериализации
    public class Param
    {
        public bool autorun, save_user, save_ip, newkeys, keys, autoconnect;
        public string name_user, ip_server;
    }
}
