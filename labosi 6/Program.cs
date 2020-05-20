using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labosi_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadatak 1
            //Notebook notebook = new Notebook();
            //Note note1 = new Note("Zabilješka", "sensas");
            //Note note2 = new Note("team", "najbolji");
            //Note note3 = new Note("natjecatelji", "na svijetu");

            //notebook.AddNote(note1);
            //notebook.AddNote(note2);
            //notebook.AddNote(note3);

            //Iterator iterator = (Iterator)notebook.GetIterator();

            //for (int i = 0; i < notebook.Count; i++)
            //{
            //    iterator.Current.Show();
            //    iterator.Next();
            //}
            //Console.WriteLine("\n");

            //Zadatak 2
            //Box box = new Box();
            //Product product1 = new Product("sito", 34);
            //Product product2 = new Product("šteka", 12);
            //Product product3 = new Product("torba", 18);

            //box.AddProduct(product1);
            //box.AddProduct(product2);
            //box.AddProduct(product3);

            //BoxIterator boxIterator = (BoxIterator)box.GetIterator(); 

            //for (int i = 0; i < box.Count; i++)
            //{
            //    Console.WriteLine(boxIterator.Current);
            //    boxIterator.Next();
            //}

            //Console.WriteLine("\n");

            //Zadatak 3
            //var datum = new DateTime(2020, 8, 27, 14, 36,50);
            //ToDoItem item = new ToDoItem("to do", "chichen dinner", datum);
            //Console.WriteLine(item.ToString());
            //CareTaker care = new CareTaker();
            //care.PushStack(item.StoreState());
            //item.Rename("item");
            //item.ChangeTask("promijeni tekst");
            //Console.WriteLine(item.ToString());
            //item.RestoreState(care.PopStack());
            //Console.WriteLine(item.ToString());

            //Z4
            //Z4.
            //BankAccount bankAccount = new BankAccount("MarioMatić", "Sopje", 108900);
            //BankAccountMemento bankAccountMemento = bankAccount.StoreState();
            //Console.WriteLine("Balance: " + bankAccount.Balance);
            //bankAccount.UpdateBalance(-500);
            //Console.WriteLine("Balance: " + bankAccount.Balance);
            //bankAccount.RestoreState(bankAccountMemento);
            //Console.WriteLine("Balance: " + bankAccount.Balance);

            //Console.WriteLine("\n");

            //Z5.
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, "sensas_team.txt");
            logger.SetNextLogger(fileLogger);

            logger.Log("INFO", MessageType.INFO);
            logger.Log("ERROR", MessageType.ERROR);
            logger.Log("WARNING", MessageType.WARNING);

        }
    }
    }
