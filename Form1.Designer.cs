
namespace Werbas_ConfigEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNewServer = new System.Windows.Forms.Button();
            this.btnServerPathSelect = new System.Windows.Forms.Button();
            this.edConnString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbServerPfad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.cbTSClient = new System.Windows.Forms.CheckBox();
            this.btnSelectClientPath = new System.Windows.Forms.Button();
            this.cbClientPfad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 194);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNewServer);
            this.tabPage1.Controls.Add(this.btnServerPathSelect);
            this.tabPage1.Controls.Add(this.edConnString);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbServerPfad);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(549, 166);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNewServer
            // 
            this.btnNewServer.Location = new System.Drawing.Point(125, 99);
            this.btnNewServer.Name = "btnNewServer";
            this.btnNewServer.Size = new System.Drawing.Size(111, 23);
            this.btnNewServer.TabIndex = 5;
            this.btnNewServer.Text = "Neuer Server";
            this.btnNewServer.UseVisualStyleBackColor = true;
            this.btnNewServer.Click += new System.EventHandler(this.btnNewServer_Click);
            // 
            // btnServerPathSelect
            // 
            this.btnServerPathSelect.Location = new System.Drawing.Point(511, 27);
            this.btnServerPathSelect.Name = "btnServerPathSelect";
            this.btnServerPathSelect.Size = new System.Drawing.Size(25, 23);
            this.btnServerPathSelect.TabIndex = 4;
            this.btnServerPathSelect.Text = "...";
            this.btnServerPathSelect.UseVisualStyleBackColor = true;
            this.btnServerPathSelect.Click += new System.EventHandler(this.btnServerPathSelect_Click);
            // 
            // edConnString
            // 
            this.edConnString.Location = new System.Drawing.Point(126, 68);
            this.edConnString.Name = "edConnString";
            this.edConnString.Size = new System.Drawing.Size(372, 23);
            this.edConnString.TabIndex = 3;
            this.edConnString.Leave += new System.EventHandler(this.edConnString_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ConnectionString:";
            // 
            // cbServerPfad
            // 
            this.cbServerPfad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServerPfad.FormattingEnabled = true;
            this.cbServerPfad.Location = new System.Drawing.Point(126, 27);
            this.cbServerPfad.Name = "cbServerPfad";
            this.cbServerPfad.Size = new System.Drawing.Size(372, 23);
            this.cbServerPfad.TabIndex = 1;
            this.cbServerPfad.SelectedIndexChanged += new System.EventHandler(this.cbServerPfad_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pfad:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnNewClient);
            this.tabPage2.Controls.Add(this.cbTSClient);
            this.tabPage2.Controls.Add(this.btnSelectClientPath);
            this.tabPage2.Controls.Add(this.cbClientPfad);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(549, 166);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clients";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnNewClient
            // 
            this.btnNewClient.Location = new System.Drawing.Point(47, 98);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(111, 23);
            this.btnNewClient.TabIndex = 11;
            this.btnNewClient.Text = "Neuer Client";
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // cbTSClient
            // 
            this.cbTSClient.AutoSize = true;
            this.cbTSClient.Location = new System.Drawing.Point(8, 57);
            this.cbTSClient.Name = "cbTSClient";
            this.cbTSClient.Size = new System.Drawing.Size(69, 19);
            this.cbTSClient.TabIndex = 10;
            this.cbTSClient.Text = "TSClient";
            this.cbTSClient.UseVisualStyleBackColor = true;
            this.cbTSClient.Click += new System.EventHandler(this.cbTSClient_Click);
            // 
            // btnSelectClientPath
            // 
            this.btnSelectClientPath.Location = new System.Drawing.Point(432, 19);
            this.btnSelectClientPath.Name = "btnSelectClientPath";
            this.btnSelectClientPath.Size = new System.Drawing.Size(25, 23);
            this.btnSelectClientPath.TabIndex = 9;
            this.btnSelectClientPath.Text = "...";
            this.btnSelectClientPath.UseVisualStyleBackColor = true;
            this.btnSelectClientPath.Click += new System.EventHandler(this.btnSelectClientPath_Click);
            // 
            // cbClientPfad
            // 
            this.cbClientPfad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientPfad.FormattingEnabled = true;
            this.cbClientPfad.Location = new System.Drawing.Point(47, 19);
            this.cbClientPfad.Name = "cbClientPfad";
            this.cbClientPfad.Size = new System.Drawing.Size(372, 23);
            this.cbClientPfad.TabIndex = 6;
            this.cbClientPfad.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pfad:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 43);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(470, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Beenden";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(389, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 194);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(573, 227);
            this.Name = "Form1";
            this.Text = "Config-Editor";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnServerPathSelect;
        private System.Windows.Forms.TextBox edConnString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbServerPfad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbTSClient;
        private System.Windows.Forms.Button btnSelectClientPath;
        private System.Windows.Forms.ComboBox cbClientPfad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNewServer;
        private System.Windows.Forms.Button btnNewClient;
    }
}

