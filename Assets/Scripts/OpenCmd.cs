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
        process.StartInfo.FileName = "cmd.exe"; // ָ��Ҫ���е������г���
        process.StartInfo.RedirectStandardInput = true;
        process.StartInfo.UseShellExecute = false; // ��������Ϊfalse���Ա��ܹ��ض�������
        process.StartInfo.CreateNoWindow = true; // ����ʾ�����д���

        process.Start(); // ���������н���

        //StreamWriter sw = process.StandardInput;
        //if (sw.BaseStream.CanWrite)
        //{
        //    sw.WriteLine(commandToExecute); // ����Ҫִ�е�����
        //}

        //process.WaitForExit(); // �ȴ�����ִ�����
        //process.Close();
    }
}