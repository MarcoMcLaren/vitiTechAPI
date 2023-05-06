using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API.Model
{
    public class SystemPrivilege
    {
        public int SystemPrivilegeID { get; set; }

        [MaxLength(255)]
        public string SystemPrivilegeDescription { get; set;}

        [JsonIgnore]
        public Employee Employee { get; set; }

        [JsonIgnore]
        public SuperUser SuperUser { get; set; }
    }
}
