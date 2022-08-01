namespace TestProject.Business.Interfaces
{
    public interface IConverter
    {
        Dictionary<T1, T2> ConvertToDictionary<T1, T2>(T1[] first, T2[] second);
    }
}
