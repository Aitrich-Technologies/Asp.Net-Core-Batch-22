using System.ComponentModel.DataAnnotations.Schema;

public partial class Resume
{

    public Guid Id { get; set; } = Guid.NewGuid();

    public string? Title { get; set; }

    public byte[]? File { get; set; }
    public Guid JobSeekerProfileId { get; set; }
    [ForeignKey("JobSeekerProfileId")]
    public virtual JobSeekerProfile JobSeekerProfile { get; set; } = null!;
    //public virtual ICollection<JobSeekerProfile> JobSeekerProfiles { get; set; } = new List<JobSeekerProfile>();

}