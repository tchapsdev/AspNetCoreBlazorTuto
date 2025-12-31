using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorTuto.Models
{
    [Table("Person", Schema = "Person")]
    public class Person
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }

        /// <summary>
        /// Person type code (e.g., 'EM', 'GC', etc.). nchar(2) NOT NULL.
        /// </summary>
        [Required]
        [Column(TypeName = "nchar(2)")]
        [MaxLength(2)]
        public string PersonType { get; set; } = null!;

        /// <summary>
        /// Whether the name is formatted in a style compatible with certain locales. bit NOT NULL.
        /// </summary>
        [Required]
        public bool NameStyle { get; set; }

        /// <summary>
        /// Courtesy title (e.g., 'Mr.', 'Ms.'). nvarchar(8) NULL.
        /// </summary>
        [MaxLength(8)]
        public string? Title { get; set; }

        /// <summary>
        /// First name. dbo.Name (assumed nvarchar(50)) NOT NULL.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = null!;

        /// <summary>
        /// Middle name. dbo.Name (assumed nvarchar(50)) NULL.
        /// </summary>
        [MaxLength(50)]
        public string? MiddleName { get; set; }

        /// <summary>
        /// Last name. dbo.Name (assumed nvarchar(50)) NOT NULL.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = null!;

        /// <summary>
        /// Name suffix (e.g., 'Jr.', 'III'). nvarchar(10) NULL.
        /// </summary>
        [MaxLength(10)]
        public string? Suffix { get; set; }

        /// <summary>
        /// Email promotion preference. int NOT NULL.
        /// </summary>
        [Required]
        public int EmailPromotion { get; set; }

        /// <summary>
        /// Additional contact info as XML with schema collection. xml NULL.
        /// Map as string; consider XElement with EF Core value converter if needed.
        /// </summary>
        [Column(TypeName = "xml")]
        public string? AdditionalContactInfo { get; set; }

        /// <summary>
        /// Demographics survey data as XML with schema collection. xml NULL.
        /// </summary>
        [Column(TypeName = "xml")]
        public string? Demographics { get; set; }

        /// <summary>
        /// Row GUID (ROWGUIDCOL). uniqueidentifier NOT NULL.
        /// </summary>
        [Required]
        public Guid RowGuid { get; set; }

        /// <summary>
        /// Last modified timestamp. datetime NOT NULL.
        /// </summary>
        [Required]
        public DateTime ModifiedDate { get; set; }
    }
}