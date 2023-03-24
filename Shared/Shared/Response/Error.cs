namespace Shared.Response
{
    public class Error : Result
    {
        public Error (string message) : base(false, message)
        {

        }
    }
}
