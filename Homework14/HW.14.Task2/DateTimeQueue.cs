namespace HW._14.Task2
{
    internal class DateTimeQueue
    {
        private List<DateTime> _items = new();
        private Nullable <DateTime> _nullableDateTime = null;

        public void Enqueue(DateTime item)
        {
            _items.Add(item);
        }

        public DateTime ? Dequeue()
        {
            if (_items.Count == 0)
            {
                Console.WriteLine("Queue is empty");
                return this._nullableDateTime;
            }

            DateTime firstElement = _items.FirstOrDefault();
            _items.RemoveAt(0);


            return firstElement;
        }

        public void Peek()
        {
            if (_items.Count == 0)
                Console.WriteLine("Queue is empty");
            else
            {
                Console.WriteLine("Current queue");
                foreach (DateTime item in _items)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
