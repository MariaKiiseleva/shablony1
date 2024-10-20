namespace sh_lab_1;

public class UserCreator
{
    public User Build(UserBuilder builder)
    {
        builder.CreateUser();
        builder.GenId();
        builder.CheckUsername();
        builder.CheckPassword();
        builder.SetPosition();

        return builder.User ?? throw new Exception("Error");
    }
}