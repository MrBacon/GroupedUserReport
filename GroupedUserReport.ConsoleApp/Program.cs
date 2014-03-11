using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroupedUserReport.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var tools = new Common.ReportTools(
                System.Web.Security.Membership.Providers["AspNetSqlMembershipProvider"]
            );
            tools.InitUserAccounts();

            OutputReport(tools);
        }

        /// <summary>
        /// Responsible for outputing a report of users accounts grouped by their associated company
        /// </summary>
        /// <param name="tools"></param>
        private static void OutputReport(Common.ReportTools tools)
        {
            throw new NotImplementedException();
        }
    }
}
