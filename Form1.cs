using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Werbas_ConfigEditor
{
    public partial class Form1 : Form
    {
        Config conf;

        private bool hasChanges = false;

        #region Formular-Routinen
        public Form1()
        {
            InitializeComponent();
            ReadConfig();
            FillServerControls();
            FillClientControls();
        }

        private void FillServerControls()
        {
            cbServerPfad.Items.Clear();
            edConnString.Clear();

            foreach(Server s in conf.Servers)
                cbServerPfad.Items.Add(s.Path);
            cbServerPfad.SelectedIndex = (cbServerPfad.Items.Count > 0 ? 0 : -1);
            btnServerPathSelect.Enabled = (cbServerPfad.SelectedIndex != -1);
            edConnString.Enabled = (cbServerPfad.SelectedIndex != -1);
        }

        private void FillClientControls()
        {
            cbClientPfad.Items.Clear();
            cbTSClient.Checked = false;

            foreach (Client c in conf.Clients)
                cbClientPfad.Items.Add(c.Path);
            cbClientPfad.SelectedIndex = (cbClientPfad.Items.Count > 0 ? 0 : -1);
            btnSelectClientPath.Enabled = (cbClientPfad.SelectedIndex != -1);
            cbTSClient.Enabled = (cbClientPfad.SelectedIndex != -1);
        }
        #endregion

        #region Lese/Schreib-Routinen für XML-Datei

        /// <summary>
        /// Liest die Config.XML ein und deserialisert sie in unsere Config-Instanz
        /// </summary>
        private void ReadConfig()
        {
            //Wenn wir noch keine Config haben, machen wir eine leere und raus hier
            conf = ConfigTools.LoadConfig("config.xml");
            if (conf == null)
                conf = new();
            hasChanges = false;
        }

        /// <summary>
        /// Schreibt die Config-Instanz als XML-File
        /// </summary>
        private void WriteConfig()
        {
            ConfigTools.SaveConfig(conf, "config.xml");
            hasChanges = false;
        }
        #endregion

        #region Event-Handler
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!hasChanges)
                return;

            WriteConfig();
            MessageBox.Show("Änderungen gespeichert.");
        }

        /// <summary>
        /// User will Programm beenden. Falls Änderungen vorliegen, noch schnell nach Speichern fragen
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Wenn Änderungen vorliegen
            if (hasChanges)
            {
                DialogResult dr=MessageBox.Show("Anderungen gehen verloren. Speichern ?", "Änderungen", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning);

                //Wenn gewünscht noch schnell wegspeichern
                if (dr == DialogResult.Yes)
                    WriteConfig();
            }
            //Und weg hier
            Application.Exit();
        }

        /// <summary>
        /// Anderer Server in der ComboBox gewählt
        /// </summary>
        private void cbServerPfad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Server s = GetSelectedServer();
            edConnString.Text = s.ConnectionString;
        }

        /// <summary>
        /// Neuer Server soll erzeugt werden
        /// </summary>
        private void btnNewServer_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new()
            {
                Description = "Pfad für Server",
                SelectedPath = @"C:\"
            };

            DialogResult dr = fbd.ShowDialog();
            if (dr != DialogResult.OK)
                return;

            Server s = new(fbd.SelectedPath, string.Empty);
            conf.Servers.Add(s);
            FillServerControls();
            cbServerPfad.SelectedIndex = conf.Servers.IndexOf(s);
            hasChanges = true;
        }

        /// <summary>
        /// ConnectionString wurde geändert, Server-Instanz entsprechend aktualisieren
        /// </summary>
        private void edConnString_Leave(object sender, EventArgs e)
        {
            //Server-Objekt updaten mit neuem ConnString
            Server s = GetSelectedServer();

            if (!s.ConnectionString.Equals(edConnString.Text))
            {
                s.ConnectionString = edConnString.Text;
                hasChanges = true;
            }

        }

        /// <summary>
        /// Server-Pfad soll geändert werden, Pfad also abfragen und Objekt entsprechend updaten
        /// </summary>
        private void btnServerPathSelect_Click(object sender, EventArgs e)
        {
            Server s = GetSelectedServer();

            FolderBrowserDialog fbd = new()
            {
                Description = "Pfad für Server",
                SelectedPath = s.Path
            };

            DialogResult dr = fbd.ShowDialog();
            if (dr != DialogResult.OK)
                return;

            if (!s.Path.Equals(fbd.SelectedPath))
            {
                s.Path = fbd.SelectedPath;
                FillServerControls();
                cbServerPfad.SelectedIndex = conf.Servers.IndexOf(s);
                hasChanges = true;
            }

        }
        #endregion

        #region Utility-Funcs für Server-und Client-Tabsheet

        //Ich weiß, ich habe hier etliches an dupliziertem Code produziert, das ließe sich
        //noch hübscher und generalisierter machen. Aber erstmal muss es funktionieren,
        //dann wird gehübscht.

        private Server GetSelectedServer()
        {
            int newIndex = cbServerPfad.SelectedIndex;

            return conf.Servers[newIndex];
        }

        private Client GetSelectedClient()
        {
            int newIndex = cbClientPfad.SelectedIndex;

            return conf.Clients[newIndex];
        }
        #endregion

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client c = GetSelectedClient();
            cbTSClient.Checked = c.TSClient;

        }

        private void btnSelectClientPath_Click(object sender, EventArgs e)
        {
            Client c = GetSelectedClient();

            FolderBrowserDialog fbd = new()
            {
                Description = "Pfad für Client",
                SelectedPath = c.Path
            };

            DialogResult dr = fbd.ShowDialog();
            if (dr != DialogResult.OK)
                return;

            if (!c.Path.Equals(fbd.SelectedPath))
            {
                c.Path = fbd.SelectedPath;
                FillClientControls();
                cbClientPfad.SelectedIndex = conf.Clients.IndexOf(c);
                hasChanges = true;
            }


        }

        private void cbTSClient_Click(object sender, EventArgs e)
        {
            Client c = GetSelectedClient();

            if (!c.TSClient  == cbTSClient.Checked)
            {
                c.TSClient = cbTSClient.Checked;
                hasChanges = true;
            }
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new()
            {
                Description = "Pfad für Client",
                SelectedPath = @"C:\"
            };

            DialogResult dr = fbd.ShowDialog();
            if (dr != DialogResult.OK)
                return;

            Client c = new(false, fbd.SelectedPath);
            conf.Clients.Add(c);
            FillClientControls();
            cbClientPfad.SelectedIndex = conf.Clients.IndexOf(c);
            hasChanges = true;
        }
    }

}
