namespace Builder;

public class PortableComputerBuilder: ComputerBuilder
{
    public PortableComputerBuilder()
    {
        computer = new Computer("PC");
    }
    public override void BuildProcessor()
    {
        computer["processor"] = "Intel i9 13900KS";
    }

    public override void BuildStorage()
    {
        computer["storage"] = "2Tb";
    }
    public override void BuildRAM()
    {
        computer["ram"] = "64gb";
    }
    public override void BuildVideocard()
    {
        computer["videocard"] = "RTX 4090";
    }
   
}