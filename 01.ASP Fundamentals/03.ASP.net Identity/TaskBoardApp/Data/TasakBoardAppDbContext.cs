﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskBoardApp.Data.Configurations;
using TaskBoardApp.Data.Models;
using Task = TaskBoardApp.Data.Models.Task;

namespace TaskBoardApp.Data
{
    public class TasakBoardAppDbContext : IdentityDbContext
    {
        public TasakBoardAppDbContext(DbContextOptions<TasakBoardAppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new BoardConfiguration());
            builder.ApplyConfiguration(new TaskConfiguration());

            base.OnModelCreating(builder);
        }
        public DbSet<Task> Tasks { get; set; }

        public DbSet<Board> Boards { get; set; } 
    }
}
