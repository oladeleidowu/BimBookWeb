using System;
using BimBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BimBookWeb.Data;

public class ApplicationDBContext:DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
}

