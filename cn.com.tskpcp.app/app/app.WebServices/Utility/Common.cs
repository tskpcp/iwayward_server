using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using System.Text.RegularExpressions;

using System.Diagnostics;
using System.Collections.Generic;
using System.Reflection;

namespace app.WebServices.Utility
{
    public class Common
    {
        private Common() { }

        #region public static string GetRandNum( int randNumLength )
        /// <summary>
        /// 取得随机数
        /// </summary>
        /// <param name="randNumLength">随机数的长度</param>
        /// <returns></returns>
        public static string GetRandNum(int randNumLength)
        {
            Random randNum = new Random(unchecked((int)DateTime.Now.Ticks));
            StringBuilder sb = new StringBuilder(randNumLength);
            for (int i = 0; i < randNumLength; i++)
            {
                sb.Append(randNum.Next(0, 9));
            }
            return sb.ToString();
        }

        #endregion

        #region public static string StringLeft(string word, int size, bool omit, string sign )

        /// <summary>
        /// 对传入的字符串取前多少位的字符
        /// </summary>
        /// <param name="word">传入字符创</param>
        /// <param name="size">截取长度</param>
        /// <param name="omit">是否使用省略符</param>
        /// <param name="sign">省略符</param>
        /// <returns></returns>
        public static string StringLeft(string word, int size, bool omit, string sign)
        {
            StringBuilder returnVal = new StringBuilder();
            int len = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] > 256)
                {
                    len += 2;
                }
                else
                {
                    len++;
                }
                if (len < size)
                {
                    returnVal.Append(word[i]);
                }
                else
                {
                    if (omit)
                    {
                        returnVal.Append(sign);
                        break;
                    }
                    else
                    {
                        returnVal.Append(word[i]);
                        break;
                    }
                }
            }
            return returnVal.ToString();
        }

        /// <summary>
        /// 对传入的字符串取前多少位的字符
        /// </summary>
        /// <param name="word">传入字符创</param>
        /// <param name="size">截取长度</param>
        /// <param name="omit">是否使用省略符</param>
        /// <returns></returns>
        public static string StringLeft(string word, int size, bool omit)
        {
            return (StringLeft(word, size, omit, "."));
        }

        /// <summary>
        /// 对传入的字符串取前多少位的字符
        /// </summary>
        /// <param name="word">传入字符创</param>
        /// <param name="size">截取长度</param>
        /// <returns></returns>
        public static string StringLeft(string word, int size)
        {
            return (StringLeft(word, size, true, "."));
        }

        #endregion

        #region public static int CNLength(string word)

        /// <summary>
        /// 获得字符串的长度，一个Unicode计算为2字符
        /// </summary>
        /// <param name="word">输入字符串</param>
        /// <returns></returns>
        public static int CNLength(string word)
        {
            int len = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] > 256)
                {
                    len += 2;
                }
                else
                {
                    len++;
                }
            }
            return (len);
        }

        #endregion

        #region 判断是否为数字
        public static bool IsNumber(string strSentence)
        {
            return IsNumber(strSentence, true);
        }

        public static bool IsNumber(string strSentence, bool singleOrMore)
        {

            if (singleOrMore)//单个
            {
                bool bl = false;
                int n;
                if (int.TryParse(strSentence, out n))
                {
                    bl = true;
                }
                return bl;
            }
            else
            {
                string[] s = strSentence.Split(new char[] { ',' });
                bool bl_more_result = true;
                for (int i = 0; i < s.Length; i++)
                {
                    bool bl_more = false;
                    int n;
                    if (int.TryParse(s[i].ToString(), out n))
                    {
                        bl_more = true;
                    }
                    if (!bl_more)
                    {
                        bl_more_result = false;
                        break;
                    }
                }
                if (!bl_more_result)
                {
                    return false;
                }
                return true;
            }
        }
        #endregion

        #region 判断数组中是否有重复的值   重复且
        public static bool IsArrayRepeat(string[] arrValue)
        {
            /*************/


            for (int i = 0; i < arrValue.Length; i++)
            {
                if (arrValue[i] == "")
                {
                    return true;
                }
                else
                {
                    if (arrValue[i].Trim() == "")
                    {
                        return true;
                    }
                }
                if (!IsNumber(arrValue[i]))
                {
                    return true;
                }

            }

            /*************/


            bool bl = false;
            List<string> newValue = new List<string>();

            foreach (string s in arrValue)
            {
                if (newValue.Contains(s))
                    bl = true;
                else
                    newValue.Add(s);
            }
            return bl;
        }

        public static bool IsNoRepeatAtAttributes(string[] arrValue)
        {
            bool bl = false;
            List<string> newValue = new List<string>();

            foreach (string s in arrValue)
            {
                if (newValue.Contains(s))
                    bl = true;
                else
                    newValue.Add(s);
            }
            return bl;
        }
        #endregion


        /// <summary>
        /// 将泛型集合类转换成DataTable
        /// </summary>
        /// <typeparam name="T">集合项类型</typeparam>
        /// <param name="list">集合</param>
        /// <param name="propertyName">需要返回的列的列名</param>
        /// <returns>数据集(表)</returns>
        public static DataTable ToDataTable<T>(IList<T> list, params string[] propertyName)
        {
            List<string> propertyNameList = new List<string>();
            if (propertyName != null)
                propertyNameList.AddRange(propertyName);

            DataTable result = new DataTable();
            if (list.Count > 0)
            {
                PropertyInfo[] propertys = list[0].GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    if (propertyNameList.Count == 0)
                    {
                        result.Columns.Add(pi.Name, pi.PropertyType);
                    }
                    else
                    {
                        if (propertyNameList.Contains(pi.Name))
                            result.Columns.Add(pi.Name, pi.PropertyType);
                    }
                }

                for (int i = 0; i < list.Count; i++)
                {
                    ArrayList tempList = new ArrayList();
                    foreach (PropertyInfo pi in propertys)
                    {
                        if (propertyNameList.Count == 0)
                        {
                            object obj = pi.GetValue(list[i], null);
                            tempList.Add(obj);
                        }
                        else
                        {
                            if (propertyNameList.Contains(pi.Name))
                            {
                                object obj = pi.GetValue(list[i], null);
                                tempList.Add(obj);
                            }
                        }
                    }
                    object[] array = tempList.ToArray();
                    result.LoadDataRow(array, true);
                }
            }
            return result;
        }

        //全字匹配并替换 
        public static string WordMatch(string str, string s_match, string value)//匹配正则 
        {
            string regex = @"^" + s_match + @"$";
            return Regex.Replace(str, regex, value);

        }

        /// <summary>
        /// 生成N位不重复随机数
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static string RandCode(int N)
        {
            char[] arrChar = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            StringBuilder num = new StringBuilder();
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < N; i++)
            {
                num.Append(arrChar[rnd.Next(0, arrChar.Length)].ToString());
            }
            return num.ToString();
        }



    }
}
