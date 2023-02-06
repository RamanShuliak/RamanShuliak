using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace C_SharpExperiments.Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User()
            {
                Name = "Roman",
                IsOnline = false
            };

            user.Notify += user.PrintAttentionMessage;

            user.LogIn();

            user.LogIn();

            var obsCollection = new ObservableCollection<int>();
            obsCollection.CollectionChanged +=
                (sender, eventArgs) =>
                {
                    switch (eventArgs.Action)
                    {
                        case NotifyCollectionChangedAction.Add:

                            Console.WriteLine($"{sender} was changed.");
                            Console.WriteLine($"{eventArgs.NewItems[0]} was added.");
                            break;

                        case NotifyCollectionChangedAction.Remove:
                            Console.WriteLine($"{eventArgs.OldStartingIndex} was remove.");
                            break;
                    }


                };

            obsCollection.Add(1);
            obsCollection.Remove(1);
        }

    }
}