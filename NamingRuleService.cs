using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miaoli.Port.Video.Service
{
    class NamingRuleService
    {
        // bad 註解呢?
        // good 善用 ctrl+shift+d

        // bad 排版很醜，多餘的空格要刪除

        // bad method命名，不知道這個method在幹嘛
        // good TestFunction -> Calculate
        public int TestFunction(int index)
        {
            switch (index)
            {
                // bad 1是什麼?
                // good 用enum定義代表意義
                case 1: break;
                default: break;
            }

            // bad 為什麼不整合在switch裡面?
            // good 用變數更改狀態
            if (index == 0) DoTrue();
            else
                DoFalse();
            
            // start
            var check = false;
            switch (index)
            {
                case 0:
                    check = true;
                    break;
                case 1:
                    // 我也不知道這個在幹嘛，總之應該有用處，先寫進來
                    break;
                default:
                    break;
            }
            // end

            // bad 多此一舉
            // good 直接定義為 true
            // reason DoTrue() -> always true
            if (DoTrue() == true) { DoTrue(); }


            return (index * (index + 1) / 2);
        }

        // bad 命名很爛，基本上是廢code
        // good 刪除
        private bool DoTrue()
        {
            return true;
        }

        // bad 命名很爛，基本上是廢code
        // good 刪除
        private bool DoFalse()
        {
            return false;
        }

        // bad 沒用到，為什麼不刪掉?, good: 刪掉
        // bad method命名
        // good TestStringFunction -> ConvertString
        public void TestStringFunction(string value)
        {
            // bad method內的參數命名，第一個字母應該要小寫
            // good NewString -> newString
            string NewString = "ABCDEFG"; //新字串

            // bad 有好東西用，為什麼不用
            // good value = !string.IsNullOrEmpty(value) ? NewString.Replace("A", ",").Replace("B", "_").Replace("C", " ") : value;
            if (value != null | value != "") value = NewString.Replace("A", ",").Replace("B", "_").Replace("C", " ");

            // 20180330 主任說要用stringbuilder
            value = !string.IsNullOrEmpty(value)
                ? new StringBuilder(NewString.Replace("A", ",").Replace("B", "_").Replace("C", " ")).ToString()
                : value;
        }

    }
}
