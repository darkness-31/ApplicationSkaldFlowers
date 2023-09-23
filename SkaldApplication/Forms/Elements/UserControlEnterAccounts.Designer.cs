namespace SkaldApplication.Forms.Elements
{
    partial class UserControlEnterAccounts
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.ButtoEntered = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(184, 162);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(184, 20);
            this.TextBoxLogin.TabIndex = 0;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(184, 214);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(184, 20);
            this.TextBoxPassword.TabIndex = 0;
            // 
            // ButtoEntered
            // 
            this.ButtoEntered.Location = new System.Drawing.Point(243, 252);
            this.ButtoEntered.Name = "ButtoEntered";
            this.ButtoEntered.Size = new System.Drawing.Size(77, 32);
            this.ButtoEntered.TabIndex = 1;
            this.ButtoEntered.Text = "Войти";
            this.ButtoEntered.UseVisualStyleBackColor = true;
            this.ButtoEntered.Click += new System.EventHandler(this.ButtoEntered_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // LabelError
            // 
            this.LabelError.AutoSize = true;
            this.LabelError.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelError.Location = new System.Drawing.Point(181, 94);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(0, 13);
            this.LabelError.TabIndex = 3;
            // 
            // UserControlEnterAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtoEntered);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxLogin);
            this.Name = "UserControlEnterAccounts";
            this.Size = new System.Drawing.Size(574, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button ButtoEntered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelError;
    }
}
