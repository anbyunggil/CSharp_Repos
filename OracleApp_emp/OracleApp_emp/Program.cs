using Oracle.ManagedDataAccess.Client;

internal class Program
{
     static void Main(string[] args)
    {
        //SELECT 데이터 조회

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



        //명령객체 생성

        OracleCommand cmd = new OracleCommand();

        cmd.Connection = conn;



        //데이터 조회

        cmd.CommandText = "SELECT EMPNO, ENAME, JOB, HIREDATE, SAL, DEPTNO FROM EMP";

        //cmd.ExecuteNonQuery()



        //데이터 조회 결과를 리턴하는 DataReader객체를 만들어야 한다.

        OracleDataReader rdr = cmd.ExecuteReader();



        while (rdr.Read())

        {



            int EMPNO = int.Parse(rdr["EMPNO"].ToString());

            string ENAME = rdr["ENAME"] as string;

            string JOB = rdr["JOB"] as string;

            DateTime hireDate = rdr.GetDateTime(rdr.GetOrdinal("HIREDATE"));

            string HIREDATE = hireDate.ToString();

            int SAL = int.Parse(rdr["SAL"].ToString());

            int DEPTNO = int.Parse(rdr["DEPTNO"].ToString());



            Console.WriteLine($"{EMPNO} : {ENAME} : {JOB} : {HIREDATE} : {SAL}  : {DEPTNO}");

        }



        //리소스 반환

        conn.Close();

    }

}

