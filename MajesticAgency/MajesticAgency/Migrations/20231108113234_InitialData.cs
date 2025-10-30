using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MajesticAgency.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackgroundDetail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProblemDomainOfProject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Budget = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timeline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExampleWebsiteURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discover = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Services_ServiceId1",
                        column: x => x.ServiceId1,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "BackgroundDetail", "Logo", "LongDescription", "Name", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "/assets/img/portfolio/ServiceDetail1.png", "/assets/img/ServiceIcon1.png", "We enable you to define your corporate identity by designing or developing your brand from stunning logos and warranties to core values and everything in between, investing in building a brand is how you prepare to connect with your target audience, we also cover a full range of branding services for business and projects of all sizes. Our dedicated team provides you with plans, guidelines, and research that are in line with the market and fit the core of your brand that your concept needs to communicate with. We also show you and your team how to maintain your brand design as it is an important part of all areas of your business.", "Brand & Design Services", "Your brand is the face of your business. Includes all the many elements that define your corporate identity." },
                    { 2, "/assets/img/portfolio/ServiceDetail2.png", "/assets/img/ServiceIcon2.png", "Digital marketing is by far the leading way to get your brand voice out there, gain exposure, and build a strong and loyal relationship with your customers. Creating and maintaining your presence on the digital environment with the right conversation, engaging content and creative design. We will help your brand shine and stay on top. The digital environment has captured the lives of most people out there. We not only do we increase your numbers, but we also aim to deliver substantial content closely related to your brand identity. Our professional team develops a high-quality marketing plan With strategic planning and our consulting expertise, we give life to your presence in the digital environment.", "Digital Marketing Services", "Digital marketing is the future. Therefore, we are building a complete and integrated digital environment." },
                    { 3, "/assets/img/portfolio/ServiceDetail3.png", "/assets/img/ServiceIcon3.png", "We understand the importance of taking your brand to the digital front and making sure it's ready for today's audiences so we bring you the latest web and mobile apps solutions that will help you shine in the digital environment. Our team can help you craft a stylish web or app design that fits your brand as we cover the full range of web and app design and development services, from creating a simple CMS, all the way to web and app maintenance.", "Development Services", "Your website is the digital face of your brand on the Internet, and your app is your brand in the palm of the user's hand." },
                    { 4, "/assets/img/portfolio/ServiceDetail4.png", "/assets/img/ServiceIcon4.png", "We offer you our wealth of experience, creative classiness and technical competence By highlighting your message and putting you first with our customized production services. Helping our clients succeed more through digital content films to animated shorts to high quality photos by captivating audiences, inspiring action & driving results. We constantly aim for true excellence on every project. It’s not about what we do, it’s about how we do it. We handle entire project from planning, excellent communication with everyone the final project execution with pride.", "Production Services", "Our philosophy in production is our common language by helping our clients achieve more success and progress." },
                    { 5, "/assets/img/portfolio/ServiceDetail5.png", "/assets/img/ServiceIcon5.png", "We make content creation simple valuable, relevant, consistent and flexible, dependable content solutions to your needs, whatever industry you're in, to attract and retain your target audience. We provide everything from all types of content for blogs, landing pages, articles and websites to social media, newsletters, emails, videos, texts and more.", "Content Services", "We provide all sorts of content by creating bold, clear, simple and error-free writing to meet your unique needs." },
                    { 6, "/assets/img/portfolio/ServiceDetail6.png", "/assets/img/ServiceIcon6.png", "Language is the method of communication, as we offer you the ability to communicate with the whole world through language translation of videos, social media, the web and a lot.", "Translation Services", "Ability to communicate with a global audience through a professional linguist." }
                });

            migrationBuilder.InsertData(
                table: "SubServices",
                columns: new[] { "Id", "Name", "ServiceId" },
                values: new object[,]
                {
                    { 1, "Branding & Identity Design", 1 },
                    { 2, "Rebranding & Identity Design", 1 },
                    { 3, "Stationery Design & Production", 1 },
                    { 4, "Product & Packaging Design", 1 },
                    { 5, "Advertising Design", 1 },
                    { 6, "Publication Design", 1 },
                    { 7, "Characters & Mascots Design", 1 },
                    { 8, "Digital Marketing Management", 2 },
                    { 9, "Digital Marketing Strategy & Planning", 2 },
                    { 10, "Search Engine Optimisation (SEO)", 2 },
                    { 11, "Google Ads & Analytics", 2 },
                    { 12, "Website & App Marketing", 2 },
                    { 13, "Social Media Marketing", 2 },
                    { 14, "Content Marketing", 2 },
                    { 15, "Automation & Email Marketing", 2 },
                    { 16, "Online Event Marketing", 2 },
                    { 17, "Paid Media", 2 },
                    { 18, "Web Strategy", 3 },
                    { 19, "Website Design & Development", 3 },
                    { 20, "Website Maintenance", 3 },
                    { 21, "E-Commerce Website", 3 },
                    { 22, "Government Website Services", 3 },
                    { 23, "App Strategy", 3 },
                    { 24, "App Design & Development", 3 },
                    { 25, "App Maintenance", 3 },
                    { 26, "E-Commerce App", 3 },
                    { 27, "Government App Services", 3 },
                    { 28, "Video Production Services", 4 },
                    { 29, "Corporate Video Production", 4 },
                    { 30, "Animation Videos", 4 },
                    { 31, "Digital Media Videos", 4 },
                    { 32, "Promotional & Commercials Videos", 4 },
                    { 33, "Video Editing Services", 4 },
                    { 34, "Event Coverage", 4 },
                    { 35, "Screen Writing", 4 },
                    { 36, "Photography", 4 },
                    { 37, "Content Writing", 5 },
                    { 38, "Copywriting", 5 },
                    { 39, "Speech Writing", 5 },
                    { 40, "Editing & Proofreading", 5 },
                    { 41, "Media Translation", 6 },
                    { 42, "Business Translation", 6 }
                });

            migrationBuilder.InsertData(
                table: "SubServices",
                columns: new[] { "Id", "Name", "ServiceId" },
                values: new object[] { 43, "Financial Translation", 6 });

            migrationBuilder.InsertData(
                table: "SubServices",
                columns: new[] { "Id", "Name", "ServiceId" },
                values: new object[] { 44, "Technical Translations", 6 });

            migrationBuilder.InsertData(
                table: "SubServices",
                columns: new[] { "Id", "Name", "ServiceId" },
                values: new object[] { 45, "Website Content Translation", 6 });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ServiceId1",
                table: "Orders",
                column: "ServiceId1");

            migrationBuilder.CreateIndex(
                name: "IX_SubServices_ServiceId",
                table: "SubServices",
                column: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "SubServices");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
