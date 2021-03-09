using System.Runtime.Serialization;

namespace RestEgBoligHeldinTest.Models
{
    public class Department
    {
        [DataMember(Name = "address")]
        public string Address { get; set; }

        [DataMember(Name = "companyNo")]
        public int CompanyNo { get; set; }

        [DataMember(Name = "departmentNo")]
        public int DepartmentNo { get; set; }

        [DataMember(Name = "index")]
        public int Index { get; set; }

        [DataMember(Name = "localCity")]
        public string LocalCity { get; set; }

        [DataMember(Name = "location")]
        public string Location { get; set; }

        [DataMember(Name = "zipCity")]
        public string ZipCity { get; set; }
    }
}