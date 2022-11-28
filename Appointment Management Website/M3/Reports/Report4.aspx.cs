using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace M3.Reports
{
    public partial class Report4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportDocument crystal = new ReportDocument();
            crystal.Load(Server.MapPath("~/Reports/PaymentMethodReports.rpt"));
            CrystalReportViewer1.ReportSource = crystal;

            crystal.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "Payment Methods Reports");
        }
    }
}