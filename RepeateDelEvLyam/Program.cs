











/*int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

int result1 = Sum(integers, x => x > 5);
Console.WriteLine(result1);

int result2 = Sum(integers, x => x % 2 == 0);
Console.WriteLine(result2);

int Sum(int[] numbers, isEqual isEqual)
{
    int result = 0;
    foreach (int i in numbers)
    {
        if (isEqual(i)) result += i;
    }

    return result;
}

delegate bool isEqual(int x);*/


/*var hello = () => Console.WriteLine("hello my ddipper))");

var message = () => Console.Write("hi ");
message += () => Console.WriteLine("world ");
message += hello;
message += Print;

message();
Console.WriteLine("------------");

message -= Print;
message -= hello;

message?.Invoke();

void Print() => Console.WriteLine("<3");*/


/*var substract = (int x, int y) =>
{
    if (x > y) return x - y;
    return y - x;
};
int result1 = substract(10, 6);
Console.WriteLine(result1);

int result2 = substract(-10, 6);
Console.WriteLine(result2);*/


/*var sum = (int x, int y) => x + y;
int result = sum(2, 4);
Console.WriteLine(result);

Operation Multiply = (x, y) => x * y;
int resultMult = Multiply(4, 6);
Console.WriteLine(resultMult);

delegate int Operation(int x, int y);*/


/*ShowMessage("hello", delegate(string msg) { Console.WriteLine(msg); });

static void ShowMessage(string message, MessageHandler messageHandler) => messageHandler(message);

delegate void MessageHandler(string msg);*/


/*Message hello = () => Console.WriteLine("hello");
hello();

delegate void Message();*/


/*Account account = new Account(500);

account.RegisterHandler(PrintSimpleText);

account.Take(100);
account.Add(200);
account.Take(1000);

void PrintSimpleText(string message) => Console.WriteLine(message);

public delegate void AccountHandler(string msg);

public class Account
{
    private int sum;
    AccountHandler? take;

    public void RegisterHandler(AccountHandler del)
    {
        take += del;
    }

    public void UnregisterHandler(AccountHandler del)
    {
        take -= del;
    }
    
    public Account(int sum) => this.sum = sum;
    public void Add(int sum) => this.sum += sum;

    public void Take(int sum)
    {
        if (this.sum >= sum)
        {
            this.sum -= sum;
            take?.Invoke($"Balanse - {sum}");
        }
        else
        {
            take?.Invoke($"No money, no funny. Your balance: {this.sum}");
        }
    }

}*/


/*Operation operation = SelectOperation(OperationType.Add);
Console.WriteLine(operation(10, 4));

Operation SelectOperation(OperationType opType)
{
    switch (opType)
    {
        case OperationType.Add: return Add;
        case OperationType.Substract: return Substract;
        default: return Multiply;
    }
}

int Add(int x, int y) => x + y;
int Substract(int x, int y) => x - y;
int Multiply(int x, int y) => x * y;

enum OperationType
{
    Add, Substract, Multiply
}

delegate int Operation(int x, int y);*/


/*DoOperation(1, 5, Add);
DoOperation(6, 4, Substruct);
DoOperation(2,4,Multiply);

void DoOperation(int a, int b, Operation op) => Console.WriteLine(op(a,b));

int Add(int x, int y) => x + y;
int Substruct(int x, int y) => x - y;
int Multiply(int x, int y) => x * y;

delegate int Operation(int a, int b);*/


/*Message mes = Hello;
mes += HowAreU;
mes();

void Hello() => Console.WriteLine("Hello");
void HowAreU() => Console.WriteLine("How are u?");

delegate void Message();*/


/*void SOmeMethod(int g, double n) { }
delegate void SomeDel(int a, double b);*/


/*Operation operation1 = Add;
Operation operation2 = new Operation(Add);
Console.WriteLine(operation1(3,5));
Console.WriteLine(operation2(12,4));

int Add(int a, int b) => a + b;

delegate int Operation(int a, int b);*/


/*Operation operation = Add;
int result = Add(4, 6);
Console.WriteLine(result);

operation = Multiply;
result = operation(4, 5);
Console.WriteLine(result);

int Add(int a, int b) => a + b;

int Multiply(int a, int b) => a * b;

delegate int Operation(int a, int b);*/



/*class Program
{
    delegate void Message();
    static void Main(string[] args)
    {
        Message mes = SayHello;
        mes();

        void SayHello() => Console.WriteLine("Hello ddipper");
    }
}*/


/*Message message1 = new Welcome().Print;
Message message2 = new Hello().Display;

message1();
message2();

delegate void Message();

class Welcome
{
    public void Print() => Console.WriteLine("Welcome");
}

class Hello
{
    public void Display() => Console.WriteLine("Hello");
}*/