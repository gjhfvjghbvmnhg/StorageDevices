using System;

// Класс, представляющий жёсткий диск
public class HardDrive : StorageDevice
{
    public int Speed; // Скорость чтения/записи в МБ/с

    // Конструктор, принимающий ёмкость и скорость
    public HardDrive(int capacity, int speed)
    {
        this.Capacity = capacity; // Устанавливаем ёмкость
        this.Speed = speed; // Устанавливаем скорость
    }

    // Реализация метода StoreData для жёсткого диска
    public override void StoreData()
    {
        Console.WriteLine($"Сохранение данных на жёсткий диск ёмкостью {Capacity} ГБ со скоростью {Speed} МБ/с.");
    }
}
