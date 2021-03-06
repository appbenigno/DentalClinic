﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic
{
    class WinForms
    {
        private static Form main;

        public static Form Main
        {
            get
            {
                if (main == null)
                {
                    main = new frmMain();
                }
                return main;
            }
        }

        private static Form about;
        public static Form About
        {
            get
            {
                if (about == null)
                {
                    about = new frmAbout();
                }
                return about;
            }
        }

        private static Form cli;
        public static Form CommandLineInterface
        {
            get
            {
                if (cli == null)
                {
                    cli = new frmCLI();
                }
                return cli;
            }
        }

        private static Form patient;
        public static Form Patient
        {
            get
            {
                if (patient == null)
                {
                    patient = new frmEmployee();
                }
                return patient;
            }
        }

        private static Form dentist;
        public static Form Dentist
        {
            get
            {
                if (dentist == null)
                {
                    dentist = new frmDentist();
                }
                return dentist;
            }
        }

        private static Form signup;
        public static Form SignUp
        {
            get
            {
                if (signup == null)
                {
                    signup = new Signup();
                }
                return signup;
            }
        }

        private static Form admin;
        public static Form Admin
        {
            get
            {
                if (admin == null)
                {
                    admin = new Admin();
                }
                return admin;
            }
        }
        private static Form staff;
        public static Form Staff
        {
            get
            {
                if (staff == null)
                {
                    staff = new Staff();
                }
                return staff;
            }
        }

        private static Form inventory;
        public static Form Inventory
        {
            get
            {
                if (inventory == null)
                {
                    inventory = new Inventory();
                }
                return inventory;
            }
        }
    }
}
