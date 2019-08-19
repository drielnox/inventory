using System;
using System.Windows.Forms;
using SmartInventorySystem.WinForms.Presenter;
using SmartInventorySystem.WinForms.View;
using SmartInventorySystem.ViewModel.Forms;

namespace SmartInventorySystem.WinForms
{
    public partial class NewItemForm : Form, INewItemView
    {
        private readonly NewItemPresenter _presenter;

        public NewItemFormViewModel ViewModel { get; private set; }

        public NewItemForm()
        {
            InitializeComponent();

            _presenter = new NewItemPresenter(this);

            ViewModel = new NewItemFormViewModel();
        }

        //connect to database on form load event
        private void frmNew_Item_Load(object sender, EventArgs e)
        {
            bsForm.DataSource = ViewModel;
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

        public void ShowInfo(string msg)
        {
            MessageBox.Show(this, "New Drug/Item Successfully Added to System", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowError(Exception ex)
        {
            MessageBox.Show(this, ex.Message, "New Drug / Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void UpdateFormBindingSource()
        {
            bsForm.ResetBindings(false);
        }
    }
}
