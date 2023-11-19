

using Builder;

ComputerBuilder computerBuilder;
Shop shop = new Shop();

computerBuilder = new PortableComputerBuilder();
shop.Construct(computerBuilder);
computerBuilder.Computer.Show();

computerBuilder = new NotebookBuilder();
shop.Construct(computerBuilder);
computerBuilder.Computer.Show();