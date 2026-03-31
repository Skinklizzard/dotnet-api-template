using Microsoft.EntityFrameworkCore;

namespace __NAMESPACE__.Data
{
public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}
}
}