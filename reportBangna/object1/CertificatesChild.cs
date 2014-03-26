using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reportBangna.object1
{
    class CertificatesChild : Persistent 
    {
        public String certifiId { get ;set ;}
        public String childName { get; set; }
        public String childSurname { get; set; }
        public String childSex { get; set; }
        public String birthDay { get; set; }
        public String birthDayDate { get; set; }
        public String birthDayTime { get; set; }
        public String childWeigth { get; set; }
        public String fatherName { get; set; }
        public String fatherSurname { get; set; }
        public String motherName { get; set; }
        public String motherSurname { get; set; }
        public String doctorName { get; set; }
        public String username { get; set; }
        public String dateCreate { get; set; }
        public String dateModi { get; set; }
        public String dateCancel { get; set; }
        public String certifiActive { get; set; }
        public String statusSurname { get; set; }
        public String birthDayMonth { get; set; }
        public String birthDayYear { get; set; }
        public CertificatesChild()
        {
            certifiId = "";
            childName = "";
            childSurname = "";
            childSex = "";
            birthDay = "";
            birthDayDate = "";
            birthDayTime = "";
            childWeigth = "";
            fatherName = "";
            fatherSurname = "";
            motherName = "";
            motherSurname = "";
            doctorName = "";
            username = "";
            dateCreate = "";
            dateModi = "";
            dateCancel = "";
            certifiActive = "";
            statusSurname = "";
            birthDayMonth = "";
            birthDayYear = "";
        }
    }
}
