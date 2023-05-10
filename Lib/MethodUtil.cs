using System;
using System.Diagnostics;
using System.Reflection;

namespace FileSystemMonitor.Lib
{
    class MethodUtil
    {
        /// <summary>
        /// 取得 目前正在執行的 Function Info 資訊
        /// </summary>
        /// <returns></returns>
        public static String GetCurrentMethodInfo()
        {
            string showString = "";
            //取得當前方法類別命名空間名稱
            //showString += "Namespace:" + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Namespace + "→";
            //取得當前類別名稱
            //showString += "class Name:" + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName + "→";
            //取得當前所使用的方法
            showString += "Method:" + System.Reflection.MethodBase.GetCurrentMethod().Name;

            return showString;
        }

        /// <summary>
        /// 取得父類別的相關資訊(共用的Functiond可用)
        /// </summary>
        /// <returns></returns>
        public static String GetParentInfo()
        {
            String showString = "";
            StackTrace ss = new StackTrace(true);
            //取得呼叫當前方法之上一層類別(GetFrame(1))的屬性
            MethodBase mb = ss.GetFrame(1).GetMethod();

            //取得呼叫當前方法之上一層類別(父方)的命名空間名稱
            //showString += mb.DeclaringType.Namespace + "\n";

            //取得呼叫當前方法之上一層類別(父方)的function 所屬class Name
            //showString += mb.DeclaringType.Name + "→";

            //取得呼叫當前方法之上一層類別(父方)的Full class Name
            showString += mb.DeclaringType.FullName + ".";

            //取得呼叫當前方法之上一層類別(父方)的Function Name
            showString += mb.Name;

            return showString;
        }
    }
}

