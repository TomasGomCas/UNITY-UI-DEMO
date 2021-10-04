using System;
using Newtonsoft.Json;

public class User
{
    public String email;
    public String nick;
    public int puntos;
    public String language;

    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }

}
