using Newtonsoft.Json;
using SystemintegrationEksamen._3x2Messages;

namespace SystemintegrationEksamen;


class Program
{
    static void Main(string[] args)
    {
        UsersDB usersDB = new UsersDB();
        User u1 = new User(1, "John", "Doe");
        User u2 = new User(2, "Jane", "Doe");
        User u3 = new User(3, "Mike", "Myers");

        u1.setMedlemsStatus(true);
        u2.setMedlemsStatus(true);
        u3.setMedlemsStatus(false);

        usersDB.addUser(u1);
        usersDB.addUser(u2);
        usersDB.addUser(u3);

        string jsonRequest =
            File.ReadAllText(
                "/Users/rasmusjerlov/Library/CloudStorage/OneDrive-EFIF/Datamatiker/Projects/Rider/SystemintegrationEksamen/Opgave3/Opgave3/Request.json");
        dynamic request = JsonConvert.DeserializeObject(jsonRequest);
        string commandType = request.CommandType;
        ushort medlemsNummer = request.Body.MedlemsNummer;


        if (commandType.ToLower().Equals("checkmembership"))
        {
            usersDB.membershipStatusReply(medlemsNummer);

            string jsonReply =
                File.ReadAllText(
                    "/Users/rasmusjerlov/Library/CloudStorage/OneDrive-EFIF/Datamatiker/Projects/Rider/SystemintegrationEksamen/Opgave3/Opgave3/Reply.json");
            dynamic reply = JsonConvert.DeserializeObject(jsonReply);
            bool isMember = reply.Body.isMember;
            Console.WriteLine($"User with membership number {medlemsNummer} is a member: {isMember}");
        }
        else
        {
            Console.WriteLine("Wrong CommandType");
        }
    }
}