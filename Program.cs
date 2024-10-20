using sh_lab_1;

try
{
    var creator = new UserCreator();

    var commonUserBuilderbuilder = new BUserBuilder("Alex Frozin", "8888cccc!",
        username =>
        (
            username.Length >= 8
            && !username.Any(char.IsPunctuation)
        ),
        password =>
        (
            password.Length >= 8
        ));

    var adminUserBuilder = new AUserBuilder("Mihail Maxov", "3301",
        username =>
        (
            username.Length >= 8
            && !username.Any(char.IsPunctuation)
        ),
        password =>
        (
            password.Length >= 8
            && password.Any(char.IsLetter)
            && password.Any(char.IsDigit)
            && password.Any(char.IsPunctuation)
        ));

    var commonUser = creator.Build(commonUserBuilderbuilder);
    var adminUser = creator.Build(adminUserBuilder);

    Console.WriteLine($"{commonUser.Id} :: {commonUser.Username} ({commonUser.Position}) password=\"{commonUser.Password}\"");
    Console.WriteLine($"{adminUser.Id} :: {adminUser.Username} ({adminUser.Position}) password=\"{adminUser.Password}\"");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}