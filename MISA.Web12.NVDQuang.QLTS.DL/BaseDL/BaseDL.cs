using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Web12.NVDQuang.QLTS.DL.BaseDL
{
    public class BaseDL<T> : IBaseDL<T>
    {
        public IEnumerable<dynamic> GetAllRecords()
        {
            // Khai báo tên stored procedure GetAllRecords
            string tableName = "asset";
/*            string tableName = EntityUtilities.GetTableName<T>();*/
            string getAllStoredProcedureName = $"Proc_{tableName}_GetAllRecords";
            using (var mySqlConnection = new MySqlConnection(DatabaseContext.ConnectionString))
            {
                // Thực hiện gọi vào DB để chạy câu lệnh SELECT 
                var records = mySqlConnection.Query(getAllStoredProcedureName, commandType: System.Data.CommandType.StoredProcedure);

                return records;
            }
        }
    }
}
