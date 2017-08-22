using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiAgro.BOL
{
    public class TariqBOL
    {
        int testID;
        string testName;
        string testEmail;
        string testLastName;

        public int TestID
        {
            get
            {
                return testID;
            }

            set
            {
                testID = value;
            }
        }

        public string TestName
        {
            get
            {
                return testName;
            }

            set
            {
                testName = value;
            }
        }

        public string TestEmail
        {
            get
            {
                return testEmail;
            }

            set
            {
                testEmail = value;
            }
        }

        public string TestLastName
        {
            get
            {
                return testLastName;
            }

            set
            {
                testLastName = value;
            }
        }
    }
}
