using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Address
{
    class Address
    {
        public int ID { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public string HP { get; set; }
        public int Grade { get; set; }

        public Address(int id, int year, string name, string hp, int grade)
        {
            ID = id;
            Year = year;
            Name = name;
            HP = hp;
            Grade = grade;
        }
    }
    internal class Program
    {
        static int N = 0;
        
        static void Main(string[] args)
        {
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

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT * FROM ADDRESS";

            

            Address addr;
            List<Address> list = new List<Address>();

            int id, year, grade;
            string input, input2;

            while (true)
            {
                UIinit();
                switch (N)
                {
                    case 1:
                        cmd.CommandText = "Create Table Address " +
                        "(ID number(8) PRIMARY KEY,  " +
                        "Year number(10), " +
                        "Name varchar2(20), " +
                        "HP varchar2(20)," +
                        "Grade number(10))";
                        //3.3 쿼리 실행하기
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        break;
                    case 2:
                        cmd.CommandText = "Delete TABLE ADDRESS;";
                        cmd.ExecuteNonQuery();
                        break;
                    case 3:
                        Console.Write("학번 입력 : ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("학년 입력 : ");
                        year = int.Parse(Console.ReadLine());
                        Console.Write("이름 입력 : ");
                        input = Console.ReadLine();
                        Console.Write("전화번호 입력 : ");
                        input2 = Console.ReadLine();
                        Console.Write("학점 입력 : ");
                        grade = int.Parse(Console.ReadLine());
                        addr = new Address(id, year, input, input2, grade);
                        list.Add(addr);
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO Address (ID, Year, NAME, HP, Grade) " +
                                    "VALUES ("+id +","+ year+",'"+ input +"','"+ input2 +"','"+ grade+"')";
                            
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        break;
                    case 4:
                        Console.Write("학번을 입력해 주세요 : ");
                        id = int.Parse(Console.ReadLine());
                        foreach(Address p in list)
                        {
                            if (id == p.ID)
                            {
                                list.Remove(p);
                                break;
                            }
                        }
                        break;
                    case 5:
                        Console.Write("수정할 학번을 입력 : ");
                        id = int.Parse(Console.ReadLine());
                        foreach(Address p in list)
                        {
                            if (id == p.ID)
                            {
                                Console.Write("학번 입력 : ");
                                id = int.Parse(Console.ReadLine());
                                Console.Write("학년 입력 : ");
                                year = int.Parse(Console.ReadLine());
                                Console.Write("이름 입력 : ");
                                input = Console.ReadLine();
                                Console.Write("전화번호 입력 : ");
                                input2 = Console.ReadLine();
                                Console.Write("학점 입력 : ");
                                grade = int.Parse(Console.ReadLine());
                                p.ID = id;
                                p.Year = year;
                                p.Name = input;
                                p.HP = input2;
                                p.Grade = grade;

                                Console.WriteLine(p.ID + " " + p.Year + " " + p.Name + " " + p.HP + " " + p.Grade);
                            }
                        }
                        break;
                    case 6:
                        foreach (Address p in list)
                        {
                            Console.WriteLine(p.ID + " " + p.Year + " " + p.Name + " " + p.HP + " " + p.Grade);
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
            //4. 리소스 반환 및 종료
            conn.Close();
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
            N = int.Parse(Console.ReadLine());

        }
    }
}