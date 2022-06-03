namespace Project_11;

public class Client{
    public string? surname { get; }
    public string? name { get; }
    public string? middleName { get; }
    public string? phoneNumber { get; set; }
    public string? passport { get; }

    public Client(){
        surname = "Ivanov";
        name = "Ivan";
        middleName = "Ivanovich";
        phoneNumber = "89112342345";
        passport = "1234567890";
    }

}