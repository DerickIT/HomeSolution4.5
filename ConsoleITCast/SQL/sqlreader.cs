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
         * 如果启用连接池，短时间内其实连接池就没有关闭，只是吧打开的conn放到了连接池中
         * 当下次在创建一个连接对象和保存在连接池中的连接字符串完全一致，这样就会直接使用放在连接池中的conn而不是重新创建
         * 调用conn当前close方法时会将conn放到连接池中，
         * ---------------------------
         * 除了ado有连接池，数据库也有一个连接池
         * 如果连接池中有对象，则open的意思是把对象取出来
         * dispose 和 close 在有连接池的情况下其实是假的
         */
    }
}
