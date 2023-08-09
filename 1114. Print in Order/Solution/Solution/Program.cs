using System;
using System.Threading;
using System.Threading.Tasks;

namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoResetEventMech mechanism = new AutoResetEventMech();
            //SemaphoreSlimMech mechanism = new SemaphoreSlimMech();

            Task task2 = Task.Run(() => mechanism.Second(() => Console.WriteLine("Second")));
            Task task3 = Task.Run(() => mechanism.Third(() => Console.WriteLine("Third")));
            Task task1 = Task.Run(() => mechanism.First(() => Console.WriteLine("First")));

            Console.ReadKey();
        }
    }
    //Using AutoResetEvent
    public class AutoResetEventMech
    {
        AutoResetEvent firstEvent = new AutoResetEvent(false);
        AutoResetEvent secondEvent = new AutoResetEvent(false);
        public AutoResetEventMech()
        {
        }

        public void First(Action printFirst)
        {

            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();
            firstEvent.Set();
        }

        public void Second(Action printSecond)
        {
            firstEvent.WaitOne();

            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();
            secondEvent.Set();
        }

        public void Third(Action printThird)
        {
            secondEvent.WaitOne();
            // printThird() outputs "third". Do not change or remove this line.
            printThird();
        }
    }
    //Using SemaphoreSlim
    public class SemaphoreSlimMech
    {
        SemaphoreSlim secondSemaphore = new SemaphoreSlim(0, 1);
        SemaphoreSlim thirdSemaphore = new SemaphoreSlim(0, 1);
        public SemaphoreSlimMech() { }
        public void First(Action action)
        {
            action();
            secondSemaphore.Release();
        }
        public void Second(Action action)
        {
            secondSemaphore.Wait();
            action();
            thirdSemaphore.Release();
        }
        public void Third(Action action)
        {
            thirdSemaphore.Wait();
            action();
        }
    }
}
