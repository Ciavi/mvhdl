namespace mvhdl.vhdl;

public enum GateType {
    And,
    Nand,
    Or,
    Nor,
    Xor,
    Xnor,
    Not
}

public interface IGate {
    public ISignal First { get; set; }
    public ISignal? Second { get; set; }
    public GateType Type { get; set; }
}