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
            Consultant consultant = new Consultant();
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1 - Просмотр паспортных данных");
            Console.WriteLine("2 - Просотр ФИО клиента");
            Console.WriteLine("3 - Просмотр номера телефона");
            Console.WriteLine("4 - Изменение Номера телефона");
            Console.WriteLine("5 - Завершение операций с клиентом");
            bool flag = false;
            while (flag == false){
                string? operation = Console.ReadLine();
                switch (operation){
                    case "1":
                        consultant.PassportView(client1);
                        break;
                    case "2":
                        consultant.NameView(client1);
                        break;
                    case "3":
                        consultant.NumbnerView(client1);
                        break;
                    case "4":
                        consultant.NumberRed(client1);
                        break;
                    case "5":
                        flag = true;
                        break;
                    default: 
                        Console.WriteLine("Error comand");
                        break;
                }
            }
        }
        void Task_2(){
            
        }
        void Task_3(){
            
        }
    }
}