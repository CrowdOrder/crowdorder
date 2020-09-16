using CrowdOrder.beta.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Data
{
    public class DbInitialiser
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any existing data.
            if (context.Categorys.Any())
            {
                return;   // DB has been seeded
            }

            context.Categorys.AddRange(CategoryBaseData());
            context.SaveChanges();
            StaticPartnersData.Create(context);
        }


        private static List<Category> CategoryBaseData()
        {
            var data = new List<Category>()
            {
                new Category()
                {
                    Name = "Marketing Services",
                    Url = "marketing-services-offers-discounts",
                    Title = "Marketing Services, Offers and Discounts",
                    MetaDescription = "Got a great product but don't know how to get it in front of customers? Get your business known with the marketing services offered by our partners.",
                    H1 = "Marketing Services, Offers and Discounts",
                    Body = "Got a great product but don't know how to get it in front of customers? Get your business known with the marketing services offered by our partners.",
                    SubCategories = new List<SubCategory>()
                    {
                        new SubCategory()
                        {
                            Name="SEO Services",
                            Url = "marketing-services-offers-discounts/SEO",
                            Title = "SEO Services, Offers and Discounts",
                            MetaDescription = "Do you want your business to be found on Google for relevant keywords? Improve your SEO with our carefully selected partners.",
                            H1 = "SEO Services, Offers and Discounts",
                            Body = "Do you want your business to be found on Google for relevant keywords? Improve your SEO with our carefully selected partners."
                        },
                        new SubCategory()
                        {
                            Name="Email Marketing Services",
                            Url = "marketing-services-offers-discounts/email-marketing",
                            Title = "Email Marketing Services, Offers and Discounts",
                            MetaDescription = "Do you have a large customer database but don't know how to put together an effective email marketing strategy? Work with one of our Email Marketing specialists to get your brand in front of your customers.",
                            H1 = "Email Marketing Services, Offers and Discounts",
                            Body = "Do you have a large customer database but don't know how to put together an effective email marketing strategy? Work with one of our Email Marketing specialists to get your brand in front of your customers."
                        },
                        new SubCategory()
                        {
                            Name="SEM/PPC Services",
                            Url = "marketing-services-offers-discounts/SEM-PPC",
                            Title = "SEM/PPC Services, Offers and Discounts",
                            MetaDescription = "Paid advertising on Google can be extremely effective for growing businesses. Take a look at our carefully selected PPC/SEM partners here.",
                            H1 = "SEM/PPC Services, Offers and Discounts",
                            Body = "Paid advertising on Google can be extremely effective for growing businesses. Take a look at our carefully selected PPC/SEM partners here."
                        },
                        new SubCategory()
                        {
                            Name="Content Marketing Services",
                            Url = "marketing-services-offers-discounts/content-marketing",
                            Title = "Content Marketing Services, Offers and Discounts",
                            MetaDescription = "Content Marketing is a great way to build brand awareness through content. Work with our partners to get your company seen online.",
                            H1 = "Content Marketing Services, Offers and Discounts",
                            Body = "Content Marketing is a great way to build brand awareness through content. Work with our partners to get your company seen online."
                        },
                        new SubCategory()
                        {
                            Name="Social Media and Influencer Marketing Services",
                            Url = "marketing-services-offers-discounts/social-media-influencer-marketing",
                            Title = "Social Media and Influencer Marketing Services, Offers and Discounts",
                            MetaDescription = "Want to grow your social media following and get influencers to promote your business? Take a look at our Social Media partners services here.",
                            H1 = "Social Media and Influencer Marketing Services, Offers and Discounts",
                            Body = "Want to grow your social media following and get influencers to promote your business? Take a look at our Social Media partners services here."
                        },
                        new SubCategory()
                        {
                            Name="Video Marketing Services",
                            Url = "marketing-services-offers-discounts/video-marketing",
                            Title = "Video Marketing Services, Offers and Discounts",
                            MetaDescription = "Do you need a fancy new video to promote your business? Look no further than our Video Marketing partners.",
                            H1 = "Video Marketing Services, Offers and Discounts",
                            Body = "Do you need a fancy new video to promote your business? Look no further than our Video Marketing partners."
                        },
                        new SubCategory()
                        {
                            Name="Podcast and Voice Marketing Services",
                            Url = "marketing-services-offers-discounts/podcast-voice-marketing",
                            Title = "Podcast and Voice Marketing Services, Offers and Discounts",
                            MetaDescription = "Do you want to start a podcast for your business or utilise voice marketing in your strategies? Work with one of our partners to help devleop your strategy.",
                            H1 = "Podcast and Voice Marketing Services, Offers and Discounts",
                            Body = "Do you want to start a podcast for your business or utilise voice marketing in your strategies? Work with one of our partners to help devleop your strategy."
                        },
                        new SubCategory()
                        {
                            Name="CRM Services",
                            Url = "marketing-services-offers-discounts/CRM",
                            Title = "CRM Services, Offers and Discounts",
                            MetaDescription = "Retaining customer data is so important in today's world for businesses. Find the best solutions here with our carefully selected partners.",
                            H1 = "CRM Services, Offers and Discounts",
                            Body = "Retaining customer data is so important in today's world for businesses. Find the best solutions here with our carefully selected partners."
                        },
                    }
                },
                new Category()
                {
                    Name = "Financial and Accountancy Services",
                    Url = "financial-accountancy-offers-discounts",
                    Title = "Financial and Accountancy Services, Offers and Discounts",
                    MetaDescription = "Need assistance with the finances of your business? Check out the services offered by our partners ranging from bookkeeping to banking.",
                    H1 = "Financial and Accountancy Services, Offers and Discounts",
                    Body = "Need assistance with the finances of your business? Check out the services offered by our partners ranging from bookkeeping to banking.",
                    SubCategories = new List<SubCategory>()
                    {
                        new SubCategory()
                        {
                            Name = "Accounting and Bookkeeping Services",
                            Url = "financial-accountancy-offers-discounts/accounting-bookkeeping",
                            Title = "Accounting and Bookkeeping Services, Offers and Discounts",
                            MetaDescription = "Need help keeping on top of your accounts and finances? Check out our top accounting and bookkeeping partners here.",
                            H1 = "Accounting and Bookkeeping Services, Offers and Discounts",
                            Body = "Need help keeping on top of your accounts and finances? Check out our top accounting and bookkeeping partners here."
                        },
                        new SubCategory()
                        {
                            Name = "Business and Investment Banking Services",
                            Url = "financial-accountancy-offers-discounts/business-investment-banking",
                            Title = "Business and Investment Banking Services, Offers and Discounts",
                            MetaDescription = "Need banking and investment services your business? Check out our Business and Investment Banking Services partners here.",
                            H1 = "Business and Investment Banking Services, Offers and Discounts",
                            Body = "Need banking and investment services your business? Check out our Business and Investment Banking Services partners here."
                        },
                        new SubCategory()
                        {
                            Name = "Funds and Investment Services",
                            Url = "financial-accountancy-offers-discounts/funds-investment",
                            Title = "Funds and Investment Services, Offers and Discounts",
                            MetaDescription = "Need further investment to grow your business? Check out our Funds and Investment partners here.",
                            H1 = "Funds and Investment Services, Offers and Discounts",
                            Body = "Need further investment to grow your business? Check out our Funds and Investment partners here."
                        },
                        new SubCategory()
                        {
                            Name = "Insurance Services",
                            Url = "financial-accountancy-offers-discounts/insurance",
                            Title = "Insurance Services, Offers and Discounts",
                            MetaDescription = "It's so important to protect your business with insurance. Get piece of mind with our business insurance partners here.",
                            H1 = "Insurance Services, Offers and Discounts",
                            Body = "It's so important to protect your business with insurance. Get piece of mind with our business insurance partners here."
                        },
                        new SubCategory()
                        {
                            Name = "Life Assurance and Pension Services",
                            Url = "financial-accountancy-offers-discounts/life-assurance-pension",
                            Title = "Life Assurance and Pension Services, Offers and Discounts",
                            MetaDescription = "Do you need financial advice for your business? Our Regulated Advice partners can steer you in the right direction.",
                            H1 = "Life Assurance and Pension Services, Offers and Discounts",
                            Body = "Do you need financial advice for your business? Our Regulated Advice partners can steer you in the right direction."
                        },
                        new SubCategory()
                        {
                            Name = "Regulated Advice Services",
                            Url = "financial-accountancy-offers-discounts/regulated-advice",
                            Title = "Regulated Advice Services, Offers and Discounts",
                            MetaDescription = "Do you need Life Assurance and Pension Services for your business? Our partners can steer you in the right direction.",
                            H1 = "Regulated Advice Services, Offers and Discounts",
                            Body = "Do you need Life Assurance and Pension Services for your business? Our partners can steer you in the right direction."
                        },
                    }
                },
                new Category()
                {
                    Name = "IT Services",
                    Url = "it-services-offers-discounts",
                    Title = "IT Services, Offers and Discounts",
                    MetaDescription = "Is IT essential to keeping your business running? Ensure your business IT runs smoothly with our IT services partners.",
                    H1 = "IT Services, Offers and Discounts",
                    Body = "Is IT essential to keeping your business running? Ensure your business IT runs smoothly with our IT services partners.",
                    SubCategories = new List<SubCategory>()
                    {
                        new SubCategory()
                        { 
                            Name = "IT Network and Infrastructure Services",
                            Url = "it-services-offers-discounts/it-network-infrastructure",
                            Title = "IT Network and Infrastructure Services, Offers and Discounts",
                            MetaDescription = "Ensuring your IT is set up correctly is pivotal for any small business. Get your IT running like clockwork with our IT Network and Infrastructure partners.",
                            H1 = "IT Network and Infrastructure Services, Offers and Discounts",
                            Body = "Ensuring your IT is set up correctly is pivotal for any small business. Get your IT running like clockwork with our IT Network and Infrastructure partners."
                        },
                        new SubCategory()
                        {
                            Name = "Cybersecurity Services",
                            Url = "it-services-offers-discounts/cybersecurity",
                            Title = "Cybersecurity Services, Offers and Discounts",
                            MetaDescription = "It's never been more important to take measures to protect your business. Our Cybersecurity partners can keep your business safe.",
                            H1 = "Cybersecurity Services, Offers and Discounts",
                            Body = "It's never been more important to take measures to protect your business. Our Cybersecurity partners can keep your business safe."
                        },
                        new SubCategory()
                        {
                            Name = "Cloud-Based IT Services",
                            Url = "it-services-offers-discounts/cloud-based-it",
                            Title = "Cloud-Based IT Services, Offers and Discounts",
                            MetaDescription = "To keep your business agile you may want to invest in Cloud-based services. Find the best in the business here.",
                            H1 = "Cloud-Based IT Services, Offers and Discounts",
                            Body = "To keep your business agile you may want to invest in Cloud-based services. Find the best in the business here."
                        },
                        new SubCategory()
                        {
                            Name = "Database and Data Storage Services",
                            Url = "it-services-offers-discounts/database-data-storage",
                            Title = "Database and Data Storage Services, Offers and Discounts",
                            MetaDescription = "Data is the new oil. Find the best data solutions with our great partners here.",
                            H1 = "Database and Data Storage Services, Offers and Discounts",
                            Body = "Data is the new oil. Find the best data solutions with our great partners here."
                        },
                        new SubCategory()
                        {
                            Name = "Technical Support Services",
                            Url = "it-services-offers-discounts/technical-support",
                            Title = "Technical Support Services, Offers and Discounts",
                            MetaDescription = "Does your business need support when it comes to IT? Outsource your IT Support Services with our partners.",
                            H1 = "Technical Support Services, Offers and Discounts",
                            Body = "Does your business need support when it comes to IT? Outsource your IT Support Services with our partners."
                        },
                        new SubCategory()
                        {
                            Name = "Quality Assurance Services",
                            Url = "it-services-offers-discounts/quality-assurance-qa",
                            Title = "Quality Assurance Services, Offers and Discounts",
                            MetaDescription = "Does your business need support when it comes to Quality Assurance services? Outsource your Quality Assurance Services with our partners.",
                            H1 = "Quality Assurance Services, Offers and Discounts",
                            Body = "Does your business need support when it comes to Quality Assurance services? Outsource your Quality Assurance Services with our partners."
                        }
                    }
                },
                new Category()
                {
                    Name = "Web Design and Development Services",
                    Url = "web-design-development-services-offers-discounts",
                    Title = "Web Design and Development Services, Offers and Discounts",
                    MetaDescription = "Do you need a website that looks good and works wonderfully? Take a look at our website design and development partners.",
                    H1 = "Web Design and Development Services, Offers and Discounts",
                    Body = "Do you need a website that looks good and works wonderfully? Take a look at our website design and development partners.",
                    SubCategories = new List<SubCategory>()
                    {
                        new SubCategory()
                        {
                            Name = "Website Design Services",
                            Url = "web-design-development-services-offers-discounts/website-design",
                            Title = "Website Design Services, Offers and Discounts",
                            MetaDescription = "Need a new website designed for your business or want to redesign your current one? Our highly skilled Website Design partners can help.",
                            H1 = "Website Design Services, Offers and Discounts",
                            Body = "Need a new website designed for your business or want to redesign your current one? Our highly skilled Website Design partners can help."
                        },
                        new SubCategory()
                        {
                            Name = "Web Development Services",
                            Url = "web-design-development-services-offers-discounts/web-development",
                            Title = "Web Development Services, Offers and Discounts",
                            MetaDescription = "Need a new website built for your business or want to upgrade your current site? Our highly skilled Website Development partners can help.",
                            H1 = "Web Development Services, Offers and Discounts",
                            Body = "Need a new website built for your business or want to upgrade your current site? Our highly skilled Website Development partners can help."
                        },
                        new SubCategory()
                        {
                            Name = "Hosting Services",
                            Url = "web-design-development-services-offers-discounts/website-design/hosting",
                            Title = "Hosting Services, Offers and Discounts",
                            MetaDescription = "You're going to need some good hosting is you're getting lots of visitors to your website. Find some cracking deasl here.",
                            H1 = "Hosting Services, Offers and Discounts",
                            Body = "You're going to need some good hosting is you're getting lots of visitors to your website. Find some cracking deasl here."
                        },
                        new SubCategory()
                        {
                            Name = "Mobile App Design Services",
                            Url = "web-design-development-services-offers-discounts/website-design/mobile-app-design",
                            Title = "Mobile App Design Services, Offers and Discounts",
                            MetaDescription = "Looking to build a Mobile App for your business? Take a look at our great range of partners here.",
                            H1 = "Mobile App Design Services, Offers and Discounts",
                            Body = "Looking to build a Mobile App for your business? Take a look at our great range of partners here."
                        }
                    }
                },
                new Category()
                {
                    Name = "HR and People Services",
                    Url = "hr-people-services-offers-discounts",
                    Title = "HR and People Services, Offers and Discounts",
                    MetaDescription = "People are the most important part of any business. Find HR and Recruitment partners at great rates here.",
                    H1 = "HR and People Services, Offers and Discounts",
                    Body = "People are the most important part of any business. Find HR and Recruitment partners at great rates here.",
                    SubCategories = new List<SubCategory>()
                    {
                        new SubCategory()
                        {
                            Name = "HR Services",
                            Url = "hr-people-services-offers-discounts/HR",
                            Title = "HR Services, Offers and Discounts",
                            MetaDescription = "People are the heartbeat of any business. Ensure they are looked after with our HR Services partners.",
                            H1 = "HR Services, Offers and Discounts",
                            Body = "People are the heartbeat of any business. Ensure they are looked after with our HR Services partners."
                        },
                        new SubCategory()
                        {
                            Name = "Recruitment Services",
                            Url = "hr-people-services-offers-discounts/recruitment",
                            Title = "Recruitment Services, Offers and Discounts",
                            MetaDescription = "If you need to bring in a new team member, it might be worth working with a recruitment specialist to find the right person. Find specialist recruiters here.",
                            H1 = "Recruitment Services, Offers and Discounts",
                            Body = "If you need to bring in a new team member, it might be worth working with a recruitment specialist to find the right person. Find specialist recruiters here."
                        }
                    }
                },
                //new Category()
                //{
                //    Name = "Outsourced Administration Services",
                //    Url = "outsourced-administration-services",
                //    Title = "Outsourced Administration Services, Offers and Discounts",
                //    MetaDescription = "",
                //    H1 = "Outsourced Administration Services, Offers and Discounts",
                //    Body = "[Content needed]",
                //    SubCategories = new List<SubCategory>()
                //    {
                //        new SubCategory()
                //        {
                //            Name = "Registered Address Provider",
                //            Url = "outsourced-administration-services/registered-address-provider",
                //            Title = "Registered Address Provider, Offers and Discounts",
                //            MetaDescription = "",
                //            H1 = "Registered Address Provider, Offers and Discounts",
                //            Body = "[content needed]"
                //        },
                //        new SubCategory()
                //        {
                //            Name = "Outsourced Administration & PA Services",
                //            Url = "outsourced-administration-services/outsourced-administration-pa-services",
                //            Title = "Outsourced Administration & PA Services, Offers and Discounts",
                //            MetaDescription = "",
                //            H1 = "Outsourced Administration & PA Services, Offers and Discounts",
                //            Body = "[content needed]"
                //        }
                //    }
                //},
                new Category()
                {
                    Name = "Business and Operations Services",
                    Url = "business-operations-services-offers-discounts",
                    Title = "Business and Operations Services, Offers and Discounts",
                    MetaDescription = "Do you need a business speciliast to help drive your business forward? Take a look at the specialists we partner with here.",
                    H1 = "Business and Operations Services, Offers and Discounts",
                    Body = "Do you need a business speciliast to help drive your business forward? Take a look at the specialists we partner with here.",
                    SubCategories = new List<SubCategory>()
                    {
                        new SubCategory()
                        {
                            Name = "Business Consulting Services",
                            Url = "business-operations-services-offers-discounts/business-consulting",
                            Title = "Business Consulting Services, Offers and Discounts",
                            MetaDescription = "Business Consulting Services can help a struggling business thrive. Find the top Business Consultancy Services here.",
                            H1 = "Business Consulting Services, Offers and Discounts",
                            Body = "Business Consulting Services can help a struggling business thrive. Find the top Business Consultancy Services here."
                        },
                        new SubCategory()
                        {
                            Name = "Business Plan Services",
                            Url = "business-operations-services-offers-discounts/business-plan",
                            Title = "Business Plan Services, Offers and Discounts",
                            MetaDescription = "It's important to have a tight business plan. Our range of Business Plan service providers can help to build your business plan.",
                            H1 = "Business Plan Services, Offers and Discounts",
                            Body = "It's important to have a tight business plan. Our range of Business Plan service providers can help to build your business plan."
                        },
                        new SubCategory()
                        {
                            Name = "Career Counselling and Mentorship Services",
                            Url = "business-operations-services-offers-discounts/career-counselling-mentorship",
                            Title = "Career Counselling and Mentorship Services, Offers and Discounts",
                            MetaDescription = "Are you looking for some career counselling or mentorship? Take a look at our Career Counselling and Mentorship service providers here.",
                            H1 = "Career Counselling and Mentorship Services, Offers and Discounts",
                            Body = "Are you looking for some career counselling or mentorship? Take a look at our Career Counselling and Mentorship service providers here."
                        },
                        new SubCategory()
                        {
                            Name = "Registered Address Provider",
                            Url = "business-operations-services-offers-discounts/registered-address-provider",
                            Title = "Registered Address Provider, Offers and Discounts",
                            MetaDescription = "",
                            H1 = "Registered Address Provider, Offers and Discounts",
                            Body = "[content needed]"
                        },
                        new SubCategory()
                        {
                            Name = "Outsourced Administration & PA Services",
                            Url = "business-operations-services-offers-discounts/outsourced-administration-pa-services",
                            Title = "Outsourced Administration & PA Services, Offers and Discounts",
                            MetaDescription = "",
                            H1 = "Outsourced Administration & PA Services, Offers and Discounts",
                            Body = "[content needed]"
                        }
                    }
                },
                new Category()
                {
                    Name = "Logistics Services",
                    Url = "logistics-services-offers-discounts",
                    Title = "Logistics Services, Offers and Discounts",
                    MetaDescription = "Is an efficient logistics process crucial for your business success. Find logistics partners that can help get your business moving here.",
                    H1 = "Logistics Services, Offers and Discounts",
                    Body = "Is an efficient logistics process crucial for your business success. Find logistics partners that can help get your business moving here.",
                    SubCategories = new List<SubCategory>()
                    {
                        new SubCategory()
                        {
                            Name = "Procurement Logistics Services",
                            Url = "logistics-services-offers-discounts/procurement-logistics",
                            Title = "Procurement Logistics Services, Offers and Discounts",
                            MetaDescription = "Do you need a super-reliabe procurement logistics company? Find a great partner from our range of Procurement Logistics Service partners.",
                            H1 = "Procurement Logistics Services, Offers and Discounts",
                            Body = "Do you need a super-reliabe procurement logistics company? Find a great partner from our range of Procurement Logistics Service partners."
                        },
                        new SubCategory()
                        {
                            Name = "Production Logistics Services",
                            Url = "logistics-services-offers-discounts/production-logistics",
                            Title = "Production Logistics Services, Offers and Discounts",
                            MetaDescription = "Do you need a super-reliabe productio logistics company? Find a great partner from our range of Production Logistics Service partners.",
                            H1 = "Production Logistics Services, Offers and Discounts",
                            Body = "Do you need a super-reliabe productio logistics company? Find a great partner from our range of Production Logistics Service partners."
                        },
                        new SubCategory()
                        {
                            Name = "Sales Logistics Services",
                            Url = "logistics-services-offers-discounts/sales-logistics",
                            Title = "Sales Logistics Services, Offers and Discounts",
                            MetaDescription = "Do you need a super-reliabe logistics company to deliver your products to customers? Find a great partner from our range of Sales Logistics Service partners.",
                            H1 = "Sales Logistics Services, Offers and Discounts",
                            Body = "Do you need a super-reliabe logistics company to deliver your products to customers? Find a great partner from our range of Sales Logistics Service partners."
                        },
                        new SubCategory()
                        {
                            Name = "Recovery and Recycling Logistics Services",
                            Url = "logistics-services-offers-discounts/recovery-recycling-logistics",
                            Title = "Recovery and Recycling Logistics Services, Offers and Discounts",
                            MetaDescription = "Do you want to make sure your waste is recycled properly? Take a look at our Recovery and Recycling Logistics partners today.",
                            H1 = "Recovery and Recycling Logistics Services, Offers and Discounts",
                            Body = "Do you want to make sure your waste is recycled properly? Take a look at our Recovery and Recycling Logistics partners today."
                        }
                    }
                },
                new Category()
                {
                    Name = "Funding and Investment Services",
                    Url = "funding-investment-services-offers-discounts",
                    Title = "Funding and Investment Services, Offers and Discounts",
                    MetaDescription = "Do you need seed investment or want to crowdfund to kick start your business? Take a look at our funding and investment partners here.",
                    H1 = "Funding and Investment Services, Offers and Discounts",
                    Body = "Do you need seed investment or want to crowdfund to kick start your business? Take a look at our funding and investment partners here.",
                    SubCategories = new List<SubCategory>()
                    {
                        new SubCategory()
                        {
                            Name = "Business Loan Services",
                            Url = "funding-investment-services-offers-discounts/business-loan",
                            Title = "Business Loan Services, Offers and Discounts",
                            MetaDescription = "Do you need a business loan to take your business to the next level? Work with our business loan partners today.",
                            H1 = "Business Loan Services, Offers and Discounts",
                            Body = "Do you need a business loan to take your business to the next level? Work with our business loan partners today."
                        },
                        new SubCategory ()
                        {
                            Name = "Crowdfunding Services",
                            Url = "funding-investment-services-offers-discounts/crowdfunding",
                            Title = "Crowdfunding Services, Offers and Discounts",
                            MetaDescription = "Do you need crowdfunding to take your business to the next level? Work with our crowdfunding partners today.",
                            H1 = "Crowdfunding Services, Offers and Discounts",
                            Body = "Do you need crowdfunding to take your business to the next level? Work with our crowdfunding partners today."
                        },
                        new SubCategory ()
                        {
                            Name = "Angel Investment and Venture Capital Services",
                            Url = "funding-investment-services-offers-discounts/angel-investment-venture-capital",
                            Title = "Angel Investment and Venture Capital Services, Offers and Discounts- Crowd Order",
                            MetaDescription = "Do you need angel investment to take your business to the next level? Work with our angel investment and venture capital partners today.",
                            H1 = "Angel Investment and Venture Capital Services, Offers and Discounts",
                            Body = "Do you need angel investment to take your business to the next level? Work with our angel investment and venture capital partners today."
                        },
                        new SubCategory ()
                        {
                            Name = "Business Incubator and Acceleration Services",
                            Url = "funding-investment-services-offers-discounts/business-incubator-acceleration",
                            Title = "Business Incubator and Acceleration Services, Offers and Discounts",
                            MetaDescription = "Do you need help making your business grow? Crowd Order work with a range of great Business Incubator partners to help you do just that.",
                            H1 = "Business Incubator and Acceleration Services, Offers and Discounts",
                            Body = "Do you need help making your business grow? Crowd Order work with a range of great Business Incubator partners to help you do just that."
                        }
                    }
                },
                new Category()
                {
                    Name = "Project Management Services",
                    Url = "project-management-services-offers-discounts",
                    Title = "Project Management Services, Offers and Discounts",
                    MetaDescription = "Do you need to keep up to date on projects and sales funnels within your business? Check out the best deals on Project Management tools here.",
                    H1 = "Project Management Services, Offers and Discounts",
                    Body = "Do you need to keep up to date on projects and sales funnels within your business? Check out the best deals on Project Management tools here.",
                    SubCategories = new List<SubCategory>()
                    {
                        new SubCategory()
                        {
                            Name = "Project Management Software",
                            Url = "project-management-services-offers-discounts/project-management-software",
                            Title = "Project Management Software, Offers and Discounts",
                            MetaDescription = "",
                            H1 = "Project Management Software, Offers and Discounts",
                            Body = ""
                        }
                    }
                },
                new Category()
                {
                    Name = "Legal Services",
                    Url = "legal-services-offers-discounts",
                    Title = "Legal Services, Offers and Discounts",
                    MetaDescription = "Do you need a lawyer to dot the I's and cross the T's? Check out the best legal software and online advice services here.",
                    H1 = "Legal Services, Offers and Discounts",
                    Body = "Do you need a lawyer to dot the I's and cross the T's? Check out the best legal software and online advice services here.",
                    SubCategories = new List<SubCategory>()
                    {
                        new SubCategory()
                        {
                            Name = "Pre-Paid Legal Services",
                            Url = "legal-services-offers-discounts/pre-paid-legal",
                            Title = "Pre-Paid Legal Services, Offers and Discounts",
                            MetaDescription = "Do you need some legal advice for your business? Take a look at our Pre-Paid Legal Service partners today.",
                            H1 = "Pre-Paid Legal Services, Offers and Discounts",
                            Body = "Do you need some legal advice for your business? Take a look at our Pre-Paid Legal Service partners today."
                        },
                        new SubCategory ()
                        {
                            Name = "Legal Software and Online Advice Service",
                            Url = "legal-services-offers-discounts/legal-software-online-advice",
                            Title = "Legal Software and Online Advice Services, Offers and Discounts",
                            MetaDescription = "Do you need some legal advice quickly? Take a look at our Legal Software and Online Advice Service partners today.",
                            H1 = "Legal Software and Online Advice Services, Offers and Discounts",
                            Body = "Do you need some legal advice quickly? Take a look at our Legal Software and Online Advice Service partners today."
                        }
                    }
                }
            };
            return data;
        }
    }
}
