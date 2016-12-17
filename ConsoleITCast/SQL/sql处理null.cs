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
         */
    }
}
