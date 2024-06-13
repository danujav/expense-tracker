using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models;

public class Transaction
{
    [Key]
    public int TransactionId { set; get; }

    public int CategoryId {set; get; }
    public Category Category { set; get; }
    
    public int Amount { set; get; }
    
    [Column(TypeName = "varchar(75)")]
    public string? Note { set; get; }

    public DateTime Date { set; get; } = DateTime.Now;
}