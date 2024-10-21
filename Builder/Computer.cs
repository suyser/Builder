using Builder;

public class Computer
{
    public CPU Cpu { get; private set; }
    public Motherboard Motherboard { get; private set; }
    public RAM Ram { get; private set; }
    public Storage Storage { get; private set; }
    public GPU Gpu { get; private set; }

    public Computer(CPU cpu, Motherboard motherboard, RAM ram, Storage storage, GPU gpu)
    {
        Cpu = cpu;
        Motherboard = motherboard;
        Ram = ram;
        Storage = storage;
        Gpu = gpu;
    }

    public override string ToString()
    {
        return $"Компьютер:n" +
               $"- Процессор: {Cpu.Model} ({Cpu.Cores} ядер)n" +
               $"- Материнская плата: {Motherboard.Model}n" +
               $"- Оперативная память: {Ram.Size} ГБn" +
               $"- Хранилище: {Storage.Type} ({Storage.Size} ГБ)n" +
               $"- Видеокарта: {Gpu.Model}n";
    }
}
