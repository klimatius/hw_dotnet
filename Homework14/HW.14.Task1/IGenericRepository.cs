namespace HW._14.Task1
{
    internal interface IGenericRepository<T> where T : class
    {
        static void Create(T transport) { }
        static void Update(T transport) { }
        static void Delete(int id) { }
        static void Get() { }
        static T GetByID(int id) { return null; }
    }
}
