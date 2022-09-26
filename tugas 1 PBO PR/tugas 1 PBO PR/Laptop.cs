using VgaLaptop;
using ProcessorLaptop;
class Laptop
{
    public string Merk;
    public string Tipe;
    public Vga vga;
    public Processor processor;
    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {this.Merk} {this.Tipe} menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {this.Merk} {this.Tipe} mati");
    }
}
class Asus : Laptop
{
    public Asus()
    {
        Merk = "ASUS";
    }
}
class ROG : Asus
{
    public ROG()
    {
        Tipe = "ROG";
    }
}
class Vivobook : Asus
{
    public Vivobook()
    {
        Tipe = "Vivobook";
    }
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}
class Acer : Laptop
{
    public Acer()
    {
        Merk = "Acer";
    }
}
class Swift : Acer
{
    public Swift()
    {
        Tipe = "Swift";
    }
}
class Predator : Acer
{
    public Predator()
    {
        Tipe = "Predator";
    }
    public void BermainGame()
    {
        Console.WriteLine($"Laptop {this.Merk} {this.Tipe} sedang memainkan game");
    }
}
class Lenovo : Laptop
{
    public Lenovo()
    {
        Merk = "Lenovo";
    }
}
class IdeaPad : Lenovo
{
    public IdeaPad()
    {
        Tipe = "IdeaPad";
    }
}
class Legion : Lenovo
{
    public Legion()
    {
        Tipe = "Legion";
    }
}