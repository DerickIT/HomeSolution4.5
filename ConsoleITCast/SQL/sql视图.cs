using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.SQL
{
    class sql视图
    {
        /*
         * 视图本身不存储数据，只是存储了查询语句
         * 视图是一张虚拟表，表示一张表的部分数据或者多张表的综合数据
         * 安全性：可以访问视图权限，但不给表的访问权限
         * 
         * 在视图中不能使用order by 除非另外指定了top或for xml
         * （*）索引视图会存储数据，微软设计的数据库存在的，oracle不会存储
         * ========================================================
         * 局部变量
         * declare  @d int 局部变量
         * @@name 全局变量
         * set @变量名=value
         */
    }
}
