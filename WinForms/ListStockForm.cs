// <copyright file="ListStockForm.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

using System;
using System.Windows.Forms;
using SmartInventorySystem.WinForms.View;
using SmartInventorySystem.WinForms.Presenter;
using SmartInventorySystem.ViewModel.Forms;
using SmartInventorySystem.ViewModel.Forms.Grids;

namespace SmartInventorySystem.WinForms
{
    public partial class ListStockForm : Form, IListStockView
    {
        private readonly ListStockPresenter _presenter;

        public ListStockFormViewModel State { get; private set; }

        public ListStockForm()
        {
            InitializeComponent();

            _presenter = new ListStockPresenter(this);

            State = new ListStockFormViewModel();

            bsForm.DataSource = State;
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
            State.SelectedStock = bsStock.Current as StockRowViewModel;
            _presenter.EnableUpdate();
            _presenter.EnableDelete();
        }

        public void ShowUpdateStockForm(StockRowViewModel selectedStock)
        {
            var form = new UpdateStockForm(selectedStock.Identifier);
            form.Show(this);
        }

        public void AskDeleteStockMessage(StockRowViewModel selectedStock)
        {
            string msg = string.Format("You are sure to delete this stock?");
            var result = MessageBox.Show(this, msg, "Delete stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                _presenter.DeleteStock(selectedStock);
            }
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            _presenter.ShowUpdateStockForm();
            _presenter.LoadStockList();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            _presenter.ShowDeleteStockMessage();
            _presenter.LoadStockList();
        }

        public void SetUpdateButtonEnable(bool v)
        {
            tsbUpdate.Enabled = v;
        }

        public void SetDeleteButtonEnable(bool v)
        {
            tsbDelete.Enabled = v;
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            _presenter.LoadStockList();
        }
    }
}
