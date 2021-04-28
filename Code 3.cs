using System;
namespace ConsoleApp7
{
    //Dispose pattern
    public class Customer : IDisposable // class with disposbke pattern
    {
        private StringReader _reader;  //stringreader is a inbuilt class
        //to detect deduntant calls
        private bool disposed = false; // dispose any class by deafult not disposed
        public Customer(string value)
        {
        this._reader = new StringReader(value);
        }
        protected virtual void Dispose(bool disposing)
        {
        if (!disposed) // variable is true or false
        {
            if (disposing)
            {
                if (_reader != null)
{
                    this._reader.Dispose();
                }
            }
        }
        disposed = true;
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);// suppressing garbage collector
    }
}
class sample
{
    public static void Main()
    {
        Customer c = new Customer("Sample");
        Console.ReadLine();
    }
}
}