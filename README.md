Grouped User Report
===================

Groups user accounts by client.

To start:

1. Create a new database called "Members"
2. Run aspnet\_regsql.exe by either filling out the wizard or setting the configration options through the command line as follows:

    C:\Windows\Microsoft.Net\Framework\v2.0.50727\aspnet_regsql -S <SqlServerName> -U <DBOwnerAccount> -P <DBOwnerAccountPassword> -A all -d Members

3. Either download this repository as a ZIP file or clone it using git:

    git clone https://github.com/IntertrustGroup/GroupedUserReport.git

4. Open GroupedUserReport.sln in VisualStudio.
5. Update the GroupedUserReport.ConsoleApp\App.config connection string section to go to your "Members" database.

    <connectionStrings>
      <add name="Members" connectionString="Data Source=<SqlServerName>;Initial Catalog=Members;UID=<UserId>;PWD=<Password>" />
    </connectionStrings>

6. Update the GroupedUserReport.WebApp\Web.config connection string section to go to your "Members" database.
7. When you first run the application it should create 15 new user accounts. You should use the MembershipProvider API to get and group these users, then output the data as a report through the ConsoleApp and WebApp projects.

By default VisualStudio will launch the currently active project. You can change this behavior by setting an explicit startup project in the solution's preferences.

You can find the MembershipProvider's API here: http://msdn.microsoft.com/en-us/library/System.Web.Security.MembershipProvider%28v=vs.110%29.aspx

