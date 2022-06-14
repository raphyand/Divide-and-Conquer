using System;
using System.Collections.Generic;

public static class DivAndCon{
    public static void Main(string[] Args){

        BinSearch myBin = new BinSearch();

        List<int> myList = new List<int>(){
            1, 2, 7, 9, 21, 47, 53, 98, 100, 202, 230, 372
             };

        myList.Sort();
        
        Console.WriteLine("Found at Index " + myBin.Iterative(1, myList, myList.Count));

    }

    public class BinSearch {
        public BinSearch(){}

        public int Iterative(int key, List<int> list,  int listSize){

            int bottom = 0;
            int top = listSize - 1;
            

            while (bottom <= top){

                int middle = top + bottom / 2;

                if ( key == list[middle] ){
                    return middle;
                }
                else {
                    if( key < list[middle] ){
                        top = middle - 1;
                    }
                    else if (key > list[middle] ){
                        bottom = middle + 1;
                    }

                }

            }


            return 0;

        }

    }



}