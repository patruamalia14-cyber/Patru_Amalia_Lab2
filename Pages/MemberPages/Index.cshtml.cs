using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Patru_Amalia_Lab2.Models;
using Patru_Amalia_Lab2.Data;

namespace Patru_Amalia_Lab2.Pages.MemberPages;

public class IndexModel : PageModel
{
    private readonly Patru_Amalia_Lab2Context _context;

    public IndexModel(Patru_Amalia_Lab2Context context)
    {
        _context = context;
    }

    public IList<Member> Member { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Member = await _context.Member.ToListAsync();
    }
}
