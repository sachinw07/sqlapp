using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sqlapp.Models;
using sqlapp;

namespace sqlapp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Customers> Customers; 
        public void OnGet()
        {
            CustomerService customerService = new CustomerService();
            Customers = customerService.GetCustomers();

        }
    }
}