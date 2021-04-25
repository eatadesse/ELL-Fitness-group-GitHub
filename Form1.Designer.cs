
namespace ELL_Fitness_group__GitHub_
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabs = new MetroFramework.Controls.MetroTabControl();
            this.homeTab = new MetroFramework.Controls.MetroTabPage();
            this.registrationTab = new MetroFramework.Controls.MetroTabPage();
            this.excercisesTab = new MetroFramework.Controls.MetroTabPage();
            this.historyTab = new MetroFramework.Controls.MetroTabPage();
            this.loginTab = new MetroFramework.Controls.MetroTabPage();
            this.panel1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 108);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "ELL Fitness";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(850, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 108);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.homeTab);
            this.tabs.Controls.Add(this.historyTab);
            this.tabs.Controls.Add(this.excercisesTab);
            this.tabs.Controls.Add(this.registrationTab);
            this.tabs.Controls.Add(this.loginTab);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 108);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 4;
            this.tabs.Size = new System.Drawing.Size(947, 537);
            this.tabs.TabIndex = 1;
            this.tabs.UseSelectable = true;
            // 
            // homeTab
            // 
            this.homeTab.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTab.HorizontalScrollbarBarColor = true;
            this.homeTab.HorizontalScrollbarHighlightOnWheel = false;
            this.homeTab.HorizontalScrollbarSize = 10;
            this.homeTab.Location = new System.Drawing.Point(4, 38);
            this.homeTab.Name = "homeTab";
            this.homeTab.Size = new System.Drawing.Size(939, 495);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            this.homeTab.VerticalScrollbarBarColor = true;
            this.homeTab.VerticalScrollbarHighlightOnWheel = false;
            this.homeTab.VerticalScrollbarSize = 10;
            // 
            // registrationTab
            // 
            this.registrationTab.HorizontalScrollbarBarColor = true;
            this.registrationTab.HorizontalScrollbarHighlightOnWheel = false;
            this.registrationTab.HorizontalScrollbarSize = 5;
            this.registrationTab.Location = new System.Drawing.Point(4, 38);
            this.registrationTab.Name = "registrationTab";
            this.registrationTab.Size = new System.Drawing.Size(939, 495);
            this.registrationTab.TabIndex = 1;
            this.registrationTab.Text = "Registration";
            this.registrationTab.VerticalScrollbarBarColor = true;
            this.registrationTab.VerticalScrollbarHighlightOnWheel = false;
            this.registrationTab.VerticalScrollbarSize = 5;
            // 
            // excercisesTab
            // 
            this.excercisesTab.HorizontalScrollbarBarColor = true;
            this.excercisesTab.HorizontalScrollbarHighlightOnWheel = false;
            this.excercisesTab.HorizontalScrollbarSize = 5;
            this.excercisesTab.Location = new System.Drawing.Point(4, 38);
            this.excercisesTab.Name = "excercisesTab";
            this.excercisesTab.Size = new System.Drawing.Size(939, 495);
            this.excercisesTab.TabIndex = 2;
            this.excercisesTab.Text = "Excercises";
            this.excercisesTab.VerticalScrollbarBarColor = true;
            this.excercisesTab.VerticalScrollbarHighlightOnWheel = false;
            this.excercisesTab.VerticalScrollbarSize = 5;
            // 
            // historyTab
            // 
            this.historyTab.HorizontalScrollbarBarColor = true;
            this.historyTab.HorizontalScrollbarHighlightOnWheel = false;
            this.historyTab.HorizontalScrollbarSize = 5;
            this.historyTab.Location = new System.Drawing.Point(4, 38);
            this.historyTab.Name = "historyTab";
            this.historyTab.Size = new System.Drawing.Size(939, 495);
            this.historyTab.TabIndex = 3;
            this.historyTab.Text = "History";
            this.historyTab.VerticalScrollbarBarColor = true;
            this.historyTab.VerticalScrollbarHighlightOnWheel = false;
            this.historyTab.VerticalScrollbarSize = 5;
            // 
            // loginTab
            // 
            this.loginTab.BackColor = System.Drawing.Color.Gainsboro;
            this.loginTab.HorizontalScrollbarBarColor = true;
            this.loginTab.HorizontalScrollbarHighlightOnWheel = false;
            this.loginTab.HorizontalScrollbarSize = 7;
            this.loginTab.Location = new System.Drawing.Point(4, 38);
            this.loginTab.Name = "loginTab";
            this.loginTab.Size = new System.Drawing.Size(939, 495);
            this.loginTab.TabIndex = 4;
            this.loginTab.Text = "Login";
            this.loginTab.VerticalScrollbarBarColor = true;
            this.loginTab.VerticalScrollbarHighlightOnWheel = false;
            this.loginTab.VerticalScrollbarSize = 5;
            this.loginTab.Click += new System.EventHandler(this.metroTabPage5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 645);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabControl tabs;
        private MetroFramework.Controls.MetroTabPage homeTab;
        private MetroFramework.Controls.MetroTabPage registrationTab;
        private MetroFramework.Controls.MetroTabPage excercisesTab;
        private MetroFramework.Controls.MetroTabPage historyTab;
        private MetroFramework.Controls.MetroTabPage loginTab;
    }
}

