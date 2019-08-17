using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartInventorySystem.ViewModel;
using SmartInventorySystem.WinForms.View;
using SmartInventorySystem.WinForms.Presenter;

namespace SmartInventorySystem.WinForms
{
    public partial class ListStockForm : Form, IListStockView
    {
        private readonly ListStockPresenter _presenter;

        public ListStockForm()
        {
            InitializeComponent();

            _presenter = new ListStockPresenter(this);
        }

        private void frmStockSheet_Load(object sender, EventArgs e)
        {
            _presenter.LoadStockList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ShowError(Exception ex)
        {
            if (Cursor != DefaultCursor)
            {
                Cursor = DefaultCursor;
            }

            MessageBox.Show(this, ex.Message, "View Stock Sheet", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void SetStockBindingSource(List<StockViewModel> stock)
        {
            bsStock.DataSource = stock;
        }

        public void ShowInfo(string msg)
        {
            throw new NotImplementedException();
        }
    }
}
