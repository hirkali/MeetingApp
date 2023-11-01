namespace MeetingApp.Models;

public static class Repository
{
    private static List<UserInfo> _users = new();

    static Repository()
    {
        _users.Add(new UserInfo(){Id = 1 ,Name="Ali",Email = "kullaici1@goo.com",Phone = "12344", WillAttend = true});
        _users.Add(new UserInfo(){Id = 2 ,Name="Selim",Email = "kullaici2@goo.com",Phone = "12333", WillAttend = true});
        _users.Add(new UserInfo(){Id = 3 ,Name="Ali",Email = "kullaici3@goo.com",Phone = "12222", WillAttend = true});
        _users.Add(new UserInfo(){Id = 4 ,Name="Ali3",Email = "kullaici4@goo.com",Phone = "1222212", WillAttend = false});
        _users.Add(new UserInfo(){Id = 5 ,Name="Ali2",Email = "kullaici5@goo.com",Phone = "1224522", WillAttend = true});
    }
    public static List<UserInfo> Users
    {
        get
        {
            return _users;
        }
    }
    public static void CreateUser(UserInfo user)
    {
        user.Id = Users.Count + 1;
        _users.Add(user);
    }

    public static UserInfo? GetById(int id)
    {
        return _users.FirstOrDefault(user => user.Id == id);
    }
}