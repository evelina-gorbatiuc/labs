Console.WriteLine("Hello, Jerry");

A();
A();
A();

Console.ReadKey();

void A()
{
    Console.WriteLine("Это функция A");
    B();
    C();
}

void B()
{
    Console.WriteLine("Это функция B");
}

void C()
{
    Console.WriteLine("Это функция C");
}