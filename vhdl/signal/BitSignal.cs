namespace mvhdl.vhdl.signals;

public class BitSignal : Signal, ISignal
{
    public BitSignal(string name, SignalValue value = SignalValue.Zero) : base(name, SignalType.Bit, value)
    {
        Name = name;

        if(IsValid(value)) Value = value;
        else throw new NotImplementedException();
    }

    public override bool IsValid(SignalValue? value)
    {
        if(value == SignalValue.Zero || value == SignalValue.One) return true;
        return false;
    }
}