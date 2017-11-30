
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //    Award awrd = new Award();
                //    awrd.AwardAcronyms = "XXM";
                //    awrd.AwardName = "aam";

                //    ResultMEntitiesxx ent = new WindowsTest.ResultMEntitiesxx();
                //    ent.Awards.Add(awrd);
                //    int flag=ent.SaveChanges();
                DAL.Award awrd = new DAL.Award();
                awrd.AwardAcronyms="Acroni";
                awrd.AwardName = "Name";
                DAL.Repository.Service.Implementation.AdminContext cntxt = new DAL.Repository.Service.Implementation.AdminContext();
                cntxt.AwardContext.Add(awrd);
                cntxt.SaveChanges();
                
                MessageBox.Show("Holala....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
