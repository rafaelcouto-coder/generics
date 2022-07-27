using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repository
{
    public class GenericRepository<T> where T : class, IEntity, new()
    {
        private readonly List<T> _items = new List<T>();

        public T CreateItem()
        {
            return new T();
        }

        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }

        public void Add(T item)
        {
            item.Id = _items.Any()
                ? _items.Max(item => item.Id) + 1
                : 1;

            _items.Add(item);
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }

        public void Save(T item)
        {
            _items.Remove(item);
        }
    }
}
