using System;
using System.Collections.Generic;

namespace Start.db;

public partial class User
{
    public uint Id { get; set; }

    public string Login { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public string Email { get; set; } = null!;

    public User () { }

    public User (string login, string pass, string email)
    {
        this.Login = login;
        this.Pass = pass;
        this.Email = email;
    }
}
