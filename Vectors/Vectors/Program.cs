using System;

namespace Vectors
{
	class MainClass
	{
		public static void Main ()
		{
			Console.WriteLine ("Hello World!");
			float a, b, c;
			a = float.Parse(Console.ReadLine ());
			b = float.Parse(Console.ReadLine ());
			c = float.Parse(Console.ReadLine ());
			Vector vector1 = new Vector(a,b,c);
			Console.Write ("a=");
			vector1.PrintVector();
			Console.WriteLine ("|a|="+vector1.Length ());
			Vector vector2 = new Vector (-1, -2, -3);
			vector1.AddVector (vector2);
			Console.Write ("a+(-1;-2;-3)=");
			vector1.PrintVector ();
		}
	}

	class Vector
	{
		public float x,y,z;
		public Vector(float a,float b,float c)
		{
			x = a;
			y = b;
			z = c;
		}
		public void PrintVector()
		{
			Console.WriteLine ("("+x+";"+y+";"+z+")");
		}
		public float Length()
		{
			return (float)Math.Sqrt(x * x + y * y + z * z);
		}
		public void AddVector(Vector vector)
		{
			x += vector.x;
			y += vector.y;
			z += vector.z;
		}
	}

}
