using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartInventorySystem.ViewModel;
using SmartInventorySystem.WinForms.View;
using SmartInventorySystem.WinForms.Presenter;

namespace SmartInventorySystem.WinForms
{
    public partial class ListDispenseForm : Form, IListDispenseView
    {
        private readonly ListDispensePresenter _presenter;

        public ListDispenseForm()
        {
            InitializeComponent();

            _presenter = new ListDispensePresenter(this);
        }

        private void frmDispenseSheet_Load(object sender, EventArgs e)
        {
            _presenter.LoadDispensedItems();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetDispenseBindingSource(ICollection<DispenseSheetViewModel2> disSheet)
        {
            bsDispenseSheet.DataSource = disSheet;
        }

        public void ShowError(Exception ex)
        {
            if (Cursor != DefaultCursor)
            {
                Cursor = DefaultCursor;
            }

            MessageBox.Show(this, ex.Message, "View Dispense Sheet", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowInfo(string msg)
        {
            throw new NotImplementedException();
        }
    }
}
