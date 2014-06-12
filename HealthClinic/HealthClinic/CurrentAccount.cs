using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic
{
    class CurrentAccount
    {
        private static Konto account;

        public static void setAccount(Konto currentAccount)
        {
            account = currentAccount;
        }

        public static Konto getAccount()
        {
            return account;
        }
    }
}
