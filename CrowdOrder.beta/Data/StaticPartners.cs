using CrowdOrder.beta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Data
{
    public static class StaticPartnersData
    {
        public static void Create(ApplicationDbContext context)
        {
            CreatePartner(context, "Vat4U", "Accounting and Bookkeeping Services", "Online VAT Reclaim", "10%", "small-business-start-up-services/vat4u", "VAT4U - Start Up and SME Services", "VAT4U provides the most advanced technology to maximise your VAT recovery, helping you to recover VAT on travel expenses and supplier invoices.", "VAT4U", "VAT4U provides the most advanced technology to maximise your VAT recovery, helping you to recover VAT on travel expenses and supplier invoices. To find out more about VAT4U, click on the ‘Click here for offers’ button." , "Vat4u_logo.png", "", "Ann Jones", "ajones@vat4u.com", "https://www.vat4u.com/",
                "<h3>" +
                            "VAT Reclaim Services" +
                        "</h3>" +
                        "<p>" +
                            "Europe's Leading VAT Recovery Solution For Businesses " +
                        "</p>" +
                        "<p>" +
                            "VAT4U provides the most advanced technology to maximise your VAT recovery while operating internationally. VAT4U embeds more than 2,000 VAT rules automating VAT recovery on Travel Expenses and Supplier invoices." +
                        "</p>" +
                        "<h4>What you need to know:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Plug VAT4U into your accounting process with a few clicks" +
                            "</li>" +
                            "<li>" +
                                "When using VAT4U, claim process time is reduced by a whopping 68%" +
                            "</li>" +
                            "<li>" +
                                "Established in more than 15 countries, VAT4U is capable of offering truly global coverage" +
                            "</li>" +
                        "</ul>" +
                        "<h4>Discounted pricing:</h4>" +
                        "<ul>" +
                            "<li>The VAT4U fee is based on a percentage of the VAT claimed</li>" +
                            "<li>Typically, VAT4U charge 5 or 20% of the VAT recovered, depending on which service you choose</li>" +
                            "<li>VAT4U offer Crowd Order users a 10% discount</li>" +
                        "</ul>" +
                        "<h4>Who is this service relevant for:</h4>" +
                        "<ul>" +
                            "<li>Companies who have a travel or cross border spend</li>" +
                            "<li>" +
                                "Companies who are not VAT exempt" +
                            "</li>" +
                            "<li>" +
                                "Companies who are not in the Tour Operators Margin Scheme" +
                            "</li>" +
                        "</ul>",
                "Your company<ul><li>Is not VAT exempt</li><li>Is not part of the tour operators margin scheme</li><li>Has a cross border or travel spend</li></ul>"
                );
            
            CreatePartner(context, "Recoup Capital", "Accounting and Bookkeeping Services", "R&D Tax Credit Reclaim", "10%", "small-business-start-up-services/recoup-capital", "Recoup Capital - Start Up and SME Services", "Recoup Capital are Research & Development tax specialists, working with a panel of the UK’s most reputable accountancy firms, to advise with R&D tax relief claims. This is a must have service for innovative small businesses and startups.", "Recoup Capital", "Recoup Capital are Research & Development tax specialists, working with a panel of the UK’s most reputable accountancy firms, to advise with R&D tax relief claims. This is a must have service for innovative small businesses and startups. To find out more about Digital Next, click on the ‘Click here for offers’ button.", "recoup_capital_logo.png", "", "James Turley", "james@recoupcapital.co.uk", "https://recoupcapital.co.uk/", 
                "<h3>" +
                            "R&D Tax Credit Reclaim Services" +
                        "</h3>" +
                        "<p>" +
                            "Encouraging innovation and fuelling growth" +
                        "</p>" +
                        "<p>" +
                            "The Research and Development tax credit incentive was introduced in April 2000 by HMRC and is designed to encourage and reward UK based Ltd companies for investing in innovative products, services and processes by providing them with a tax credit of up to 33p for every £1 invested." +
                        "</p>" +
                        "<h4>What you need to know:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Recoup Capital is one of the UK’s fasted growing R&D specialists" +
                            "</li>" +
                            "<li>" +
                                "They offer a no obligation free consultation" +
                            "</li>" +
                        "</ul>" +
                        "<h4>Discounted pricing:</h4>" +
                        "<ul>" +
                            "<li>The Recoup Capital fee is based on a % of the re-claimed amount</li>" +
                            "<li>" +
                                "Typically, they charge 25% of the re-claimed amount" +
                            "</li>" +
                            "<li>" +
                                "Recoup Capital offer Crowd Order users a 10% discount, reducing this amount to 22.5%" +
                            "</li>" +
                        "</ul>" +
                        "<h4>Who is this service relevant for:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Companies that invest money into new or existing products, processes and services" +
                            "</li>" +
                        "</ul>"
                );

            CreatePartner(context, "Registered address", "Registered Address Provider", "Registered Address Provider", "10%", "small-business-start-up-services/registered-address", "Registered Address - Start Up and SME Services", "Are you hoping to start a small business or startup company and don’t have a company formed or physical address yet? Registered Address can help give a professional look to your business at a low cost.", "Registered Address", "Are you hoping to start a small business or startup company and don’t have a company formed or physical address yet? Registered Address can help give a professional look to your business at a low cost. To find out more about Registered Address, click on the ‘Click here for offers’ button.", "registered_address_new_logo.jpg", "https://www.registeredaddress.co.uk", "", "", "https://www.registeredaddress.co.uk/",
                "<h3>" +
                            "Registered Address & Business Formation Services" +
                        "</h3>" +
                        "<p>" +
                            "Project a professional image all at a fraction of the cost of establishing your own office" +
                        "</p>" +
                        "<p>" +
                            "Get a registered address and form a company with the U.K's leading company address provider" +
                        "</p>" +
                        "<h4>What you need to know:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Registered Address offer office addresses in the following locations:" +
                                "<ul>" +
                                    "<li>" +
                                        "London" +
                                    "</li>" +
                                    "<li>" +
                                        "Manchester" +
                                    "</li>" +
                                    "<li>" +
                                        "Edinburgh" +
                                    "</li>" +
                                    "<li>" +
                                        "Cardiff" +
                                    "</li>" +
                                "</ul>" +
                            "</li>" +
                            "<li>" +
                               "They have a 4.7 star review across nearly a thousand review on Trust Pilot" +
                            "</li>" +
                        "</ul>" +
                        "<h4>Discounted pricing:</h4>" +
                        "<ul>" +
                            "<li>Registered Address offer annual use of premium office address from £24.95 - 99 per year</li>" +
                            "<li>" +
                                "They offer Crowd Order users a 15% discount" +
                            "</li>" +
                            "<li>" +
                                "Simply enter this code at the checkout: CRD15P" +
                            "</li>" +
                        "</ul>" +
                        "<h4>Who is this service relevant for:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Any company looking to present a professional image by having an address in a premium location" +
                            "</li>" +
                        "</ul>"
                );

            CreatePartner(context, "Smart PA", "Outsourced Administration & PA Services", "Outsourced Administration & PA Services", "5%", "small-business-start-up-services/smartpa", "SmartPA - Start Up and SME Services", "SmartPA help you delegate time consuming tasks to Virtual Assistants to enable you to concentrate on what really matters to your business. SmartPA’s Virtual Assistants can assist with tasks ranging from Admin, Marketing and Business Support.", "SmartPA", "SmartPA help you delegate time consuming tasks to Virtual Assistants to enable you to concentrate on what really matters to your business. SmartPA’s Virtual Assistants can assist with tasks ranging from Admin, Marketing and Business Support. To find out more about SmartPA, click on the ‘Click here for offers’ button.", "smart_pa_logo.png", "", "Team", "marketing@smart-pa.com", "https://www.smart-pa.com/uk/",
                "<h3>" +
                            "Virtual PA & Administrative Support" +
                        "</h3>" +
                        "<p>" +
                            "14 countries, 15 languages and 3000+ clients" +
                        "</p>" +
                        "<p>" +
                            "Smart PA's support is designed to make life easier with 24/7 coverage and multi-lingual support. They carry a 5 star Trust Pilot review and can call companies such as the BBC, Total and Krispy Kreme their clients." +
                        "</p>" +
                        "<h4>What you need to know:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "SmartPA offer support in the following areas:" +
                                "<ul>" +
                                    "<li>" +
                                        "Call Handling" +
                                    "</li>" +
                                    "<li>" +
                                        "Book keeping" +
                                    "</li>" +
                                    "<li>" +
                                        "Social media management" +
                                    "</li>" +
                                    "<li>" +
                                        "Diary & email management" +
                                    "</li>" +
                                    "<li>" +
                                        "Email marketing" +
                                    "</li>" +
                                    "<li>" +
                                        "Event management" +
                                    "</li>" +
                                "</ul>" +
                            "</li>" +
                            "<li>" +
                                "No sign-up costs or overheads" +
                            "</li>" +
                        "</ul>" +
                        "<h4>Discounted pricing:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "SmartPA offer 5 pricing tiers:" +
                                "<ul>" +
                                    "<li>" +
                                        "Basic: £250" +
                                    "</li>" +
                                    "<li>" +
                                        "Professional: £500" +
                                    "</li>" +
                                    "<li>" +
                                        "Professional Plus: £750" +
                                    "</li>" +
                                    "<li>" +
                                        "Premium: £1,000" +
                                    "</li>" +
                                    "<li>" +
                                        "Premium Plus: £1,250" +
                                    "</li>" +
                                "</ul>" +
                            "</li>" +
                            "<li>" +
                                "SmartPA offer Crowd Order users a 5% discount for the first 3 months" +
                            "</li>                            " +
                        "</ul>" +
                        "<h4>Who is this service relevant for:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Individuals and entrepreneurs" +
                            "</li>" +
                            "<li>Small and medium-sized businesses</li>" +
                            "<li>Large corporations and government bodies</li>" +
                            "<li>Anyone looking to streamline their processes, cut costs and increase efficiency</li>" +
                        "</ul>"
                );


            CreatePartner(context, "Pipedrive", "Website Design Services", "CRM", "20%", "small-business-start-up-services/pipedrive", "Pipedrive - Start Up and SME Services", "Pipedrive is one of the top sales CRM offerings on the market. Pipedrive allows you to manage leads and deals, track communications, automate time consuming tasks and report on progress.", "Pipedrive", "Pipedrive is one of the top sales CRM offerings on the market. Pipedrive allows you to manage leads and deals, track communications, automate time consuming tasks and report on progress. To find out more about Pipedrive, click on the ‘Click here for offers’ button.", "pipedrive_logo.png", "https://www.pipedrive.com/en/register?campaign=crowdorder", "", "", "https://www.pipedrive.com/en/register?campaign=crowdorder",
                "<h3>" +
                            "Company Information:" +
                        "</h3>" +
                        "<p>" +
                            "Used by over 90,000 companies in 179 countries, Pipedrive is one of the leading CRM systems in the world and was #1 CRM in Software Reviews’ Data Quadrant in 2018 and 2019." +
                            "Pipedrive’s 24/7 customer service is second to none with a guaranteed 60 second or less customer support response time and 4.5 rating for ‘ease of use’ by Capterra." +
                            "Used and trusted by customers such as Amazon, Skyscanner, Vimeo, RE/MAX and many more. Pipedrive have closed $24bn+ worth of deals for 90,000+ companies." +
                        "</p>" +
                        "<h4>Services:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "When you need to stay laser-focused on the right deals, Pipedrive is here to support you." +
                            "</li>" +
                            "<li>" +
                                "Pipedrive is full of features that help you prioritise deals, track performance and predict revenue.  Pipedrive's software allows you to:" +
                                "<ul>" +
                                    "<li>" +
                                        "Manage leads & deals: get more hot deals fed straight into your sales pipelines around the clock from your custom chatbot and web forms" +
                                    "</li>" +
                                    "<li>" +
                                        "Track communications: track calls, emails and contact history exactly where you need to and have full visibility and control of your schedule" +
                                    "</li>" +
                                    "<li>" +
                                        "Automate sales workflows: eliminate busywork by automating repetitive administrative tasks and integrate into 150+ apps" +
                                    "</li>" +
                                    "<li>" +
                                        "Produce reports & insights on demand: deep dive into metrics customised for your business and measure company performance against set goals" +
                                    "</li>" +
                                "</ul>" +
                            "</li>       " +
                        "</ul>" +
                        "<h4>Discounted pricing:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Pipedrive offers Crowd Order customers a 20% discount on any package, in addition to a free trial" +
                            "</li>" +
                            "<li>" +
                                "Pipedrive offers four plans, each with varying functionality:" +
                                "<ul>" +
                                    "<li>" +
                                        "Essential: 		£12.50 per user, per month" +
                                    "</li>" +
                                    "<li>" +
                                        "Advanced: 		£24.90 per user, per month" +
                                    "</li>" +
                                    "<li>" +
                                        "Professional: 	£49.90 per user, per month" +
                                    "</li>" +
                                    "<li>" +
                                        "Enterprise: 	£99.00 per user, per month" +
                                    "</li>                                    " +
                                "</ul>" +
                            "</li>" +
                        "</ul>" +
                        "<h4>Who is this service relevant for:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Any sales or business development team seeking to:" +
                                "<ul>" +
                                    "<li>" +
                                        "Increase workflow visibility" +
                                    "</li>" +
                                    "<li>" +
                                        "Simplify or automate tasks" +
                                    "</li>" +
                                    "<li>" +
                                        "Increase collaboration between teams" +
                                    "</li>" +
                                    "<li>" +
                                        "Streamline workflows" +
                                    "</li>" +
                                "</ul>" +
                            "</li>" +
                            "<li>" +
                                "Pipedrive offer a package for all companies, big or small and on average, users of Pipedrive see a 28% increase in closing rates after the first year." +
                            "</li>" +
                        "</ul>"
                );
            
            CreatePartner(context, "Staff treats", "HR Services", "Employee Benefits", "10%", "small-business-start-up-services/staff-treats", "Staff Treats - Start Up and SME Services", "Staff Treats are a fantastic company that provide startups and SME’s with employee benefits that are usually reserved for the large corporations and businesses. Some of the top benefits include discounts with high street shops, half price cinema tickets and even cheaper mobile phone plans.", "Staff Treats", "Staff Treats are a fantastic company that provide startups and SME’s with employee benefits that are usually reserved for the large corporations and businesses. Some of the top benefits include discounts with high street shops, half price cinema tickets and even cheaper mobile phone plans. To find out more about Byrd, click on the ‘Click here for offers’ button.", "staff_treats_logo.png", "", "James Solomon", "James.Solomon@xexec.com", "https://www.stafftreats.com/",
                " <h3>" +
                            "Employee Benefits" +
                        "</h3>" +
                        "<p>" +
                            "There's a better way to engage employees" +
                        "</p>" +
                        "<p>" +
                            "Our team is on a mission to provide UK SMEs with access to the same employee benefits and perks that large corporates use to engage and treat their staff. These include discounts at popular high street retailers, half-priced cinema tickets, cheap mobile plans, and so much more" +
                        "</p>" +
                        "<h4>What you need to know:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Staff Treats provide the employee benefits to companies such as Apple, Adidas and Starbucks" +
                            "</li>" +
                            "<li>" +
                                "Benefits include Cinema, Shopping, Mobile Phone Bills, Travel, Supermarkets and Gadgets" +
                            "</li>" +
                            "<li>Instant access available </li>" +
                        "</ul>" +
                        "<h4>Discounted pricing:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Staff Treats offer three different pricing structures, depending on what benefits you would like:" +
                                "<ul>" +
                                    "<li>" +
                                        "Starter: £4 per employee, per month" +
                                    "</li>" +
                                    "<li>" +
                                        "Standard: £6 per employee, per month" +
                                    "</li>" +
                                    "<li>" +
                                        "Premium: £9 per employee, per month" +
                                    "</li>" +
                                "</ul>" +
                            "</li>" +
                            "<li>" +
                                "Staff Treats offer all Crowd Order users a 10% discount on the above pricing" +
                            "</li>                            " +
                        "</ul>" +
                        "<h4>Who is this service relevant for:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Any company, large or small, who want to show their appreciation to their staff" +
                            "</li>" +
                        "</ul>"
                );
            
            CreatePartner(context, "Personio", "HR Services", "HR & Payroll Software", "50%", "small-business-start-up-services/personio", "Personio - Start Up and SME Services", "Personio is an innovative software company that allows small business owners to digitalize and simplify the lengthy HR processes. The software can help save time in several areas including recruitment, onboarding management, employee data management and even payroll.", "Personio", "Personio is an innovative software company that allows small business owners to digitalize and simplify the lengthy HR processes. The software can help save time in several areas including recruitment, onboarding management, employee data management and even payroll. To find out more about Personio, click on the ‘Click here for offers’ button.", "personio_logo.png", "", "Moritz Rumstadt", "moritz.rumstadt@personio.de", "https://www.personio.com/",
                "<h3>" +
                            "Employee Benefits" +
                        "</h3>" +
                        "<p>" +
                            "We make HR professionals real heroes by giving them more time to focus on what matters most: the employees. With our software, we digitalize and simplify time-consuming HR processes and thus create time for strategic topics like talent development or employer branding" +
                        "</p>" +
                        "<h4>What you need to know:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Personio provides a complete solution for recruitment, employee management and payroll" +
                            "</li>" +
                            "<li>" +
                                "Their software automates and simplifies your HR tasks within a single solution so you have enough time for strategic HR initiatives" +
                            "</li>                           " +
                            "<li>" +
                                "Nearly 2,000 customers in more than 40 countries are already successfully using Personio" +
                            "</li>" +
                        "</ul>" +
                        "<h4>Discounted pricing:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Personio offer three different pricing structures, depending on what solutions you would like:" +
                                "<ul>" +
                                    "<li>" +
                                        "Essential" +
                                    "</li>" +
                                    "<li>Professional</li>" +
                                    "<li>" +
                                        "Enterprise" +
                                    "</li>" +
                                "</ul>" +
                            "</li>" +
                            "<li>" +
                                "Personio offer all Crowd Order users a 50% discount for all implementation and set-up fees, regardless of which package you choose" +
                            "</li>" +
                            "<li>We encourage our users to reach out to Personio to receive a quote and to take advantage of their offer of a two-week free trial</li>" +
                        "</ul>" +
                        "<h4>Who is this service relevant for:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Any company that employs less than 2,000 personnel" +
                            "</li>" +
                        "</ul>"
                );
            
            CreatePartner(context, "You At Work", "HR Services", "Employee Benefits", "TBC", "small-business-start-up-services/you-at-work", "", "", "", "", "You_at_work_logo.png", "", "Neil Bowen", "neil.bowen@youatwork.com");
            
            CreatePartner(context, "Synergy retail support", "Procurement Logistics Services", "Fulfillment & 3rd Party Logistics", "Bespoke", "small-business-start-up-services/synergy-retail-services", "Synergy Retail Support - Start Up and SME Services", "Synergy Retail Support is a trusted 3PL & fulfilment partner. Services include Fulfilment, 3PL Logistics, Fashion Logistics and Co-Packing. They would be a great fulfilment partner for small businesses.", "Synergy Retail Support", "Synergy Retail Support is a trusted 3PL & fulfilment partner. Services include Fulfilment, 3PL Logistics, Fashion Logistics and Co-Packing. They would be a great fulfilment partner for small businesses. To find out more about Synergy Retail Support, click on the ‘Click here for offers’ button.", "synergy_retail_support_white_logo.png", "", "Gary Rees", "gary.rees@synergyretailsupport.co.uk", "https://synergyretailsupport.co.uk/",
                " <h3>" +
                            "Fulfilment and Third Party Logistics" +
                        "</h3>" +
                        "<p>" +
                            "Scalable fulfilment for your business that helps you exceed your customers’ expectations" +
                            "Powered by industry-leading technology, late cut-off times and a deep understanding of e-commerce, Synergy is a truly scalable partner." +
                        "</p>" +
                        "<h4>What you need to know:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Synergy Retail Support offer a tech stack that is fully integratable with the clients back office and reporting function" +
                            "</li>" +
                            "<li>" +
                                "Services they offer:" +
                                "<ul>" +
                                    "<li>Warehousing</li>" +
                                    "<li>Pick and Pack</li>" +
                                    "<li>Shipping</li>" +
                                    "<li>Returns Handling</li>" +
                                    "<li>Barcode Adding</li>" +
                                "</ul>                         " +
                            "</li>" +
                        "</ul>" +
                        "<h4>Discounted pricing:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Synergy Retail Support offer a bespoke pricing solution so we encourage our users to speak to their Managing Director, Gary Rees, to receive a quote" +
                            "</li>" +
                            "<li>" +
                                "Crowd Order users receive a great rate so be sure to use the button below to connect" +
                            "</li>                            " +
                        "</ul>" +
                        "<h4>Who is this service relevant for:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Any business looking to outsource their warehousing and logistics operations" +
                            "</li>" +
                            "<li>E-commerce businesses</li>" +
                            "<li>" +
                                "Fashion businesses" +
                            "</li>" +
                        "</ul>",
                "Your company <ul><li>Must have revenue of over £1m per annum</li></ul>"
                );


            CreatePartner(context, "Get byrd", "Procurement Logistics Services", "Fulfillment & 3rd Party Logistics", "Bespoke", "small-business-start-up-services/byrd", "Byrd - Start Up and SME Services", "Byrd is a smart all-in-one fulfilment and logistics solution that can seamlessly help your startup or small business get your products to customers safely and quickly. Byrd pride themselves on boarding businesses quickly and at a price that is great for startups or small businesses.", "Byrd", "Byrd is a smart all-in-one fulfilment and logistics solution that can seamlessly help your startup or small business get your products to customers safely and quickly. Byrd pride themselves on boarding businesses quickly and at a price that is great for startups or small businesses. To find out more about Byrd, click on the ‘Click here for offers’ button.", "byrd_logo.png", "", "Christopher Erdmann", "christopher.erdmann@getbyrd.com", "https://getbyrd.com/en/",
                " <h3>" +
                            "Fulfilment and Third Party Logistics" +
                        "</h3>" +
                        "<p>" +
                            "Scalable fulfilment for your business that helps you exceed your customers’ expectations" +
                        "</p>" +
                        "<p>" +
                            "By using Get Byrd’s logistics solution, you gain access to a global warehouse network operating on cloud-based technology, empowering you to outsource and manage your whole fulfilment with an all-in-one software solution" +
                        "</p>" +
                        "<h4>What you need to know:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Get Byrd operate over 10 fulfilment centres throughout Europe and the USA" +
                            "</li>" +
                            "<li>" +
                                "They offer a seamless API integration to fully integrate with your e-commerce system of choice within just a few clicks" +
                            "</li>" +
                            "<li>" +
                                "Services they offer:" +
                                "<ul>" +
                                    "<li>Warehousing</li>" +
                                    "<li>Pick and Pack</li>" +
                                    "<li>Shipping</li>" +
                                    "<li>Returns Handling</li>" +
                                "</ul>" +
                            "</li>" +
                        "</ul>" +
                        "<h4>Discounted pricing:</h4>" +
                        "<ul>" +
                            "<li>Get Byrd offer a bespoke pricing solution so we encourage our users to reach out to their knowledgeable team to receive a quote</li>" +
                            "<li>Crowd Order users receive a great rate so be sure to use the button below to connect</li>" +
                        "</ul>" +
                        "<h4>Who is this service relevant for:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Any business looking to outsource their warehousing and logistics operations" +
                            "</li>" +
                            "<li>" +
                                "E-commerce businesses" +
                            "</li>" +
                        "</ul>",
                "Your company <ul><li>Must ship over 200 units per month</li></ul>"
                );
            
            CreatePartner(context, "Digital next", "Content Marketing Services", "Digital Marketing Agency", "15%", "small-business-start-up-services/digital-next", "Digital Next - Start Up and SME Services", "Digital Next are a digital marketing agency that specialize in Search Engine Optimisation (SEO), Pay-Per-Click (PPC) advertising, Web Design and Digital PR. Digital Next have experience of working with top brands and startups across various industries.", "Digital Next", "Digital Next are a digital marketing agency that specialize in Search Engine Optimisation (SEO), Pay-Per-Click (PPC) advertising, Web Design and Digital PR. Digital Next have experience of working with top brands and startups across various industries. To find out more about Digital Next, click on the ‘Click here for offers’ button.", "digital_next_logo.jpg", "", "Jade Merabi", "jade@digitalnext.co.uk", "https://digitalnext.co.uk/",
                "<h3>" +
                            "SEO, PPC, Paid Social Media Advertising& Web Design" +
                        "</h3>" +
                        "<p>" +
                            "The Visible Spectrum of Digital Marketing, simplified…" +
                        "</p>" +
                        "<p>" +
                            "At Digital Next, we believe that developing a multi-channel strategy is paramount to online success, which is why our holistic 360° approach simplifies the full spectrum of marketing" +
                        "</p>" +
                        "<h4>What you need to know:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Digital next were listed as one of the top 100 growing tech companies and achieved significant press after the work they did for EE" +
                            "</li>" +
                            "<li>Regardless of your sector or marketing requirement, Digital Next can likely help as they offer a broad range of services across PPC, SEO, Social Media Management, Email Marketing, Web Design and much more</li>" +
                        "</ul>" +
                        "<h4>Discounted pricing:</h4>" +
                        "<ul>" +
                            "<li>When it comes to PPC, Digital Next normally charge 20% of your marketing spend, but Crowd Order users are only charged 17%</li>" +
                            "<li>Similarly, to have them manage your Social Media Marketing would normally cost 30% of your spend, but our users only pay 25%</li>" +
                            "<li>Their SEO and Web Design pricing is bespoke to each client, but they aim to offer a similar 15% discount to our users</li>" +
                        "</ul>" +
                        "<h4>Who is this service relevant for:</h4>" +
                        "<ul>" +
                            "<li>Any company looking to gain further traction / customers via any marketing channel</li>" +
                            "<li>Any company looking to refresh their website or improve its effectiveness at converting traffic</li>" +
                        "</ul>"
                );
            
            CreatePartner(context, "Custard", "Content Marketing Services", "Digital Marketing Agency", "10%", "small-business-start-up-services/custard", "Custard - Start Up and SME Services", "Custard are a digital marketing agency that specialize in Search Engine Optimisation (SEO), Pay-Per-Click (PPC) advertising and Social Media Management. Custard have experience of working with top brands and startups across various industries.", "Custard", "Custard are a digital marketing agency that specialize in Search Engine Optimisation (SEO), Pay-Per-Click (PPC) advertising and Social Media Management. Custard have experience of working with top brands and startups across various industries. To find out more about Custard, click on the ‘Click here for offers’ button.", "custard_logo.jpg", "", "Alex Duthie", "alex@custard.co.uk", "https://www.custard.co.uk/",
                "<h3>SEO, PPC & Paid Social Media Advertising</h3>" +
                        "<p> " +
                            "Tailored SEO, PPC & SMM campaigns from an honest digital marketing agency" +
                        "</p> " +
                        "<p> " +
                            "Get in front of your customers with flexible results-focused SEO, PPC and SMM campaigns from Custard. Rebuild your faith in the power of search marketing" +
                        "</p><h4>What you need to know:</h4>" +
                        "<ul>" +
                            "<li>Custard a boutique marketing firm based in Manchester that pride themselves on their integrity and ability to generate value for clients</li>" +
                            "<li>Custard were shortlisted for both the U.K Search Awards in 2019 and the Northern Digital Awards in 2020</li>" +
                            "<li>They've had some fantastic results across their PPC, SEO and Social Media Management which are showcased here</li>" +
                        "</ul>" +
                        "<h4>Discounted pricing:</h4>" +
                        "<ul>" +
                            "<li>Regardless of the service, Custard will offer you a 10% discount across all fees</li>" +
                        "</ul>" +
                        "<h4>Who is this service relevant for:</h4>" +
                        "<ul>" +
                            "<li>Any company looking to gain further traction / customers via any marketing channel</li>" +
                            "<li>Any company looking to refresh their website or improve its effectiveness at converting traffic</li>" +
                            "<li>Companies whose marketing budgets would allow for Custard's minimum monthly management fee of £500+VAT for paid social and search services or £2,000 for SEO related management services</li>" +
                        "</ul>",
                "Your company<ul><li>Has acknowledged they are open to paying a monthly management fee of £500 for Paid Search related services</li><li>OR has acknowledged they are open to paying a monthly management fee of £500 for Paid Social related services </li><li>OR has acknowledged they are open to paying a monthly management fee of £2,000 for SEO related services</li></ul>"
                );
            
            CreatePartner(context, "Glorious creative", "Branding Services", "Branding Agency", "Bespoke", "small-business-start-up-services/glorious-creative", "Glorious Creative - Start Up and SME Services", "Glorious Creative are an award-winning branding agency who specialize in helping businesses tell their brand story through creative. Services range from building a brand tone of voice, creative advertising and building brand assets.", "Glorious Creative", "Glorious Creative are an award-winning branding agency who specialize in helping businesses tell their brand story through creative. Services range from building a brand tone of voice, creative advertising and building brand assets. To find out more about Glorious Creative, click on the ‘Click here for offers’ button.", "glorious_creative_logo.jpg", "", "Mark Ross", "mark@gloriouscreative.co.uk", "https://www.gloriouscreative.co.uk/",
                "<h3>" +
                            "Branding and Design Services" +
                        "</h3>" +
                        "<p>" +
                            "Everything we do starts with the brand. Initially, it may take the form of a workshop or simply listening hard to the brand story – it’s whatever it takes to ensure the brand vision, mission, positioning and strategy are in place" +
                        "</p>" +
                        "<h4>What you need to know:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "This team of talented creatives have picked up in excess of 60 national and international design awards" +
                            "</li>" +
                            "<li>" +
                                "Clients include names such as Dunlop, Balfour Beatty and The TATE Gallery" +
                            "</li>" +
                        "</ul>" +
                        "<h4>Discounted pricing:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Glorious Creative offer a bespoke pricing model and as such, we encourage our users to reach out the knowledgable team there and brainstorm ideas" +
                            "</li>" +
                            "<li>" +
                                "Given that pricing is bespoke, the team work on a best efforts basis to reduce costs for our client base and so far, we have heard great things!" +
                            "</li>" +
                        "</ul>" +
                        "<h4>Who is this service relevant for:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Companies or start-ups looking to refresh or invent their brand identity to draw in customers" +
                            "</li>" +
                            "<li>" +
                                "Companies looking to enhance their brand identity through creative, eye-catching marketing" +
                            "</li>" +
                            "<li>" +
                                "Companies about to embark upon a new marketing campaign" +
                            "</li>" +
                        "</ul>"
                );

            //CreatePartner(context, "Opayo", "Accounting and Bookkeeping Services", "Payment Solutions", "Bespoke", "small-business-start-up-services/opayo", "Opayo - Start Up and SME Services", "Opayo are a secure payments provider who work with merchants of all sizes with the might of Sage behind them. Their range of services include online payments, card terminals, point of sale solutions and many more.", "Opayo", "Opayo are a secure payments provider who work with merchants of all sizes with the might of Sage behind them. Their range of services include online payments, card terminals, point of sale solutions and many more. To find out more about Opayo, click on the ‘Click here for offers’ button.", "sage_pay_logo.png", "https://www.sagepaylabs.com/SSO/login.jsp?application=LeadHandover", "", "");

            CreatePartner(context, "Wrike", "Project Management Software", "Workflow Management Software", "10%", "small-business-start-up-services/wrike", "Wrike - Start Up and SME Services", "Wrike is a top project management tool that allows team members from all over the world collaborate and keep on top of projects across multiple business areas including Finance, Marketing and many more.", "Wrike", "Wrike is a top project management tool that allows team members from all over the world collaborate and keep on top of projects across multiple business areas including Finance, Marketing and many more. To find out more about Wrike, click on the ‘Click here for offers’ button.", "wrike_logo.jpg", "", "Jose Maroto", "jose.maroto@team.wrike.com", "https://www.wrike.com/",
                " <h3>" +
                            "Workflow Management & Collaboration Software" +
                        "</h3>" +
                        "<p>" +
                            "Connect with your co-workers no matter where you are. Collaborate, communicate, and conquer your projects with Wrike" +
                        "</p>" +
                        "<p>" +
                            "<strong>" +
                                "Organise everything you need to complete your project in one place. Keep your priorities straight and your goals in sight." +
                            "</strong>" +
                        "</p>" +
                        "<h4>What you need to know:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Wrike has over 20,000 clients, including Google, Air BnB and L'Oréal" +
                            "</li>" +
                            "<li>" +
                                "The software has a long range of integration capabilities, including Salesforce, Microsoft Teams  and Tableau" +
                            "</li>" +
                            "<li>They offer a free trial!</li>" +
                        "</ul>" +
                        "<h4>Discounted pricing:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "The Wrike fees range from $9.80 - 40.00 USD per user, per month, depending on the package you choose" +
                            "</li>" +
                            "<li>" +
                                "Wrike offer Crowd Order users a 10% discount, regardless of the package" +
                            "</li>                            " +
                        "</ul>" +
                        "<h4>Who is this service relevant for:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Any Operations, Product Development, Project Management, Marketing, Creative and I.T team looking to:" +
                                "<ul>" +
                                    "<li>" +
                                        "Increase workflow visibility" +
                                    "</li>" +
                                    "<li>" +
                                        "Simplify planning" +
                                    "</li>" +
                                    "<li>" +
                                        "Increase collaboration between teams" +
                                    "</li>" +
                                    "<li>" +
                                        "Streamline workflows" +
                                    "</li>" +
                                "</ul>" +
                            "</li>       " +
                        "</ul>"
                );
           
            CreatePartner(context, "Kiss Flow", "Cloud-Based IT Services", "Workflow Management Software", "10%", "small-business-start-up-services/kiss-flow", "Kiss Flow - Start Up and SME Services", "", "", "", "kissflow_logo.png", "https://kissflow.com/?utm_kf_source=KFPartners&utm_medium=crowdorder&utm_campaign=customerreferral", "", "", "https://kissflow.com/?utm_kf_source=KFPartners&utm_medium=crowdorder&utm_campaign=customerreferral",
                " <h3>" +
                            "Kissflow" +
                        "</h3>" +                        
                        "<p>" +
                            "<strong>" +
                                 "Don't trust us. Trust 10,000+ digital leaders. The most advanced companies in the world use Kissflow as their digital workplace partner." +
                            "</strong>" +
                        "</p>" +
                        "<h4>What you need to know:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Kissflow is a cloud-based forms automation that automates business processes and tracks performance across collaboration, HR, Procurement and more." +
                            "</li>" +
                            "<li>" +
                                "Their software automates and simplifies these processes within a single solution, so you have enough time for other time intensive projects to help grow your business." +
                            "</li>" +
                            "<li>Over 10,000 digital leaders are already successfully using Kissflow from companies such as Uber, Pepsi and Domino’s.</li>" +
                        "</ul>" +
                        "<h4>Discounted pricing:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Kissflow offer three different pricing structures, depending on what solutions you would like:" +
                                "<ul>" +
                                    "<li>" +
                                        "Starter" +
                                    "</li>" +
                                    "<li>" +
                                        "Growing" +
                                    "</li>" +
                                    "<li>" +
                                        "Enterprise" +
                                    "</li>" +
                                "</ul>" +
                            "</li>" +
                            "<li>" +
                                "Kissflow offer all Crowd Order users a discount for all implementation and set-up fees, regardless of which package you choose." +
                            "</li>" +
                            "<li>" +
                                "We encourage our users to reach out to Kissflow to receive a quote and to take advantage of their offer of a two-week free trial." +
                            "</li>" +
                        "</ul>" +
                        "<h4>Who is this service relevant for:</h4>" +
                        "<ul>" +
                            "<li>" +
                                "Any company that employs more than 100 employees" +
                            "</li>       " +
                        "</ul>");


        }
        public static void CreatePartner(ApplicationDbContext context, string name, string subCategoryName, string serviceName, string serviceOffer,
            string url, string title, string meta, string h1, string body, string logoFileName = "", string connectUrl = "", string mainContact = null, string mainContactEmail = null, string siteUrl = "", string about = "", string qualifyingCriteria = "")
        {
            var subCategory = context.SubCategorys.Where(x => x.Name == subCategoryName).FirstOrDefault();
            var partner = new Partner()
            {
                Name = name,
                Url = url,
                Title = title,
                MetaDescription = meta,
                H1 = h1,
                Body = body,
                LogoUrl = logoFileName,
                SiteUrl = siteUrl,
                DefaultPartnerSignupType = (connectUrl != "" ? DataHelpers.PartnerSignupType.Url : DataHelpers.PartnerSignupType.Email),
                MainContact = mainContact,
                MainContactEmail = mainContactEmail,
                About = about
            };
            var service = new Service()
            {
                Title = serviceName,
                SubCategory = subCategory,
                ConnectUrl = connectUrl,
                DiscountOffer = serviceOffer,
                ConnectContact = mainContact,
                ConnectEmail = mainContactEmail,
                PartnerSignupType = (connectUrl != "" ? DataHelpers.PartnerSignupType.Url : DataHelpers.PartnerSignupType.Email),
                QualifyingCriteria = qualifyingCriteria
            };

            partner.Services = new List<Service>()
            {
                service
            };
            context.Partners.Add(partner);
            context.SaveChanges();

        }
    }
}
