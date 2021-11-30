namespace HW._14.Task2
{
    internal class Motorcycle
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

        public override string ToString()
        {
            return ($"Model: {this.model}, name: {this.name}, id: {this.id}, odometer: {this.odometer}, year: {this.year}");
        }
    }
}
