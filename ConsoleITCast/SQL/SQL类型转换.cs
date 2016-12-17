using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.SQL
{
    class SQL类型转换
    {
        /*
         * 类型转换中通常用cast 或者convert
         * cast:select cast(100 as varchar(30))+'hello'
         * convert: select convert(datetime,getdate(),111)
         */
    }
    class unions
    {
        /*
         * union将多个结果集联合
         * union  all 不会去除重复数据
         * union 会去除重复数据
         * 当联合的时候注意列的类型
         * 列的个数必须一致
         * =================================
         * select top 0 * into newtable from stutable 复制表结构重新创建一个newtable 表
         * 如果表已经存在
         * insert into backstu select * from table  //backstu必须提前存在
         */
    }
}
