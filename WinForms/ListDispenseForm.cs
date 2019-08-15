using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SmartInventorySystem.ViewModel;

namespace SmartInventorySystem.WinForms
{
    public partial class frmDispenseSheet : Form
    {
        public frmDispenseSheet()
        {
            InitializeComponent();
        }

        private void frmDispenseSheet_Load(object sender, EventArgs e)
        {
            try
            {
                Load_DispenseSheet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "View Dispense Sheet");
            }
        }

        private void Load_DispenseSheet()
        {
            try
            {
                var disSheet = new List<DispenseSheetViewModel2>();

                using (var ctx = new InventoryModel())
                {
                    disSheet = ctx.Dispenses
                        .OrderByDescending(x => x.Identifier)
                        .Select(x => new DispenseSheetViewModel2
                        {
                            GroupId = x.GroupId,
                            ItemName = x.ItemName,
                            UnitPrice = x.UnitPrice,
                            DispenseQuantity = x.DispenseQuantity,
                            DispenseCompleted = x.DispenseCompleted,
                            GroupDate = x.GroupDate
                        })
                        .ToList();
                }

                bsDispenseSheet.DataSource = disSheet;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
