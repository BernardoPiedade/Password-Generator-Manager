namespace Password_Generator_Manager
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pwd_login = new System.Windows.Forms.TextBox();
            this.pwd_create = new System.Windows.Forms.TextBox();
            this.Button_create = new System.Windows.Forms.Button();
            this.textBox_Show_Pass = new System.Windows.Forms.TextBox();
            this.button_Get = new System.Windows.Forms.Button();
            this.Platform_Get = new System.Windows.Forms.Label();
            this.textBox_Platform_Get = new System.Windows.Forms.TextBox();
            this.Get_Password_Label = new System.Windows.Forms.Label();
            this.Button_Send_New = new System.Windows.Forms.Button();
            this.Label_Add_New = new System.Windows.Forms.Label();
            this.Platform_Add = new System.Windows.Forms.Label();
            this.textBox_Platform_Add = new System.Windows.Forms.TextBox();
            this.Password_Add = new System.Windows.Forms.Label();
            this.textBox_Password_Add = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Login
            // 
            this.Button_Login.Location = new System.Drawing.Point(271, 118);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(75, 23);
            this.Button_Login.TabIndex = 0;
            this.Button_Login.Text = "Enter";
            this.Button_Login.UseVisualStyleBackColor = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Master Password";
            // 
            // pwd_login
            // 
            this.pwd_login.Location = new System.Drawing.Point(217, 83);
            this.pwd_login.Name = "pwd_login";
            this.pwd_login.PasswordChar = '*';
            this.pwd_login.Size = new System.Drawing.Size(129, 20);
            this.pwd_login.TabIndex = 2;
            // 
            // pwd_create
            // 
            this.pwd_create.Location = new System.Drawing.Point(217, 83);
            this.pwd_create.Name = "pwd_create";
            this.pwd_create.PasswordChar = '*';
            this.pwd_create.Size = new System.Drawing.Size(129, 20);
            this.pwd_create.TabIndex = 5;
            // 
            // Button_create
            // 
            this.Button_create.Location = new System.Drawing.Point(271, 118);
            this.Button_create.Name = "Button_create";
            this.Button_create.Size = new System.Drawing.Size(75, 23);
            this.Button_create.TabIndex = 3;
            this.Button_create.Text = "Create";
            this.Button_create.UseVisualStyleBackColor = true;
            this.Button_create.Click += new System.EventHandler(this.Button_create_Click);
            // 
            // textBox_Show_Pass
            // 
            this.textBox_Show_Pass.AcceptsReturn = true;
            this.textBox_Show_Pass.AcceptsTab = true;
            this.textBox_Show_Pass.Location = new System.Drawing.Point(404, 143);
            this.textBox_Show_Pass.Multiline = true;
            this.textBox_Show_Pass.Name = "textBox_Show_Pass";
            this.textBox_Show_Pass.ReadOnly = true;
            this.textBox_Show_Pass.Size = new System.Drawing.Size(166, 54);
            this.textBox_Show_Pass.TabIndex = 22;
            // 
            // button_Get
            // 
            this.button_Get.Location = new System.Drawing.Point(495, 105);
            this.button_Get.Name = "button_Get";
            this.button_Get.Size = new System.Drawing.Size(75, 23);
            this.button_Get.TabIndex = 21;
            this.button_Get.Text = "Get";
            this.button_Get.UseVisualStyleBackColor = true;
            this.button_Get.Click += new System.EventHandler(this.button_Get_Click);
            // 
            // Platform_Get
            // 
            this.Platform_Get.AutoSize = true;
            this.Platform_Get.Location = new System.Drawing.Point(405, 51);
            this.Platform_Get.Name = "Platform_Get";
            this.Platform_Get.Size = new System.Drawing.Size(48, 13);
            this.Platform_Get.TabIndex = 20;
            this.Platform_Get.Text = "Platform:";
            // 
            // textBox_Platform_Get
            // 
            this.textBox_Platform_Get.Location = new System.Drawing.Point(404, 70);
            this.textBox_Platform_Get.Name = "textBox_Platform_Get";
            this.textBox_Platform_Get.Size = new System.Drawing.Size(166, 20);
            this.textBox_Platform_Get.TabIndex = 19;
            // 
            // Get_Password_Label
            // 
            this.Get_Password_Label.AutoSize = true;
            this.Get_Password_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Get_Password_Label.Location = new System.Drawing.Point(401, 20);
            this.Get_Password_Label.Name = "Get_Password_Label";
            this.Get_Password_Label.Size = new System.Drawing.Size(95, 15);
            this.Get_Password_Label.TabIndex = 18;
            this.Get_Password_Label.Text = "Get Password";
            // 
            // Button_Send_New
            // 
            this.Button_Send_New.Location = new System.Drawing.Point(102, 178);
            this.Button_Send_New.Name = "Button_Send_New";
            this.Button_Send_New.Size = new System.Drawing.Size(75, 23);
            this.Button_Send_New.TabIndex = 17;
            this.Button_Send_New.Text = "Send";
            this.Button_Send_New.UseVisualStyleBackColor = true;
            this.Button_Send_New.Click += new System.EventHandler(this.Button_Send_New_Click);
            // 
            // Label_Add_New
            // 
            this.Label_Add_New.AutoSize = true;
            this.Label_Add_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Add_New.Location = new System.Drawing.Point(12, 20);
            this.Label_Add_New.Name = "Label_Add_New";
            this.Label_Add_New.Size = new System.Drawing.Size(185, 15);
            this.Label_Add_New.TabIndex = 16;
            this.Label_Add_New.Text = "Add new Platform/Password";
            // 
            // Platform_Add
            // 
            this.Platform_Add.AutoSize = true;
            this.Platform_Add.Location = new System.Drawing.Point(12, 51);
            this.Platform_Add.Name = "Platform_Add";
            this.Platform_Add.Size = new System.Drawing.Size(48, 13);
            this.Platform_Add.TabIndex = 15;
            this.Platform_Add.Text = "Platform:";
            // 
            // textBox_Platform_Add
            // 
            this.textBox_Platform_Add.Location = new System.Drawing.Point(11, 70);
            this.textBox_Platform_Add.Name = "textBox_Platform_Add";
            this.textBox_Platform_Add.Size = new System.Drawing.Size(166, 20);
            this.textBox_Platform_Add.TabIndex = 14;
            // 
            // Password_Add
            // 
            this.Password_Add.AutoSize = true;
            this.Password_Add.Location = new System.Drawing.Point(12, 110);
            this.Password_Add.Name = "Password_Add";
            this.Password_Add.Size = new System.Drawing.Size(155, 26);
            this.Password_Add.TabIndex = 13;
            this.Password_Add.Text = "Password \r\n(Leave empty to generate one):";
            // 
            // textBox_Password_Add
            // 
            this.textBox_Password_Add.Location = new System.Drawing.Point(11, 143);
            this.textBox_Password_Add.Name = "textBox_Password_Add";
            this.textBox_Password_Add.PasswordChar = '*';
            this.textBox_Password_Add.Size = new System.Drawing.Size(166, 20);
            this.textBox_Password_Add.TabIndex = 12;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 240);
            this.Controls.Add(this.textBox_Show_Pass);
            this.Controls.Add(this.button_Get);
            this.Controls.Add(this.Platform_Get);
            this.Controls.Add(this.textBox_Platform_Get);
            this.Controls.Add(this.Get_Password_Label);
            this.Controls.Add(this.Button_Send_New);
            this.Controls.Add(this.Label_Add_New);
            this.Controls.Add(this.Platform_Add);
            this.Controls.Add(this.textBox_Platform_Add);
            this.Controls.Add(this.Password_Add);
            this.Controls.Add(this.textBox_Password_Add);
            this.Controls.Add(this.pwd_create);
            this.Controls.Add(this.Button_create);
            this.Controls.Add(this.pwd_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pwd_login;
        private System.Windows.Forms.TextBox pwd_create;
        private System.Windows.Forms.Button Button_create;
        private System.Windows.Forms.TextBox textBox_Show_Pass;
        private System.Windows.Forms.Button button_Get;
        private System.Windows.Forms.Label Platform_Get;
        private System.Windows.Forms.TextBox textBox_Platform_Get;
        private System.Windows.Forms.Label Get_Password_Label;
        private System.Windows.Forms.Button Button_Send_New;
        private System.Windows.Forms.Label Label_Add_New;
        private System.Windows.Forms.Label Platform_Add;
        private System.Windows.Forms.TextBox textBox_Platform_Add;
        private System.Windows.Forms.Label Password_Add;
        private System.Windows.Forms.TextBox textBox_Password_Add;
    }
}