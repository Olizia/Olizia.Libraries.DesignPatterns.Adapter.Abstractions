namespace Olizia.Libraries.DesignPatterns.Adapter.Abstractions;

/// <summary>
/// Interface used to implement adapter pattern
/// </summary>
/// <typeparam name="TAdapter">An adapter</typeparam>
/// <typeparam name="TTAdapter">An adapter</typeparam>
public interface IAdapter<TAdapter, TTAdapter>
    where TAdapter : class
    where TTAdapter : class
{
    /// <summary>
    /// Adapter an object to another
    /// </summary>
    public TTAdapter Adapt(TAdapter adapter);

    /// <summary>
    /// Adapter an object to another
    /// </summary>
    public TAdapter Adapt(TTAdapter adapter);
}