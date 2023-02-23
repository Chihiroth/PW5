List<IHello> Greetings = new List<IHello>();
Greetings.Add(new Rus());
Greetings.Add(new Eng());
Greetings.Add(new Spn());
Greetings.Add(new Jap());
Greetings.Add(new Chn());
foreach (IHello lang in Greetings)
{
    lang.SayHello();
}
Console.ReadKey(true);
interface IHello
{
    void SayHello();
}

class Rus : IHello { public void SayHello() { Console.WriteLine("Привет!");}}
class Eng : IHello { public void SayHello() { Console.WriteLine("Hello!");}}
class Spn : IHello { public void SayHello() { Console.WriteLine("Hola!");}}
class Jap : IHello { public void SayHello() { Console.WriteLine("Konbanwa!");} }
class Chn : IHello { public void SayHello() { Console.WriteLine("hai!"); } }