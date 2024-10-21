using Builder;

class Program
{
    static void Main(string[] args)
    {
        var computer = new ComputerBuilder()
            .SetCPU(new CPU("Intel Core i7", 8))
            .SetMotherboard(new Motherboard("ASUS ROG Strix"))
            .SetRAM(new RAM(16))
            .SetStorage(new Storage("SSD", 512))
            .SetGPU(new GPU("NVIDIA GeForce RTX 3060"))
            .Build();

        Console.WriteLine(computer);
    }
}
