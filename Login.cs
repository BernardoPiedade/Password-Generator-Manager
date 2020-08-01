using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;

namespace Password_Generator_Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            Label_Add_New.Visible = false;
            Platform_Add.Visible = false;
            textBox_Platform_Add.Visible = false;
            Password_Add.Visible = false;
            textBox_Password_Add.Visible = false;
            Button_Send_New.Visible = false;

            Get_Password_Label.Visible = false;
            Platform_Get.Visible = false;
            textBox_Platform_Get.Visible = false;
            button_Get.Visible = false;
            textBox_Show_Pass.Visible = false;

            try
            {
                string _ConnectionString = "Server=localhost; Port=3306; Uid=root; Pwd=mysql";

                using (MySqlConnection _conn = new MySqlConnection(_ConnectionString))
                {
                    _conn.Open();

                    try
                    {
                        // Create database
                        MySqlCommand create_DB = new MySqlCommand("CREATE DATABASE password_manager", _conn);
                        create_DB.ExecuteNonQuery();

                        // Use database
                        MySqlCommand use_db = new MySqlCommand("USE password_manager", _conn);
                        use_db.ExecuteNonQuery();

                        // Create table for passwords
                        MySqlCommand create_PWD_table = new MySqlCommand("CREATE TABLE password_manager (platform VARCHAR(255), password VARCHAR(255));", _conn);
                        create_PWD_table.ExecuteNonQuery();

                        // Create table for user
                        MySqlCommand create_User_table = new MySqlCommand("CREATE TABLE user (password VARCHAR(255));", _conn);
                        create_User_table.ExecuteNonQuery();

                    }
                    catch
                    {
                    }

                    _conn.Close();
                }
            }
            catch
            {
                MessageBox.Show("Couldn't connect to mysql service.", "Connection error");
            }

            try
            {
                XmlDocument a = new XmlDocument();
                a.Load(filename: "a.xml");

                XmlNodeList showBoxNodeList = a.GetElementsByTagName("c");
                string o = "";

                foreach (XmlNode node in showBoxNodeList)
                {
                    o = node.InnerText;
                }

                if (o.Equals("0"))
                {
                    Button_create.Visible = true;
                    pwd_create.Visible = true;

                    Button_Login.Visible = false;
                    pwd_login.Visible = false;
                }
                else
                {
                    Button_create.Visible = false;
                    pwd_create.Visible = false;

                    Button_Login.Visible = true;
                    pwd_login.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Couldn't read xml, are you missing some files?", "Couldn't read xml");
            }
        }

        private void Button_create_Click(object sender, EventArgs e)
        {
            createAcc();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void createAcc()
        {
            if (pwd_create.TextLength > 0)
            {
                string ConnectionString = "Server=localhost; Port=3306; Database=password_manager; Uid=root; Pwd=mysql";

                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();

                    try
                    {
                        MySqlCommand user_password = new MySqlCommand("INSERT INTO user VALUES ('" + pwd_create.Text + "')", conn);
                        user_password.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Couldn't add master password to database, please check you connection.", "Connetion issues");
                    }

                    conn.Close();
                }


                Label_Add_New.Visible = true;
                Platform_Add.Visible = true;
                textBox_Platform_Add.Visible = true;
                Password_Add.Visible = true;
                textBox_Password_Add.Visible = true;
                Button_Send_New.Visible = true;

                Get_Password_Label.Visible = true;
                Platform_Get.Visible = true;
                textBox_Platform_Get.Visible = true;
                button_Get.Visible = true;
                textBox_Show_Pass.Visible = true;

                label1.Visible = false;
                Button_create.Visible = false;
                pwd_create.Visible = false;

                Button_Login.Visible = false;
                pwd_login.Visible = false;


                XmlDocument a = new XmlDocument();
                a.Load(filename: "a.xml");

                XmlNodeList showBoxNodeList = a.GetElementsByTagName("c");

                foreach (XmlNode node in showBoxNodeList)
                {
                    node.InnerText = "1";
                }
                a.Save(filename: "a.xml");
            }
            else
            {
                MessageBox.Show("Please create a master password!", "Master password can't be empty");
            }
        }

        private void login()
        {
            if(pwd_login.TextLength > 0)
            {
                string ConnectionString = "Server=localhost; Port=3306; Database=password_manager; Uid=root; Pwd=mysql";
                string u_pwd = "";

                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    try
                    {
                        using (MySqlCommand select = new MySqlCommand("SELECT * FROM user", conn))
                        {
                            MySqlDataReader reader = select.ExecuteReader();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    u_pwd = (string)reader["password"];
                                }
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Couldn't add master password to database, please check you connection.", "Connetion issues");
                    }

                    conn.Close();
                }

                if(pwd_login.Text == u_pwd)
                {
                    Label_Add_New.Visible = true;
                    Platform_Add.Visible = true;
                    textBox_Platform_Add.Visible = true;
                    Password_Add.Visible = true;
                    textBox_Password_Add.Visible = true;
                    Button_Send_New.Visible = true;

                    Get_Password_Label.Visible = true;
                    Platform_Get.Visible = true;
                    textBox_Platform_Get.Visible = true;
                    button_Get.Visible = true;
                    textBox_Show_Pass.Visible = true;

                    label1.Visible = false;
                    Button_create.Visible = false;
                    pwd_create.Visible = false;

                    Button_Login.Visible = false;
                    pwd_login.Visible = false;
                }
                else
                {
                    MessageBox.Show("Passwords don't match!", "Wrong password!");
                }
            }
            else
            {
                MessageBox.Show("Please enter the master password to access manager", "Master password can't be empty");
            }
        }

        private void Button_Send_New_Click(object sender, EventArgs e)
        {
            if(textBox_Platform_Add.TextLength > 0 && textBox_Password_Add.TextLength > 0)
            {
                string ConnectionString = "Server=localhost; Port=3306; Database=password_manager; Uid=root; Pwd=mysql";

                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();

                    try
                    {
                        MySqlCommand user_password = new MySqlCommand("INSERT INTO password_manager VALUES ('" + textBox_Platform_Add.Text + "', '"+textBox_Password_Add.Text+"')", conn);
                        user_password.ExecuteNonQuery();
                        MessageBox.Show("Platform / Password added successfuly!", "Success");
                        textBox_Password_Add.Text = "";
                        textBox_Platform_Add.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Couldn't add platform / password to database, please check you connection.", "Connetion issues");
                    }

                    conn.Close();
                }
            }
            else if (textBox_Platform_Add.TextLength > 0 && textBox_Password_Add.TextLength <= 0)
            {
                const string src = "abcdefghijklmnopqrstuvwxyz0123456789#$%&";
                int length = 16;
                var sb = new StringBuilder();
                Random RNG = new Random();
                for (var i = 0; i < length; i++)
                {
                    var c = src[RNG.Next(0, src.Length)];
                    sb.Append(c);
                }

                string ConnectionString = "Server=localhost; Port=3306; Database=password_manager; Uid=root; Pwd=mysql";

                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();

                    try
                    {
                        MySqlCommand user_password = new MySqlCommand("INSERT INTO password_manager VALUES ('" + textBox_Platform_Add.Text + "', '" + sb.ToString() + "')", conn);
                        user_password.ExecuteNonQuery();
                        MessageBox.Show("Platform / Password added successfuly!", "Success");
                        textBox_Password_Add.Text = "";
                        textBox_Platform_Add.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Couldn't add platform / password to database, please check you connection.", "Connetion issues");
                    }

                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill the forms correctly", "Forms requirements");
            }
        }

        private void button_Get_Click(object sender, EventArgs e)
        {
            if(textBox_Platform_Get.TextLength > 0)
            {
                string ConnectionString = "Server=localhost; Port=3306; Database=password_manager; Uid=root; Pwd=mysql";
                string pwd = "";

                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    try
                    {
                        using (MySqlCommand select = new MySqlCommand("SELECT password FROM password_manager WHERE platform = '"+textBox_Platform_Get.Text+"'", conn))
                        {
                            MySqlDataReader reader = select.ExecuteReader();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    pwd = (string)reader["password"];
                                }
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Couldn't find a password for that platform, did you write it right?", "Platform not found");
                    }

                    conn.Close();
                }

                textBox_Show_Pass.Text = pwd;
            }
            else
            {
                MessageBox.Show("Please fill the forms correctly", "Forms requirements");
            }
        }
    }
}
