namespace Shared.Response
{

    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }

   
}

