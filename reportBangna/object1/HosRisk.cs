using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reportBangna.object1
{
    public class HosRisk:Persistent
    {
        public String Id = "", informDeptRisk="", riskId="", deptRisk="", localRisk="", dateRisk="", timeRisk="", firstName="", lastName="", HN="", VN="", visitDate="", Ward="";
        public String PsychiatryPrimary = "", PsychiatrySecond = "", congenital1 = "", congenital2 = "", congenital3 = "", congenital4 = "", congenital5 = "", IncidentProgram="";
        public String IncidentType = "", IncidentCate = "", IncidentStype = "", IncidentSummary = "", InformType = "", IncidentPreliminary = "", SolveId = "", ImportanceLevel = "";
        public String Active = "", dateCreate="", dateModi="", dateCancel="", userCreate="", userMOdi="", userCancel="", remark="", MACIP="", MACUSER="", AnalyzePatient="";
        public String AnalyzeEmp = "", AnalyzeTeam = "", AnalyzeEnvir = "", AnalyzePolice = "", AnalyzeOrg = "", AnalyzeEmpOther = "", AnalyzeTeamOther = "", AnalyzeEnvirOther = "", AnalyzePoliceOther = "", AnalyzeOrgOther = "";
        public String ViolenceLevel = "", deptConcerned = "", AnalyzePatientOther = "", monthId="", yearId="", deptWard="";
    }
}
