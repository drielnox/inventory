using System;
using System.Windows.Forms;
using SmartInventorySystem.WinForms.View;
using SmartInventorySystem.WinForms.Presenter;
using SmartInventorySystem.ViewModel.Forms;

namespace SmartInventorySystem.WinForms
{
    public partial class ListStockForm : Form, IListStockView
    {
        private readonly ListStockPresenter _presenter;

        public ListStockFormViewModel ViewModel { get; private set; }

        public ListStockForm()
        {
            InitializeComponent();

            _presenter = new ListStockPresenter(this);

            ViewModel = new ListStockFormViewModel();
        }

        private void frmStockSheet_Load(object sender, EventArgs e)
        {
            _presenter.LoadStockList();
            bsForm.DataSource = ViewModel;
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

        public void ShowInfo(string msg)
        {
            if (Cursor != DefaultCursor)
            {
                Cursor = DefaultCursor;
            }

            MessageBox.Show(this, msg, "View Stock Sheet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void UpdateFormBindingSource()
        {
            bsForm.ResetBindings(false);
            bsStock.ResetBindings(false);
        }

        private void bsStock_CurrentChanged(object sender, EventArgs e)
        {
            
        }
    }
}
