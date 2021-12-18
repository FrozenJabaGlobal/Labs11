using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class EntityService<T> : IEntityService<T>
    {
        IDataReadWriteService<T> readWrite;

        public EntityService(IDataReadWriteService<T> _readWrite) => readWrite = _readWrite;
        public void Add(T item)
        {
            readWrite.WriteData(item);
        }

        public void Remove(T item)
        {
            List<T> data = readWrite.ReadData();

            data.Remove(item);
            readWrite.ClearData();

            foreach (var _item in data)
                Add(_item);
        }

        public T Search(T item)
        {
            List<T> data = readWrite.ReadData();

            foreach (var _item in data)
            {
                if (_item.Equals(item))
                    return _item;
            }
            return default;
        }

        public string Show()
        {
            StringBuilder stringData = new StringBuilder();
            List<T> data = readWrite.ReadData();
            foreach (var element in data)
                stringData.Append(element.ToString());
            return stringData.ToString();
        }

        public ISpecialBehavior SetSpecialBehavior(int behaviorType)
        {
            ISpecialBehavior[] types = { new Bake(), new Study(), new DoMoney(), new JumpWithParashute()};
            return types[behaviorType - 1];
        }
    }
}