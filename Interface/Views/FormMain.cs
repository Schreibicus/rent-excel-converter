using System;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;
using Presenters.IViews;

namespace Interface.Views
{
    public partial class FormMain : MetroForm, IViewMain
    {
        public event Action SelectFileRequested;
        public event Action ShowDataRequested;
        public event Action ViewCloseRequested;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {           
            btnOpenFile.Click += (sndr, args) => SelectFileRequested?.Invoke();
            btnShowData.Click += (sndr, args) => ShowDataRequested?.Invoke();
            btnClose.Click += (sndr, args) => ViewCloseRequested?.Invoke();
        }

        public void Open()
        {
            Application.Run(this);
        }

        

        public FileInfo OpenFileDialog()
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Title = @"Select Excel File",
                Filter = @"XLS|*.xls|XLSX|*.xlsx",
                Multiselect = false
            };

            return dialog.ShowDialog() != DialogResult.OK ? 
                null : new FileInfo(dialog.FileName);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, @"Info");
        }
    }
}
