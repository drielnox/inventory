using System;
using System.Windows.Forms;
using SmartInventorySystem.WinForms.View;
using SmartInventorySystem.WinForms.Presenter;
using SmartInventorySystem.ViewModel.Forms;

namespace SmartInventorySystem.WinForms
{
    public partial class NewSupplierForm : Form, INewSupplierView
    {
        private readonly NewSupplierPresenter _presenter;

        public NewSupplierFormViewModel State { get; private set; }

        public NewSupplierForm()
        {
            InitializeComponent();

            _presenter = new NewSupplierPresenter(this);

            State = new NewSupplierFormViewModel();
        }

        //connect to database on form load event        
        private void frmNewSupplier_Load(object sender, EventArgs e)
        {
            bsForm.DataSource = State;
        }

        // save form data into database 
        private void btnSave_Click(object sender, EventArgs e)
        {
            _presenter.PerformSave();
            _presenter.CleanFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ShowError(Exception ex)
        {
            MessageBox.Show(this, ex.Message, "New Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowInfo(string msg)
        {
            MessageBox.Show(this, msg, "New Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void UpdateFormBindingSource()
        {
            bsForm.ResetBindings(false);
        }
    }
}
