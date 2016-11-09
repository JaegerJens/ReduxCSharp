using System;

namespace Redux
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new Store(new Reducer());
            Console.WriteLine(store.GetState().Counter);
            store.Dispatch(new Action(Action.ActionType.Increment));
            Console.WriteLine(store.GetState().Counter);
            Console.ReadKey();
        }
    }
}
