using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열은 객체다
            //1.new로 생성
            //2.heap 메모리에 생성
            //3. 고정배열(정적배열) : 배열의 크기가 설정되면 변경 불가
            //4. 자료구조의 기본

            /*
            //값 배열
            int[] arr = new int[10];
            Console.WriteLine(arr[0]);
            int[] arr2 = new int[5] { 10, 20, 30, 40, 50 };
            Console.WriteLine(arr2[0]);
            int[] arr3 = new int[] { 1, 2, 3, 4, 5 }; //선호
            int[] arr4 = { 100, 200, 300, 400, 500 }; //선호

            for(int i = 0; i < arr4.Length; i++)
            {
                Console.WriteLine(arr4[i]);
            }
            foreach(int i in arr4) //나열된 자원에 접근하여 순차적으로 표시해주는 함수
            {
                Console.WriteLine(i);
            }

            //Console.WriteLine(arr);
            //배열의 할당
            int[] ar = { 1, 3, 5, 7, 9 };
            int[] ar2 = ar; //할당 (주소값 할당)
            for(int i = 0; i < ar2.Length; i++)
            {
                ar2[i] += i;
            }
            for(int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine($"ar : {ar[i]}");
            }

            string[] atrarr = { "ㅇ아아", "으아아" };


            int[] varray = new int[] { 12, 56, 45, 90, 56, 10 };
            Console.WriteLine($"인덱스 값 : {Array.LastIndexOf(varray,56)}");
            Array.Sort(varray); //초급자는 절대 접근 금지 ... 과제시 sort 함수 금지
            for(int i = 0; i < varray.Length;i++)
            {
                Console.WriteLine("varry[{0}], {1}",i,varray[i]);
            }

            Console.WriteLine("자동 정렬 Desc >> 선행 >> sort");
            Array.Reverse(varray);
            for (int i = 0; i < varray.Length; i++)
            {
                Console.WriteLine("varry[{0}], {1}", i, varray[i]);
            }

            //초급 정렬코드 직접 구현( swap 방식, bubble sort)
            Console.WriteLine("Clear");
            Array.Clear(varray, 2, 3); //[2],[3],[4] >> 값을 0으로 초기화
            for(int i =0; i < varray.Length; i++)
            {
                Console.WriteLine($"varray[{i}] : {varray[i]}");
            }
            int[] a = new int[] { 45, 12, 88, 97, 10 };
            int[] b = new int[5];
            Array.Copy(a, b, 3);
            foreach(int item in b)
            {
                Console.WriteLine($"b[{item}]");
            }
            */

            //2차원 배열
            //행, 열
            int[,] arr6 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            for(int i =0; i <3; i++)
            {
                for(int j=0; j < 2; j++)
                {
                    Console.WriteLine("arr[{0},{1}]={2}", i, j, arr6[i, j]);
                }
            }
            Console.WriteLine($"행의개수 : {arr6.GetLength(0)}");
            Console.WriteLine($"열의개수 : {arr6.GetLength(1)}");
            for(int i = 0; i < arr6.GetLength(0); i++)
            {
                for( int j = 0; j < arr6.GetLength(1);j++)
                {
                    Console.WriteLine($"arr[{i},{j}]={arr6[i,j]}");
                }
            }



        }
    }
}
