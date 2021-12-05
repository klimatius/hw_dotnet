namespace HW._13.Task2
{
    internal interface IMotorcycleRepository
    {
        static void CreateMotorcycle(Motorcycle moto) { }
        static void UpdateMotorcycle(Motorcycle moto) { }
        static void DeleteMotorcycle(int id) { }
        static void GetMotorcycles() { }
        static Motorcycle GetMotorcycleByID(int id) { return null;}
    }
}
