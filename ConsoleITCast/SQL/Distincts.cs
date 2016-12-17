using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.SQL
{
    class Distincts
    {
        /*
         * distinct是针对你查出的结果去重复
         * max
         * min
         * count
         * sum
         * avg 计算平均分的时候对空值不处理 null
         * between 18 and 24 在18-24之间
         * or
         * in
         * and
         * ------------------------
         * 通配符
         * like '%zhn%'
         * []通配符
         * like '%[赵钱]%'只要包含赵或者钱就能被查出
         * like 'x[赵钱]y' 表示 x赵y  x钱y  加^表示除了赵钱以外的x*y
         * 在数据库中转义不用\用[]
         * select * from table where name not like 'zhao%'查询出所有不姓赵的姓名
         * 
         */
    }
}
