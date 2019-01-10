using System;

namespace Banking.CoreProcess
{
    public interface DbHelper
    {
        void insert(string v1, string[] column, object[] v2);

        void update(string v1, string[] bankAccountColumn, object[] v2);
    }
}