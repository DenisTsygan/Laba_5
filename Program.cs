using System;

namespace Laba_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant1 = new Restaurant(companyName: "Chef", createdDate: new DateTime(2013, 3, 4),
            isLicenseOrganization: true, emailAdministration:"chefMaster@od.ua",addresManagerOffice:"Novikova 3",
                maxCapacityPersom:123,countPrivateHalls: 8, sponsorName:"Amazon",starsRaiting: 4);
            FastFoodCafe fastFood1 = new FastFoodCafe(companyName: "i DNL", createdDate: new DateTime(2018, 3, 4), 
                isLicenseOrganization: false, emailAdministration:"dnl123@uk.uk",addresManagerOffice:"Makloni 23a", 
                maxCapacityPersom: 234, 34,TYPE_KITCHEN_ENUM.ASIA,20000);
            Catering catering1 = new Catering(companyName: "dogster", createdDate: new DateTime(2021, 3, 4), 
                isLicenseOrganization: false, emailAdministration: "dogster@uk.uk",addresManagerOffice:"Streeet 98", 
                maxCapacityPersom: 345,countBuffetTables:15,isGeneralPurpose: true, menuAsortiment:"breakfest");
            Restaurant restaurant2 = new Restaurant(companyName: "Kif  ", createdDate: new DateTime(2004, 3, 4), 
                isLicenseOrganization:false, emailAdministration: "goodKif@od.ua     ", addresManagerOffice: "Novikova 3", 
                maxCapacityPersom: 2,countPrivateHalls:2 ,sponsorName:" Kfc    ",starsRaiting: 1);
            FastFoodCafe fastFood2 = new FastFoodCafe(companyName: "rook", createdDate: new DateTime(2011, 3, 4), 
                isLicenseOrganization:true, emailAdministration: "rook@uk.utttt", addresManagerOffice: "Nemekova 3", 
                maxCapacityPersom:250, countStreetTables:23, typeKitchen: TYPE_KITCHEN_ENUM.DEFAULT, trafficPeopleInDay:12356);
            Restaurant restaurant3 = new Restaurant(companyName: "bon", createdDate: new DateTime(2013, 3, 4), 
                isLicenseOrganization: true, emailAdministration: "bon@od.ua", addresManagerOffice: "Klopova 3" , 
                maxCapacityPersom: 579,countPrivateHalls:6, sponsorName: "Apple", starsRaiting:3);
            Restaurant restaurant4 = new Restaurant(companyName: "  Apetit  ", createdDate: new DateTime(2013, 3, 4), 
                isLicenseOrganization: true, emailAdministration: "apetit@od.ua", addresManagerOffice: "Frungel 3" ,
                maxCapacityPersom: 908, countPrivateHalls:7,sponsorName: " Cyclone  ", starsRaiting:5);

            Console.WriteLine("----------------------------------");
            CateringEstablishments cateringEstablishments = new(restaurant1,restaurant4,fastFood2);
            cateringEstablishments.addEstablishment(restaurant2);
            cateringEstablishments.addEstablishment(catering1);
            Console.WriteLine(cateringEstablishments);
            Console.WriteLine("----------------------------------");

            Console.WriteLine("-----------------Delete index 3-------------------");
            cateringEstablishments.deleteEstablishmentByIndex(3);
            Console.WriteLine(cateringEstablishments);
            Console.WriteLine("----------------------------------");

            Console.WriteLine("-------------------Update index 3 on fastFood1------------------");
            cateringEstablishments.updateEstablishmentByIndex(fastFood1,3);
            Console.WriteLine(cateringEstablishments);
            Console.WriteLine("----------------------------------");
        }
    }
}
