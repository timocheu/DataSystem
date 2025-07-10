using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query
{
    public static class Database
    {
        public static string Insert(string table, string[] template)
        {
            StringBuilder insertSlot = new StringBuilder();
            for (int i = 0 ; i < template.Length; i++) 
            {
                insertSlot.Append($"@{template[i].ToLower()}");

                if (i < template.Length - 1) insertSlot.Append(", ");
            }

            string query = $"INSERT INTO {table}({string.Join(", ", template)}) VALUES ({insertSlot.ToString()})";

            return query;
        }
    }
}
