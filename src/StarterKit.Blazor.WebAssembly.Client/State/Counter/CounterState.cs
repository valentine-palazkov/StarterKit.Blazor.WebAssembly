using Fluxor.Persist.Storage;

namespace StarterKit.Blazor.WebAssembly.Client.State.Counter;

[PersistState]
public record CounterState(int ClickCount);