using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_L
{
    public static class Test
    {
        public static void Test1_2()
        {
            Box box1 = new Box("Ime prve kutije");
            Box box2 = new Box("Ime druge kutije");

            box2.Add(new Product("Laptop", 1000.0, 1.2));
            box2.Add(new Product("Smart watch", 103.50, 0.4));

            box1.Add(new Product("Mobitel", 150.0, 0.5));
            box1.Add(box2);

            Product wine = new Product("Vino", 20.0, 2.0);
            box1.Add(wine);

            Console.WriteLine(box1.Description());
            Console.WriteLine("Price: " + box1.Price);
            Console.WriteLine("Weight: " + box1.Weight + Environment.NewLine + "------------------------");

            Console.WriteLine(box2.Description());
            Console.WriteLine("Price: " + box2.Price);
            Console.WriteLine("Weight: " + box2.Weight + Environment.NewLine + "------------------------");

            Console.WriteLine(wine.Description());
            Console.WriteLine("Price: " + wine.Price);
            Console.WriteLine("Weight: " + wine.Weight + Environment.NewLine + "------------------------");

            ShippingService service = new ShippingService(2.7m);
            Console.WriteLine("First box (shipping): " + service.CalculateShippingPrice(box1));
            Console.WriteLine("Wine (shipping): " + service.CalculateShippingPrice(wine));
        }

        public static void Test3()
        {
            DataConsolePrinter printer = new DataConsolePrinter();

            IDataset dataset = new Dataset("C:\\Users\\lucij\\Desktop\\Faks\\4semestar\\RPPOON\\LV\\LV5_L\\LV5_L\\CSV.txt");
            Console.WriteLine("Dataset");
            printer.Print(dataset);
            Console.WriteLine();

            IDataset proxy = new VirtualProxyDataset("C:\\Users\\lucij\\Desktop\\Faks\\4semestar\\RPPOON\\LV\\LV5_L\\LV5_L\\CSV.txt");
            Console.WriteLine("Proxy");
            printer.Print(proxy);

            User prvi = User.GenerateUser("Osoba 1");
            User drugi = User.GenerateUser("Osoba 2");

            Console.WriteLine();

            Console.WriteLine("First user");
            proxy = new ProtectionProxyDataset(prvi);
            printer.Print(proxy);

            Console.WriteLine(Environment.NewLine + "Second user");
            proxy = new ProtectionProxyDataset(drugi);
            printer.Print(proxy);

        }

        public static void Test4()
        {
            LoggingProxyDataset proxy = new LoggingProxyDataset();

            DataConsolePrinter printer = new DataConsolePrinter();
            printer.Print(proxy);
            proxy.LogMessage("Message");
        }

        public static void Test5()
        {
            ITheme light = new LightTheme();
            Note note = new ReminderNote("Reminder for something", light);
            note.Show();

            ITheme magenta = new MagentaTheme();
            note.Theme = magenta;
            note.Show();
        }

        public static void Test6()
        {
            GroupNote firstGroupNote = new GroupNote("Some reminder", new LightTheme());
            firstGroupNote.AddName("Mick Jagger");
            firstGroupNote.AddName("Serj Tankian");
            firstGroupNote.Show();

            GroupNote secondGroupNote = new GroupNote("Reminder!", new MagentaTheme());
            secondGroupNote.AddName("Vesna Zmijanac");
            secondGroupNote.AddName("Baby Lasagna");

            Console.WriteLine(Environment.NewLine + "Before: ");
            secondGroupNote.Show();
            secondGroupNote.RemoveName("Vesna Zmijanac");
            Console.WriteLine(Environment.NewLine + "After: ");
            secondGroupNote.Show();
        }

        public static void Test7()
        {
            Notebook notebook = new Notebook(new LightTheme());
            ReminderNote firstReminder = new ReminderNote("Something to remember", new LightTheme());
            notebook.AddNote(firstReminder);
            notebook.Display();

            Console.WriteLine("After");

            ReminderNote secondReminder = new ReminderNote("Another thing to remeber", new MagentaTheme());
            notebook.AddNote(secondReminder);
            notebook.ChangeTheme(new MagentaTheme());
            notebook.AddNote(new ReminderNote("Some note", new LightTheme()));
            notebook.Display();
        }
    }
}
