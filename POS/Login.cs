using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.COMMON;

namespace POS
{
    public partial class Login : Form
    {
        #region Global Declaration
        //private IDAL.IUserRef _IUserRef = null;
        #endregion

        public Login()
        {
            InitializeComponent();
            //_IUserRef = new BLL.BUserRef();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                AuthenticateUser(txtUserName.Text, txtPassword.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Author:  Amin
        /// Created Date:01/01/2011
        /// Description:This is used for user access authentication event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AuthenticateUser(string userID, string password)
        {
            try
            {
                Sha1 sha1Obj = new Sha1();

                if (!new MemberShips().CheckMemberShip(userID, sha1Obj.GetEncryptString(password)))
                {
                    //////////   new UserDA().InsertUserLog(Request.UserHostAddress.ToString(), userName, password);
                    // lblMessage.Text = "Log In Failed.";
                    MessageBox.Show("Incorrect Login Information.", "Login Failed");
                }
                else
                {
                    new Home().Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
