using System;
using Microsoft.EntityFrameworkCore;
using quotable.api.models;

/// <summary>
///  The database context that provides access to document and other data.
/// </summary>
public class QuotableContext: DbContext
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="options"></param>
	public QuotableContext(DbContextOptions options): base(options)
	{

        public DbSet<Quote> Quote { get; set; }
	}
}
