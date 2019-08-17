using SmartInventorySystem.WinForms.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartInventorySystem.ViewModel;

namespace SmartInventorySystem.WinForms.View
{
    interface IListDispenseView : IView
    {
        void SetDispenseBindingSource(ICollection<DispenseSheetViewModel2> disSheet);
    }
}
