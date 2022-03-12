﻿using System;
using System.Windows.Forms;

using LockCent.Properties;

namespace LockCent.Pages
{
    public partial class SettingsPage : Form
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void RestoreSettings()
        {
            int svtype = Convert.ToInt32(Settings.Default["SaveType"]);

            if (svtype == 1)
            {
                FolderSelector.Value = 1;
            }
            else
            {
                FolderSelector.Value = 0;
            }

            bool notestype = Convert.ToBoolean(Settings.Default["Notes"]);

            if (notestype)
            {
                cbNotes.Checked = true;
            }
            else
            {
                cbNotes.Checked = false;
            }
        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {
            RestoreSettings();
        }

        private void FolderSelector_ValueChanged(object sender, EventArgs e)
        {
            if (FolderSelector.Value == 0)
            {
                Settings.Default["SaveType"] = 0;
                Settings.Default.Save();
            }
            else
            {
                FolderSelector.Value = 0;
                MessageBox.Show("DataBase option is Not Done yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbNotes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNotes.Checked)
            {
                Settings.Default["Notes"] = true;
            }
            else
            {
                Settings.Default["Notes"] = false;
            }

            Settings.Default.Save();
        }
    }
}
