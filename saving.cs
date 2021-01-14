using System;
using System.IO;
using System.Text;


public class Program
{
	public static void Main(){
		//Veri oluşturma		
		StringBuilder sb = new StringBuilder();
                int i = 0;

                i = 1;
                sb.Append(i.ToString() + ",");

                i =0;
                sb.Append(i.ToString() + ",");

                i=1;
                sb.Append(i.ToString() + ",");

                File.WriteAllText(@"/home/pi/Desktop/CSharpSaveToText/savedText.txt",sb.ToString());
		

		//Verileri okuyup consolda yazdırma
		int a,b,c;
		
		string[] values = File.ReadAllText(@"/home/pi/Desktop/CSharpSaveToText/savedText.txt").Split(',');
		a =Convert.ToInt32( values[0]);
		b =Convert.ToInt32( values[1]);
		c =Convert.ToInt32( values[2]);
		Console.WriteLine("Birinci deger : " + a);
		Console.WriteLine("İkinci deger : " + b);
		Console.WriteLine("Ucuncu deger : " + c);
	}

}
