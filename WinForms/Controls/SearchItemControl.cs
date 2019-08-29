// <copyright file="SearchItemControl.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

namespace SmartInventorySystem.WinForms.Controls
{
    using System;
    using System.Windows.Forms;
    using Presenter.Controls;
    using View.Controls;
    using ViewModel.Controls;
    using ViewModel.Forms.Grids;

    public partial class SearchItemControl : UserControl, IItemSearchView
    {
        public event EventHandler<SelectedItemEventArgs> OnSelectedItem;

        private readonly SearchItemPresenter _presenter;

        public SearchItemControl()
        {
            InitializeComponent();

            _presenter = new SearchItemPresenter(this);

            State = new ItemSearchControlViewModel();

            bsControl.DataSource = State;
        }

        /// <inheritdoc/>
        public ItemRowViewModel SelectedItem => bsItems.Current as ItemRowViewModel;

        /// <inheritdoc/>
        public ItemSearchControlViewModel State { get; protected set; }

        /// <inheritdoc/>
        public void FireOnItemSelected(ItemRowViewModel selectedItem)
        {
            var e = new SelectedItemEventArgs();
            e.SelectedItem = selectedItem;
            OnSelectedItem?.Invoke(this, e);
        }

        /// <inheritdoc/>
        public void ShowError(Exception ex)
        {
            MessageBox.Show(this, ex.Message, "Items to search.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <inheritdoc/>
        public void ShowInfo(string msg)
        {
            MessageBox.Show(this, msg, "Items to search.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <inheritdoc/>
        public void UpdateFormBindingSource()
        {
            bsControl.ResetBindings(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _presenter.PerformSearch();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _presenter.SelectItem();
        }
    }
}
