using SmartInventorySystem.ViewModel.Core;

namespace SmartInventorySystem.ViewModel.Forms
{
    public class NewSupplierFormViewModel : FormViewModel
    {
        public string SupplierName { get; set; }
        public string ContextPerson { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
