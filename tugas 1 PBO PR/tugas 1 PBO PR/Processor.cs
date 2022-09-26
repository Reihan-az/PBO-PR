namespace ProcessorLaptop
{

    class Processor
    {
        public string Merk;
        public string Tipe;
    }
    class Intel : Processor
    {
        public Intel()
        {
            Merk = "Intel";
        }
    }
    class AMD : Processor
    {
        public AMD()
        {
            Merk = "AMD";
        }
    }
    class CoreI3 : Intel
    {
        public CoreI3()
        {
            Tipe = "Core i3";
        }
    }
    class CoreI5 : Intel
    {
        public CoreI5()
        {
            Tipe = "Core i5";
        }
    }
    class CoreI7 : Intel
    {
        public CoreI7()
        {
            Tipe = "Core i7";
        }
    }
    class Ryzen : AMD
    {
        public Ryzen()
        {
            Tipe = "RAYZEN";
        }
    }
    class Athlon : AMD
    {
        public Athlon()
        {
            Tipe = "ATHLON";
        }
    }
}