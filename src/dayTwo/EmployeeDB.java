package dayTwo;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by andrewrcouture on 2016-08-25.
 */
public class EmployeeDB {

    List<Employee> employees = new ArrayList<>();
    List<String> data = new ArrayList<>();

    static Connection con;
    static Statement statement = null;
    static ResultSet rs = null;
    static ResultSetMetaData metaData;
    static int rowCount = 0;

    String userName = MainProgram.arguments[0];
    String password = MainProgram.arguments[1];
    String url = "jdbc:mysql://localhost:3306/augustDPP?UseSSL=false";

    public EmployeeDB() throws Exception {
        //load driver
        Class.forName("com.mysql.jdbc.Driver");
        //connect to db
        con = DriverManager.getConnection(url,userName,password);
    }
    public List<String> queryAll() throws Exception {
        statement = con.createStatement();
        rs = statement.executeQuery("SELECT * from employee");
        int columnCount = metaData.getColumnCount();

        while (rs.next()){
            for (int i = 1; i <= columnCount; i++){
                data.add(rs.getString(i));
            }
            TaskProcessing.printAll(data);
        }
    }
}
