namespace OrisonMIS.Server.Exceptions
{
    public class StoredProcedureRelatedException : Exception
    {
        public StoredProcedureRelatedException(string message, Exception? innerException) : base(message,innerException) {}
    
    }
}
