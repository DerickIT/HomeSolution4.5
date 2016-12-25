using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.SQL
{
    class tran事务
    {
        public void method()
        {
            SqlTransaction sd = new SqlConnection().BeginTransaction();
            SqlCommand COMM = new SqlCommand();
            COMM.Transaction = sd;
            sd.Rollback();
            sd.Commit();
            /*
             * 声明事务，用conn.begintrancation
             * cmd.trancation= 新声明的这个事务对象
             * 可以使用sd.Rollback()()
             * ========================
             * sqlparameter 参数0需要把它转成object类型， 否则默认会把他识别为bigint类型，不能插入成功
             */
        }
    }
}
