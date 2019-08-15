using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SmartInventorySystem.ViewModel;

namespace SmartInventorySystem
{
    public partial class frmStockSheet : Form
    {
        public frmStockSheet()
        {
            InitializeComponent();
        }

        private void frmStockSheet_Load(object sender, EventArgs e)
        {
            try
            {
                Load_StockSheet();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "View Stock Sheet");
            }

        }

        private void Load_StockSheet()
        {
            try
            {
                var stock = new List<StockViewModel>();

                using (var ctx = new InventoryModel())
                {
                    stock = ctx.Items
                        .Select(x => new StockViewModel
                        {
                            Name = x.Name,
                            Description = x.Description,
                            Manufacturer = x.Manufacturer,
                            StockLevel = x.StockLevel,
                            ReOrderLevel = x.ReOrderLevel,
                            MajorSupplier = x.MajorSupplier,
                            PurchasePrice = x.PurchasePrice,
                            SellingPrice = x.SellingPrice
                        })
                        .ToList();
                }

                bsStock.DataSource = stock;
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
