using Newtonsoft.Json;
using SystemintegrationEksamen._3x2Messages;

namespace SystemintegrationEksamen;

public class UsersDB
{
    public List<User> Users { get; set; }
    
    public UsersDB()
    {
        Users = new List<User>();
    }
    
    public void addUser(User user)
    {
        if (!Users.Contains(user))
        {
            Users.Add(user);
        }
        else
        {
            Console.WriteLine("User already exists");
        }
    }

    public bool checkMembership(ushort medlemsNummer)
    {
        foreach (User u in Users)
        {
            if (u.getMedlemsNummer() == medlemsNummer)
            {
                return u.MedlemsStatus;
            }

        }

        return false;
    }

    public void membershipStatusReply(ushort medlemsNummer)
    {
        var reply = new
        {
            Body = new
            {
                isMember = checkMembership(medlemsNummer)
            }
        };
        string jsonReply = JsonConvert.SerializeObject(reply);
        File.WriteAllText("/Users/rasmusjerlov/Library/CloudStorage/OneDrive-EFIF/Datamatiker/Projects/Rider/SystemintegrationEksamen/SystemintegrationEksamen/Opgave3/Reply.json", jsonReply);
    }
}