namespace Project_11;

public class Consultant{
    string? passport = "";
    public void PassportView(Client client1){
        if (client1.passport != ""){
        foreach (char el in client1.passport){
            passport = passport + "*";
        }
        Console.WriteLine(passport);
        }
        else Console.WriteLine("passport string not");
    }
    public void NameView(Client client1){
        Console.WriteLine($"Фамилия: {client1.surname}");
        Console.WriteLine($"Имя: {client1.name}");
        Console.WriteLine($"Отчество: {client1.middleName}");
    }
    public void NumbnerView(Client client1){
        Console.WriteLine($"Номер телефона: {client1.phoneNumber}");
    }
    public void NumberRed(Client client1){
        while (1 == 1){
        client1.phoneNumber = Console.ReadLine();
        if (client1.phoneNumber == ""){
            Console.WriteLine("Номер телефона не введен");
        }
        else break;
        }
        Console.WriteLine($"Новый номер телефона: {client1.phoneNumber}");
    }
    
}