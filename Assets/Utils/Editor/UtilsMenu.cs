using UnityEngine;
using UnityEditor;

namespace Utils.Editor
{
    /// <summary>
    /// Unity菜单工具
    /// </summary>
    public static class UtilsMenu
    {
        [MenuItem("Utils/Debug/Test Debug Utils")]
        public static void TestDebugUtils()
        {
            DebugUtils.LogSuccess("这是一个成功消息!");
            DebugUtils.LogWarning("这是一个警告消息!");
            DebugUtils.LogError("这是一个错误消息!");
            DebugUtils.LogWithColor("这是一个自定义颜色消息!", Color.cyan);
        }

        [MenuItem("Utils/Scene/Clear Console %#c")]
        public static void ClearConsole()
        {
            var assembly = System.Reflection.Assembly.GetAssembly(typeof(SceneView));
            var type = assembly.GetType("UnityEditor.LogEntries");
            var method = type.GetMethod("Clear");
            method?.Invoke(new object(), null);
        }
    }
}

