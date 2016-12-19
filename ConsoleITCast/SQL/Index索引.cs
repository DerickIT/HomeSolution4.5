using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.SQL
{
    class Index索引
    {
        /*
         * 索引就是相当于生活中的字典，按照目录查
         * 全表扫描：对数据进行检索效率最差，就是一条一条的找
         * 聚集索引：当数据使劲的存储顺序与索引的顺序一直就把该索引交聚集索引
         * 非聚集索引：当索引中数据的顺序与数据实际存储的顺序不一致的时候，该索引叫非聚集索引
         * 
         * 创建索引的放肆：在表设计器中右键选择【索引/键】创建索引 选择列，索引咧
         * 填充因子，留出空位 | | | | 方便如果有之后插进来，不至于整个表移动
         * * 即使使用了索引，仍然有可能全表扫描，如like，函数，类型转换
         */
    }
}
