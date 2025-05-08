using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXWebApplication1.Models {
    static class SampleData {
        public static List<SampleOrder> Orders = new List<SampleOrder>() {
            new SampleOrder {
                OrderID = 10248,
                OrderDate = new DateTime(1996, 7, 4),
                ShipCountry = "France",
                ShipCity = "Reims",
                CustomerName = "Paul Henriot"
            },
            new SampleOrder {
                OrderID = 10249,
                OrderDate = new DateTime(1996, 7, 5),
                ShipCountry = "Germany",
                ShipCity = "Münster",
                CustomerName = "Karin Josephs"
            },
            new SampleOrder {
                OrderID = 10250,
                OrderDate = new DateTime(1996, 7, 8),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Mario Pontes"
            },
            new SampleOrder {
                OrderID = 10251,
                OrderDate = new DateTime(1996, 7, 8),
                ShipCountry = "France",
                ShipCity = "Lyon",
                CustomerName = "Mary Saveley"
            },
            new SampleOrder {
                OrderID = 10252,
                OrderDate = new DateTime(1996, 7, 9),
                ShipCountry = "Belgium",
                ShipCity = "Charleroi",
                CustomerName = "Pascale Cartrain"
            },
            new SampleOrder {
                OrderID = 10253,
                OrderDate = new DateTime(1996, 7, 10),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Mario Pontes"
            },
            new SampleOrder {
                OrderID = 10254,
                OrderDate = new DateTime(1996, 7, 11),
                ShipCountry = "Switzerland",
                ShipCity = "Bern",
                CustomerName = "Yang Wang"
            },
            new SampleOrder {
                OrderID = 10255,
                OrderDate = new DateTime(1996, 7, 12),
                ShipCountry = "Switzerland",
                ShipCity = "Genève",
                CustomerName = "Michael Holz"
            },
            new SampleOrder {
                OrderID = 10256,
                OrderDate = new DateTime(1996, 7, 15),
                ShipCountry = "Brazil",
                ShipCity = "Resende",
                CustomerName = "Paula Parente"
            },
            new SampleOrder {
                OrderID = 10257,
                OrderDate = new DateTime(1996, 7, 16),
                ShipCountry = "Venezuela",
                ShipCity = "San Cristóbal",
                CustomerName = "Carlos Hernández"
            },
            new SampleOrder {
                OrderID = 10258,
                OrderDate = new DateTime(1996, 7, 17),
                ShipCountry = "Austria",
                ShipCity = "Graz",
                CustomerName = "Roland Mendel"
            },
            new SampleOrder {
                OrderID = 10259,
                OrderDate = new DateTime(1996, 7, 18),
                ShipCountry = "Mexico",
                ShipCity = "México D.F.",
                CustomerName = "Francisco Chang"
            },
            new SampleOrder {
                OrderID = 10260,
                OrderDate = new DateTime(1996, 7, 19),
                ShipCountry = "Germany",
                ShipCity = "Köln",
                CustomerName = "Henriette Pfalzheim"
            },
            new SampleOrder {
                OrderID = 10261,
                OrderDate = new DateTime(1996, 7, 19),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Bernardo Batista"
            },
            new SampleOrder {
                OrderID = 10262,
                OrderDate = new DateTime(1996, 7, 22),
                ShipCountry = "USA",
                ShipCity = "Albuquerque",
                CustomerName = "Paula Wilson"
            },
            new SampleOrder {
                OrderID = 10263,
                OrderDate = new DateTime(1996, 7, 23),
                ShipCountry = "Austria",
                ShipCity = "Graz",
                CustomerName = "Roland Mendel"
            },
            new SampleOrder {
                OrderID = 10264,
                OrderDate = new DateTime(1996, 7, 24),
                ShipCountry = "Sweden",
                ShipCity = "Bräcke",
                CustomerName = "Maria Larsson"
            },
            new SampleOrder {
                OrderID = 10265,
                OrderDate = new DateTime(1996, 7, 25),
                ShipCountry = "France",
                ShipCity = "Strasbourg",
                CustomerName = "Frédérique Citeaux"
            },
            new SampleOrder {
                OrderID = 10266,
                OrderDate = new DateTime(1996, 7, 26),
                ShipCountry = "Finland",
                ShipCity = "Oulu",
                CustomerName = "Pirkko Koskitalo"
            },
            new SampleOrder {
                OrderID = 10267,
                OrderDate = new DateTime(1996, 7, 29),
                ShipCountry = "Germany",
                ShipCity = "München",
                CustomerName = "Peter Franken"
            },
            new SampleOrder {
                OrderID = 10268,
                OrderDate = new DateTime(1996, 7, 30),
                ShipCountry = "Venezuela",
                ShipCity = "Caracas",
                CustomerName = "Manuel Pereira"
            },
            new SampleOrder {
                OrderID = 10269,
                OrderDate = new DateTime(1996, 7, 31),
                ShipCountry = "USA",
                ShipCity = "Seattle",
                CustomerName = "Karl Jablonski"
            },
            new SampleOrder {
                OrderID = 10270,
                OrderDate = new DateTime(1996, 8, 1),
                ShipCountry = "Finland",
                ShipCity = "Oulu",
                CustomerName = "Pirkko Koskitalo"
            },
            new SampleOrder {
                OrderID = 10271,
                OrderDate = new DateTime(1996, 8, 1),
                ShipCountry = "USA",
                ShipCity = "Lander",
                CustomerName = "Art Braunschweiger"
            },
            new SampleOrder {
                OrderID = 10272,
                OrderDate = new DateTime(1996, 8, 2),
                ShipCountry = "USA",
                ShipCity = "Albuquerque",
                CustomerName = "Paula Wilson"
            },
            new SampleOrder {
                OrderID = 10273,
                OrderDate = new DateTime(1996, 8, 5),
                ShipCountry = "Germany",
                ShipCity = "Cunewalde",
                CustomerName = "Horst Kloss"
            },
            new SampleOrder {
                OrderID = 10274,
                OrderDate = new DateTime(1996, 8, 6),
                ShipCountry = "France",
                ShipCity = "Reims",
                CustomerName = "Paul Henriot"
            },
            new SampleOrder {
                OrderID = 10275,
                OrderDate = new DateTime(1996, 8, 7),
                ShipCountry = "Italy",
                ShipCity = "Bergamo",
                CustomerName = "Giovanni Rovelli"
            },
            new SampleOrder {
                OrderID = 10276,
                OrderDate = new DateTime(1996, 8, 8),
                ShipCountry = "Mexico",
                ShipCity = "México D.F.",
                CustomerName = "Miguel Angel Paolino"
            },
            new SampleOrder {
                OrderID = 10277,
                OrderDate = new DateTime(1996, 8, 9),
                ShipCountry = "Germany",
                ShipCity = "Leipzig",
                CustomerName = "Alexander Feuer"
            },
            new SampleOrder {
                OrderID = 10278,
                OrderDate = new DateTime(1996, 8, 12),
                ShipCountry = "Sweden",
                ShipCity = "Luleå",
                CustomerName = "Christina Berglund"
            },
            new SampleOrder {
                OrderID = 10279,
                OrderDate = new DateTime(1996, 8, 13),
                ShipCountry = "Germany",
                ShipCity = "Frankfurt a.M.",
                CustomerName = "Renate Messner"
            },
            new SampleOrder {
                OrderID = 10280,
                OrderDate = new DateTime(1996, 8, 14),
                ShipCountry = "Sweden",
                ShipCity = "Luleå",
                CustomerName = "Christina Berglund"
            },
            new SampleOrder {
                OrderID = 10281,
                OrderDate = new DateTime(1996, 8, 14),
                ShipCountry = "Spain",
                ShipCity = "Madrid",
                CustomerName = "Alejandra Camino"
            },
            new SampleOrder {
                OrderID = 10282,
                OrderDate = new DateTime(1996, 8, 15),
                ShipCountry = "Spain",
                ShipCity = "Madrid",
                CustomerName = "Alejandra Camino"
            },
            new SampleOrder {
                OrderID = 10283,
                OrderDate = new DateTime(1996, 8, 16),
                ShipCountry = "Venezuela",
                ShipCity = "Barquisimeto",
                CustomerName = "Carlos González"
            },
            new SampleOrder {
                OrderID = 10284,
                OrderDate = new DateTime(1996, 8, 19),
                ShipCountry = "Germany",
                ShipCity = "Frankfurt a.M.",
                CustomerName = "Renate Messner"
            },
            new SampleOrder {
                OrderID = 10285,
                OrderDate = new DateTime(1996, 8, 20),
                ShipCountry = "Germany",
                ShipCity = "Cunewalde",
                CustomerName = "Horst Kloss"
            },
            new SampleOrder {
                OrderID = 10286,
                OrderDate = new DateTime(1996, 8, 21),
                ShipCountry = "Germany",
                ShipCity = "Cunewalde",
                CustomerName = "Horst Kloss"
            },
            new SampleOrder {
                OrderID = 10287,
                OrderDate = new DateTime(1996, 8, 22),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Janete Limeira"
            },
            new SampleOrder {
                OrderID = 10288,
                OrderDate = new DateTime(1996, 8, 23),
                ShipCountry = "Italy",
                ShipCity = "Reggio Emilia",
                CustomerName = "Maurizio Moroni"
            },
            new SampleOrder {
                OrderID = 10289,
                OrderDate = new DateTime(1996, 8, 26),
                ShipCountry = "UK",
                ShipCity = "London",
                CustomerName = "Victoria Ashworth"
            },
            new SampleOrder {
                OrderID = 10290,
                OrderDate = new DateTime(1996, 8, 27),
                ShipCountry = "Brazil",
                ShipCity = "Sao Paulo",
                CustomerName = "Pedro Afonso"
            },
            new SampleOrder {
                OrderID = 10291,
                OrderDate = new DateTime(1996, 8, 27),
                ShipCountry = "Brazil",
                ShipCity = "Rio de Janeiro",
                CustomerName = "Bernardo Batista"
            },
            new SampleOrder {
                OrderID = 10292,
                OrderDate = new DateTime(1996, 8, 28),
                ShipCountry = "Brazil",
                ShipCity = "Sao Paulo",
                CustomerName = "Anabela Domingues"
            },
            new SampleOrder {
                OrderID = 10293,
                OrderDate = new DateTime(1996, 8, 29),
                ShipCountry = "Mexico",
                ShipCity = "México D.F.",
                CustomerName = "Miguel Angel Paolino"
            },
            new SampleOrder {
                OrderID = 10294,
                OrderDate = new DateTime(1996, 8, 30),
                ShipCountry = "USA",
                ShipCity = "Albuquerque",
                CustomerName = "Paula Wilson"
            },
            new SampleOrder {
                OrderID = 10295,
                OrderDate = new DateTime(1996, 9, 2),
                ShipCountry = "France",
                ShipCity = "Reims",
                CustomerName = "Paul Henriot"
            },
            new SampleOrder {
                OrderID = 10296,
                OrderDate = new DateTime(1996, 9, 3),
                ShipCountry = "Venezuela",
                ShipCity = "Barquisimeto",
                CustomerName = "Carlos González"
            },
            new SampleOrder {
                OrderID = 10297,
                OrderDate = new DateTime(1996, 9, 4),
                ShipCountry = "France",
                ShipCity = "Strasbourg",
                CustomerName = "Frédérique Citeaux"
            }
        };
        public static List<WebsiteContent> Websites = new List<WebsiteContent>() {
            new WebsiteContent { Title = "Website Example 1", LogoUrl = "/images/logo1.png", Slogan = "The best example website", MainContent = "Welcome to Website Example 1!", HeaderLinks = new List<string> { "/home", "/about", "/contact" }, FooterLinks = new List<string> { "/privacy-policy", "/terms-of-service" }, MenuLinks = new List<string> { "/services", "/blog" }, SeoTitle = "Website Example 1 - Best Website", SeoDescription = "Example website", SeoKeywords = "example, website, best" },
            new WebsiteContent { Title = "Website Example 2", LogoUrl = "/images/logo2.png", Slogan = "Your trusted source", MainContent = "Welcome to Website Example 2!", HeaderLinks = new List<string> { "/home", "/about-us", "/support" }, FooterLinks = new List<string> { "/privacy-policy", "/terms" }, MenuLinks = new List<string> { "/portfolio", "/services" }, SeoTitle = "Website Example 2 - Trusted Source", SeoDescription = "Reliable website", SeoKeywords = "trusted, source, information" },
            new WebsiteContent { Title = "Website Example 3", LogoUrl = "/images/logo3.png", Slogan = "Innovation at its best", MainContent = "Welcome to Website Example 3!", HeaderLinks = new List<string> { "/home", "/about", "/products" }, FooterLinks = new List<string> { "/terms-of-use", "/privacy" }, MenuLinks = new List<string> { "/shop", "/contact" }, SeoTitle = "Website Example 3 - Innovation", SeoDescription = "Innovative website", SeoKeywords = "innovation, best, products" },
            new WebsiteContent { Title = "Website Example 4", LogoUrl = "/images/logo4.png", Slogan = "Your one-stop shop", MainContent = "Welcome to Website Example 4!", HeaderLinks = new List<string> { "/home", "/about-us", "/contact" }, FooterLinks = new List<string> { "/terms", "/privacy" }, MenuLinks = new List<string> { "/shop", "/services" }, SeoTitle = "Website Example 4 - One-Stop Shop", SeoDescription = "E-commerce platform", SeoKeywords = "shop, one-stop, services" },
            new WebsiteContent { Title = "Website Example 5", LogoUrl = "/images/logo5.png", Slogan = "Leading the way", MainContent = "Welcome to Website Example 5!", HeaderLinks = new List<string> { "/home", "/about", "/products" }, FooterLinks = new List<string> { "/terms-of-service", "/privacy-policy" }, MenuLinks = new List<string> { "/shop", "/blog" }, SeoTitle = "Website Example 5 - Leading", SeoDescription = "Leading website", SeoKeywords = "leading, products, shop" },
            new WebsiteContent { Title = "Website Example 6", LogoUrl = "/images/logo6.png", Slogan = "Connecting people", MainContent = "Welcome to Website Example 6!", HeaderLinks = new List<string> { "/home", "/contact", "/about" }, FooterLinks = new List<string> { "/privacy", "/terms" }, MenuLinks = new List<string> { "/services", "/portfolio" }, SeoTitle = "Website Example 6 - Connection", SeoDescription = "Social platform", SeoKeywords = "connecting, social, people" },
            new WebsiteContent { Title = "Website Example 7", LogoUrl = "/images/logo7.png", Slogan = "Innovate your business", MainContent = "Welcome to Website Example 7!", HeaderLinks = new List<string> { "/home", "/about", "/contact" }, FooterLinks = new List<string> { "/terms", "/privacy-policy" }, MenuLinks = new List<string> { "/services", "/blog" }, SeoTitle = "Website Example 7 - Innovation", SeoDescription = "Innovative business solutions", SeoKeywords = "business, innovation, solutions" },
            new WebsiteContent { Title = "Website Example 8", LogoUrl = "/images/logo8.png", Slogan = "Explore new horizons", MainContent = "Welcome to Website Example 8!", HeaderLinks = new List<string> { "/home", "/about-us", "/portfolio" }, FooterLinks = new List<string> { "/privacy-policy", "/terms-of-service" }, MenuLinks = new List<string> { "/shop", "/contact" }, SeoTitle = "Website Example 8 - Explore", SeoDescription = "Exploration platform", SeoKeywords = "explore, horizons, new" },
            new WebsiteContent { Title = "Website Example 9", LogoUrl = "/images/logo9.png", Slogan = "Where ideas grow", MainContent = "Welcome to Website Example 9!", HeaderLinks = new List<string> { "/home", "/about", "/services" }, FooterLinks = new List<string> { "/terms-of-use", "/privacy" }, MenuLinks = new List<string> { "/portfolio", "/blog" }, SeoTitle = "Website Example 9 - Ideas", SeoDescription = "Creative platform", SeoKeywords = "ideas, creativity, innovation" },
            new WebsiteContent { Title = "Website Example 10", LogoUrl = "/images/logo10.png", Slogan = "Make your mark", MainContent = "Welcome to Website Example 10!", HeaderLinks = new List<string> { "/home", "/contact", "/about-us" }, FooterLinks = new List<string> { "/privacy-policy", "/terms" }, MenuLinks = new List<string> { "/services", "/shop" }, SeoTitle = "Website Example 10 - Make Your Mark", SeoDescription = "Make your mark in the world", SeoKeywords = "make your mark, business, services" },
            new WebsiteContent { Title = "Website Example 11", LogoUrl = "/images/logo11.png", Slogan = "The world at your fingertips", MainContent = "Welcome to Website Example 11!", HeaderLinks = new List<string> { "/home", "/about-us", "/contact" }, FooterLinks = new List<string> { "/terms-of-service", "/privacy-policy" }, MenuLinks = new List<string> { "/portfolio", "/blog" }, SeoTitle = "Website Example 11 - World at Your Fingertips", SeoDescription = "Explore the world online", SeoKeywords = "world, explore, fingertips" },
            new WebsiteContent { Title = "Website Example 12", LogoUrl = "/images/logo12.png", Slogan = "Empowering your future", MainContent = "Welcome to Website Example 12!", HeaderLinks = new List<string> { "/home", "/about-us", "/services" }, FooterLinks = new List<string> { "/terms-of-use", "/privacy" }, MenuLinks = new List<string> { "/shop", "/contact" }, SeoTitle = "Website Example 12 - Empowering", SeoDescription = "Empower your business", SeoKeywords = "empower, future, business" },
            new WebsiteContent { Title = "Website Example 13", LogoUrl = "/images/logo13.png", Slogan = "Innovation leads the way", MainContent = "Welcome to Website Example 13!", HeaderLinks = new List<string> { "/home", "/about", "/products" }, FooterLinks = new List<string> { "/privacy-policy", "/terms-of-service" }, MenuLinks = new List<string> { "/blog", "/contact" }, SeoTitle = "Website Example 13 - Innovation Leads", SeoDescription = "Innovative platform", SeoKeywords = "innovation, leads, platform" },
            new WebsiteContent { Title = "Website Example 14", LogoUrl = "/images/logo14.png", Slogan = "Transform your business", MainContent = "Welcome to Website Example 14!", HeaderLinks = new List<string> { "/home", "/about-us", "/services" }, FooterLinks = new List<string> { "/terms", "/privacy-policy" }, MenuLinks = new List<string> { "/portfolio", "/contact" }, SeoTitle = "Website Example 14 - Transform", SeoDescription = "Business transformation", SeoKeywords = "transform, business, services" },
            new WebsiteContent { Title = "Website Example 15", LogoUrl = "/images/logo15.png", Slogan = "Experience the difference", MainContent = "Welcome to Website Example 15!", HeaderLinks = new List<string> { "/home", "/about", "/blog" }, FooterLinks = new List<string> { "/terms", "/privacy-policy" }, MenuLinks = new List<string> { "/shop", "/services" }, SeoTitle = "Website Example 15 - Experience", SeoDescription = "A website like no other", SeoKeywords = "experience, difference, website" },
            // Tiếp tục gán thêm dữ liệu...
        };

    }
}
