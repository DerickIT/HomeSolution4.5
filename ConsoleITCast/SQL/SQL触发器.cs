using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.SQL
{
    class SQL触发器
    {
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
         * 
         */
    }
}
