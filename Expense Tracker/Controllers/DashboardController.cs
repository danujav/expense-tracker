using Expense_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker
{
    public class DashboardController : Controller
    {

        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            // Last 7 Days Transactions
            DateTime StartDate = DateTime.Today.AddDays(-6);
            DateTime EndDate = DateTime.Today;

            List<Transaction> SelectedTransactions = await _context.Transactions
            .Include(x => x.Category)
            .Where(y => y.Date >= StartDate && y.Date <= EndDate)
            .ToListAsync();

            // Calculate Total Income Last 7 Days
            int TotalIncome = await _context.Transactions
            .Include(x => x.Category)
            .Where(i => i.Category.Type == "Income")
            .SumAsync(i => i.Amount);
            ViewBag.TotalIncome = TotalIncome.ToString("C0");

            // Calculate Total Expense Last 7 Days
            int TotalExpense = await _context.Transactions
            .Where(i => i.Category.Type == "Expense")
            .SumAsync(i => i.Amount);
            ViewBag.TotalExpense = TotalExpense.ToString("C0");

            // Balance
            int Balance = TotalIncome - TotalExpense;
            ViewBag.Balance = Balance.ToString("C0");


            // Recente 5 Transactions
            ViewBag.RecentTransactions = await _context.Transactions
            .Include(i => i.Category)
            .OrderByDescending(i => i.Date)
            .Take(5)
            .ToListAsync();


            return View();
        }
    }
}