using LogLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["movieName"].Value = this.movieName.Text;

            config.AppSettings.Settings["roomNum"].Value = this.roomNum.Text;
            config.AppSettings.Settings["time"].Value = this.time.Text;
            config.AppSettings.Settings["date"].Value = this.date.Text;
            config.AppSettings.Settings["price"].Value = this.price.Text;

            TraceHelper.GetInstance().Info("配置已修改：  电影名 " + this.movieName.Text 
                + "  房间号 " + this.roomNum.Text
                + "  时间 " + this.time.Text
                + "  日期 "+ this.date.Text
                + "  价格 " + this.price.Text, "form2 Function");

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings"); // 重新加载新的配置文件 

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
