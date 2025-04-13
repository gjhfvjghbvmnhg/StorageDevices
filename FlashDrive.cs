using System;

// Класс, представляющий флеш-накопитель
public class FlashDrive : StorageDevice
{
    public string UsbType; // Тип USB (например, USB 2.0, USB 3.0)

    // Конструктор, принимающий ёмкость и тип USB
    public FlashDrive(int capacity, string usbType)
    {
        this.Capacity = capacity; // Устанавливаем ёмкость
        this.UsbType = usbType; // Устанавливаем тип USB
    }

    // Реализация метода StoreData для флеш-накопителя
    public override void StoreData()
    {
        Console.WriteLine($"Сохранение данных на флеш-накопитель ёмкостью {Capacity} ГБ через {UsbType}.");
    }
}
