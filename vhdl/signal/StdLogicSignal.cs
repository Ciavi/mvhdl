namespace mvhdl.vhdl.signals;

public class StdLogicSignal : Signal, ISignal
{
    public StdLogicSignal(string name, SignalValue value = SignalValue.U) : base(name, SignalType.StdLogic, value)
    {
        Name = name;

        if(IsValid(value)) Value = value;
        else Value = SignalValue.U;
    }

    public override bool IsValid(SignalValue? value) {
        return true;
    }
}