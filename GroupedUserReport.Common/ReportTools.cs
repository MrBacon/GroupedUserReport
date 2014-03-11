using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;

namespace GroupedUserReport.Common
{
    public class ReportTools
    {
        public MembershipProvider MembershipProvider { get; private set; }

        public ReportTools(MembershipProvider membershipProvider)
        {
            MembershipProvider = membershipProvider;
        }

        /// <summary>
        /// Groups all user accounts by the company they belong to. Use the company domain name as the key.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, MembershipUser[]> GroupUsersByDomain()
        {
            var result = new Dictionary<string, MembershipUser[]>(StringComparer.InvariantCultureIgnoreCase);

            throw new NotImplementedException();

            return result;
        }

        /// <summary>
        /// Given a domain, such as "smokymountain.com", return all associated user accounts.
        /// 
        /// Hint: Look at the ASP.NET MembershipProvider API for helpful methods.
        /// </summary>
        /// <param name="domain"></param>
        /// <returns></returns>
        public MembershipUser[] GetUsersByDomain(string domain)
        {
            throw new NotImplementedException();
        }






        #region Do Not Modify
        /// <summary>
        /// Initiates the user/membership repository with 15 dummy user acccounts.
        /// </summary>
        public void InitUserAccounts()
        {
            var totalRecords = 0;
            MembershipProvider.GetAllUsers(0, int.MaxValue, out totalRecords);

            if (totalRecords > 0)
            {
                return;
            }

            var setupData = new []
            {
                new { username = "UserOne",         email = "user.one@smokymountain.com" },
                new { username = "UserTwo",         email = "user.two@dakin-farm.com" },
                new { username = "UserThree",       email = "user.three@smokymountain.com" },
                new { username = "UserFour",        email = "user.four@farmland-foods.com" },
                new { username = "UserFive",        email = "user.five@farmland-foods.com" },
                new { username = "UserSix",         email = "user.six@hormel.com" },
                new { username = "UserSeven",       email = "user.seven@hormel.com" },
                new { username = "UserEight",       email = "user.eight@dakin-farm.com" },
                new { username = "UserNine",        email = "user.nine@dakin-farm.com" },
                new { username = "UserTen",         email = "user.ten@smokymountain.com" },
                new { username = "UserEleven",      email = "user.eleven@smithfield.com" },
                new { username = "UserTwelve",      email = "user.twelve@smokymountain.com" },
                new { username = "UserThirteen",    email = "user.thirteen@hormel.com" },
                new { username = "UserFourteen",    email = "user.fourteen@smokymountain.com" },
                new { username = "UserFifteen",     email = "user.fifteen@smithfield.com" }
            };

            foreach (var config in setupData)
            {
                MembershipCreateStatus status;

                MembershipProvider.CreateUser(
                    config.username, "#Password#", config.email, "Question?", "Answer!", true, Guid.NewGuid(), out status
                );

                if (status != MembershipCreateStatus.Success)
                {
                    throw new Exception(
                        String.Format("Failed to initialize member repository: {0}", status.ToString("g"))
                    );
                }
            }
        }
        #endregion
    }
}
