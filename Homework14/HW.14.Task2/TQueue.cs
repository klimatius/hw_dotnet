namespace HW._14.Task2
{
    internal class TQueue<T> where T : class
    {
        private List<T> _items = new();

        public void Enqueue(T item)
        {
            _items.Add(item);
        }

        public T Dequeue()
        {
            if (_items.Count == 0)
            {
                Console.WriteLine("Queue is empty");
                return null;
            }

            T firstElement = _items.FirstOrDefault();
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
                foreach (T item in _items)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
