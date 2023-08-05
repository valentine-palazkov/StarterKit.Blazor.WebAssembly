using Fluxor;

namespace StarterKit.Blazor.WebAssembly.Client.State.Counter
{
    public class Reducer
    {
        [ReducerMethod]
        public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action) =>
        new(clickCount: state.ClickCount + 1);
    }
}
