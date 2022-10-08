namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        void Add(T t);

        void Delete(T t);

        void Update(T t);

        List<T> GetList();
    } 
}
