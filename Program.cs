using System;

class Program
{
    static void Main()
    {
        // Создание объекта жёсткого диска
        HardDrive hdd = new HardDrive(1024, 150);
        hdd.StoreData();

        // Создание объекта флеш-накопителя
        FlashDrive flash = new FlashDrive(64, "USB 3.0");
        flash.StoreData();
    }
}
