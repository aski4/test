using System;
using System.Text;
using System.Collections.Generic;
using PatternsGoF.Adapter;
using PatternsGoF.Adapter.AdapterReal;
using PatternsGoF.Bridge;
using PatternsGoF.Bridge.BridgeReal;
using PatternsGoF.Builder;
using PatternsGoF.Builder.BuilderReal;
using PatternsGoF.ChainOfResponsobility;
using PatternsGoF.ChainOfResponsobility.CORReal;
using PatternsGoF.Command;
using PatternsGoF.Command.CommandReal;
using System.IO;

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
            //program.BridgeFormal();
            //program.BridgeReal();
            #endregion

            #region Builder
            //program.BuilderFormal();
            //program.BuilderReal();
            #endregion

            #region CoR
            //program.ChainOfResponsobilityFormal();
            //for (int i = 0; i < 15000; i++)
            //{
            //    program.ChainOfResponsobilityReal();
            //}
            //Console.ReadKey();
            #endregion

            #region Command
            //program.CommandFormal();
            //program.CommandReal();
            #endregion

        }
        #region PrivateMethods
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

        private void BuilderFormal()
        {
            BuilderFormal builderFormal = new BuilderFormal();
            builderFormal.Main();
            Console.ReadKey();
        }
        private void BuilderReal()
        {

            var sandwitchMaker = new SandwichMaker(new StandartSandwichBuilder());
            sandwitchMaker.BuildSandwich();
            var standartSandwich = sandwitchMaker.GetSandwich();

            standartSandwich.Display();
            Console.ReadLine();

            sandwitchMaker = new SandwichMaker(new ClubSandwichBuilder());
            sandwitchMaker.BuildSandwich();
            var clubSandwich = sandwitchMaker.GetSandwich();

            clubSandwich.Display();
            Console.ReadLine();
        }

        private void ChainOfResponsobilityFormal()
        {
            ChainOfResponsobilityFormal CoR = new ChainOfResponsobilityFormal();
            CoR.Main();
            Console.ReadKey();
            Console.WriteLine();
        }
        private void ChainOfResponsobilityReal()
        {
            Hand[] hands = new Hand[10];
            Deck deck = new Deck();
            deck.Shuffle();

            for (int i = 0; i < hands.Length; i++)
            {
                hands[i] = new Hand();
            }

            for (int cardCount = 0; cardCount < 5; cardCount++)
            {
                foreach (Hand hand in hands)
                {
                    hand.Add(deck.Deal());
                }
            }
            using (StreamWriter fs = new StreamWriter(@"D:\Poker.txt", true, Encoding.UTF8))
            {
                foreach (Hand item in hands)
                {
                    Console.WriteLine("{0} ({1})", item.Rank, item);
                    fs.WriteLine("{0} ({1})", item.Rank, item);
                }
            }
        }

        private void CommandFormal()
        {
            CommandFormal command = new CommandFormal();
            command.Main();
            Console.ReadKey();
        }
        private void CommandReal()
        {
            User user = new User();
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            user.Undo(4);
            user.Redo(3);

            Console.ReadKey();
        }
        #endregion
    }
}
