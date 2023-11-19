namespace Builder;

public class NotebookBuilder: ComputerBuilder
{
    public NotebookBuilder()
    {
        computer = new Computer("Notebook");
    }
    public override void BuildProcessor()
    {
        computer["processor"] = "Ryzen 7 5800H";
    }

    public override void BuildStorage()
    {
        computer["storage"] = "512Gb";
    }
    public override void BuildRAM()
    {
        computer["ram"] = "64Gb";
    }
    public override void BuildVideocard()
    {
        computer["videocard"] = "AMD Radeon Graphics";
    }
   
}