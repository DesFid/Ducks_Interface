using System;
public class MuteQuack: IQuackBehavior
{
    public void quack()
    {
        Console.WriteLine("<<Silence>>");
    }
}