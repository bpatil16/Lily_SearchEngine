using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch
{
    enum AccountType
    {
        Jobseeker,
        Employer
    }
    class Account
    {
        private static int lastAccountNumber = 0;


        #region Properties

        public int AccountNumber { get; private set; }

        public AccountType TypeOfAccount { get; set; }

        public string EmailAddress { get; set; }

        public string Resume { get; private set; }

        public int JobNumber { get; private set; }

        #endregion Properties

        #region Constructor
        public Account()
        {
            AccountNumber = ++lastAccountNumber;
        }
        #endregion Constructor


        #region Methods

        public string AddResume(string resume)
        {
            return Resume = resume;
        }

        public int AddJob(int jobid)
        {
            return JobNumber = jobid;
        }

        #endregion Methods

    }
}