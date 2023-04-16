using Microsoft.EntityFrameworkCore;
using Test_GSNR.Models;

namespace Test_GSNR.Data;

public class NotesDb : DbContext
{
	public NotesDb(DbContextOptions<NotesDb> options) : base(options) { }

	public DbSet<NoteItem> Notes { get; set; }
}
