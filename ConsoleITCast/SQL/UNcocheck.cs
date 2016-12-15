using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.SQL
{
    class UNcocheck
    {
        /*
         * 约束
         * 唯一约束
         * 主键约束
         * 非空约束
         * 默认约束
         * 外键约束
         * alert table  mytable drop column myid  删除myid列
         * alert table  mytable add column myid  增加myid列
         * alert table table1 add constraint pk_id primary key (id)将id设为主键
         * alert table  mytable add constraint uq_weiyi unique(name)  添加唯一约束(name)
         * alert table  mytable add constraint default_pc default('男') for sex 增加默认约束默认为男
         * alert table  mytable add constraint pc_check check(age>0 and age<100)增加check约束
         * =
         * alert table  mytable add constraint pk_waijian_kit primary key(kit)//添加主键约束
         * alert table  mytable add constraint fk_de_kd foreign key(deptid) references table (id)添加外检约束
         * 
         * 增加朱外检约束时，要先删除
         * 
         * 
         * ---------------------
         * 设置级联更新，级联删除
         * [ON DELETE（NO ACTION|CASCADE|SET NULL|SET DEFAULT）]  CASCADE
         * [ON UPDATE{NO ACTION|CASCADE|SET NULL|SET DEFAULT}]
         * 
         */
    }
}
