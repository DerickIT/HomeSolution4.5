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

#if false
        *游标
        sql语句是吧结果集作为一个整体或作为一个但原来操作的，但是我们需要猪呢对结果集中的每条记录进行特殊操作，需要用到游标
        --------
        游标是过程化思维，而sql本身是几何化思维
        针对表中的每一行数据内容调用某个存储过程，或者为每个用户的手机发一条短信，
        多数清华下使用查询的性能要变游标高效，但是游标可以优化
        ------------
        declare 游标名 cursor[local|global][优选选项可选]for 查询语句
        open 游标名
        fetch [next]from 游标名into@v1 将游标向后移动一条
        @@fetch_status=0 为移动成功
        close 游标名
        deallocate 游标名-删除游标中数据库中保存的数据结构（释放资源）


        实例：
        declare cue_rew cursor fast_forward for select * from table
        open cur_reward
        fetch new fromn cur_reward into * ..column
        wheile @@fetch_status=0
        执行语句
        beign

        end
#endif
    }
}
