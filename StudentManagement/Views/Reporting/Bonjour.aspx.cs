using StudentManagement.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagement.Views.Reporting
{
    public partial class Bonjour : System.Web.Mvc.ViewPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (StudentContext  db = new StudentContext())
            {
                ListGroups listGroups = new ListGroups();
                BonjourRapport bonjourRapport = new BonjourRapport();
               // listGroups.Database.Tables[0].SetDataSource(db.Groups);

                CrystalReportViewer1.ReportSource = null;
                CrystalReportViewer1.ReportSource = bonjourRapport;
                
            }
           
        }
    }
}