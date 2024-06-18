using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Expense_Tracker.Models;

public class Category
{
    [Key] public int CategoryId { get; set; }

    [Column(TypeName = "varchar(50)")] public string Title { set; get; }

    [Column(TypeName = "varchar(5)")] public string Icon { set; get; } = "";

    [Column(TypeName = "varchar(10)")]
    public string Type { set; get; } = "Expense";

    [NotMapped]
    public string TitleWithIcon
    {
        get
        {
            return this.Icon + " " + this.Title;
        }
    }
}