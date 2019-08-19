namespace SmartInventorySystem.ViewModel.Grids
{
    public class StockRowViewModel : Core.ViewModel
    {
        public string Description { get; set; }
        public string MajorSupplier { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public float PurchasePrice { get; set; }
        public int ReOrderLevel { get; set; }
        public float SellingPrice { get; set; }
        public int StockLevel { get; set; }
    }
}
