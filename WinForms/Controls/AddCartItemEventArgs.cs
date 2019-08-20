using System;

namespace SmartInventorySystem.WinForms.Controls
{
    public class AddCartItemEventArgs : EventArgs
    {
        public int Amount { get; internal set; }
        public int UnitPrice { get; internal set; }
    }
}
