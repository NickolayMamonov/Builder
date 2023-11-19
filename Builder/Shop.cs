namespace Builder;

public class Shop
{
    public void Construct(ComputerBuilder computerBuilder)
    {
        computerBuilder.BuildProcessor();
        computerBuilder.BuildStorage();
        computerBuilder.BuildRAM();
        computerBuilder.BuildVideocard();
        
    }
}