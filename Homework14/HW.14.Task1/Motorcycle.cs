namespace HW._14.Task1
{
    internal class Motorcycle : IGenericRepository<Motorcycle>
    {
        private static List<Motorcycle> _motoList = new List<Motorcycle>();
        int id;
        string model;
        string name;
        int year;
        int odometer;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="name"></param>
        /// <param name="year"></param>
        /// <param name="odometer"></param>
        /// <param name="id"></param>
        internal Motorcycle(string model, string name, int year, int odometer, int id)
        {
            this.id = id;
            this.model = model;
            this.name = name;
            this.year = year;
            this.odometer = odometer;
        }

        public static void Create(Motorcycle moto)
        {
            _motoList.Add(moto);
        }

        public static void Delete(int id)
        {
            foreach (var item in _motoList)
            {
                if ((item as Motorcycle).id == id)
                {
                    _motoList.Remove(item);
                    return;
                }
            }
        }

        public static void Get()
        {
            foreach (var item in _motoList)
            {
                Console.WriteLine((item as Motorcycle).ToString());
            }
        }

        public static void Update(Motorcycle moto)
        {
            foreach (var item in _motoList)
            {
                if ((item as Motorcycle).id == moto.id)
                {
                    _motoList.Remove(item);
                    _motoList.Add(moto);
                    return;
                }
            }
        }

        public static Motorcycle GetByID(int id)
        {
            foreach (var item in _motoList)
            {
                if ((item as Motorcycle).id == id)
                    return (item as Motorcycle);
            }
            return null;
        }

        public override string ToString()
        {
            return ($"Model: {this.model}, name: {this.name}, id: {this.id}, odometer: {this.odometer}, year: {this.year}");
        }
    }
}




