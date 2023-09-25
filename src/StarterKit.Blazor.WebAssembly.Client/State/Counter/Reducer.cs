using Fluxor;

namespace StarterKit.Blazor.WebAssembly.Client.State.Counter;

public static class Reducers
{
    [ReducerMethod]
    public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action) =>
        state with { ClickCount = state.ClickCount + 1 };
}