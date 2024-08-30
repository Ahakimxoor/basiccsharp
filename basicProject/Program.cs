using System;
using System.Security.Cryptography.X509Certificates;
public class Acounting{

    private decimal balance;

    // 2. Constructor-ka xisaabta (Initial balance)
    public Acounting(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposid(decimal lacagDhigasho)
    {
        if (lacagDhigasho > 0)
        {
            balance -= lacagDhigasho;
            Console.WriteLine($"{lacagDhigasho} waxa laguugu daray lacaga acount gaaga {balance}");
        }
        else 
        {
            Console.WriteLine($"lacag sax ah geli ");
        }
    }
    public void WithDraw(decimal amount)
    {
        if (amount > balance && amount <= balance)
        {
            Console.WriteLine($"lacagatadu waa kala baxday hamplyo{amount} haraagagu cusub waa: {balance}");
        }
        else 
        {
            Console.WriteLine("lacagta aad gelisay maaha mid sax ah mise haraagaga kuma filna ");
        }
    
    }

    public decimal GetBlance()
    {
        return balance;
    }
}
public class Program{
    public static void Main(string[] args){
          Acounting myAccount = new Acounting(500); 

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n--- Bangigaaga ---");
            Console.WriteLine("1. Ku dar lacag xisaabta");
            Console.WriteLine("2. Kala bax lacag xisaabta");
            Console.WriteLine("3. Hubi dheelitirka xisaabta");
            Console.WriteLine("4. Ka bax barnaamijka");
            Console.Write("Dooro hawsha aad rabto inaad qabato (1-4): ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                Console.Write("fadlan geli lacagta aa rabtid inaa dhigatid  ");
                decimal kuDarlacagta = Convert.ToDecimal(Console.ReadLine());
                myAccount.Deposid(kuDarlacagta);
                break;
                case "2":
                Console.WriteLine("fadlan geli lacagta rabtid inaa kala baxdo acount gaaga:  ");
                decimal lacagKalaBixid = Convert.ToDecimal(Console.ReadLine());
                myAccount.WithDraw(lacagKalaBixid);
                break;
                case "3":
                Console.WriteLine($"haraagagu wa {myAccount.GetBlance()}");
                break;
                case "4":
                Console.WriteLine("bye nabad galyo ");
                break;
                default:
                Console.WriteLine("sorry 4 taan number mid ka mid ah geli  ");
                break;
            }
    }
    
}
}
