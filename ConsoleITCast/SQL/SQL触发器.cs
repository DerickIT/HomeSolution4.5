using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.SQL
{
    class SQL触发器
    {
#if false
       sdfasdf
        asdf
#endif
        /*
         * 相当于.net中的事件
         * 自动化操作，减少了手动操作出错的记率
         * 触发器中的deleted。inserted 两个表
         * 当执行insert语句会用到inserted表，当执行delete语句是会用到deleted
         * 当执行uodate语句的时候，会将旧数据放到deleted表中，将新数据放到insertted表中
         * 
         * 
         * ============================================
         * create trigger triggername on 表名 after insert
         * as
         * begin
         * declare @name varchar(50)
         * select * from table where name=@name
         * end
         * ============================
         * create trigger tri_name on taname after deleter
         * as
         * begin 把每次删除的记录存到了tb表
         * insert into tb select * from deleted
         * end
         * 表级触发器  （无论影响多少行值触发一次）
         * 
         * 
         * 启动sqlserver代理-打开数据库新建作业-可以自己设置任务去自动触发
         * 
         * 
         * 尽量避免在触发其中执行耗时操作，因为触发器认为sql语句会在一个事务中
         * 能尽量不用就不用触发器
         */
    }
}
