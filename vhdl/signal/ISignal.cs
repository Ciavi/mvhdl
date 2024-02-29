namespace mvhdl.vhdl;

public enum SignalType {
    Bit,
    StdLogic
}

public enum SignalValue {
    Zero,
    One,
    U,
    X,
    Z,
    W,
    L,
    H,
    DC
}

public class ValueChangedEventArgs : EventArgs {
    public SignalValue PreviousValue { get; set; }
    public SignalValue CurrentValue { get; set; }
}

public delegate void ValueChangedEventHandler(Object sender, ValueChangedEventArgs e);

public interface ISignal {
    public string Name { get; set; }
    public SignalType Type { get; set; }
    public SignalValue Value { get; set; }
}

public abstract class Signal : ISignal
{
    private string name;
    private SignalType type;
    private SignalValue value;

    public string Name { get => name; set => name = value; }
    public SignalType Type { get => type; set => type = value; }
    public SignalValue Value { get => value; set {
        ValueChanged?.Invoke(this, new ValueChangedEventArgs() {
            PreviousValue = this.value,
            CurrentValue = value
        });

        this.value = value;
    } }

    public Signal(string name, SignalType type = SignalType.StdLogic, SignalValue value = SignalValue.U) {
        Name = name;
        Type = type;
        Value = value;
    }

    public abstract bool IsValid(SignalValue? value);

    public event ValueChangedEventHandler ValueChanged;
}