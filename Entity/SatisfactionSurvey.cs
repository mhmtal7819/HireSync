using System;

namespace Entity
{
    public class SatisfactionSurvey
    {
        public int SurveyId { get; set; }   // Primary Key
        public string SurveyTitle { get; set; }  // Nvarchar(25)
        public string SurveyType { get; set; }   // Varchar(50)

        public byte[] DepartmentId { get; set; }  // Varbinary(64) (byte array olarak tanımlanır)
    }
}
