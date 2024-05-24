using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities;

[Table("Photos")]
//overwrites the table name in the database - without it the name would be "Photo"
public class Photo
{
    public int Id { get; set; }
    public string Url { get; set; }
    public bool IsMain { get; set; }
    public string PublicId { get; set; }

    //relationship property
    //fully defined relationship
    public int AppUserId { get; set; }
    public AppUser AppUser { get; set; }
}
