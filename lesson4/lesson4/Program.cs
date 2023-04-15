using System;

namespace lesson4;

public class Program
{
    public static void Main(string[] args)
    {
        Counter counter = new Counter();
        Handler1 handler1 = new Handler1();
        Handler2 handler2 = new Handler2();

        counter.Now50 += handler1.Display;
        counter.Now50 += handler2.Display;

        counter.Count50();
    }
}

