using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Actions action;
            List<Bus> buses = new List<Bus>();
//            string license;
            bool result;

            do
            {
                Console.WriteLine("Choose an action from:");
                foreach (Actions act in (Actions[])Enum.GetValues(typeof(Actions)))
                {
                    Console.WriteLine("\t" + act);
                }
                Console.Write("\nYour choice: ");
                result = Enum.TryParse(Console.ReadLine(), out action);
                if (!result)
                {
                    Console.WriteLine("no such option\n");
                    continue;
                }

                switch (action) 
                {
                    case Actions.ADD:
                        try
                        {
                            buses.Add(new Bus());
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception.Message);
                        }

                        foreach (Bus bus in buses)
                        {
                            Console.WriteLine(bus);
                        }

                        break;

                    case Actions.FIND:
                        break;
                    case Actions.REFUEL:
                        break;
                    default:
                        break;
                }

            } while (action != Actions.EXIT);

        }

        private static void RefuelBus(List<Bus> buses, string license)
        {
            throw new NotImplementedException();
        }

        private static void FindBus(List<Bus> buses, string license)
        {
            throw new NotImplementedException();
        }

    }

}
