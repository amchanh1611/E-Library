using E_Library.BUS.BUS;
using E_Library.BUS.IBUS;
using E_Library.Models;
using E_Library.Repository.IRepository;
using E_Library.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<E_LibraryDbContext>(option => option.UseSqlServer("Data Source=DESKTOP-9GO1A8E\\SQLEXPRESS;Initial Catalog=ELibrary;Integrated Security=True;User Id=sa;Password=Chanh@0101"));
builder.Services.AddTransient<ISubjectRepository, SubjectRepository>();
builder.Services.AddTransient<IGetTotalSubject, GetTotalSubject>();
builder.Services.AddTransient<ISubjectBUS, SubjectBUS>();
builder.Services.AddTransient<ISubjectRepository, SubjectRepository>();
builder.Services.AddTransient<IDocumentBUS, DocumentBUS>();
builder.Services.AddTransient<IDocumentRepository, DocumentRepository>();
builder.Services.AddControllersWithViews().AddNewtonsoftJson(option => option.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();