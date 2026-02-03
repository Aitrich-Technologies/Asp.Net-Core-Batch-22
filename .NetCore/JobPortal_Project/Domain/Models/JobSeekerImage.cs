using System.ComponentModel.DataAnnotations.Schema;

public class JobSeekerImage
{
    public Guid Id { get; set; } = Guid.NewGuid();

    // Original file name (e.g., "resume.jpg")
    public string FileName { get; set; }

    // MIME type (e.g., "image/jpeg", "image/png")
    public string ContentType { get; set; }

    // Actual image binary data
    public byte[] ImageData { get; set; }

    // Foreign key to JobSeekerProfile
    public Guid JobSeekerProfileId { get; set; }
    [ForeignKey("JobSeekerProfileId")]
    public virtual JobSeekerProfile JobSeekerProfile { get; set; } = null!;
}
