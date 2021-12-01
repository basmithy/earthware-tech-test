using EarthwareTechTest.Helpers;
using EarthwareTechTest.Models;
using EarthwareTechTest.State;
using Microsoft.AspNetCore.Components;

namespace EarthwareTechTest.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject] public ReceiptState receiptState { get; set; } = new();
        [Inject] public NavigationManager navManager { get; set; }


        public ReceiptGenerator receiptGenerator = new();
        public List<Product> ShoppingBasket { get; set; } = new();
        public Product IndividualProduct { get; set; } = new();

        
        

        public void HandleValidSubmit()
        {
            ShoppingBasket.Add(IndividualProduct);
            IndividualProduct = new();
        }

        public void GenerateReceipt()
        {
            receiptState.StateReceipt = receiptGenerator.GenerateReceipt(ShoppingBasket);
            navManager.NavigateTo("/receipt");
        }
    }
}
