using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.SQL
{
    class sql子查询
    {
        /*
         * 子查询分为独立子查询（可以自己独立完成的查询），相关子查询（子查询引用了父查询的结果）
         * in exists not in 。。。
         * 把一个查询结果作为另一个查询的查询源
         * select * from t where id in(select id from sdf)
         * 
         * 
         * ==============
         * 分页  mssql2000
         * 把前面的数据跳过，再取前几条 
         * not in top 
         * ===============
         * mssql05                 【 增加一个行号                 】
         * select * from ( select  row_number over(order by id desc） as number from table) as t1 where ti.number between 2*5+1 end 3*5 
         * 获取第2页的数据
         * 
         */
    }
}
