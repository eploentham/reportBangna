using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.objdb
{
    public class HosRiskDB
    {
        Config1 cf;
        public ConnectDB connBua;
        public HosRisk hr;
        public HosRiskDB()
        {
            initConfig();
        }
        private void initConfig()
        {
            cf = new Config1();
            connBua = new ConnectDB("bangna");
            hr = new HosRisk();
            hr.congenital1 = "congenital1";
            hr.congenital2 = "congenital2";
            hr.congenital3 = "congenital3";
            hr.congenital4 = "congenital4";
            hr.congenital5 = "congenital5";
            hr.dateRisk = "date_risk";
            hr.deptRisk = "dept_risk";
            hr.firstName = "first_name";
            hr.HN = "hn";
            hr.Id = "hos_risk_id";
            hr.ImportanceLevel = "importance_level";
            hr.IncidentCate = "incident_cate";
            hr.IncidentPreliminary = "incident_preliminary";
            hr.IncidentProgram = "incident_program";
            hr.IncidentStype = "incident_stype";
            hr.IncidentSummary = "incident_summary";
            hr.IncidentType = "incident_type";
            hr.informDeptRisk = "inform_dept";
            hr.InformType = "inform_type";
            hr.lastName = "last_name";
            hr.localRisk = "local_risk";
            hr.PsychiatryPrimary = "psychiatry_primary";
            hr.PsychiatrySecond = "psychiatry_second";
            hr.riskId = "risk_id";
            hr.SolveId = "solve";
            hr.timeRisk = "time_risk";
            hr.visitDate = "visit_date";
            hr.VN = "vn";
            hr.Ward = "ward";
            hr.Active = "hos_rick_active";
            hr.monthId = "month_id";
            hr.yearId = "year_id";
            hr.dateCreate = "date_create";
            hr.dateCancel = "date_cancel";
            hr.dateModi = "date_modi";
            hr.userCancel = "user_cancel";
            hr.userCreate = "user_create";
            hr.userMOdi = "user_modi";
            hr.MACIP = "mac_ip";
            hr.MACUSER = "mac_user";
            hr.AnalyzeEmp = "analyze_emp";
            hr.AnalyzeEmpOther = "analyze_emp_other";
            hr.AnalyzeEnvir = "analyze_envir";
            hr.AnalyzeEnvirOther = "analyze_envir_other";
            hr.AnalyzeOrg = "analyze_org";
            hr.AnalyzeOrgOther = "analyze_org_other";
            hr.AnalyzePatient = "analyze_patient";
            hr.AnalyzePatientOther = "analyze_patient_other";
            hr.AnalyzePolice = "analyze_police";
            hr.AnalyzePoliceOther = "analyze_police_other";
            hr.AnalyzeTeam = "analyze_team";
            hr.AnalyzeTeamOther = "analyze_team_other";
            hr.ViolenceLevel = "violence_level";
            hr.deptConcerned = "dept_concerned";
            hr.deptWard = "dept_ward";
            
            hr.table = "t_hos_risk";
            hr.pkField = "hos_risk_id";

        }
        private HosRisk setData(HosRisk p, DataTable dt)
        {
            //p.checknhsoId = dt.Rows[0][cNhso1.checknhsoId].ToString();
            p.congenital1 = dt.Rows[0][hr.congenital1].ToString();
            p.congenital2 = dt.Rows[0][hr.congenital2].ToString();
            p.congenital3 = dt.Rows[0][hr.congenital3].ToString();
            p.congenital4 = dt.Rows[0][hr.congenital4].ToString();
            p.congenital5 = dt.Rows[0][hr.congenital5].ToString();
            p.dateRisk = dt.Rows[0][hr.dateRisk].ToString();
            p.deptRisk = dt.Rows[0][hr.deptRisk].ToString();
            p.firstName = dt.Rows[0][hr.firstName].ToString();
            p.HN = dt.Rows[0][hr.HN].ToString();
            p.Id = dt.Rows[0][hr.Id].ToString();
            p.ImportanceLevel = dt.Rows[0][hr.ImportanceLevel].ToString();
            p.IncidentCate = dt.Rows[0][hr.IncidentCate].ToString();
            p.IncidentPreliminary = dt.Rows[0][hr.IncidentPreliminary].ToString();
            p.IncidentProgram = dt.Rows[0][hr.IncidentProgram].ToString();
            p.IncidentStype = dt.Rows[0][hr.IncidentStype].ToString();
            p.IncidentSummary = dt.Rows[0][hr.IncidentSummary].ToString();
            p.IncidentType = dt.Rows[0][hr.IncidentType].ToString();
            p.informDeptRisk = dt.Rows[0][hr.informDeptRisk].ToString();
            p.InformType = dt.Rows[0][hr.InformType].ToString();
            p.lastName = dt.Rows[0][hr.lastName].ToString();
            p.localRisk = dt.Rows[0][hr.localRisk].ToString();
            p.PsychiatryPrimary = dt.Rows[0][hr.PsychiatryPrimary].ToString();
            p.PsychiatrySecond = dt.Rows[0][hr.PsychiatrySecond].ToString();
            p.riskId = dt.Rows[0][hr.riskId].ToString();
            p.SolveId = dt.Rows[0][hr.SolveId].ToString();
            p.timeRisk = dt.Rows[0][hr.timeRisk].ToString();
            p.visitDate = dt.Rows[0][hr.visitDate].ToString();
            p.VN = dt.Rows[0][hr.VN].ToString();
            p.Ward = dt.Rows[0][hr.Ward].ToString();
            p.Active = dt.Rows[0][hr.Active].ToString();
            return p;
        }
        public HosRisk selectByPk(String hosRiskId)
        {
            HosRisk item = new HosRisk();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + hr.table + " Where " + hr.pkField + "='" + hosRiskId + "'";
            dt = connBua.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public DataTable selectByMonthYear(String yearId, String monthId)
        {
            //HosRisk item = new HosRisk();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + hr.table + " Where " + hr.Active + "='1' and "+hr.monthId+"='"+monthId+"' and "+hr.yearId+"='"+(int.Parse(yearId)-543)+"' ";
            dt = connBua.selectData(sql);
            return dt;
        }
        private String insert(HosRisk p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.Id == "")
                {
                    p.Id = p.getGenID();
                }
                p.monthId = "RIGHT('00' + CAST(month(GETDATE()) AS NVARCHAR), 2)";
                p.yearId = "CAST(year(GETDATE()) AS NVARCHAR)";
                p.dateCreate = " CAST(year(GETDATE()) AS NVARCHAR)+'-'+ RIGHT('00' + CAST(month(GETDATE()) AS NVARCHAR), 2)+'-'+ RIGHT('00' + CAST(day(GETDATE()) AS NVARCHAR), 2)"
                    + "' '+ RIGHT('00' + CAST(hour(GETDATE()) AS NVARCHAR), 2)+':'+ RIGHT('00' + CAST(minute(GETDATE()) AS NVARCHAR), 2)+':'+ RIGHT('00' + CAST(second(GETDATE()) AS NVARCHAR), 2)";
                p.Active = "1";
                sql = "Insert Into " + hr.table + "(" + hr.pkField + "," + hr.congenital1 + "," + hr.congenital2 + "," +
                    hr.congenital3 + "," + hr.congenital4 + "," + hr.congenital5 + "," +
                    hr.dateRisk + "," + hr.deptRisk + "," + hr.firstName + "," +
                    hr.HN + "," + hr.ImportanceLevel + "," + hr.IncidentCate + "," +
                    hr.IncidentPreliminary + "," + hr.IncidentProgram + "," + hr.IncidentStype + "," +
                    hr.IncidentSummary + "," + hr.IncidentType + "," + hr.informDeptRisk + "," +
                    hr.InformType + "," + hr.lastName + "," + hr.localRisk + "," +
                    hr.PsychiatryPrimary + "," + hr.PsychiatrySecond + "," + hr.riskId + "," +
                    hr.SolveId + "," + hr.timeRisk + "," + hr.visitDate + "," +
                    hr.VN + "," + hr.Ward + "," + hr.Active + "," + hr.monthId + "," + hr.yearId + "," + hr.dateCreate + ") " +
                    "Values('" + p.Id + "','" + p.congenital1 + "','" + p.congenital2 + "','" +
                    p.congenital3 + "','" + p.congenital4 + "','" + p.congenital5 + "','" +
                    p.dateRisk + "','" + p.deptRisk + "','" + p.firstName + "','" +
                    p.HN + "','" + p.ImportanceLevel + "','" + p.IncidentCate + "','" +
                    p.IncidentPreliminary + "','" + p.IncidentProgram + "','" + p.IncidentStype + "','" +
                    p.IncidentSummary + "','" + p.IncidentType + "','" + p.informDeptRisk + "','" +
                    p.InformType + "','" + p.lastName + "','" + p.localRisk + "','" +
                    p.PsychiatryPrimary + "','" + p.PsychiatrySecond + "','" + p.riskId + "','" +
                    p.SolveId + "','" + p.timeRisk + "','" + p.visitDate + "','" +
                    p.VN + "','" + p.Ward + "','" + p.Active + "'," + p.monthId + "," + p.yearId + "," + p.dateCreate + ") ";
                chk = connBua.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert HosRisk");
            }

            return chk;
        }
        public String update(HosRisk p)
        {
            String sql = "", chk = "";
            try
            {
                p.dateModi = " CAST(year(GETDATE()) AS NVARCHAR)+'-'+ RIGHT('00' + CAST(month(GETDATE()) AS NVARCHAR), 2)+'-'+ RIGHT('00' + CAST(day(GETDATE()) AS NVARCHAR), 2)";
                sql = "Update "+hr.table+" Set "+hr.congenital1+"='"+p.congenital1+"',"+
                    hr.congenital2+"='"+p.congenital2+"',"+
                    hr.congenital3+"='"+p.congenital3+"',"+
                    hr.congenital4+"='"+p.congenital4+"',"+
                    hr.congenital5+"='"+p.congenital5+"',"+
                    hr.dateRisk+"='"+p.dateRisk+"',"+
                    hr.deptRisk+"='"+p.deptRisk+"',"+
                    hr.firstName+"='"+p.firstName+"',"+
                    hr.HN+"='"+p.HN+"',"+
                    hr.ImportanceLevel+"='"+p.ImportanceLevel+"',"+
                    hr.IncidentCate+"='"+p.IncidentCate+"',"+
                    hr.IncidentPreliminary+"='"+p.IncidentPreliminary+"',"+
                    hr.IncidentProgram+"='"+p.IncidentProgram+"',"+
                    hr.IncidentStype+"='"+p.IncidentStype+"',"+
                    hr.IncidentSummary+"='"+p.IncidentSummary+"',"+
                    hr.IncidentType+"='"+p.IncidentType+"',"+
                    hr.informDeptRisk+"='"+p.informDeptRisk+"',"+
                    hr.InformType+"='"+p.InformType+"',"+
                    hr.lastName+"='"+p.lastName+"',"+
                    hr.localRisk+"='"+p.localRisk+"',"+
                    hr.PsychiatryPrimary+"='"+p.PsychiatryPrimary+"',"+
                    hr.PsychiatrySecond+"='"+p.PsychiatrySecond+"',"+
                    hr.riskId+"='"+p.riskId+"',"+
                    hr.SolveId+"='"+p.SolveId+"',"+
                    hr.timeRisk+"='"+p.timeRisk+"',"+
                    hr.visitDate+"='"+p.visitDate+"',"+
                    hr.VN+"='"+p.VN+"',"+
                    hr.Ward+"='"+p.Ward+"', "+
                    hr.dateModi + "='" + p.dateModi + "' " +
                    "Where "+hr.pkField+"='"+p.Id+"'";
                chk = connBua.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update HosRisk");
            }
            return chk;
        }
        public String VoidHosRisk(String hosRiskId)
        {
            String sql = "", chk = "";
            //p.dateCancel = "SELECT CAST(year(GETDATE()) AS NVARCHAR)+'-'+SELECT RIGHT('00' + CAST(month(GETDATE()) AS NVARCHAR), 2)+'-'+SELECT RIGHT('00' + CAST(day(GETDATE()) AS NVARCHAR), 2)";
            sql = "Update " + hr.table + " Set " + hr.Active + " = '3', " + hr.dateCancel + "= CAST(year(GETDATE()) AS NVARCHAR)+'-'+ RIGHT('00' + CAST(month(GETDATE()) AS NVARCHAR), 2)+'-'+ RIGHT('00' + CAST(day(GETDATE()) AS NVARCHAR), 2) " +
                "Where " + hr.pkField + "='" + hosRiskId + "'";
            try
            {
                chk = connBua.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
            }

            return chk;
        }
        public String UpdateRemark(String hosRiskId, String remark)
        {
            String sql = "", chk = "";
            sql = "Update " + hr.table + " Set " + hr.remark + " = '" + remark + "' " +
                "Where " + hr.pkField + "='" + hosRiskId + "'";
            try
            {
                chk = connBua.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
            }

            return chk;
        }
        //public String UpdateRemark(String hosRiskId, String remark)
        //{
        //    String sql = "", chk = "";
        //    sql = "Update " + hr.table + " Set " + hr.remark + " = '" + remark + "' " +
        //        "Where " + hr.pkField + "='" + hosRiskId + "'";
        //    try
        //    {
        //        chk = connBua.ExecuteNonQuery(sql);
        //    }
        //    catch (Exception ex)
        //    {
        //    }

        //    return chk;
        //}
        public String UpdateAnalyzePatient(String hosRiskId, String analyzePatient, String analyzePatientOther)
        {
            String sql = "", chk = "";
            sql = "Update " + hr.table + " Set " + hr.AnalyzePatient + " = '" + analyzePatient + "', " 
                + hr.AnalyzePatientOther + " = '" + analyzePatientOther + "' " +
                "Where " + hr.pkField + "='" + hosRiskId + "'";
            try
            {
                chk = connBua.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
            }

            return chk;
        }
        public String UpdateAnalyzeEmp(String hosRiskId, String analyzeEmp, String analyzeEmpOther)
        {
            String sql = "", chk = "";
            sql = "Update " + hr.table + " Set " + hr.AnalyzeEmp + " = '" + analyzeEmp + "', "
                + hr.AnalyzeEmpOther + " = '" + analyzeEmpOther + "' " +
                "Where " + hr.pkField + "='" + hosRiskId + "'";
            try
            {
                chk = connBua.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
            }

            return chk;
        }
        public String UpdateAnalyzeTeam(String hosRiskId, String analyzeTeam, String analyzeTeamOther)
        {
            String sql = "", chk = "";
            sql = "Update " + hr.table + " Set " + hr.AnalyzeTeam + " = '" + analyzeTeam + "', "
                + hr.AnalyzeTeamOther + " = '" + analyzeTeamOther + "' " +
                "Where " + hr.pkField + "='" + hosRiskId + "'";
            try
            {
                chk = connBua.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
            }

            return chk;
        }
        public String UpdateAnalyzeEnvir(String hosRiskId, String analyzeEnvir, String analyzeEnvirOther)
        {
            String sql = "", chk = "";
            sql = "Update " + hr.table + " Set " + hr.AnalyzeEnvir + " = '" + analyzeEnvir + "', "
                + hr.AnalyzeEnvirOther + " = '" + analyzeEnvirOther + "' " +
                "Where " + hr.pkField + "='" + hosRiskId + "'";
            try
            {
                chk = connBua.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
            }

            return chk;
        }
        public String UpdateAnalyzePolice(String hosRiskId, String analyzePolice, String analyzePoliceOther)
        {
            String sql = "", chk = "";
            sql = "Update " + hr.table + " Set " + hr.AnalyzePolice + " = '" + analyzePolice + "', "
                + hr.AnalyzePoliceOther + " = '" + analyzePoliceOther + "' " +
                "Where " + hr.pkField + "='" + hosRiskId + "'";
            try
            {
                chk = connBua.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
            }

            return chk;
        }
        public String UpdateAnalyzeOrg(String hosRiskId, String analyzeOrg, String analyzeOrgOther)
        {
            String sql = "", chk = "";
            sql = "Update " + hr.table + " Set " + hr.AnalyzeOrg + " = '" + analyzeOrg + "', "
                + hr.AnalyzeOrgOther + " = '" + analyzeOrgOther + "' " +
                "Where " + hr.pkField + "='" + hosRiskId + "'";
            try
            {
                chk = connBua.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
            }

            return chk;
        }
        public String UpdateVielenceLEvel(String hosRiskId, String VielenceLevel)
        {
            String sql = "", chk = "";
            sql = "Update " + hr.table + " Set " + hr.ViolenceLevel + " = '" + VielenceLevel + "' " +
                //+ hr.AnalyzeOrgOther + " = '" + analyzeOrgOther + "' " +
                "Where " + hr.pkField + "='" + hosRiskId + "'";
            try
            {
                chk = connBua.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
            }

            return chk;
        }
        public String UpdateDeptConcerned(String hosRiskId, String deptConcerned, String deptWard)
        {
            String sql = "", chk = "";
            sql = "Update " + hr.table + " Set " + hr.deptConcerned + " = '" + deptConcerned + "', " +
                hr.deptWard + " = '" + deptWard + "' " +
                "Where " + hr.pkField + "='" + hosRiskId + "'";
            try
            {
                chk = connBua.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
            }

            return chk;
        }

        public String insertHosRisk(HosRisk p)
        {
            HosRisk item = new HosRisk();
            String chk = "";
            item = selectByPk(p.Id);
            if (item.Id == "")
            {
                chk = insert(p);
            }
            else
            {
                chk = update(p);
            }
            return chk;
        }
        public DataTable selectIncidentProgram()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select distinct "+hr.IncidentProgram+" From " + hr.table + " Where " + hr.Active + "='1' Order By "+hr.IncidentProgram;
            dt = connBua.selectData(sql);

            return dt;
        }
        public ComboBox getCboIncidentProgram(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectIncidentProgram();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][hr.IncidentProgram].ToString();
                item.Text = dt.Rows[i][hr.IncidentProgram].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public DataTable selectIncidentType()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select distinct " + hr.IncidentType + " From " + hr.table + " Where " + hr.Active + "='1' Order By " + hr.IncidentType;
            dt = connBua.selectData(sql);

            return dt;
        }
        public ComboBox getCboIncidentType(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectIncidentType();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][hr.IncidentType].ToString();
                item.Text = dt.Rows[i][hr.IncidentType].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public DataTable selectIncidentCate()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select distinct " + hr.IncidentCate + " From " + hr.table + " Where " + hr.Active + "='1' Order By " + hr.IncidentCate;
            dt = connBua.selectData(sql);

            return dt;
        }
        public ComboBox getCboIncidentCate(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectIncidentCate();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][hr.IncidentCate].ToString();
                item.Text = dt.Rows[i][hr.IncidentCate].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public DataTable selectIncidentStype()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select distinct " + hr.IncidentStype + " From " + hr.table + " Where " + hr.Active + "='1' Order By " + hr.IncidentStype;
            dt = connBua.selectData(sql);

            return dt;
        }
        public ComboBox getCboIncidentStype(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectIncidentStype();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][hr.IncidentStype].ToString();
                item.Text = dt.Rows[i][hr.IncidentStype].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public DataTable selectPsychiatryPrimary()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select distinct " + hr.PsychiatryPrimary + " From " + hr.table + " Where " + hr.Active + "='1' Order By " + hr.PsychiatryPrimary;
            dt = connBua.selectData(sql);

            return dt;
        }
        public ComboBox getCboPsychiatryPrimary(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectPsychiatryPrimary();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][hr.PsychiatryPrimary].ToString();
                item.Text = dt.Rows[i][hr.PsychiatryPrimary].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public DataTable selectCongenital1()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select distinct " + hr.congenital1 + " From " + hr.table + " Where " + hr.Active + "='1' Order By " + hr.congenital1;
            dt = connBua.selectData(sql);

            return dt;
        }
        public ComboBox getCboCongenital1(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectCongenital1();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][hr.congenital1].ToString();
                item.Text = dt.Rows[i][hr.congenital1].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public DataTable selectCongenital2()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select distinct " + hr.congenital2 + " From " + hr.table + " Where " + hr.Active + "='1' Order By " + hr.congenital2;
            dt = connBua.selectData(sql);

            return dt;
        }
        public ComboBox getCboCongenital2(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectCongenital2();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][hr.congenital2].ToString();
                item.Text = dt.Rows[i][hr.congenital2].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public DataTable selectCongenital3()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select distinct " + hr.congenital3 + " From " + hr.table + " Where " + hr.Active + "='1' Order By " + hr.congenital3;
            dt = connBua.selectData(sql);

            return dt;
        }
        public ComboBox getCboCongenital3(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectCongenital3();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][hr.congenital3].ToString();
                item.Text = dt.Rows[i][hr.congenital3].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public DataTable selectCongenital4()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select distinct " + hr.congenital4 + " From " + hr.table + " Where " + hr.Active + "='1' Order By " + hr.congenital4;
            dt = connBua.selectData(sql);

            return dt;
        }
        public ComboBox getCboCongenital4(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectCongenital4();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][hr.congenital4].ToString();
                item.Text = dt.Rows[i][hr.congenital4].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public DataTable selectInFormDeptRisk()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select distinct " + hr.informDeptRisk + " From " + hr.table + " Where " + hr.Active + "='1' Order By " + hr.informDeptRisk;
            dt = connBua.selectData(sql);

            return dt;
        }
        public ComboBox getCboInFormDeptRisk(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectInFormDeptRisk();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][hr.informDeptRisk].ToString();
                item.Text = dt.Rows[i][hr.informDeptRisk].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public DataTable selectDeptRisk()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select distinct " + hr.deptRisk + " From " + hr.table + " Where " + hr.Active + "='1' Order By " + hr.deptRisk;
            dt = connBua.selectData(sql);

            return dt;
        }
        public ComboBox getCboDeptRisk(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectDeptRisk();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][hr.deptRisk].ToString();
                item.Text = dt.Rows[i][hr.deptRisk].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public DataTable selectLocalRisk()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select distinct " + hr.localRisk + " From " + hr.table + " Where " + hr.Active + "='1' Order By " + hr.localRisk;
            dt = connBua.selectData(sql);

            return dt;
        }
        public ComboBox getCboLocalRisk(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectLocalRisk();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][hr.localRisk].ToString();
                item.Text = dt.Rows[i][hr.localRisk].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        //public DataTable selectPsychiatryPrimary()
        //{
        //    String sql = "";
        //    DataTable dt = new DataTable();
        //    sql = "Select distinct " + hr.PsychiatryPrimary + " From " + hr.table + " Where " + hr.Active + "='1' Order By " + hr.PsychiatryPrimary;
        //    dt = connBua.selectData(sql);

        //    return dt;
        //}
        //public ComboBox getCboPsychiatryPrimary(ComboBox c)
        //{
        //    ComboBoxItem item = new ComboBoxItem();
        //    DataTable dt = selectPsychiatryPrimary();
        //    //String aaa = "";
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        item = new ComboBoxItem();
        //        item.Value = dt.Rows[i][hr.PsychiatryPrimary].ToString();
        //        item.Text = dt.Rows[i][hr.PsychiatryPrimary].ToString();
        //        c.Items.Add(item);
        //        //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
        //        //c.Items.Add(new );
        //    }
        //    return c;
        //}
    }
}
