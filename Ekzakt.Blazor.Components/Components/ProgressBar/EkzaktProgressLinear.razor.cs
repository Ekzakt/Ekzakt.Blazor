using Ekzakt.Blazor.Components;
using Microsoft.AspNetCore.Components;

namespace Ekzakt.Blazor.Components;

public partial class EkzaktProgressLinear : EkzaktComponentBase
{
    [Parameter]
    public double PercentageDone { get; set; } = 0;

    private string GetWidthStyle => $"width: {PercentageDone}%;";

}