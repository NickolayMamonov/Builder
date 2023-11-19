namespace Builder;

public abstract class ComputerBuilder
{
    protected Computer computer;

    public Computer Computer
    {
        get { return computer; }
    }

    public abstract void BuildProcessor();
    public abstract void BuildStorage();
    public abstract void BuildRAM();
    public abstract void BuildVideocard();
    
}