using System;
using System.Collections.Generic;
using System.Data;

namespace Address
{
    class Address
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string HP { get; set; }

        public Address(int id, string name, string hp)
        {
            ID = id;
            Name = name;
            HP = hp;
        }
    }
    internal class Program
    {
        static int N = 0;

        public static DataTable DataTable { get; private set; }

        static void Main(string[] args)
        {
            Address addr;
            List<Address> list = new List<Address>();
            int id;
            string input, input2;

            while (true)
            {
                UIinit();
                switch (N)
                {
                    case 1:
                        Console.WriteLine("테이블을 생성 했습니다.");
                        DataTable = new DataTable();
                        break;

                    case 2:     //삽입
                        Console.Write("ID를 입력해 주세요 : ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("이름을 입력해 주세요 : ");
                        input = Console.ReadLine();
                        Console.Write("전화번호를 입력해 주세요 : ");
                        input2 = Console.ReadLine();
                        addr = new Address(id, input, input2);
                        list.Add(addr);
                        break;

                    case 3:     //조회
                        foreach (Address p in list)
                        {
                            Console.WriteLine(p.ID + " " + p.Name + " " + p.HP);
                        }

                        break;

                    case 4:     //수정
                        Console.Write("수정할 ID를 입력해 주세요 : ");
                        id = int.Parse(Console.ReadLine());

                        foreach (Address p in list)
                        {
                            if (id == p.ID)
                            {
                                Console.Write("ID를 입력해 주세요 : ");
                                id = int.Parse(Console.ReadLine());
                                Console.Write("이름을 입력해 주세요 : ");
                                input = Console.ReadLine();
                                Console.Write("전화번호를 입력해 주세요 : ");
                                input2 = Console.ReadLine();
                                p.ID = id;
                                p.Name = input;
                                p.HP = input2;

                                Console.WriteLine(p.ID + " " + p.Name + " " + p.HP);
                            }
                        }

                        break;

                    case 5:
                        Console.WriteLine("\n프로그램을 종료합니다.\n");
                       
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\n잘못된 메뉴를 입력하셨습니다. \n\n다시 입력 해 주세요.\n");
                        break;

                }
            }
        }
        static void UIinit()
        {
            Console.WriteLine("1. 테이블 생성");
            Console.WriteLine("2. 테이블 삽입");
            Console.WriteLine("3. 테이블 조회");
            Console.WriteLine("4. 테이블 수정");
            Console.WriteLine("5. 프로그램 종료");

            Console.Write("메뉴 : ");
            N = Int32.Parse(Console.ReadLine());
        }
    }
}