using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    internal interface IAdminMainView
    {
        event EventHandler TabControlChanged;
        object SelectedTab { get; }
        object TabPage1 { get; }
        object TabPage2 { get; }
        void LoadFormInTab(Form form, object tabPage);
    }
}
