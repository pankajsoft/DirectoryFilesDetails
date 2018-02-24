using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DirectoryFilesDetails
{
	class Program
	{
		static void Main(string[] args)
		{

			foreach (var path in Directory.GetFiles(Environment.CurrentDirectory))
			{
				FileInfo fileInfo = new FileInfo(path);
				Console.WriteLine(fileInfo.Name);
			}

			Console.ReadKey();
		}
	}
}
