using System;
using System.Collections.Generic;
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

            _viewMain.ViewCloseRequested += ViewCloseRequestedHandler;
        }


        public void Run()
        {
            _viewMain.Open();
        }


        public void SelectFileRequestedHandler()
        {
        }

        public void ShowDataRequestedHandler()
        {
        }

        public void ViewCloseRequestedHandler()
        {
            _viewMain.Close();
        }
    }
}
