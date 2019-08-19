using SmartInventorySystem.WinForms.Core;
using SmartInventorySystem.WinForms.View.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInventorySystem.WinForms.Presenter.Controls
{
    class DispenseItemDetailsPresenter : Presenter<IDispenseItemDetailsView>
    {
        public DispenseItemDetailsPresenter(IDispenseItemDetailsView view) : base(view)
        {
        }
    }
}
