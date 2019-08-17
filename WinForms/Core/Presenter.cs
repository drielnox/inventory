using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInventorySystem.WinForms.Core
{
    abstract class Presenter<TView>
    where TView : IView
    {
        protected TView View { get; private set; }

        public Presenter(TView view)
        {
            View = view;
        }
    }
}
