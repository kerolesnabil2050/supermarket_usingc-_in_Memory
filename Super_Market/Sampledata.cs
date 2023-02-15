using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market
{
    class Sampledata
    {
        //public static List<Product> products { get; set; } = new List<Product>();
        //public static List<Category> categories { get; set; } = new List<Category>();
        ////static public List<Store> stors { get; set; } = new List<Store>();


        //static SampleData()
        //{
        //products.Add(new Product()
        //{
        //    Id = 1,
        //    Name = "Meet",
        //    SellingPrice = 25.5,
        //    PurchasingPrice = 27.5,
        //    Quantity = 26,
        //    ProductionDate = new DateTime(2023, 2, 11),
        //    ExpirationDate = new DateTime(2023, 10, 11),
        //    category_name = "Meat & Fish"
        //});

        //products.Add(new Product()
        //{
        //    Id = 2,
        //    Name = "Apple",
        //    SellingPrice = 25.5,
        //    PurchasingPrice = 27.5,
        //    Quantity = 26,
        //    ProductionDate = new DateTime(2023, 2, 11),
        //    ExpirationDate = new DateTime(2023, 10, 11),
        //    category_name = "Fruits"
        //});
        //products.Add(new Product()
        //{
        //    Id = 3,
        //    Name = "banana",
        //    SellingPrice = 25.5,
        //    PurchasingPrice = 27.5,
        //    Quantity = 26,
        //    ProductionDate = new DateTime(2023, 2, 11),
        //    ExpirationDate = new DateTime(2023, 10, 11),
        //    category_name = "Fruits"
        //});
        //categories.Add(new Category() { Id = 30, Name = "Meat & Fish",Products= new[] { products[0]} });

        //categories.Add(new Category() { Id = 20, Name = "Fruits", Products = new[] { products[1], products[2] } });

        //stors.Add(new Store { Id = 50, Name = "pop", Location = "minia", Categories = categories });

















        public static List<Stor> stores = new List<Stor>()
        {
            new Stor{Name="pop",Location="minia",Categories=protiencategory },
            new Stor{Name="dsadasdas",Location="minia",Categories=protiencategory },

        };



        public static Proudect meet = new Proudect()
        {
            Id = 1,
            Name = "meet",
            SellingPrice = 25.5,
            PurchasingPrice = 27.5,
            Quantity = 26,
            ProductionDate = new DateTime(2023, 2, 11),
            ExpirationDate = new DateTime(2023, 10, 11),
            category_id = 20,
        };

        public static Proudect p2 = new Proudect()
        {
            Id = 2,
            Name = "fish",
            SellingPrice = 25.5,
            PurchasingPrice = 57.5,
            Quantity = 26,
            ProductionDate = new DateTime(2023, 2, 11),
            ExpirationDate = new DateTime(2023, 10, 11),
            category_id = 20,
        };


        public static List<Categorys> protiencategory = new List<Categorys>()
            {
                new Categorys{Id=20,Name="protien product",storeName="pop" ,Products=new List<Proudect>{ meet ,p2} }

            };
        public static List<Users> users = new List<Users>()
        {
            new Users{UserName="Admin",Password=111,Salary=2500,Pos=position.Admin},
             new Users{UserName="casher1",Password=222,Salary=2500,Pos=position.Casher},
              new Users{UserName="casher2",Password=333,Salary=3500,Pos=position.Casher}


        };
        public static Sellinvoce Sell = new Sellinvoce()
        {
            Products = new List<Proudect>() { meet, p2 },
            NameStore = stores[0].Name,
            casherUserName = users[1],
            PaidMoney = 250,

        };

        public static List<Suppliers> suppliers = new List<Suppliers>()
        {
            new Suppliers{Id=1,Name="seliva",products=new List<Proudect>() { meet,p2} },
            new Suppliers{Id=2,Name="alaa",products=new List<Proudect>() { p2} },
             new Suppliers{Id=3,Name="kero",products=new List<Proudect>() { p2} },



        };
        public static Recipt Receiptrr = new Recipt()
        {
            StoreName = stores[0].Name,
            products = new List<Proudect>() { p2 },
            Quantity = 20,
            supplier = suppliers[0]
        };
        //{
        //   new Receipt
        //   {
        //    StoreName = stores[0].Name,
        //    products = new List<Product>() {  p2 },
        //    Quantity=20,
        //    supplier = suppliers[0],

        //   },
        //   new Receipt
        //   {
        //    StoreName = stores[0].Name,
        //    products = new List<Product>() {  p2 },
        //    Quantity=100,
        //    supplier = suppliers[2],
        //   },
        //    new Receipt
        //   {
        //    StoreName = stores[1].Name,
        //    products = new List<Product>() {  p2 },
        //    Quantity=100,
        //    supplier = suppliers[2],
        //   },
        //     new Receipt
        //   {
        //    StoreName = stores[0].Name,
        //    products = new List<Product>() {  p2 },
        //    Quantity=100,
        //    supplier = suppliers[0],
        //   }

        //};
    }
}
