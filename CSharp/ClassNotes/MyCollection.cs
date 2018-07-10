using System.Collections.Generic;
using System.Linq;

namespace Rolodex.Library.Models
{
  public class MyCollection
  {
    public void MyArray()
    {
      //1 dim
      int[] arr1 = new int[10];
      int[] arr2 = {1,2,3,4,5};
      int[] arr3 = new int[5]{1,2,3,4,5};

      var take3 = arr2[2];
      arr2[3] = 10;

      //multi dim
      int[,] arr4 = new int[3,3];
      int[,] arr5 = {{1,2},{3,4}};
      int[,] arr6 = {
        {1,2},
        {3,4}
      };
      int[,] arr7 = new int[3,2]{{1,2},{3,4},{5,6}};
      int[,] arr8 = new int[3,2]{
        {1,2},
        {3,4},
        {5,6}
      };

      var take4 = arr7[1,1];
      arr7[0,1] = 10;

      //jagged
      int[][] arr9 = new int[3][];
      int[][] arr9a = {new int[5], new int[]{1,2,3}, new int[4]{4,5,6,7}};
      int[][,] arr10 = new int[3][,];
      int[][,] arr10a = {new int[3,3], new int[,]{{1},{3}}, new int[2,2]{{1,2},{3,4}}};

      var take5 = arr9a[2][1];
      var take2 = arr10a[2][0,1];
    }

    public void MyList()
    {
      //single type
      List<int> li1 = new List<int>();
      List<int> li2 = new List<int>{1,2,3};
      var take2 = li2.ElementAt(1);
      var take2a = li2[1];
      li2[3] = 10;
      li2.Add(10);
      li2.Remove(2);
      li2.RemoveAt(1);
      li2.RemoveRange(1,1);
      li2.RemoveAll(i => i % 2 != 0);

      //array type
      List<int[]> li3 = new List<int[]>();
      var li3a = new List<int[]>{
        new int[]{1,2,3}, 
        new int[]{4,5,6,7},
        new int[] {8,9}
      };
      var take6 = li3a.ElementAtOrDefault(1).ElementAtOrDefault(2);
      li3a.ElementAt(2)[2] = 0;

      List<int[,]> li4 = new List<int[,]>();
      var li4a = new List<int[,]>{new int[,]{{1,2},{3,4}}, new int[,]{{1,2,3}, {4,5,6}}};
      List<int[][]> li5 = new List<int[][]>();

      //list type
      List<List<int>> li6 = new List<List<int>>();
    }

    public void MyDictionary()
    {
      Dictionary<int, int> di1 = new Dictionary<int, int>();
      Dictionary<int, int> di2 = new Dictionary<int, int>{{1,10},{2,20},{3,30}};
      Dictionary<List<int>, string> di3 = new Dictionary<List<int>, string>();

      var l = new List<int>();
      di1[1] = 10;
      di1[1] = 11;
      di3[l] = "hello";
      di3[l] = "goodbye";
      di1.Add(7,70);
      if (di1.ContainsKey(5))
      {
        //todo
      }
    }
  }
}
