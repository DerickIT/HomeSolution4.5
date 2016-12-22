using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.SQL
{
    class SQL存储过程
    {
        /*
         * 存储过程可以防止sql注入
         * 输出参数用output标注就可输出
         * 建议在创建proc的过程中加上begin  end
         * create proc uu_proc
         * @id int = 0;
         * as
         * begin
         * ...执行sql语句
         * end
         * 
         * 存储过程分页
         * 传入参数，输出参数
         */
    }
}
