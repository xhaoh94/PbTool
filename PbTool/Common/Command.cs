﻿using System.Diagnostics;
using System.Text;


/// <summary>
/// 控制台命令
/// </summary>
public class Command
{
    private static readonly int _ReadSize = 2048;

    public event Action<string?> Output = Console.WriteLine;//输出事件
    public event Action<string?> Error = Console.WriteLine;//错误事件
    private event Action? _callback;//退出事件

    private bool _run;//循环控制
    private Process _process;//cmd进程
    private Encoding _outEncoding = Encoding.Default;//输出字符编码

    bool _isNoWindow;
    public static Command Run(string fileName = "cmd.exe", string argument = "", bool isNoWindow = true, Action? callback = null)
    {
        var command = new Command(fileName, argument, isNoWindow, callback);
        return command;
    }
    public Command(string fileName = "cmd.exe", string argument = "", bool isNoWindow = true, Action? callback = null)
    {
        _isNoWindow = isNoWindow;
        _callback = callback;
        _process = new Process();
        _process.StartInfo.FileName = fileName;
        _process.StartInfo.Arguments = argument;
        if (isNoWindow)
        {
            _process.StartInfo.UseShellExecute = false;//是否使用操作系统shell启动
            _process.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息        
            _process.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            _process.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            _process.StartInfo.CreateNoWindow = true;//不显示程序窗口        
        }

        ReStart();
    }

    /// <summary>
    /// 停止使用，关闭进程和循环线程
    /// </summary>
    public void Stop()
    {
        _run = false;
        _process.Close();
    }


    /// <summary>
    /// 启用
    /// </summary>
    public void ReStart()
    {
        Stop();
        _process.Start();
        _run = true;
        if (_isNoWindow)
        {
            _process.StandardInput.AutoFlush = true;
            ReadResult();
            ErrorResult();
        } 
    }

    public void Wait()
    {
        _process.WaitForExit();//等待程序执行完退出进程
        Stop();
        if (_callback != null)
        {
            _callback?.Invoke();
        }
    }
    public void Input(string argument = "")
    {
        if (!_run)
        {
            return;
        }
        _process.StandardInput.WriteLine(argument);
    }

    #region 输出
    //异步读取输出结果
    private void ReadResult()
    {
        if (!_run)
        {
            return;
        }
        while (!_process.StandardOutput.EndOfStream)
        {
            Output?.Invoke(_process.StandardOutput.ReadLine());
        }

    }


    //异步读取错误输出
    private void ErrorResult()
    {
        if (!_run)
        {
            return;
        }
        while (!_process.StandardError.EndOfStream)
        {
            Error?.Invoke(_process.StandardError.ReadLine());
        }
    }
    #endregion
    ~Command()
    {
        _run = false;
        _process?.Close();
        _process?.Dispose();
    }

}