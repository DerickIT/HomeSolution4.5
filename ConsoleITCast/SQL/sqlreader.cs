using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.SQL
{
    class sqlreader
    {
        /*
         * sqldatareader向前进一步就会释放之前上一条已经读过的数据
         * 1、reader是只进的
         * 2、只能读取数据，不能修改数据，因为查询的数据集是一个独立的占服务器内存的数据，与源表没有关系了
         * 3、必须保证datareader是连接状态
         * --------------------------
         * 使用dataeraader建议使用索引来获取数据而不是通过列名
         * read.getvalue(0)
         * IsDBNull()验证当前这列是否为空
         * ExecuteScalar（）;获取当前一行
         */
    }
    class adonet连接池
    {
        /*
         * 默认启用连接池
         * 如果不启用连接池，每次都会重新打开和关闭，耗费性能较大
         * 如果启用连接池，短时间内其实连接池就没有关闭
         */
    }
}
