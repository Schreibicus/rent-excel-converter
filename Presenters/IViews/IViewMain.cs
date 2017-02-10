using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.IViews
{
    public interface IViewMain : IView
    {
        void Open();
        void Close();

        event Action SelectFileRequested;
        event Action ShowDataRequested;
        event Action ViewCloseRequested;

        void OpenFileDialog();
    }
}
