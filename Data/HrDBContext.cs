using Microsoft.EntityFrameworkCore;

namespace hr.Data
{
  public class HrDBContext : DbContext
  {
    public HrDBContext(DbContextOptions options) : base(options) { }
  }
}