using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using EducationCenterCRM.DAL.EF.Repositories;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.BLL.Services.Impl;
using EducationCenterCRM.BLL.Services.Interfaces;
using EducationCenterCRM.DAL;
using EducationCenterCRM.DAL.EF.Contexts;
using EducationCenterCRM.MVC.Configuration;
using EducationCenterCRM.MVC.Mapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace EducationCenterCRM.MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IEntityService<Student>, StudentService>();
            services.AddScoped<IRepository<Student>, StudentRepository>();
            services.AddScoped<IEntityService<Teacher>, TeacherService>();
            services.AddScoped<IRepository<Teacher>, BaseRepository<Teacher>>();
            services.AddScoped<IEntityService<StudentGroup>, StudentGroupService>();
            services.AddScoped<IRepository<StudentGroup>, StudentGroupRepository>();
            services.AddScoped<IEntityService<Course>, CourseService>();
            services.AddScoped<IRepository<Course>, CourseRepository>();
            services.AddScoped<IRepository<Topic>, BaseRepository<Topic>>();
            services.AddScoped<IEntityService<Topic>, EntityService<Topic>>();
            services.AddScoped<IEntityService<Lesson>, LessonService>();
            services.AddScoped<IRepository<Lesson>, LessonRepository>();
            services.AddControllersWithViews();

            // Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddControllersWithViews()
                .AddViewOptions(options => options.HtmlHelperOptions.ClientValidationEnabled = true);

            services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddDefaultUI()
                .AddEntityFrameworkStores<ApplicationContext>()
                .AddDefaultTokenProviders();

            services.AddMvc();
            services.AddRazorPages();

            services.Configure<SecurityOptions>(
                Configuration.GetSection(SecurityOptions.SectionTitle));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider, IOptions<SecurityOptions> securityOptions)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });
            CreateRoles(serviceProvider, securityOptions).Wait();
        }

        private async Task CreateRoles(IServiceProvider serviceProvider, IOptions<SecurityOptions> securityOptions)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            var roles = new[] { "admin", "manager", "student", "teacher" };


            foreach (var roleName in roles)
                await roleManager.CreateAsync(new IdentityRole
                {
                    Name = roleName,
                    NormalizedName = roleName.ToUpper()
                });

            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            var adminUser = await userManager.FindByEmailAsync(securityOptions.Value.AdminUserEmail);

            if (adminUser != null)
            {
                await userManager.AddToRoleAsync(adminUser, "ADMIN");
            }

            var managerUser = await userManager.FindByEmailAsync(Configuration["Security:ManagerUserEmail"]);

            if (managerUser != null)
            {
                await userManager.AddToRoleAsync(managerUser, "MANAGER");
            }
            
        }
    }
}
