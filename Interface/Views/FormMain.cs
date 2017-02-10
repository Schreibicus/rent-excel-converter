using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        

        public void OpenFileDialog()
        {
            //Open file dialog
        }

        
    }
}
