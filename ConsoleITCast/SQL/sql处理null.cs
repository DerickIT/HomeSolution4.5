using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.SQL
{
    class sql处理null
    {
        /*
         * 数据库中有三总值
         * true
         * false
         * unknow
         * 数据库中处理null值
         * null在数据库中表示unknown值
         * select * from sa where fname is null 查询所有是null值
         * null与任何值进行运算后都是null
         * 所以不能是xxx=null 或者<>null
         * null 不是NULL 在数据库的可编辑状态中
         */
    }
    class orderby
    {
        /*
         * 排序使用order by
         * 排序之后是数据源 
         * select * from ta order by name desc,id asc
         *  默认是升序 asc
         *  orderby 要放在where 字句之后
         *  order by之后可以跟一个计算表达式
         *  先执行group by 分组然后在统计每一组的信息
         *  -------------------------------
         * 一般分组语句group by都与 聚合函数配合使用
         * 如果没有聚合函数，分组的意义不大
         * 当在select语句中出现聚合函数时，这时不能再select中出现其他列，除非该列也在group by字句中出现或者在聚合函数中出现
         */
    }
    class havings
    {
        /*
         * having 在分组之后筛选 where是在分组之前筛选
         * 分组之后筛选的是组
         * select id as 数据id ,count(*) 总人数 from tbale where sex=0 group by id having count(*)>2 按照班级分组，并且筛选出人数》2
         * having能使用哪列是取决于你分组后结果集有哪列
         * ==============================
         * SQL语句的执行顺序
         * select from  where groupby having order by
         */
    }
}
