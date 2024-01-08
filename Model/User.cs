using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpApi.Model
{
  [Table("users")]
  public class User
  {
    [Key]
    public int id { get; private set; }

    public string name { get; private set; }
    public string email { get; private set; }

    public User(string name, string email)
    {
      this.name = name ?? throw new ArgumentNullException(nameof(name));
      this.email = email ?? throw new ArgumentNullException(nameof(email));
    }
  }
}