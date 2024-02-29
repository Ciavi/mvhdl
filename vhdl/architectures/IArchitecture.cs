namespace mvhdl.vhdl.architectures;

using mvhdl.vhdl.entity;

public interface IArchitecture {
    public IEntity ParentEntity { get; set; }
    public ISignal[] Signals { get; set; }
    // Maybe support processes in the future? Might be: public IProcess[] Processes { get; set; }
}