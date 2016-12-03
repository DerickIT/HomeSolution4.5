using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{
    /// <summary>
    /// 正则表达式联系
    /// </summary>
    public class Regexs
    {
        /*
         * .除\n外的任意字符
         * （）分组，优先级，提取组
         * [-]加-是表示a-z或者0-9不加-是表示只能是其中任意一个字符
         * “abc*”匹配限定前面的表达式出现0次或多次
         * x{abc}+y限定符，至少出现1次，可以出现多次
         * ？限定符x{abc}？y表示只能出现0次或者1次
         * {n}--a{abc}{5,10}，至少出现5次abc，最多出现10次
         * [^a-z]字符a-z开头
         * [^az$]必须要完全匹配
         * \d表示0-9，\D表示除了0-9的所有字符
         * \s表示看不到的空白符\S小写s的反面，除了看不到的空白符
         * \w汉字，下划线，单词
         
         */

        public bool test()
        {
            var vl = "b[jtsu]g";//只能匹配到【】中的内容，就像bug，但不能匹配出brg
            Regex rg = new Regex("", RegexOptions.IgnoreCase);
            //Regex.IsMatch();判断字符串是否匹配相应的规则
            //Regex.Match()从某个字符串中取出符合规则的字符
            //Regex.Matches()字符串提取，可以提取所有的符合规则的字符串
            //Regex.Replace()字符串替换，把所有匹配正则表达四的字符串替换成相应的字符串
            return false;
        }
    }
}
