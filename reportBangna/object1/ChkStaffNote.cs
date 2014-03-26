using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reportBangna.object1
{
    class ChkStaffNote : Persistent
    {
        public String staffNoteId = "";
        public String MNC_DATE="";
        public String MNC_TIME="";
        public String vn="";
        public String MNC_HN_NO="";
        public String MNC_PFIX_DSC="";
        public String MNC_FNAME_T="";
        public String MNC_LNAME_T="";
        public String MNC_FN_TYP_DSC="";
        public String MNC_DOT_CD="";
        public String MNC_PFIX_DSC_D="";
        public String MNC_DOT_FNAME="";
        public String MNC_DOT_LNAME="";
        public String MNC_MD_DEP_DSC="";
        public String statusActive = "";
        public String statusReceive = "";
        public String remark = "";
        public String MNC_VN = "";
        public String MNC_VN_SEQ = "";
        

//        select PATIENT_T01.MNC_DATE,PATIENT_T01.MNC_TIME 

//,convert (varchar,PATIENT_T01.MNC_PRE_NO)+'/'+convert (varchar,PATIENT_T01.MNC_VN_SEQ)+'('
//+convert (varchar,PATIENT_T01.MNC_VN_SUM)+')' as vn
//,PATIENT_T01.MNC_HN_NO,
//PATIENT_M02.MNC_PFIX_DSC, 
//PATIENT_M01.MNC_FNAME_T,patient_m01.MNC_LNAME_T,
//FINANCE_M02.MNC_FN_TYP_DSC,PATIENT_M26.MNC_DOT_CD,
//doctor.MNC_PFIX_DSC,
//patient_m26.MNC_DOT_FNAME,patient_m26.MNC_DOT_LNAME
//,PATIENT_M32.MNC_MD_DEP_DSC
//from PATIENT_T01

//inner join PATIENT_M01 on patient_t01.MNC_HN_NO = PATIENT_M01.mnc_hn_no
//inner join FINANCE_M02 on patient_t01.MNC_FN_TYP_CD = FINANCE_M02.MNC_FN_TYP_CD
//inner join PATIENT_M32 on patient_t01.MNC_SEC_NO = patient_M32.MNC_SEC_NO
//inner join PATIENT_M26 on patient_t01.MNC_DOT_CD  = PATIENT_M26.mnc_dot_cd
//inner join PATIENT_M02 ON PATIENT_M02.MNC_PFIX_CD = PATIENT_M01.MNC_PFIX_CDT
//inner join PATIENT_M02 as doctor ON doctor.MNC_PFIX_CD = PATIENT_M26.MNC_DOT_PFIX

//where MNC_DATE ='2013-07-10'
//and patient_t01.MNC_DOC_STS <> 'v'
//order by mnc_pre_no
    }
}
