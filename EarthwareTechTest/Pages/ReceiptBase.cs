using EarthwareTechTest.State;
using Microsoft.AspNetCore.Components;

namespace EarthwareTechTest.Pages
{
    public class ReceiptBase : ComponentBase
    {
        [Inject] public ReceiptState receiptState { get; set; } = new();


    }
}
