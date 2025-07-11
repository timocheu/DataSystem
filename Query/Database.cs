using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query
{
    public static class Database
    {
        public static string InsertRow(string table, string[] template)
        {
            // @a, @b, @c
            string slot = string.Join(", ", template.Select(s => '@' + s).ToArray());

            return $"INSERT INTO {table}({string.Join(", ", template)}) VALUES ({slot})";
        }

        public static string DeleteRow(string table, int rowId) 
            => $"DELETE FROM {table} WHERE rowId = {rowId}";

        public static string UpdateRow(string table, int rowId, string name)
            => $"UPDATE {table} SET Name = {name} WHERE rowId = rowId";
    }
}
