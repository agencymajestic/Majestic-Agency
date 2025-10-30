using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class MajesticDbContext : DbContext
    {
        public MajesticDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<SubService> SubServices { get; set; }
        public DbSet<Order> Orders { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // This calls the base method, but does nothing
            // base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Service>().HasData(
              new Service { Id = 1, Name = "Brand & Design Services", Logo = "/assets/img/ServiceIcon1.png", ShortDescription = "Your brand is the face of your business. Includes all the many elements that define your corporate identity.", LongDescription = "We enable you to define your corporate identity by designing or developing your brand from stunning logos and warranties to core values and everything in between, investing in building a brand is how you prepare to connect with your target audience, we also cover a full range of branding services for business and projects of all sizes. Our dedicated team provides you with plans, guidelines, and research that are in line with the market and fit the core of your brand that your concept needs to communicate with. We also show you and your team how to maintain your brand design as it is an important part of all areas of your business.", BackgroundDetail = "/assets/img/portfolio/ServiceDetail1.png" },
              new Service { Id = 2, Name = "Digital Marketing Services", Logo = "/assets/img/ServiceIcon2.png", ShortDescription = "Digital marketing is the future. Therefore, we are building a complete and integrated digital environment.", LongDescription = "Digital marketing is by far the leading way to get your brand voice out there, gain exposure, and build a strong and loyal relationship with your customers. Creating and maintaining your presence on the digital environment with the right conversation, engaging content and creative design. We will help your brand shine and stay on top. The digital environment has captured the lives of most people out there. We not only do we increase your numbers, but we also aim to deliver substantial content closely related to your brand identity. Our professional team develops a high-quality marketing plan With strategic planning and our consulting expertise, we give life to your presence in the digital environment.", BackgroundDetail = "/assets/img/portfolio/ServiceDetail2.png" },
              new Service { Id = 3, Name = "Development Services", Logo = "/assets/img/ServiceIcon3.png", ShortDescription = "Your website is the digital face of your brand on the Internet, and your app is your brand in the palm of the user's hand.", LongDescription = "We understand the importance of taking your brand to the digital front and making sure it's ready for today's audiences so we bring you the latest web and mobile apps solutions that will help you shine in the digital environment. Our team can help you craft a stylish web or app design that fits your brand as we cover the full range of web and app design and development services, from creating a simple CMS, all the way to web and app maintenance.", BackgroundDetail = "/assets/img/portfolio/ServiceDetail3.png" },
              new Service { Id = 4, Name = "Production Services", Logo = "/assets/img/ServiceIcon4.png", ShortDescription = "Our philosophy in production is our common language by helping our clients achieve more success and progress.", LongDescription = "We offer you our wealth of experience, creative classiness and technical competence By highlighting your message and putting you first with our customized production services. Helping our clients succeed more through digital content films to animated shorts to high quality photos by captivating audiences, inspiring action & driving results. We constantly aim for true excellence on every project. It’s not about what we do, it’s about how we do it. We handle entire project from planning, excellent communication with everyone the final project execution with pride.", BackgroundDetail = "/assets/img/portfolio/ServiceDetail4.png" },
              new Service { Id = 5, Name = "Content Services", Logo = "/assets/img/ServiceIcon5.png", ShortDescription = "We provide all sorts of content by creating bold, clear, simple and error-free writing to meet your unique needs.", LongDescription = "We make content creation simple valuable, relevant, consistent and flexible, dependable content solutions to your needs, whatever industry you're in, to attract and retain your target audience. We provide everything from all types of content for blogs, landing pages, articles and websites to social media, newsletters, emails, videos, texts and more.", BackgroundDetail = "/assets/img/portfolio/ServiceDetail5.png" },
              new Service { Id = 6, Name = "Translation Services", Logo = "/assets/img/ServiceIcon6.png", ShortDescription = "Ability to communicate with a global audience through a professional linguist.", LongDescription = "Language is the method of communication, as we offer you the ability to communicate with the whole world through language translation of videos, social media, the web and a lot.", BackgroundDetail = "/assets/img/portfolio/ServiceDetail6.png" }
              );


              modelBuilder.Entity<SubService>().HasData(
              new SubService { Id = 1, Name = "Branding & Identity Design", ServiceId = 1 },
              new SubService { Id = 2, Name = "Rebranding & Identity Design", ServiceId = 1 },
              new SubService { Id = 3, Name = "Stationery Design & Production", ServiceId = 1 },
              new SubService { Id = 4, Name = "Product & Packaging Design", ServiceId = 1 },
              new SubService { Id = 5, Name = "Advertising Design", ServiceId = 1 },
              new SubService { Id = 6, Name = "Publication Design", ServiceId = 1 },
              new SubService { Id = 7, Name = "Characters & Mascots Design", ServiceId = 1 },

              new SubService { Id = 8, Name = "Digital Marketing Management", ServiceId = 2 },
              new SubService { Id = 9, Name = "Digital Marketing Strategy & Planning", ServiceId = 2 },
              new SubService { Id = 10, Name = "Search Engine Optimisation (SEO)", ServiceId = 2 },
              new SubService { Id = 11, Name = "Google Ads & Analytics", ServiceId = 2 },
              new SubService { Id = 12, Name = "Website & App Marketing", ServiceId = 2 },
              new SubService { Id = 13, Name = "Social Media Marketing", ServiceId = 2 },
              new SubService { Id = 14, Name = "Content Marketing", ServiceId = 2 },
              new SubService { Id = 15, Name = "Automation & Email Marketing", ServiceId = 2 },
              new SubService { Id = 16, Name = "Online Event Marketing", ServiceId = 2 },
              new SubService { Id = 17, Name = "Paid Media", ServiceId = 2 },


              new SubService { Id = 18, Name = "Web Strategy", ServiceId = 3 },
              new SubService { Id = 19, Name = "Website Design & Development", ServiceId = 3 },
              new SubService { Id = 20, Name = "Website Maintenance", ServiceId = 3 },
              new SubService { Id = 21, Name = "E-Commerce Website", ServiceId = 3 },
              new SubService { Id = 22, Name = "Government Website Services", ServiceId = 3 },
              new SubService { Id = 23, Name = "App Strategy", ServiceId = 3 },
              new SubService { Id = 24, Name = "App Design & Development", ServiceId = 3 },
              new SubService { Id = 25, Name = "App Maintenance", ServiceId = 3 },
              new SubService { Id = 26, Name = "E-Commerce App", ServiceId = 3 },
              new SubService { Id = 27, Name = "Government App Services", ServiceId = 3 },


              new SubService { Id = 28, Name = "Video Production Services", ServiceId = 4 },
              new SubService { Id = 29, Name = "Corporate Video Production", ServiceId = 4 },
              new SubService { Id = 30, Name = "Animation Videos", ServiceId = 4 },
              new SubService { Id = 31, Name = "Digital Media Videos", ServiceId = 4 },
              new SubService { Id = 32, Name = "Promotional & Commercials Videos", ServiceId = 4 },
              new SubService { Id = 33, Name = "Video Editing Services", ServiceId = 4 },
              new SubService { Id = 34, Name = "Event Coverage", ServiceId = 4 },
              new SubService { Id = 35, Name = "Screen Writing", ServiceId = 4 },
              new SubService { Id = 36, Name = "Photography", ServiceId = 4 },


              new SubService { Id = 37, Name = "Content Writing", ServiceId = 5 },
              new SubService { Id = 38, Name = "Copywriting", ServiceId = 5 },
              new SubService { Id = 39, Name = "Speech Writing", ServiceId = 5 },
              new SubService { Id = 40, Name = "Editing & Proofreading", ServiceId = 5 },


              new SubService { Id = 41, Name = "Media Translation", ServiceId = 6 },
              new SubService { Id = 42, Name = "Business Translation", ServiceId = 6 },
              new SubService { Id = 43, Name = "Financial Translation", ServiceId = 6 },
              new SubService { Id = 44, Name = "Technical Translations", ServiceId = 6 },
              new SubService { Id = 45, Name = "Website Content Translation", ServiceId = 6 }
              );

    }
    }

}
