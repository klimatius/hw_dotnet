namespace HW._14.Task2
{
    internal class ObjectQueue
    {
        private List<object> _items = new();

        public void Enqueue(object item)
        {
            _items.Add(item);
        }

        public object Dequeue()
        {
            if (_items.Count == 0)
            {
                Console.WriteLine("Queue is empty");
                return null;
            }

            object firstElement = _items.FirstOrDefault();
            _items.RemoveAt(0);

            
            return firstElement;
        }

        public void Peek()
        {
            if ( _items.Count == 0)
                Console.WriteLine("Queue is empty");
            else
            {
                Console.WriteLine("Current queue");
                foreach (object item in _items)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
