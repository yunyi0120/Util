using UnityEngine;

namespace Utils
{
    /// <summary>
    /// 调试工具类
    /// </summary>
    public static class DebugUtils
    {
        /// <summary>
        /// 带颜色的日志输出
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="color">颜色</param>
        public static void LogWithColor(string message, Color color)
        {
            string colorHex = ColorUtility.ToHtmlStringRGB(color);
            Debug.Log($"<color=#{colorHex}>{message}</color>");
        }

        /// <summary>
        /// 输出错误日志
        /// </summary>
        /// <param name="message">错误信息</param>
        public static void LogError(string message)
        {
            LogWithColor($"[ERROR] {message}", Color.red);
        }

        /// <summary>
        /// 输出警告日志
        /// </summary>
        /// <param name="message">警告信息</param>
        public static void LogWarning(string message)
        {
            LogWithColor($"[WARNING] {message}", Color.yellow);
        }

        /// <summary>
        /// 输出成功日志
        /// </summary>
        /// <param name="message">成功信息</param>
        public static void LogSuccess(string message)
        {
            LogWithColor($"[SUCCESS] {message}", Color.green);
        }
    }
}

