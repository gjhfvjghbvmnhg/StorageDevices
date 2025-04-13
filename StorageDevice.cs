using System;

// Абстрактный класс, представляющий устройство хранения данных
public abstract class StorageDevice
{
    public int Capacity; // Ёмкость устройства в гигабайтах

    // Абстрактный метод, который должен быть реализован в наследниках
    public abstract void StoreData();
}
