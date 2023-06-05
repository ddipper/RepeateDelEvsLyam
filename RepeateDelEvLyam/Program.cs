var multiply = (int n) => (int m) => m * n;

var fn = multiply(3);

Console.WriteLine(fn(2));
Console.WriteLine(fn(3));
Console.WriteLine(fn(4));


/*var fn = Multiply(3);
Console.WriteLine(fn(2));
Console.WriteLine(fn(3));
Console.WriteLine(fn(5));

Operation Multiply(int n)
{
    int Inner(int m)
    {
        return n * m;
    }

    return Inner;
}

delegate int Operation(int n);*/


/*var outerFn = () =>
{
    int x = 10;
    var innerFn = () => Console.WriteLine(x++);
    return innerFn;
};

var fn = outerFn();
fn();
fn();
fn();*/


/*var fn = Outer();
fn();
fn();
fn();

Action Outer()
{
    int x = 5;

    void Inner()
    {
        x++;
        Console.WriteLine(x);
    }
    return Inner;
}*/


/*Func<int, int, string> createString = (a, b) => $"{a}{b}";
Console.WriteLine(createString(1,5));
Console.WriteLine(createString(34,2));

int result1 = DoOperation(5, DoubleNumber);
Console.WriteLine(result1);

int result2 = DoOperation(3, SquareNumber);
Console.WriteLine(result2);

int DoOperation(int n, Func<int, int> operation) => operation(n);
int DoubleNumber(int n) => 2 * n;
int SquareNumber(int n) => n * n;*/


/*Predicate<int> isPositive = (int x) => x > 0; 

Console.WriteLine(isPositive(30));
Console.WriteLine(isPositive(-20));*/


/*DoOperation(10, 6, Add);
DoOperation(13, 2, Multiply);

void DoOperation(int a, int b, Action<int, int> op) => op(a, b);

void Add(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");
void Multiply(int x, int y) => Console.WriteLine($"{x} * {y} = {x * y}");*/


/*EmailReceiver emailBox = ReceiveMessage;//контвариантность
emailBox(new EmailMessage("Welcome"));

void ReceiveMessage(Message message) => message.Print();
delegate void EmailReceiver(EmailMessage message);

//MessageBuilder messageBuilder = writeEmailMessage; //ковариантность
//Message message = messageBuilder("Hello");
//message.Print();

//EmailMessage writeEmailMessage(string text) => new EmailMessage(text);

//delegate Message MessageBuilder(string text);

class Message
{
    public string Text { get; }
    public Message(string text) => Text = text;
    public virtual void Print() => Console.WriteLine($"Message: {Text}");

}

class EmailMessage : Message
{
    public EmailMessage(string text) : base(text) { }
    public override void Print() => Console.WriteLine($"Email: {Text}");
}

class SmsMessage : Message
{
    public SmsMessage(string text) : base(text) { }
    public override void Print() => Console.WriteLine($"Sms: {Text}");
}*/



/*Account account = new Account(100);                                   //Very very very nice :))  
account.Notify += DisplayMessage;
account.Put(20);
account.Take(40);
account.Take(400);

void DisplayMessage(Account sender, AccountEventArgs e)
{
    Console.WriteLine($"Transaction sum: {e.Sum}");
    Console.WriteLine(e.Message);
    Console.WriteLine($"Now at balance: {sender.Sum}");
}

class AccountEventArgs
{
    public string Message { get; }
    public int Sum { get; }

    public AccountEventArgs(string message, int sum)
    {
        Message = message;
        Sum = sum;
    }
}

class Account
{
    public delegate void AccountHandler(Account sender, AccountEventArgs e);
    public event AccountHandler? Notify;

    public int Sum { get; private set; }
    public Account(int sum) => Sum = sum;

    public void Put(int sum)
    {
        Sum += sum;
        Notify?.Invoke(this, new AccountEventArgs($"Balance++, {sum}", sum));
    }

    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= sum;
            Notify?.Invoke(this, new AccountEventArgs($"Balance--, {sum}", sum));
        }
        else
        {
            Notify?.Invoke(this, new AccountEventArgs($"No money, no funny", sum));
        }
    }
}*/



/*Account account = new Account(200);

account.Notify += account.DisplayMessage;
account.Put(20);
account.Take(50);
account.Notify -= account.DisplayMessage;

class Account
{
    public void DisplayMessage(string msg) => Console.WriteLine(msg);
    public delegate void AccountHandler(string message);
    AccountHandler? _notify;
    public event AccountHandler Notify
    {
        add
        {
            _notify += value;
            Console.WriteLine($"{value.Method.Name} added");
        }
        remove
        {
            _notify -= value;
            Console.WriteLine($"{value.Method.Name} removed");
        }
    }
    public Account(int sum) => Sum = sum;
    public int Sum { get; private set; }
    public void Put(int sum)
    {
        Sum += sum;
        _notify?.Invoke($"Balance++ {sum}");
    }
    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= sum;
            _notify?.Invoke($"Balance-- {sum}");
        }
        else
        {
            _notify?.Invoke($"No money, no funny {Sum}");
        }
    }
}*/


/*Account account = new Account(500);

account.Notify += DisplayMessage;
account.Put(20);
account.Take(40);
account.Take(500);

void DisplayMessage(string msg) => Console.WriteLine(msg);

class Account
{
    public delegate void AccountHandler(string msg);
    public event AccountHandler Notify;
    public int Sum { get; private set; }
    public Account(int sum) => Sum = sum;

    public void Put(int sum)
    {
        Sum += sum;
        Notify?.Invoke($"Balance++ {sum}");
    }

    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= sum;
            Notify?.Invoke($"Balance-- {sum}");
        }
        else
        {
            Notify?.Invoke("No money, no funny");
        }
    }
}*/



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


/*var hello = () => Console.WriteLine("hello my dipper))");

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


/*var Subtract = (int x, int y) =>
{
    if (x > y) return x - y;
    return y - x;
};
int result1 = Subtract(10, 6);
Console.WriteLine(result1);

int result2 = Subtract(-10, 6);
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
            take?.Invoke($"Balance - {sum}");
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
        case OperationType.Subtract: return Subtract;
        default: return Multiply;
    }
}

int Add(int x, int y) => x + y;
int Subtract(int x, int y) => x - y;
int Multiply(int x, int y) => x * y;

enum OperationType
{
    Add, Subtract, Multiply
}

delegate int Operation(int x, int y);*/


/*DoOperation(1, 5, Add);
DoOperation(6, 4, Subtract);
DoOperation(2,4,Multiply);

void DoOperation(int a, int b, Operation op) => Console.WriteLine(op(a,b));

int Add(int x, int y) => x + y;
int Subtract(int x, int y) => x - y;
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

        void SayHello() => Console.WriteLine("Hello dipper");
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