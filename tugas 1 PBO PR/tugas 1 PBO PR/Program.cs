using VgaLaptop;
using ProcessorLaptop;
namespace PBOmodulinheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook();
            laptop1.vga = new Nvidia();
            laptop1.processor = new CoreI5();
            Laptop laptop2 = new IdeaPad();
            laptop2.vga = new Amd();
            laptop2.processor = new Ryzen();
            Predator predator = new Predator();
            predator.vga = new Amd();
            predator.processor = new CoreI7();

            //Soal Nomor 1
            //laptop2.LaptopDinyalakan();
            //laptop2.LaptopDimatikan();

            //Soal Nomor 2
            //laptop1.Ngoding();

            //Soal Nomor 3
            //Console.WriteLine(laptop1.vga.Merk);
            //Console.WriteLine(laptop1.processor.Merk);
            //Console.WriteLine(laptop1.processor.Tipe);

            //Soal Nomor 4
            //predator.BermainGame();

            //Soal Nomor 5
            //Acer acer = new Predator();
            //acer.BermainGame():
        }
    }
}
