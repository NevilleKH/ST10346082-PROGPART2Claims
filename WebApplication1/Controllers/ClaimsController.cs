using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.Entities;

namespace WebApplication1.Controllers
{
    public class ClaimsController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public ClaimsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddClaimViewModel viewModel)
        {
            var claim = new Claim
            {
                Id = viewModel.Id,
                FullName = viewModel.FullName,
                HoursWorked = viewModel.HoursWorked,
                HourlyRate = viewModel.HourlyRate,
                TotalAmount = viewModel.TotalAmount,
                ClaimStatus = viewModel.ClaimStatus,
            };
            await dbContext.Claims.AddAsync(claim);
            await dbContext.SaveChangesAsync();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var claims = await dbContext.Claims.ToListAsync();

            return View(claims);

        }

        [HttpGet]
        public async Task<IActionResult> ClaimsStatus()
        {
            var claims = await dbContext.Claims.ToListAsync();

            return View(claims);

        }

        [HttpGet]
        public async Task<IActionResult> Accepted(int id)
        {
            var claim = await dbContext.Claims.FindAsync(id);

            if(claim != null)
            {
                claim.ClaimStatus = "Approved";
                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("ClaimsStatus");
        }

        [HttpGet]
        public async Task<IActionResult> Denied(int id)
        {
            var claim = await dbContext.Claims.FindAsync(id);

            if (claim != null)
            {
                claim.ClaimStatus = "Rejected";
                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("ClaimsStatus");
        }




    }

    
}
