using CSMS3.ApplicationContract;
using CSMS3.Infrastructure.Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSMS3.Application.DTO;

namespace CSMS3.Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ServiceProxy<IService1> proxy = new ServiceProxy<IService1>())
            {
                var dataObject = proxy.Channel.GetYongHuXXByCID("2");
                MessageBox.Show(dataObject.S_CID);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (ServiceProxy<IService1> proxy = new ServiceProxy<IService1>())
            {
                YongHuXXDTO dto = new YongHuXXDTO();
                dto.S_CID = "2";
                dto.D_BIAOKADYRQ = DateTime.Now;
                dto.D_CAOZUOSJ = DateTime.Now;
                dto.D_LIHU = DateTime.Now;
                proxy.Channel.AddYongHuXX(dto);
                MessageBox.Show(dto.S_CID);
            }
        }
    }
}
