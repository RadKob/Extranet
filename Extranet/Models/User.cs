using System.ComponentModel.DataAnnotations;

namespace Extranet.Models
{
    public class User
    {
        [Key]
        public int user_id {  get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string role { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime created_at { get; set; }
        public DateTime modifited_at { get; set; }
        public bool is_del { get; set; }
        public DateTime deleted_at { get; set; }
        public Profile profile { get; set; }
    }
}
