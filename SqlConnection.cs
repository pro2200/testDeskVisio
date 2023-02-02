using System;

namespace Assignment1
{
    internal class SqlConnection
    {
        private string connectionString;

        public SqlConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}