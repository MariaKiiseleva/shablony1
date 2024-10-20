namespace sh_lab_1;

public class AUserBuilder : UserBuilder
{
    public AUserBuilder(string tmpUsername, string tmpPassword,
        CheckMethod? tmpCheckUsernameMethod = null,
        CheckMethod? tmpCheckPasswordMethod = null) :
        base(tmpUsername, tmpPassword, tmpCheckUsernameMethod, tmpCheckPasswordMethod)
    {
    }
    public override void GenId()
    {
        User.Id = idSeed++;
    }
    public override void CheckUsername()
    {
        if (CheckUsernameMethod(Username))
        {
            User.Username = Username;
        }
        else
        {
            throw new Exception($"Неверное имя пользователя \"{Username}\"");
        }
    }

    public override void CheckPassword()
    {
        if (CheckPasswordMethod(Password))
        {
            User.Password = Password;
        }
        else
        {
            throw new Exception($"Неверный пароль \"{Password}\"");
        }
    }
    public override void SetPosition()
    {
        User.Position = "Admin";
    }
}
