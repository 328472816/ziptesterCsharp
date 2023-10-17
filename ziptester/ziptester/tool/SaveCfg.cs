using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ziptester.tool
{
    class SaveCfg
    {

        public static void LoadProfile()
        {
            string strPath = AppDomain.CurrentDomain.BaseDirectory;
            _file = new IniFile(strPath + "Cfg.ini");
            G_LG = _file.ReadString("CONFIG", "Language", "en");    //读数据，下同
            G_DEBUG = _file.ReadString("CONFIG", "Debug", "User");

        }

        public static void SaveProfile()
        {
            string strPath = AppDomain.CurrentDomain.BaseDirectory;
            _file = new IniFile(strPath + "Cfg.ini");
            _file.WriteString("CONFIG", "Language", G_LG);            //写数据，下同
            _file.WriteString("CONFIG", "Debug", G_DEBUG);
        }

        private static IniFile _file;//内置了一个对象

        public static string G_LG = "en";//给ini文件赋新值，并且影响界面下拉框的显示
        public static string G_DEBUG = "User";
    }
}
