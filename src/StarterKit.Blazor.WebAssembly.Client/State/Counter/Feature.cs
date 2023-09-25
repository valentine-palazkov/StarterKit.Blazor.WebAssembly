using Fluxor;

namespace StarterKit.Blazor.WebAssembly.Client.State.Counter;

public class Feature : Feature<CounterState>
{
    public override string GetName() => nameof(CounterState);
    protected override CounterState GetInitialState() => new(0);
}