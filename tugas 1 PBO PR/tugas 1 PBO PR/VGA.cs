namespace VgaLaptop
{
    class Vga
    {
        public string Merk;
    }
    class Nvidia : Vga
    {
        public Nvidia()
        {
            Merk = "Nvidia";
        }
    }
    class Amd : Vga
    {
        public Amd()
        {
            Merk = "AMD";
        }
    }
}