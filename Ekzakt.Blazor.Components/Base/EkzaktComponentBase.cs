using Ekzakt.Blazor.Components.Interfaces;
using Microsoft.AspNetCore.Components;

namespace Ekzakt.Blazor.Components.Base;

public class EkzaktComponentBase : ComponentBase, IEkzaktStateHasChanged
{
    /// <summary>
    /// User class names, separated by space.
    /// </summary>
    [Parameter]
    public string? Class { get; set; }


    /// <summary>
    /// User styles, applied on top of the component's own classes and styles.
    /// </summary>
    [Parameter]
    public string? Style { get; set; }


    /// <inheritdoc/>
    void IEkzaktStateHasChanged.StateHasChanged() => StateHasChanged();
}
