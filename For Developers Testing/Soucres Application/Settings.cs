//(application Support cooming soon)
using System;
using System.Windows.Forms;

namespace Control_Panel
{
    public partial class SettingsForm : Form
    {
        public bool EnableBackup
        {
            get => chkEnableBackup.Checked;
            set => chkEnableBackup.Checked = value;
        }

        public string FileTreePath
        {
            get => txtFileTreePath.Text;
            set => txtFileTreePath.Text = value;
        }

        public int InterfaceBrightness
        {
            get => trackBrightness.Value;
            set => trackBrightness.Value = value;
        }

        public SettingsForm()
        {
            this.Text = "Settings";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ClientSize = new System.Drawing.Size(370, 180);
            this.StartPosition = FormStartPosition.CenterParent;

            var table = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 4,
                Padding = new Padding(12),
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55));
            table.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            table.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            table.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            table.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            chkEnableBackup = new CheckBox { Text = "Enable backup", Anchor = AnchorStyles.Left };
            table.Controls.Add(chkEnableBackup, 0, 0);
            table.SetColumnSpan(chkEnableBackup, 2);

            var lblPath = new Label { Text = "Customize current file tree path:", Anchor = AnchorStyles.Left, AutoSize = true };
            table.Controls.Add(lblPath, 0, 1);
            txtFileTreePath = new TextBox { Width = 200, Anchor = AnchorStyles.Left | AnchorStyles.Right };
            table.Controls.Add(txtFileTreePath, 1, 1);

            var lblBrightness = new Label { Text = "Interface brightness:", Anchor = AnchorStyles.Left, AutoSize = true };
            table.Controls.Add(lblBrightness, 0, 2);
            trackBrightness = new TrackBar { Minimum = 0, Maximum = 100, Value = 50, TickFrequency = 10, Width = 150, Anchor = AnchorStyles.Left };
            table.Controls.Add(trackBrightness, 1, 2);

            var buttonPanel = new FlowLayoutPanel { FlowDirection = FlowDirection.RightToLeft, Dock = DockStyle.Fill, AutoSize = true };
            var btnOK = new Button { Text = "OK", DialogResult = DialogResult.OK, Width = 70 };
            var btnCancel = new Button { Text = "Cancel", DialogResult = DialogResult.Cancel, Width = 70 };
            buttonPanel.Controls.Add(btnOK);
            buttonPanel.Controls.Add(btnCancel);
            table.Controls.Add(buttonPanel, 1, 3);

            this.AcceptButton = btnOK;
            this.CancelButton = btnCancel;
            this.Controls.Add(table);
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private CheckBox chkEnableBackup;
        private TextBox txtFileTreePath;
        private TrackBar trackBrightness;
    }
}
