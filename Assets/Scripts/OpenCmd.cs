using System.Diagnostics;
using System.IO;

using UnityEngine;

public class CommandPromptCaller : MonoBehaviour
{
    public string commandToExecute;

    private void Start()
    {
        ExecuteCommand();
    }

    public void ExecuteCommand()
    {
        Process process = new Process();
        process.StartInfo.FileName = "cmd.exe"; // 指定要运行的命令行程序
        process.StartInfo.RedirectStandardInput = true;
        process.StartInfo.UseShellExecute = false; // 必须设置为false，以便能够重定向输入
        process.StartInfo.CreateNoWindow = true; // 不显示命令行窗口

        process.Start(); // 启动命令行进程

        //StreamWriter sw = process.StandardInput;
        //if (sw.BaseStream.CanWrite)
        //{
        //    sw.WriteLine(commandToExecute); // 发送要执行的命令
        //}

        //process.WaitForExit(); // 等待命令执行完成
        //process.Close();
    }
}