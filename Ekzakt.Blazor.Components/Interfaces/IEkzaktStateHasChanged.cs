﻿namespace Ekzakt.Blazor.Interfaces;

public interface IEkzaktStateHasChanged
{
    /// <summary>
    /// Notifies the component that its state has changed. When applicable, this will
    /// cause the component to be re-rendered.
    /// </summary>
    void StateHasChanged();
}