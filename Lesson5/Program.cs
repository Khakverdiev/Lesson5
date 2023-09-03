// Task 1
//Article art = new Article();
//Console.WriteLine("Enter Product name: ");
//art.ProductName = Console.ReadLine();
//Console.WriteLine("Enter Product code: ");
//art.ProductCode = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Product Price: ");
//art.ProductPrice = Convert.ToDouble(Console.ReadLine());
//art.articleType = ArticleType.consumerGoods;

//Console.WriteLine($"Product Name - {art.ProductName}");
//Console.WriteLine($"Product Code - {art.ProductCode}");
//Console.WriteLine($"Product Price - {art.ProductPrice}");
//Console.WriteLine(art.articleType);

//struct Article
//{
//    public ArticleType articleType;
//    private string productName;
//    private int productCode;
//    private double productPrice;


//    public string ProductName
//    {
//        get { return productName; }
//        set { productName = value; }
//    }

//    public int ProductCode
//    {
//        set
//        {
//            if (value > 000000000 && value < 999999999)
//            {
//                productCode = value;
//            }
//        }
//        get { return productCode; }
//    }

//    public double ProductPrice
//    {
//        set
//        {
//            if (value > 0)
//            {
//                productPrice = value;
//            }

//        }
//        get { return productPrice; }
//    }
//}

// Task 2
//Client cl = new Client();
//cl.ClientName = Console.ReadLine();
//cl.ClientSurname = Console.ReadLine();
//cl.ClientPatronymic = Console.ReadLine();
//cl.ClientAddress = Console.ReadLine();
//cl.ClientCode = Convert.ToInt32(Console.ReadLine());
//cl.ClientPhone = Convert.ToInt32(Console.ReadLine());
//cl.ClientOrders = Convert.ToInt32(Console.ReadLine());
//cl.Implemented = Convert.ToInt32(Console.ReadLine());
//cl.AmountOfOrders = Convert.ToInt32(Console.ReadLine());
//cl.cltype = ClientType.Special;

//Console.WriteLine($"Name - {cl.ClientName}\nSurname - {cl.ClientSurname}\nPatronymic - {cl.ClientPatronymic}");
//Console.WriteLine($"Address - {cl.ClientAddress}\nCode - {cl.ClientCode}\nPhone - {cl.ClientPhone}");
//Console.WriteLine($"Orders - {cl.ClientOrders}\nImplemented - {cl.Implemented}\nAmout - {cl.AmountOfOrders}");
//Console.WriteLine($"Client Type - {cl.cltype}");

//struct Client
//{
//    private string clientName;
//    private string clientSurname;
//    private string clientPatronymic;
//    private string clientAddress;
//    private int clientCode;
//    private int clientPhone;
//    private int clientOrders;
//    private int implemented;
//    private int amountOfOrders;
//    public ClientType cltype;

//    public string ClientName { get { return clientName; } set { clientName = value; } }
//    public string ClientSurname { get { return clientSurname; } set { clientSurname = value; } }
//    public string ClientPatronymic { get { return clientPatronymic; } set { clientPatronymic = value; } }
//    public string ClientAddress { get { return clientAddress; } set { clientAddress = value; } }

//    public int ClientCode
//    {
//        get { return clientCode; }
//        set
//        {
//            if (value > 0 && value < 11)
//            {
//                clientCode = value;
//            }
//        }
//    }

//    public int ClientPhone
//    {
//        get { return clientPhone; }
//        set
//        {
//            if (value > 111111111 && value < 999999999)
//            {
//                clientPhone = value;
//            }
//        }
//    }

//    public int ClientOrders
//    {
//        get { return clientOrders; }
//        set
//        {
//            if (value > 0)
//            {
//                clientOrders = value;
//            }
//        }
//    }

//    public int Implemented
//    {
//        get { return implemented; }
//        set
//        {
//            if (value > 0)
//            {
//                implemented = value;
//            }
//        }
//    }

//    public int AmountOfOrders
//    {
//        get { return amountOfOrders; }
//        set
//        {
//            if (value > 0)
//            {
//                amountOfOrders = value;
//            }
//        }
//    }
//}

// Task 3
//RequestItem req = new RequestItem();
//req.Item = Console.ReadLine();
//req.NumberOfUnits = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Item - {req.Item}");
//Console.WriteLine($"Number of units - {req.NumberOfUnits}");
//struct RequestItem
//{
//    private string item;
//    private int numberOfUnits;

//    public string Item { get{ return item; } set { item = value; } }
//    public int NumberOfUnits 
//    { 
//        get 
//        { 
//            return numberOfUnits; 
//        } 
//        set 
//        {
//            if (value > 0) 
//            {
//                numberOfUnits = value;
//            }    
//        } 
//    }
//}

// Task 4
//string[] client = { "tovar1", "tovar2", "tovar3" };
//int[] cost = { 5000, 25000, 1000 };
//Request rq1 = new Request();
//rq1.CodeOrder = 502576912;
//rq1.Day = 15;
//rq1.Month = 7;
//rq1.Year = 2023;
//Request rq2 = new Request(rq1.CodeOrder, "Vlad", rq1.Day, rq1.Month, rq1.Year, client, cost, PayType.Cash);
//rq2.PrintRequest();

//struct Request
//{
//    private int codeOrder;
//    private string orderClient;
//    private int day;
//    private int month;
//    private int year;
//    private string[] orderList;
//    private int[] orderCost;
//    private int totalAllOrders;
//    private PayType paytype;

//    public Request(int codeOrder, string orderClient, int day, int month, int year, string[] orderList, int[] orderCost, PayType paytype)
//    {
//        this.codeOrder = codeOrder;
//        this.orderClient = orderClient;
//        this.day = day;
//        this.month = month;
//        this.year = year;
//        this.orderList = orderList;
//        this.orderCost = orderCost;
//        this.paytype = paytype;
//        this.totalAllOrders = orderCost.Sum();
//    }

//    public void PrintRequest()
//    {
//        Console.WriteLine($"Id: {codeOrder}");
//        Console.WriteLine($"Client: {orderClient}");
//        Console.WriteLine($"Date: {day}.{month}.{year}");
//        Console.WriteLine($"Pay Type: {paytype}");
//        Console.WriteLine("\nOrder list: \n");
//        for (int i = 0; i < orderList.Length; i++)
//        {
//            Console.WriteLine($"Goods: {orderList[i]}. Cost: {orderCost[i]}.");
//        }
//        Console.WriteLine($"\nOrder price: {totalAllOrders}\n");
//    }

//    public int CodeOrder
//    {
//        get { return codeOrder; }
//        set
//        {
//            if (value > 000000000 && value < 999999999)
//            {
//                codeOrder = value;
//            }
//        }
//    }

//    public int Day
//    {
//        get { return day; }
//        set
//        {
//            if (value > 0 && value < 31)
//            {
//                day = value;
//            }
//        }
//    }

//    public int Month
//    {
//        get { return month; }
//        set
//        {
//            if (value > 0 && value < 13)
//            {
//                month = value;
//            }
//        }
//    }

//    public int Year
//    {
//        get { return year; }
//        set
//        {
//            if (value == 2023)
//            {
//                year = value;
//            }
//        }
//    }
//}

// Task 5
//enum ArticleType
//{
//    wholesaleGoods,
//    consumerGoods,
//    goodsForSaleToBusinesses
//}

// Task 6
//enum ClientType
//{
//    Unimportant,
//    regularСlient,
//    Special
//}

//enum PayType
//{
//    Cash,
//    withACard
//}
