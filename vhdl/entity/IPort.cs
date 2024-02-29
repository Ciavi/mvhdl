namespace mvhdl.vhdl.entity;

public enum PortType {
    Input,
    Output
}

public interface IPort {
    public PortType Type { get; set; }

    public ISignal Signal { get; set; }
}