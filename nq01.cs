/*

Does C# have file IO?

Yes it does. It uses a FileStream class which is derived from the Stream class.
Below is an example of how to use this. The below code proves the functionality, 
but the inspiration for this example came from the source below. 

Source: http://www.tutorialspoint.com/csharp/csharp_file_io.htm

*/

using System;
using System.IO;

public class nq01{
	public static void Main(){
		FileStream f = new FileStream("example.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
		for (int i = 10; i > 0; i--){
			f.WriteByte((byte)i);
		}
		f.Position = 0;
		for (int i = 10; i > 0; i--){
			Console.WriteLine(f.ReadByte());
		}
		f.Close();
	}
}
