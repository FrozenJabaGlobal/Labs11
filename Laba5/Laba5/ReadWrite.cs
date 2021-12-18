using DAL;
using DataProviderContract;
using System.Collections.Generic;

namespace BLL
{
    public class ReadWriteService<T> : IDataReadWriteService<T>
    {
        public IDataContext<T> _dataContext;
        public ReadWriteService(string path, IDataProvider<T> dataProvider)
        {
            _dataContext = new DataContext<T>(path, dataProvider);
        }

        public List<T> ReadData() => _dataContext.GetData();

        public void WriteData(T data) => _dataContext.SetData(data);

        public void ClearData() => _dataContext.ClearData();
    }
}