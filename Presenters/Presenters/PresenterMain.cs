using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.IPresenters;
using Presenters.IViews;

namespace Presenters.Presenters
{
    public class PresenterMain : IPresenterMain 
    {

        private readonly IViewMain _viewMain;


        public PresenterMain(IViewMain viewMain)
        {
            _viewMain = viewMain;
            
            _viewMain.SelectFileRequested += SelectFileRequestedHandler;
            _viewMain.ShowDataRequested += ShowDataRequestedHandler;
            _viewMain.ViewCloseRequested += ViewCloseRequestedHandler;
        }


        public void Run()
        {
            _viewMain.Open();
        }


        public void SelectFileRequestedHandler()
        {
            FileInfo file = _viewMain.OpenFileDialog();

            if (file == null) { return; }

            _viewMain.ShowMessage(file.Name);
        }


        public void ShowDataRequestedHandler()
        {
            _viewMain.ShowMessage(@"UNDER CONSTRUCTION");
        }


        public void ViewCloseRequestedHandler()
        {
            _viewMain.Close();
        }
    }
}
