using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.SQL
{
    class SQL事务
    {
        /*
         * 事务
         * begin tran
         * begin try
         * declare @sum int =0 
         * 执行操作  insert into 
         * set @sum=@sum+@@error
         * commit tran
         * end try
         * begin catch
         * rollback
         * end catch
         * if @@error<>0
         * begin
         *  rollback
         * end
         * else
         * begin
         * commit tran
         * end
         * 
         * 使用@@error判断是否出错
         * 
         * ===========================
         * 给事务命名
         * 提交事务 commit 事务名
         * 回滚事务 rollback 事务名
         * 
         * 
         * 原子性  不可拆分
         * 一致性  事务完成时，必须使所有的数据都保持一致  
         * 隔离    由并发更改前的数据要保持隔离  不能影响其他
         * 持久性  事务完成后，他对系统的影响是永久的
         */
    }
}
