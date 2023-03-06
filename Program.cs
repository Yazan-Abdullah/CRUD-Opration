﻿using Microsoft.EntityFrameworkCore;
using WebAppCrudOperation.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//
builder.Services.AddDbContext<DBApplecationContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("ConnetionDb")));
// هيك انا ضفت السيرفيسيز الي بتربط بين الداتا بيس والابليكيشن
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employees}/{action=Index}/{id?}");

app.Run();
