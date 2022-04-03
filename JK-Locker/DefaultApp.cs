using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace JK_Locker
{
    class DefaultApp
    {
		public static void DefaultSet()
		{
			string strExeName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
			string strExePath = System.IO.Path.GetDirectoryName(strExeName) + "\\JKLocker.ico";
			SetFileOpenApp(".jkf", strExeName, strExePath);
		}
		/// <summary>
		/// 设置文件默认打开程序 前提是程序支持参数启动打开文件
		/// 特殊说明:txt后缀比较特殊,还需要从注册表修改userchoie的键值才行
		/// </summary>
		/// <param name="fileExtension">文件拓展名 示例:'.slnc'</param>
		/// <param name="appPath">默认程序绝对路径 示例:'c:\\test.exe'</param>
		/// <param name="fileIconPath">文件默认图标绝对路径 示例:'c:\\test.ico'</param>
		private static void SetFileOpenApp(string fileExtension, string appPath, string fileIconPath)
		{
			//slnc示例 注册表中tree node path
			//|-.slnc				默认		"slncfile"
			//|--slncfile
			//|---DefaultIcon		默认		"fileIconPath"			默认图标
			//|----shell
			//|-----open
			//|------command		默认		"fileExtension \"%1\""	默认打开程序路径
			var fileExtensionKey = Registry.ClassesRoot.OpenSubKey(fileExtension);
			if (fileExtensionKey != null)
				Registry.ClassesRoot.DeleteSubKeyTree(fileExtension, false);
			fileExtensionKey = Registry.ClassesRoot.CreateSubKey(fileExtension);
			using (fileExtensionKey)
			{
				var fileKeyName = $"{fileExtension.Substring(1)}file";
				fileExtensionKey.SetValue(null, fileKeyName, RegistryValueKind.String);
				using (var fileKey = fileExtensionKey.CreateSubKey(fileKeyName))
				{
					using (var defaultIcon = fileKey.CreateSubKey("DefaultIcon"))
					{
						defaultIcon.SetValue(null, fileIconPath);
					}
					using (var shell = fileKey.CreateSubKey("shell"))
					{
						using (var open = shell.CreateSubKey("open"))
						{
							using (var command = open.CreateSubKey("command"))
							{
								command.SetValue(null, $"{appPath} \"%1\"");
							}
						}
					}
				}
			}
		}


	}
}
