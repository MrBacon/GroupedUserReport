using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroupedUserReport.WebApp
{
    public partial class _Default : System.Web.UI.Page
    {
        protected Common.ReportTools ReportTools { get; private set; }

        protected void Page_Init(object sender, EventArgs e)
        {
            ReportTools = new Common.ReportTools(
                System.Web.Security.Membership.Providers["AspNetSqlMembershipProvider"]
            );

            ReportTools.InitUserAccounts();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}