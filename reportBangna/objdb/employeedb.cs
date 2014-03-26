using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reportBangna.objdb
{
    public class EmployeeDB
    {
        private ConnectDB conn;
        public Employee emp;
        public EmployeeDB()
        {
            conn = new ConnectDB();
            initConfig();
        }
        public EmployeeDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            emp = new Employee();
            emp.companyId = "company_id";
            emp.departId = "depart_id";
            emp.empActive = "emp_active";
            emp.empHoliday = "emp_holiday";
            emp.empId = "emp_id";
            emp.empName = "emp_name";
            emp.empNameE = "emp_name_e";
            emp.empNickName = "emp_nickname";
            emp.empPassword = "emp_password";
            emp.empPrivilege = "emp_privilege";
            emp.empRealDay = "emp_realday";
            emp.empSSN = "emp_ssn";
            emp.empTimeRule = "emp_timerule";
            emp.empType = "emp_type";
            emp.empWorkType = "emp_worktype";
            emp.id = "id";
            emp.pkField = "emp_id";
            emp.sited = "";
            emp.empUsername = "emp_username";
            emp.table = "b_employee";
        }
        public Employee selectLogin(String employeeLogin, String employeePassword)
        {
            String sql ="";
            Employee item = new Employee();
            DataTable dt = new DataTable();
            sql = "Select * From " + emp.table + " Where " + emp.empUsername  + "='" + employeeLogin +
                "' and " + emp.empPassword  + " = '" + employeePassword + "' and " + emp.empActive + "='1'";
            dt = conn.selectData(sql);

            if (dt.Rows.Count > 0) {
                item.pkField = dt.Rows [0][emp.pkField].ToString();
                item.empActive = dt.Rows[0][emp.empActive].ToString();
                item.empName  = dt.Rows[0][emp.empName ].ToString();
                item.empId = dt.Rows[0][emp.empId].ToString();
                item.empNameE  = dt.Rows[0][emp.empNameE ].ToString();
                item.empUsername  = dt.Rows[0][emp.empUsername ].ToString();
                item.empSSN  = dt.Rows[0][emp.empSSN].ToString();
                item.empPassword = dt.Rows[0][emp.empPassword].ToString();

            }
            return item;
        }
    }
}
