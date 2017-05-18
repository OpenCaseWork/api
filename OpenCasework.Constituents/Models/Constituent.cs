using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenCaseWork.Constituents.Models
{
    public class Constituent
    {
        public long ConstituentId { get; set; }
        public int TitleID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int SuffixID { get; set; }
        public string Nickname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int CityID { get; set; }
        public int TownshipID { get; set; }
        public string StateCd { get; set; }
        public int PostalCodeID { get; set; }
        public string PostalCode { get; set; }
        public string FederalID { get; set; }
        public DateTime BirthDate { get; set; }
        public int GenderId { get; set; }
        public int MinorityId { get; set; }
        public int IncomeLevelId { get; set; }
        public string MaidenName { get; set; }


        /*    



Private mvarImportID As String 

Private mstrExtractAddressChanged As String
Private mvarEthnicityId As Variant

Public PreferredLanguageId As Variant
Public PrintLabel As Variant
Public NOTES As String*/

    }
}
