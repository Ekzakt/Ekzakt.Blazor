using Ekzakt.Blazor.Components.Base;
using Microsoft.AspNetCore.Components;

namespace Ekzakt.Blazor;

public partial class EkzaktProgressLinear : EkzaktComponentBase
{
    [Parameter]
    public double PercentageDone { get; set; } = 0;

    private string GetWidthStyle => $"width: {PercentageDone}%;";

}