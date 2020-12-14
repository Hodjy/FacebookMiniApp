using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public static class FacebookBasicMethods
    {
        public static string LogInUser()
        {
            string loginError = string.Empty;

            loginError = ConnectionManager.LogInUser("3925570110805927");

            return loginError;
        }

        public static void LogOutUser()
        {
            ConnectionManager.LogOutUser();
        }
    }
}
