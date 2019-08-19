using SmartInventorySystem.ViewModel.Core;

namespace SmartInventorySystem.ViewModel.Forms
{
    public class NewItemFormViewModel : FormViewModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AlternativeName { get; set; }
        public string Manufacturer { get; set; }
        public string MajorSupplier { get; set; }
        public string PackSize { get; set; }
        public string PackDescription { get; set; }
        public string AlternativeItem { get; set; }
        public string StandardIssueQuantity { get; set; }
        public string EconomicOrderQuantity { get; set; }
    }
}
