using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace AddressBook
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
                    case 1:     //테이블 만들기
                        string strConn = "Data Source=(DESCRIPTION=" +
                "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                "(HOST=localhost)(PORT=1521)))" +
                "(CONNECT_DATA=(SERVER=DEDICATED)" +
                "(SERVICE_NAME=xe)));" +
                "User Id=hr;Password=hr;";

                        //1.연결 객체 만들기 - Client
                        OracleConnection conn = new OracleConnection(strConn);

                        //2.데이터베이스 접속을 위한 연결
                        conn.Open();

                        //3.서버와 함께 신나게 놀기
                        //3.1 Query 명령객체 만들기
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = conn; 
                        //연결객체와 연동
                        //3.2 명령하기, 테이블 생성하기
                        cmd.CommandText = "Create Table PhoneBook " +
                            "(ID number(4) PRIMARY KEY,  " +
                            "NAME varchar(20), " +
                            "HP varchar(20))";
                        //3.3 쿼리 실행하기
                        cmd.ExecuteNonQuery();
                        //4. 리소스 반환 및 종료
                        conn.Close();
                        break;

                    case 2:     //테이블 삭제

                        break;

                    case 3:     //데이터 삽입
                        Console.Write("ID를 입력해 주세요 : ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("이름을 입력해 주세요 : ");
                        input = Console.ReadLine();
                        Console.Write("전화번호를 입력해 주세요 : ");
                        input2 = Console.ReadLine();
                        addr = new Address(id, input, input2);
                        list.Add(addr);
                        break;

                    case 4:     //데이터 삭제
                        Console.Write("ID를 입력해 주세요 : ");
                        id = int.Parse(Console.ReadLine());
                        foreach (Address p in list)
                        {
                            if (id == p.ID)
                            {
                                list.Remove(p);
                                break;
                            }
                        }
                        break;

                    case 5:     //데이터 수정
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

                    case 6:     //데이터 조회
                        foreach (Address p in list)
                        {
                            Console.WriteLine(p.ID + " " + p.Name + " " + p.HP);
                        }

                        break;

                    case 7:
                        Console.WriteLine("\n프로그램을 종료합니다.\n");
                        Console.WriteLine("안녕히 계세요. 수고하셨습니다.\n");
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
            Console.WriteLine("1. 테이블 만들기");
            Console.WriteLine("2. 테이블 삭제");
            Console.WriteLine("3. 데이터 삽입");
            Console.WriteLine("4. 데이터 삭제");
            Console.WriteLine("5. 데이터 수정");
            Console.WriteLine("6. 데이터 조회");
            Console.WriteLine("7. 프로그램 종료");

            Console.Write("메뉴 : ");
            N = Int32.Parse(Console.ReadLine());
        }
    }
}