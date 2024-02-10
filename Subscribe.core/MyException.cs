namespace Subscriber.core
{
    public class MyException : Exception
    {
        public int Status { get; set; }

        public string TableName { get; set; }

        public MyException(int status, string tableName, string message) : base(message)
        {
            Status = status;
            TableName = tableName;
        }
    }
}
