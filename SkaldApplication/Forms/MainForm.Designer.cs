namespace SkaldApplication
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.FlowLayoutPanelAccounts = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelNameUser = new System.Windows.Forms.Label();
            this.ButtonAccountEnter = new System.Windows.Forms.Button();
            this.ButtonAccountRegistration = new System.Windows.Forms.Button();
            this.ButtonAccountExit = new System.Windows.Forms.Button();
            this.FlowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonStock = new System.Windows.Forms.Button();
            this.ButtonMaterials = new System.Windows.Forms.Button();
            this.ButtonPersons = new System.Windows.Forms.Button();
            this.ButtonAccounts = new System.Windows.Forms.Button();
            this.ButtonSales = new System.Windows.Forms.Button();
            this.ButtonPurchase = new System.Windows.Forms.Button();
            this.ButtonCloseTab = new System.Windows.Forms.Button();
            this.TabsControl = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.FlowLayoutPanelAccounts.SuspendLayout();
            this.FlowLayoutPanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.FlowLayoutPanelAccounts);
            this.SplitContainer.Panel1.Controls.Add(this.FlowLayoutPanelMenu);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.ButtonCloseTab);
            this.SplitContainer.Panel2.Controls.Add(this.TabsControl);
            this.SplitContainer.Size = new System.Drawing.Size(686, 450);
            this.SplitContainer.SplitterDistance = 108;
            this.SplitContainer.TabIndex = 0;
            this.SplitContainer.TabStop = false;
            // 
            // FlowLayoutPanelAccounts
            // 
            this.FlowLayoutPanelAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FlowLayoutPanelAccounts.Controls.Add(this.LabelNameUser);
            this.FlowLayoutPanelAccounts.Controls.Add(this.ButtonAccountEnter);
            this.FlowLayoutPanelAccounts.Controls.Add(this.ButtonAccountRegistration);
            this.FlowLayoutPanelAccounts.Controls.Add(this.ButtonAccountExit);
            this.FlowLayoutPanelAccounts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlowLayoutPanelAccounts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutPanelAccounts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FlowLayoutPanelAccounts.Location = new System.Drawing.Point(0, 365);
            this.FlowLayoutPanelAccounts.Name = "FlowLayoutPanelAccounts";
            this.FlowLayoutPanelAccounts.Size = new System.Drawing.Size(108, 85);
            this.FlowLayoutPanelAccounts.TabIndex = 1;
            // 
            // LabelNameUser
            // 
            this.LabelNameUser.AutoSize = true;
            this.LabelNameUser.Location = new System.Drawing.Point(3, 0);
            this.LabelNameUser.Name = "LabelNameUser";
            this.LabelNameUser.Size = new System.Drawing.Size(46, 13);
            this.LabelNameUser.TabIndex = 1;
            this.LabelNameUser.Text = "Аноним";
            this.LabelNameUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonAccountEnter
            // 
            this.ButtonAccountEnter.Location = new System.Drawing.Point(3, 16);
            this.ButtonAccountEnter.Name = "ButtonAccountEnter";
            this.ButtonAccountEnter.Size = new System.Drawing.Size(93, 29);
            this.ButtonAccountEnter.TabIndex = 1;
            this.ButtonAccountEnter.Text = "Войти";
            this.ButtonAccountEnter.UseVisualStyleBackColor = true;
            this.ButtonAccountEnter.Click += new System.EventHandler(this.ButtonAccountEnter_Click);
            // 
            // ButtonAccountRegistration
            // 
            this.ButtonAccountRegistration.Location = new System.Drawing.Point(3, 51);
            this.ButtonAccountRegistration.Name = "ButtonAccountRegistration";
            this.ButtonAccountRegistration.Size = new System.Drawing.Size(93, 29);
            this.ButtonAccountRegistration.TabIndex = 2;
            this.ButtonAccountRegistration.Text = "Регистрация";
            this.ButtonAccountRegistration.UseVisualStyleBackColor = true;
            this.ButtonAccountRegistration.Click += new System.EventHandler(this.ButtonAccountRegistration_Click);
            // 
            // ButtonAccountExit
            // 
            this.ButtonAccountExit.Enabled = false;
            this.ButtonAccountExit.Location = new System.Drawing.Point(102, 3);
            this.ButtonAccountExit.Name = "ButtonAccountExit";
            this.ButtonAccountExit.Size = new System.Drawing.Size(93, 29);
            this.ButtonAccountExit.TabIndex = 0;
            this.ButtonAccountExit.Text = "Выйти";
            this.ButtonAccountExit.UseVisualStyleBackColor = true;
            this.ButtonAccountExit.Visible = false;
            // 
            // FlowLayoutPanelMenu
            // 
            this.FlowLayoutPanelMenu.Controls.Add(this.ButtonStock);
            this.FlowLayoutPanelMenu.Controls.Add(this.ButtonMaterials);
            this.FlowLayoutPanelMenu.Controls.Add(this.ButtonPersons);
            this.FlowLayoutPanelMenu.Controls.Add(this.ButtonAccounts);
            this.FlowLayoutPanelMenu.Controls.Add(this.ButtonSales);
            this.FlowLayoutPanelMenu.Controls.Add(this.ButtonPurchase);
            this.FlowLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlowLayoutPanelMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanelMenu.Name = "FlowLayoutPanelMenu";
            this.FlowLayoutPanelMenu.Size = new System.Drawing.Size(108, 217);
            this.FlowLayoutPanelMenu.TabIndex = 0;
            // 
            // ButtonStock
            // 
            this.ButtonStock.Location = new System.Drawing.Point(3, 3);
            this.ButtonStock.Name = "ButtonStock";
            this.ButtonStock.Size = new System.Drawing.Size(93, 29);
            this.ButtonStock.TabIndex = 3;
            this.ButtonStock.Text = "Склад";
            this.ButtonStock.UseVisualStyleBackColor = true;
            this.ButtonStock.Visible = false;
            // 
            // ButtonMaterials
            // 
            this.ButtonMaterials.Location = new System.Drawing.Point(3, 38);
            this.ButtonMaterials.Name = "ButtonMaterials";
            this.ButtonMaterials.Size = new System.Drawing.Size(93, 29);
            this.ButtonMaterials.TabIndex = 4;
            this.ButtonMaterials.Text = "Материалы";
            this.ButtonMaterials.UseVisualStyleBackColor = true;
            this.ButtonMaterials.Visible = false;
            // 
            // ButtonPersons
            // 
            this.ButtonPersons.Location = new System.Drawing.Point(3, 73);
            this.ButtonPersons.Name = "ButtonPersons";
            this.ButtonPersons.Size = new System.Drawing.Size(93, 29);
            this.ButtonPersons.TabIndex = 5;
            this.ButtonPersons.Text = "Люди";
            this.ButtonPersons.UseVisualStyleBackColor = true;
            this.ButtonPersons.Visible = false;
            // 
            // ButtonAccounts
            // 
            this.ButtonAccounts.Location = new System.Drawing.Point(3, 108);
            this.ButtonAccounts.Name = "ButtonAccounts";
            this.ButtonAccounts.Size = new System.Drawing.Size(93, 29);
            this.ButtonAccounts.TabIndex = 6;
            this.ButtonAccounts.Text = "Аккаунты";
            this.ButtonAccounts.UseVisualStyleBackColor = true;
            this.ButtonAccounts.Visible = false;
            // 
            // ButtonSales
            // 
            this.ButtonSales.Location = new System.Drawing.Point(3, 143);
            this.ButtonSales.Name = "ButtonSales";
            this.ButtonSales.Size = new System.Drawing.Size(93, 29);
            this.ButtonSales.TabIndex = 7;
            this.ButtonSales.Text = "Продажи";
            this.ButtonSales.UseVisualStyleBackColor = true;
            this.ButtonSales.Visible = false;
            // 
            // ButtonPurchase
            // 
            this.ButtonPurchase.Location = new System.Drawing.Point(3, 178);
            this.ButtonPurchase.Name = "ButtonPurchase";
            this.ButtonPurchase.Size = new System.Drawing.Size(93, 29);
            this.ButtonPurchase.TabIndex = 8;
            this.ButtonPurchase.Text = "Покупки";
            this.ButtonPurchase.UseVisualStyleBackColor = true;
            this.ButtonPurchase.Visible = false;
            // 
            // ButtonCloseTab
            // 
            this.ButtonCloseTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCloseTab.Location = new System.Drawing.Point(553, 0);
            this.ButtonCloseTab.Name = "ButtonCloseTab";
            this.ButtonCloseTab.Size = new System.Drawing.Size(20, 20);
            this.ButtonCloseTab.TabIndex = 2;
            this.ButtonCloseTab.Text = "X";
            this.ButtonCloseTab.UseVisualStyleBackColor = true;
            this.ButtonCloseTab.Visible = false;
            this.ButtonCloseTab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonCloseTab_MouseClick);
            // 
            // TabsControl
            // 
            this.TabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsControl.Location = new System.Drawing.Point(0, 0);
            this.TabsControl.Name = "TabsControl";
            this.TabsControl.SelectedIndex = 0;
            this.TabsControl.Size = new System.Drawing.Size(574, 450);
            this.TabsControl.TabIndex = 0;
            this.TabsControl.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.TabsControl_ControlAdded);
            this.TabsControl.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.TabsControl_ControlRemoved);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.SplitContainer);
            this.Name = "MainForm";
            this.Text = "1C";
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.FlowLayoutPanelAccounts.ResumeLayout(false);
            this.FlowLayoutPanelAccounts.PerformLayout();
            this.FlowLayoutPanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.Button ButtonPersons;
        private System.Windows.Forms.Button ButtonStock;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelMenu;
        private System.Windows.Forms.Button ButtonMaterials;
        private System.Windows.Forms.Button ButtonAccounts;
        private System.Windows.Forms.Button ButtonSales;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelAccounts;
        private System.Windows.Forms.Button ButtonPurchase;
        private System.Windows.Forms.Label LabelNameUser;
        private System.Windows.Forms.Button ButtonAccountEnter;
        private System.Windows.Forms.Button ButtonAccountRegistration;
        private System.Windows.Forms.Button ButtonAccountExit;
        private System.Windows.Forms.TabControl TabsControl;
        private System.Windows.Forms.Button ButtonCloseTab;
    }
}

