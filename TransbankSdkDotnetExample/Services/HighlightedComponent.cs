namespace TransbankSdkDotnetExample.Services;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

public class HighlightedComponent : ComponentBase
{
    [Inject]
    protected IJSRuntime JS { get; set; } = default!;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JS.InvokeVoidAsync("highlightAllCodeBlocks");
        }
    }
}
