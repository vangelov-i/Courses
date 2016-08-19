using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 21:38 - 22:48 -> 100 ot pyrviq pyt madafakaa! mnoo qka zadacha!
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            int roomsNum = int.Parse(Console.ReadLine());
            string roomsInitial = Console.ReadLine();

            int[] roomsState = new int[roomsNum];

            for (int i = 0; i < roomsNum; i++)
            {

                if (roomsInitial[i % roomsInitial.Length] == 'L')
                {
                    roomsState[i] = 1;
                }

            }

            int currRoom = roomsNum / 2;

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');
                if (command[0] == "END")
                {
                    break;
                }
                int roomDif = int.Parse(command[1].ToString()) + 1;
                if (command[0] == "LEFT")
                {
                    currRoom = currRoom - roomDif;
                    if (currRoom < 0 && currRoom + roomDif != 0)
                    {
                        currRoom = 0;
                    }
                    else if (currRoom + roomDif == 0)
                    {
                        currRoom = 0;
                        continue;
                    }
                    if (roomsState[currRoom] == 1)
                    {
                        roomsState[currRoom] = 0;
                    }
                    else
                    {
                        roomsState[currRoom] = 1;
                    }
                }
                else if (command[0] == "RIGHT")
                {
                    currRoom = currRoom + roomDif;
                    if (currRoom > roomsNum - 1 && (currRoom - roomDif) != (roomsNum - 1))
                    {
                        currRoom = roomsNum - 1;
                    }
                    else if (currRoom - roomDif == roomsNum - 1)
                    {
                        currRoom = currRoom - roomDif;
                        continue;
                    }
                    if (roomsState[currRoom] == 1)
                    {
                        roomsState[currRoom] = 0;
                    }
                    else
                    {
                        roomsState[currRoom] = 1;
                    }
                }

            }

            int darkRooms = 0;
            for (int i = 0; i < roomsState.Length; i++)
            {
                if (roomsState[i] == 0)
                {
                    darkRooms++;
                }
            }
            Console.WriteLine(68 * darkRooms);
            // num of prays = 68 * darkRooms
        }
    }
}