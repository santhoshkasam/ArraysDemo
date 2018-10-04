using System;

class Program
{
  static void Main(string[] args)
  {
    #region Declaration

    int[] ar;//Just declaration
    int[] a = new int[5];//Declaration with intialization. here a is reference to an array which is there on heap.
    //Index will begin from 0.
    a[0] = 1;
    a[1] = 2;
    a[4] = 3;

    #endregion

    #region arraysaredynamic

    //Arrays are dynamic. means you can define the dynamically. like below.
    int n = int.Parse(args[0]);
    int[] b = new int[n];
    for (var i = 0; i < n; i++)
    {
      Console.WriteLine(b[i]);
    }
    #endregion

    #region initializingwithvalues
    //for will give the better performance compare to foreach
    int[] c = { 1, 2, 3, 4, 5 };//initializingwithvalues
    for (var i = 0; i < c.Length; i++)
    {
      Console.WriteLine(c[i]);
    }

    foreach (var variable in c)
    {
      Console.WriteLine(variable);
    }

    #endregion

    #region Declaretheninitializationwithvalues

    int[] d;
    //d = { 1,2,3};//not Valid
    //d = new int[4] { 1, 2, 3 };//This is not valid. you should not give size and initialize values at the same time.
    d = new int[] { 1, 2, 3 };// this means d reference variable with array on size 3.


    #endregion

    #region SizeofArrayCannotbechanged
    Console.WriteLine("SizeofArrayCannotbechanged");
    int[] e = { 1, 2, 3 };
    Console.WriteLine(e.Length);
    e = new int[5];
    Console.WriteLine(e.Length);

    for (int i = 0; i < e.Length; i++)
    {
      Console.WriteLine(e[i]);
    }
    #endregion


    #region ArrayCopy,ArraySort,ArrayReverse
    Console.WriteLine("ArrayCopy, ArraySort, ArrayReverse");
    int[] f = { 1, 2, 3 };
    int[] g = f;
    f = new int[4];
    Array.Copy(g, f, g.Length);//How to know which length we can specify? use ternary 
    Array.Sort(f);
    Array.Reverse(f);
    for (int i = 0; i < f.Length; i++)
    {
      Console.WriteLine(f[i]);
    }

    string[] strSortAr = { "Anisha", "Arun", "Abhay", "Ganesh" };
    Array.Sort(strSortAr);//lexical order sorting
    for (int i = 0; i < strSortAr.Length; i++)
    {
      Console.WriteLine(strSortAr[i]);
    }
    #endregion

    #region twodimensionalarray
    int[,] twoAr = { { 1, 2, 3 }, { 4, 5, 6 } };



    #endregion

  }
}
