

namespace Interaces
{
    public class IAdminMainView
    {

        event EventHandler TabControlChanged;
        object SelectedTab { get; }
        object TabPage1 { get; }
        object TabPage2 { get; }
        void LoadFormInTab(Form form, object tabPage);
    }

}
