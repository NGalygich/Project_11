namespace Project_11;
static class Program{
    static public void Main(){
        string? task = Console.ReadLine();
        switch (task){
            case "1":
                Task_1();
                break;
            case "2":
                Task_2();
                break;
            case "3":
                Task_3();
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
        void Task_1(){
            Client client1 = new Client();
            string? passport = "";
            if (client1.passport != ""){
                foreach (char el in client1.passport){
                    passport = passport + "*";
                }
                Console.WriteLine(passport);
            }
            else Console.WriteLine("passport string not");
            Console.WriteLine($"Фамилия: {client1.surname}");
            Console.WriteLine($"Имя: {client1.name}");
            Console.WriteLine($"Отчество: {client1.middleName}");
            Console.WriteLine($"Номер телефона: {client1.phoneNumber}");
            while (1 == 1){
                client1.phoneNumber = Console.ReadLine();
                if (client1.phoneNumber == ""){
                    Console.WriteLine("Номер телефона не введен");
                }
                else break;
            }
            Console.WriteLine($"Новый номер телефона: {client1.phoneNumber}");
        }
        void Task_2(){
            
        }
        void Task_3(){
            
        }
    }
}