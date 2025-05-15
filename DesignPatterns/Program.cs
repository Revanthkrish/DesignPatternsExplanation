using DesignPatterns.Behavioural.ChainOfResponsibility;
using DesignPatterns.Behavioural.Command;
using DesignPatterns.Behavioural.Interpreter;
using DesignPatterns.Behavioural.Iterator;
using DesignPatterns.Behavioural.Mediator;
using DesignPatterns.Behavioural.Memento;
using DesignPatterns.Behavioural.Observer;
using DesignPatterns.Behavioural.State;
using DesignPatterns.Behavioural.Strategy;
using DesignPatterns.Behavioural.Template;
using DesignPatterns.Behavioural.Visitor;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Factory;
using DesignPatterns.Creational.ProtoType;
using DesignPatterns.Creational.Singeleton;
using DesignPatterns.Integrated.FactoryProxy;
using DesignPatterns.Repository;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.FlyWeight;
using DesignPatterns.Structural.Proxy;
Console.WriteLine("Creational Design Patterns");
Console.WriteLine("1.Singeleton Design Pattern");
Console.WriteLine("2.Factory Method Pattern");
Console.WriteLine("3.Abstract Factory Method");
Console.WriteLine("4.Builder Design Pattern");
Console.WriteLine("5.ProtoType Design Pattern");
Console.WriteLine("Structural Design Patterns");
Console.WriteLine("6.Adapter Design Pattern");
Console.WriteLine("7.Bridge Design Pattern");
Console.WriteLine("8.Composite Design Pattern");
Console.WriteLine("9.Decorator Design Pattern");
Console.WriteLine("10.Facade Design Pattern");
Console.WriteLine("11.FlyWeight Design Pattern");
Console.WriteLine("12.Proxy Design Pattern");
Console.WriteLine("Integrated Design Patterns");
Console.WriteLine("13.Factory+Proxy");
Console.WriteLine("Behavioral Design Patterns");
Console.WriteLine("14.Chain Of Responsibility");
Console.WriteLine("15.Command Design Pattern");
Console.WriteLine("16.Interpreter Design Pattern");
Console.WriteLine("17.Iterator Design Patterns");
Console.WriteLine("18.Mediator Design Pattern");
Console.WriteLine("19.Memento Design Pattern");
Console.WriteLine("20.Observer Design Pattern");
Console.WriteLine("21.State Design Pattern");
Console.WriteLine("22.Strategy Design Pattern");
Console.WriteLine("23.Template Method");
Console.WriteLine("24.Visitor");
Console.WriteLine("25.Repository ");
int cases = Convert.ToInt32(Console.ReadLine());
switch (cases)
{
    case 1:
        SingeletonTest.Run(); break;

    case 2:
        NotificationFactory factory;

        Console.WriteLine("Enter notification type (email/sms):");
        var input = Console.ReadLine();

        // Choose the correct factory based on user input
        if (input == "email")
            factory = new EmailNotificationFactory();
        else
            factory = new SmsNotificationFactory();

        // Use the factory to create the notification object
        INotification notifier = factory.CreateNotification();

        // Call the common method on the object
        notifier.Notify("Your order has been shipped.");
        break;

        case 3:
        Console.WriteLine("Enter OS (windows/mac): ");
        string? os = Console.ReadLine();

        IGUIFactory absfactory;

        // Choose the correct factory
        if (os == "windows")
            absfactory = new WindowsFactory();
        else
            absfactory = new MacFactory();

        // Create application with the chosen factory
        Application app = new Application(absfactory);
        app.RenderUI();  // Render buttons and checkboxes
        break;

        case 4:
        // Step 1: Create a builder
        IInvoiceBuilder builder = new DetailedInvoiceBuilder();

        // Step 2: Pass it to a director
        InvoiceDirector director = new InvoiceDirector(builder);

        // Step 3: Director tells builder what to build
        director.BuildFullInvoice();

        // Step 4: Get the final product
        Invoice invoice = builder.GetInvoice();
        invoice.Show();
        Console.WriteLine("\n✅ Builder Pattern helped us construct a complex object (Invoice) step-by-step without needing to use multiple constructors.");
        break;

        case 5:
        Console.WriteLine("=== Prototype Design Pattern Implementation ===\n");

        // Original invoice object
        Invoice1 original = new Invoice1("Alice", "Laptop", 1500);
        Console.WriteLine("Original Invoice:");
        original.Print();

        // Clone the invoice for a new customer
        Invoice1 copy = (Invoice1)original.Clone();
        copy.CustomerName = "Bob"; // Modify clone without affecting original

        Console.WriteLine("\nCloned Invoice (modified):");
        copy.Print();

        Console.WriteLine("\n✅ Prototype pattern allows you to clone existing objects without re-instantiating or reinitializing them.");
        break;

    case 6:
        Console.WriteLine("=== Adapter Design Pattern - Real-World Billing System ===\n");

        Console.WriteLine("Scenario: You have a modern e-commerce system that expects to use a unified payment interface.");
        Console.WriteLine("However, your company still uses a legacy payment gateway that doesn't match the expected interface.\n");

        // Legacy service (external or old SDK)
        LegacyPaymentGateway legacyGateway = new LegacyPaymentGateway();

        // Adapter makes it compatible with the system's IPaymentProcessor interface
        IPaymentProcessor paymentProcessor = new PaymentAdapter(legacyGateway);

        Console.WriteLine("Customer is checking out with a cart total of $250.00...");

        // System processes payment using unified interface (not worrying about internal legacy code)
        paymentProcessor.ProcessPayment(250.00m);

        Console.WriteLine("\n✅ Result: Payment was successfully processed using the Adapter pattern.");
        Console.WriteLine("This allows legacy systems to be integrated with modern interfaces without modifying either side.");
        break;

        case 7:
        Console.WriteLine("=== Bridge Design Pattern - Report Generator ===\n");

        Console.WriteLine("Use Case: We need to generate reports in different formats (PDF, Excel) for multiple departments (Billing, Tax).\n");

        // Create PDF renderer and Excel renderer
        IReportRenderer pdfRenderer = new PdfRenderer();
        IReportRenderer excelRenderer = new ExcelRenderer();

        // Use PDF renderer for billing report
        Report billingPdf = new BillingReport(pdfRenderer);
        billingPdf.Generate();

        Console.WriteLine();

        // Use Excel renderer for tax report
        Report taxExcel = new TaxReport(excelRenderer);
        taxExcel.Generate();

        Console.WriteLine("\n✅ Bridge Pattern allows format logic and department logic to evolve independently.");
        break;

        case 8:
        Console.WriteLine("=== Composite Design Pattern - Invoice Builder ===\n");

        // Create individual items
        var laptop = new InvoiceItem("Laptop", 1200m);
        var mouse = new InvoiceItem("Wireless Mouse", 50m);
        var bag = new InvoiceItem("Laptop Bag", 80m);
        var warranty = new InvoiceItem("Extended Warranty", 200m);

        // Create a bundle
        var laptopBundle = new InvoiceBundle("Laptop Bundle");
        laptopBundle.Add(laptop);
        laptopBundle.Add(bag);
        laptopBundle.Add(warranty);

        // Another bundle with mouse
        var fullPackage = new InvoiceBundle("Full Package");
        fullPackage.Add(laptopBundle);
        fullPackage.Add(mouse);

        // Display the full invoice
        Console.WriteLine("Invoice Details:\n");
        fullPackage.Display();

        Console.WriteLine($"\nTotal Amount: ${fullPackage.GetTotal()}");

        Console.WriteLine("\n✅ Composite Pattern allowed us to treat individual items and bundles uniformly.");
        break;

        case 9:
        Console.WriteLine("=== Decorator Design Pattern - Billing System ===\n");

        // Step 1: Create base product
        InVoiceD baseInvoice = new BaseProduct();

        // Step 2: Add gift wrap
        InVoiceD withGiftWrap = new GiftWrapDecorator(baseInvoice);

        // Step 3: Add express shipping
        InVoiceD withShipping = new ExpressShippingDecorator(withGiftWrap);

        // Step 4: Add tax
        InVoiceD finalInvoice = new TaxDecorator(withShipping);

        // Print result
        Console.WriteLine($"Final Invoice Description: {finalInvoice.GetDescription()}");
        Console.WriteLine($"Total Amount: ${finalInvoice.GetTotal():0.00}");

        Console.WriteLine("\n✅ Decorator Pattern lets us dynamically add features without modifying original classes.");
        break;

    case 10:
        Console.WriteLine("=== Facade Design Pattern - Order Processing ===\n");

        // Client interacts with a single interface
        OrderProcessor orderProcessor = new OrderProcessor();

        // Internally handles inventory, payment, invoice, and email
        orderProcessor.PlaceOrder(
            item: "Laptop",
            customer: "John Doe",
            email: "john@example.com",
            paymentType: "Credit Card"
        );

        Console.WriteLine("✅ Facade Pattern simplifies client interaction with a complex system.");
        break;

        case 11:
        Console.WriteLine("=== Flyweight Design Pattern - Character Rendering ===\n");

        CharacterFactory factory2 = new CharacterFactory();

        // Reusing 'A' and 'B' multiple times with different font sizes
        ICharacter charA1 = factory2.GetCharacter('A');
        charA1.Display(12);  // External state (point size)

        ICharacter charA2 = factory2.GetCharacter('A');
        charA2.Display(14);  // Same shared object, different point size

        ICharacter charB1 = factory2.GetCharacter('B');
        charB1.Display(12);

        Console.WriteLine("\n✅ Flyweight Pattern reused shared objects and saved memory.");
        break;

        case 12:
        Console.WriteLine("=== Proxy Design Pattern - File Access Control ===\n");

        IFileAccessor adminProxy = new FileAccessProxy("Admin");
        adminProxy.OpenFile("confidential-report.pdf");

        Console.WriteLine();

        IFileAccessor guestProxy = new FileAccessProxy("Guest");
        guestProxy.OpenFile("confidential-report.pdf");

        Console.WriteLine("\n✅ Proxy Pattern adds a layer of control before accessing the real object.");
        break;

    case 13:
        Console.WriteLine("=== Proxy + Factory Design Pattern Demo ===\n");

        Console.WriteLine("Creating file accessor for Admin...");
        IFileAccesor adminAccessor = FileAccessFactory.CreateFileAccessor("Admin");
        adminAccessor.OpenFile("payroll-data.xlsx");

        Console.WriteLine("\nCreating file accessor for Guest...");
        IFileAccesor guestAccessor = FileAccessFactory.CreateFileAccessor("Guest");
        guestAccessor.OpenFile("payroll-data.xlsx");

        Console.WriteLine("\n✅ Factory created role-based proxies. Proxy enforced access control.");
        break;

        case 14:
        Console.WriteLine("=== Chain of Responsibility Pattern - Support Ticket System ===\n");

        // Create handlers
        SupportHandler tier1 = new Tier1Support();
        SupportHandler tier2 = new Tier2Support();
        SupportHandler manager = new Manager();

        // Set up the chain: Tier1 → Tier2 → Manager
        tier1.SetNext(tier2);
        tier2.SetNext(manager);

        // Make various requests
        Console.WriteLine("Sending 'Basic' issue...");
        tier1.HandleRequest("Basic");

        Console.WriteLine("\nSending 'Intermediate' issue...");
        tier1.HandleRequest("Intermediate");

        Console.WriteLine("\nSending 'Critical' issue...");
        tier1.HandleRequest("Critical");

        Console.WriteLine("\nSending 'Unknown' issue...");
        tier1.HandleRequest("Unknown");

        Console.WriteLine("\n✅ Chain of Responsibility pattern processed issues through a handler chain.");
        break;

        case 15:
        Console.WriteLine("=== Command Design Pattern - Smart Home ===\n");

        // Receiver
        Light livingRoomLight = new Light();

        // Concrete Commands
        ICommand lightOn = new LightOnCommand(livingRoomLight);
        ICommand lightOff = new LightOffCommand(livingRoomLight);

        // Invoker
        RemoteControl remote = new RemoteControl();

        // Turn ON
        Console.WriteLine("Pressing ON button...");
        remote.SetCommand(lightOn);
        remote.PressButton();

        // Turn OFF
        Console.WriteLine("\nPressing OFF button...");
        remote.SetCommand(lightOff);
        remote.PressButton();

        // Undo (revert OFF → ON)
        Console.WriteLine("\nUndoing last action...");
        remote.PressUndo();

        Console.WriteLine("\n✅ Command Pattern decouples sender from receiver and supports undo/redo.");
        break ;

        case 16:
        Console.WriteLine("=== Interpreter Design Pattern - Arithmetic Evaluator ===\n");

        // Expression: 5 + 10 - 3
        IExpression five = new NumberExpression(5);
        IExpression ten = new NumberExpression(10);
        IExpression three = new NumberExpression(3);

        IExpression addExpr = new AddExpression(five, ten);       // (5 + 10)
        IExpression finalExpr = new SubtractExpression(addExpr, three);  // (5 + 10) - 3

        Console.WriteLine("Expression: 5 + 10 - 3");
        Console.WriteLine($"Result: {finalExpr.Interpret()}");

        Console.WriteLine("\n✅ Interpreter pattern allowed us to parse and evaluate expressions using a simple grammar.");
        break;

        case 17:
        ConcreteAggregate<string> collection = new ConcreteAggregate<string>();

        // Adding items to the collection
        collection.Add("Item 1");
        collection.Add("Item 2");
        collection.Add("Item 3");
        collection.Add("Item 4");

        // Creating an iterator to iterate over the collection
        IIterator<string> iterator = collection.CreateIterator();

        Console.WriteLine("Iterating over the collection:");

        // Start iteration from the first element
        for (string item = iterator.First(); !iterator.IsDone; item = iterator.Next())
        {
            Console.WriteLine(item);
        }

        /* Output:
         Iterating over the collection:
         Item 1
         Item 2
         Item 3
         Item 4
         */

        /* Explanation:
         * - Aggregate holds the collection.
         * - Iterator accesses elements sequentially.
         * - Client interacts only with Iterator, not directly with collection.
         * - Separation of traversal logic from the collection itself.
         */
        break ; 

        case 18:
        // Create mediator
        IChatMediator chatMediator = new ChatMediator();

        // Create users and register them to mediator
        User john = new ChatUser(chatMediator, "John");
        User alice = new ChatUser(chatMediator, "Alice");
        User bob = new ChatUser(chatMediator, "Bob");

        chatMediator.RegisterUser(john);
        chatMediator.RegisterUser(alice);
        chatMediator.RegisterUser(bob);

        // Users send messages via mediator
        john.Send("Hi everyone!");
        alice.Send("Hey John! How are you?");
        bob.Send("Hello John and Alice!");

        /* Output:
         John sends: Hi everyone!
         Alice received from John: Hi everyone!
         Bob received from John: Hi everyone!

         Alice sends: Hey John! How are you?
         John received from Alice: Hey John! How are you?
         Bob received from Alice: Hey John! How are you?

         Bob sends: Hello John and Alice!
         John received from Bob: Hello John and Alice!
         Alice received from Bob: Hello John and Alice!
        */

        /* Explanation:
         * - Mediator manages communication between users.
         * - Users communicate only through the mediator.
         * - Reduces tight coupling between user objects.
         * - Simplifies complex communication logic by centralizing interactions.
         * - Real-world scenario: Group chat rooms, Air Traffic Control systems.
         */
        break;

    case 19:

        Editor editor = new Editor();
        History history = new History();

        // User types something
        editor.Type("This is the first sentence. ");
        history.Save(editor.Save()); // Save state

        editor.Type("This is the second sentence. ");
        history.Save(editor.Save()); // Save state

        editor.Type("This is the third sentence. ");
        Console.WriteLine("Current Content: " + editor.GetContent());

        // User presses undo
        editor.Restore(history.Undo());
        Console.WriteLine("After Undo 1: " + editor.GetContent());

        // Another undo
        editor.Restore(history.Undo());
        Console.WriteLine("After Undo 2: " + editor.GetContent());

        /* Output:
         Current Content: This is the first sentence. This is the second sentence. This is the third sentence. 
         After Undo 1: This is the first sentence. This is the second sentence. 
         After Undo 2: This is the first sentence. 
        */

        /* Explanation:
         * - Originator (Editor) maintains current state.
         * - Memento stores past states of the Editor.
         * - Caretaker (History) keeps a stack of mementos for undo operations.
         * - Real-world analogy: Undo feature in text editors like Word or Notepad.
         */
        break;

    case 20:
        // Create subject (news agency)
        NewsAgency agency = new NewsAgency();

        // Create and register observers (subscribers)
        Subscriber alice1 = new Subscriber("Alice");
        Subscriber bob1 = new Subscriber("Bob");
        Subscriber charlie = new Subscriber("Charlie");

        agency.RegisterObserver(alice1);
        agency.RegisterObserver(bob1);
        agency.RegisterObserver(charlie);

        // Publish news
        agency.PublishNews("Observer Pattern Introduced in C#");

        // Remove one observer
        agency.RemoveObserver(bob1);

        // Publish another news
        agency.PublishNews("New .NET Version Released");

        /* Output:
         News Published: Observer Pattern Introduced in C#
         Alice received news update: Observer Pattern Introduced in C#
         Bob received news update: Observer Pattern Introduced in C#
         Charlie received news update: Observer Pattern Introduced in C#

         News Published: New .NET Version Released
         Alice received news update: New .NET Version Released
         Charlie received news update: New .NET Version Released
        */

        /* Explanation:
         * - NewsAgency is the Subject that notifies its observers.
         * - Subscribers register to receive updates.
         * - When news is published, all registered observers get the update.
         * - Real-world analogy: YouTube subscriptions, stock ticker updates, etc.
         */
        break;

        case 21:
        // Initial state: LoggedOut
        Context userContext = new Context(new LoggedOutState());

        // First action: logs in
        userContext.Request();

        // Second action: logs out
        userContext.Request();

        // Third action: logs in again
        userContext.Request();

        /* Output:
         State changed to: LoggedOutState
         User is logged out. Logging in...
         State changed to: LoggedInState
         User is logged in. Logging out...
         State changed to: LoggedOutState
         User is logged out. Logging in...
         State changed to: LoggedInState
        */

        /* Explanation:
         * - Context maintains the current state (e.g., logged in/out).
         * - Each state class defines behavior and transitions.
         * - Real-world use: Authentication, Vending machines, Traffic lights, Media players.
         */
        break;

        case 22:
        PaymentContext payment = new PaymentContext();

        // User chooses Credit Card
        payment.SetStrategy(new CreditCardPayment());
        payment.ExecutePayment(100.50m);

        // User switches to PayPal
        payment.SetStrategy(new PayPalPayment());
        payment.ExecutePayment(200.75m);

        // User tries Cryptocurrency
        payment.SetStrategy(new CryptoPayment());
        payment.ExecutePayment(300.00m);

        /* Output:
         Paid $100.50 using Credit Card.
         Paid $200.75 using PayPal.
         Paid $300.00 using Cryptocurrency.
        */

        /* Explanation:
         * - Strategy pattern lets you choose different algorithms (strategies) at runtime.
         * - The context class delegates the work to the current strategy.
         * - Real-world examples: Payment methods, Sorting algorithms, Compression formats.
         */
        break;

    case 23:
        DataExporter sqlExporter = new SQLDataExporter();
        Console.WriteLine("--- SQL Export ---");
        sqlExporter.Export();

        Console.WriteLine();

        DataExporter apiExporter = new APIDataExporter();
        Console.WriteLine("--- API Export ---");
        apiExporter.Export();

        /* Output:
         --- SQL Export ---
         Connected to SQL Database.
         Fetched data from SQL table.
         Formatted data as CSV.
         Saved CSV to disk from SQL data.
         Disconnected from data source.

         --- API Export ---
         Connected to REST API.
         Fetched data from API endpoint.
         Formatted data as JSON.
         Saved JSON to disk from API data.
         Disconnected from data source.
        */

        /* Explanation:
         * - The Template Method defines the steps of an algorithm.
         * - Subclasses override specific steps without changing the structure.
         * - Real-world use: Exporting data, parsing files, setting up connections.
         */
        break;

    case 24:
        List<IItemElement> items = new List<IItemElement>
        {
            new Book("Design Patterns", 500),
            new Book("C# in Depth", 700),
            new Fruit("Apple", 100, 2),
            new Fruit("Banana", 50, 5)
        };

        ShoppingCartVisitor visitor = new ShoppingCartVisitor();

        foreach (var item in items)
        {
            item.Accept(visitor);
        }

        Console.WriteLine($"Total Cost: {visitor.GetTotalCost()} INR");

        /* Output:
         Book: Design Patterns, Price: 500 INR
         Book: C# in Depth, Price: 700 INR
         Fruit: Apple, Cost: 200 INR
         Fruit: Banana, Cost: 250 INR
         Total Cost: 1650 INR
        */

        /* Explanation:
         * - Visitor pattern allows adding new operations to existing object structures.
         * - The operation (Visit) is decoupled from the object (Book/Fruit).
         * - Real-world use: Shopping carts, tax calculation, reporting on object structures.
         */
        break;

        case 25:
        IProductRepository repo = new ProductRepository();

        // Add products
        repo.Add(new Product1 { Id = 1, Name = "Laptop", Price = 75000 });
        repo.Add(new Product1 { Id = 2, Name = "Mouse", Price = 1500 });

        // Display all products
        Console.WriteLine("All Products:");
        foreach (var p in repo.GetAll())
        {
            Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Price: {p.Price}");
        }

        // Update a product
        repo.Update(new Product1 { Id = 2, Name = "Wireless Mouse", Price = 1800 });

        // Get product by Id
        var single = repo.GetById(2);
        Console.WriteLine($"\nProduct with ID 2: {single.Name} - {single.Price}");

        // Delete a product
        repo.Delete(1);

        // Display all after deletion
        Console.WriteLine("\nProducts after deletion:");
        foreach (var p in repo.GetAll())
        {
            Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Price: {p.Price}");
        }

        /* Output:
         All Products:
         Id: 1, Name: Laptop, Price: 75000
         Id: 2, Name: Mouse, Price: 1500

         Product with ID 2: Wireless Mouse - 1800

         Products after deletion:
         Id: 2, Name: Wireless Mouse, Price: 1800
        */

        /* Explanation:
         * - Repository pattern abstracts data access logic from business logic.
         * - Provides a cleaner and testable approach to managing entities.
         * - Real-world use: Used in layered architecture (DAL, BLL, UI) for CRUD operations.
         */
        break;
}