using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Extranet.Models
{
    public class Profile
    {
        [Key]
        public int profile_id { get; set; }
        public int user_id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string current_position { get; set; }
        public string phone { get; set; }
        public string email {  get; set; }
        public string localization { get; set; }
        public string profile_description { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string competencesJson { get; set; }
        [NotMapped]
        public List<string> Competences
        {
            get => JsonConvert.DeserializeObject<List<string>>(competencesJson);
            set => competencesJson = JsonConvert.SerializeObject(value);
        }
        [Column(TypeName = "varchar(50)")]
        public string experienceJson { get; set; }
        [NotMapped]
        public List<Experience> experience
        {
            get => JsonConvert.DeserializeObject<List<Experience>>(experienceJson);
            set => experienceJson = JsonConvert.SerializeObject(value);
        }
        [Column(TypeName = "varchar(50)")]
        public string educationJson { get; set; }
        [NotMapped]
        public List<Education> education
        {
            get => JsonConvert.DeserializeObject<List<Education>>(experienceJson);
            set => experienceJson = JsonConvert.SerializeObject(value);
        }
        //relationships
        public User user { get; set; }
    }
    public class Experience
    {
        public string workplace { get; set; }
        public DateTime from { get; set; }
        public DateTime to { get; set; }
        public string responsibilities { get; set; }
    }
    public class Education
    {
        public string field_of_study { get; set; }
        public string academic_title { get; set; }
        public string school { get; set; }
        public DateTime from { get; set; }
        public DateTime to { get; set; }
    }
}
