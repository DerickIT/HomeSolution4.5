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
         * 当正则表达式提取时，如果一个字符能匹配，多个字符也能匹配，这是就按照最多字符的方式来匹配【贪婪模式】
         * ？是用来终止贪婪模式在+号等限定符后使用
         * 默认正则表达式采用贪婪模式
         * 如果发现取出来全部的，可能是贪婪模式影响
         * 用正则表达式匹配时，如果提取不要加^$
         * 用@转义时注意里面没有用\\\去转义其他，下划线_不需要转义
         * 用正则表达式检查敏感词，直接用正则表达式包含“^毒品|白粉$”
         
         */

        public bool test()
        {
            var vl = "^(b[jtsu]g])$";//只能匹配到【】中的内容，就像bug，但不能匹配出brg
            Regex rg = new Regex("", RegexOptions.IgnoreCase);
            //Regex.IsMatch();判断字符串是否匹配相应的规则
            //Regex.Match()从某个字符串中取出符合规则的字符
            //Regex.Matches()字符串提取，可以提取所有的符合规则的字符串
            //Regex.Replace()字符串替换，把所有匹配正则表达四的字符串替换成相应的字符串
            Regex.IsMatch("busdkk", vl);//注意优先级
            //邮政编码
            var yreg = @"^\d{6}$";//出啊先6次
            var shenfenzreg = @"^\d{15}$|^\d{18}$";//身份证号，只能是15位或者18位
            var phonereg = @"^((\d{3,4}\-?\d{7,8})|(\d{5}))$";//验证010-xxxxxxxx，或者83838 02000000223！！！！！！！！！！！！！！！通过()可以提取组[]  mareg.groups[1]
            var email = @"^[a-zA-Z0-9_\.]+@[A-Za-z0-9]+(\.[a-zA-Z]+)+$";//验证邮箱
            var ipreg = @"\d{1,3}{\.\d{1,3}}{\.\d{3}}";//验证ip规则
            var date = @"^{\d{1,4}\-\d{1,2}\-\d{1,2}$";//验证时间格式
            var urlreg = @"^[a-zA-Z]+://.+$";//验证url格式+表示是一道多
            var numreg = @"^1[1-9]$";//验证10-20的数字@"^((1[1-9])|2([1-9]))$"
            var regdd = @"^([a-zA-Z]+)\s*(\d{1,2})\s*,\s*(\d{4})\s*$";
            /*
             * 
             * eoacom@163.com
             * reg=@"^([a-zA-Z0-9_\-]+)@([A-Za-z0-9]+(\.[a-zA-Z0-9]+)+)$";
             * (1(2(3))))按照这种分组
             * 取出文件中后缀名，先取到所有的文件名，根据文件名分组，然)后取出最后那个组【aaa】[。txt]    取到.
             * 中奖观众185****2222，175****6958,164****2020
             * reg="(\d{3})(\d{4})(\d{4})"当用替换时使用"$1****$3"能吧中间的4个数字替换成****
             */
            Regex.IsMatch("ufj887", yreg);//如果要出现一个字符，这个字符是关键字，需要转义
            Regex.Replace("", @"\-+", "-");
            return false;
        }
    }
}
