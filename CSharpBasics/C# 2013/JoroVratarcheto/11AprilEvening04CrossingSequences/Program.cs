using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 15:20 - 17:00 
class Program
{
    static void Main(string[] args)
    {
        //spiral -> 1,1,2,  2, 3, 3, 4,4,5,5
        //          7,9,11,13, 17,

        long trNminus3 = long.Parse(Console.ReadLine());
        long trNminus2 = long.Parse(Console.ReadLine());
        long trNminus1 = long.Parse(Console.ReadLine());
        long trN = 0L;
        List<long> trList = new List<long>();
        trList.Add(trNminus3);
        trList.Add(trNminus2);
        trList.Add(trNminus1);

        long spStart = long.Parse(Console.ReadLine());
        long step = long.Parse(Console.ReadLine());


        long edgeMember = (long)spStart;
        List<long> spiralList = new List<long>();
        spiralList.Add(edgeMember);
        for (int i = 1; ; i++)
        {
            trN = trNminus3 + trNminus2 + trNminus1;
            trList.Add(trN);
            for (int j = 0; j < 2; j++)
            {
                edgeMember += step * i;
                spiralList.Add(edgeMember);
            }
            if (edgeMember >= 1000000 && trN >= 1000000)
            {
                break;
            }
            trNminus3 = trNminus2;
            trNminus2 = trNminus1;
            trNminus1 = trN;
        }

        //Console.WriteLine("________");
        //foreach (var item in trList)
        //{
        //    Console.WriteLine(item);
        //}
        //Console.WriteLine("---------------------------------");
        //foreach (var item in spiralList)
        //{
        //    Console.WriteLine(item);
        //}


        long commonMember = 0L;
        foreach (var number in trList)
        {
            if (spiralList.Contains(number))
            {
                commonMember = number;
                break;
            }
        }
        //Console.WriteLine("____________________________");
        if (commonMember == 0 || commonMember > 1000000)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine(commonMember);
        }

    }
}
