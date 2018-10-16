using System;
using System.Text;
using System.Collections.Generic;
using PatternsGoF.Adapter;
using PatternsGoF.Adapter.AdapterReal;
using PatternsGoF.Bridge;
using PatternsGoF.Bridge.BridgeReal;

namespace PatternConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Program program = new Program();

            #region AdapterConsole
            //program.AdapterFormal();
            //program.AdapterReal();
            #endregion

            #region BridgeConsole
            program.BridgeFormal();
            program.BridgeReal();
            #endregion
        }

        private void AdapterFormal()
        {
            AdapterFormal adapterFormal = new AdapterFormal();
            adapterFormal.Main();
            Console.ReadKey();
        } 
        private void AdapterReal()
        {
            Driver driver = new Driver();

            Auto auto = new Auto();
            Ship ship = new Ship();

            driver.Travel(auto);
            driver.Travel(ship);

            Camel camel = new Camel();
            ITransport camelTrasport = new CamelToTransportAdapter(camel);

            driver.Travel(camelTrasport);
            Console.ReadKey();
        }

        private void BridgeFormal()
        {
            BridgeFormal bridgeFormal = new BridgeFormal();
            bridgeFormal.Main();
            Console.ReadKey();
        }
        private void BridgeReal()
        {
            List<Manuscript> manuscripts = new List<Manuscript>();
            StandartFormatter standartFormatter = new StandartFormatter();
            ReverseForrmatter reverseForrmatter = new ReverseForrmatter();

            var faq = new FAQ(standartFormatter)
            {
                Title = "The Bridge Pattern FAQ"
            };
            faq.Questions.Add("What is it?", "a design pattern");
            faq.Questions.Add("When do we use it?", "When you need to separate an abastraction from an implementation.");
            manuscripts.Add(faq);

            var book = new Book(reverseForrmatter)
            {
                Title = "1Q84",
                Author = "Haruki Murakami",
                Text = "The story begins in gridlock on a Tokyo superhighway bridge."
            };
            manuscripts.Add(book);

            foreach (var item in manuscripts)
            {
                item.Print();
            }
            Console.ReadKey();
        }
    }
}
