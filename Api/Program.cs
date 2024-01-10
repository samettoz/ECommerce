
using Business.Abstract;
using Business.Concrete;
using Core.Repository;
using Core.Repository.EntityFramework;
using Dto.Response;
using DtoMapper;
using Entity;
using Entity.Abstract;
using Microsoft.OpenApi.Models;
using Model.Response;
using ModelMapper;
using Service.Context;
using Service.Services.Abstract;
using Service.Services.Concrete;
using System.Reflection;

namespace Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<IEntityRepositoryBase<Product>, EfEntityRepositoryBase<Product, ECommerceDbContext>>();
            builder.Services.AddSingleton<IProductService, ProductService>();
            builder.Services.AddSingleton<IProductBusiness, ProductBusiness>();

            builder.Services.AddSingleton<IEntityRepositoryBase<Brand>, EfEntityRepositoryBase<Brand, ECommerceDbContext>>();
            builder.Services.AddSingleton<IBrandService, BrandService>();
            builder.Services.AddSingleton<IBrandBusiness, BrandBusiness>();

            builder.Services.AddSingleton<IEntityRepositoryBase<Categorie>, EfEntityRepositoryBase<Categorie, ECommerceDbContext>>();
            builder.Services.AddSingleton<ICategorieService, CategorieService>();
            builder.Services.AddSingleton<ICategorieBusiness, CategorieBusiness>();

            builder.Services.AddSingleton<IEntityRepositoryBase<Order>, EfEntityRepositoryBase<Order, ECommerceDbContext>>();
            builder.Services.AddSingleton<IOrderService, OrderService>();
            builder.Services.AddSingleton<IOrderBusiness, OrderBusiness>();


            builder.Services.AddSingleton<IEntityRepositoryBase<Customer>, EfEntityRepositoryBase<Customer, ECommerceDbContext>>();
            builder.Services.AddSingleton<ICustomerService, CustomerService>();
            builder.Services.AddSingleton<ICustomerBusiness, CustomerBusiness>();

            builder.Services.AddSingleton<IEntityRepositoryBase<OrderDetail>, EfEntityRepositoryBase<OrderDetail, ECommerceDbContext>>();
            builder.Services.AddSingleton<IOrderDetailService, OrderDetailService>();
            builder.Services.AddSingleton<IOrderDetailBusiness, OrderDetailBusiness>();


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c => 
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API", Version = "v1" });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(options => 
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                    
                });
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}