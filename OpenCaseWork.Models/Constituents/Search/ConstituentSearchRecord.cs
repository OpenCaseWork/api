using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OpenCaseWork.Constituents.Models.Search
{
    [Table("constituent_search")]
    public class ConstituentSearchRecord
    {
        [Column("provider_number")]
        public string ProviderNumber { get; set; }
        [Column("constituent_id")]
        public int Id { get; set; }
        [Column("federal_id")]
        public string FederalId { get; set; }
        [Column("birth_date")]
        public DateTime? BirthDate { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("addr1")]
        public string Address { get; set; }
        [Column("contact_text")]
        public string Phone { get; set; }
        [Column("city")]
        public string City { get; set; }
        [Column("state")]
        public string State { get; set; }
        [Column("zip_code")]
        public string PostalCode { get; set; }
        [Column("eccpis_id")]
        public string ECCPIS { get; set; }
        [Column("home_phone")]
        public string HomePhone { get; set; }
        [Column("cell_phone")]
        public string CellPhone { get; set; }
        [Column("business_phone")]
        public string BusinessPhone { get; set; }
    }
} 
