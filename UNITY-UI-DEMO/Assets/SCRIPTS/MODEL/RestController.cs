using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Text;

public class RestController : MonoBehaviour
{

    void Start()
    {
        getUser("email","token");
    }

    public void getUser(String email,String token)
    {

        HttpWebRequest request;
        request = WebRequest.Create("https://unity-ui-demo-default-rtdb.europe-west1.firebasedatabase.app/user/" + email + ".json") as HttpWebRequest;
        request.Method = "GET";
        request.ContentType = "application/json; charset=utf-8";

        HttpWebResponse response = request.GetResponse() as HttpWebResponse;
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string body = reader.ReadToEnd();

        JObject json = JObject.Parse(body);

        User user = new User();
        // user.language = (String) json["email"]["language"];
        // user.nick = (String) json["email"]["nick"];
        //  user.puntos = (int) json["email"]["points"];
        user.language = (String) json["language"];
        user.nick = (String) json["nick"];
        user.puntos = (int) json["points"];

        Debug.Log("ESTO ES EL OBJETO CREADO: " + user.ToString());

        //user.
        // Convert to object
        /*List<Post> posts = new List<Post>();
        foreach (var x in json)
        {
            Post post = new Post(x.Value["user"].ToString(), x.Value["text"].ToString());
            posts.Add(post);
        }
        return new Muro(posts);*/
    }

    public void signInWithEmail(String email, String password)
    {
        User user = new User();

        HttpWebRequest request;
        request = WebRequest.Create("https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=AIzaSyCjAYewjY8HS2Z5m5SvgZXaYbydBfvRjEw") as HttpWebRequest;
        request.Method = "POST";
        request.ContentType = "application/json; charset=utf-8";
        //request.body

        HttpWebResponse response = request.GetResponse() as HttpWebResponse;
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string body = reader.ReadToEnd();

        JObject json = JObject.Parse(body);

        //User user = new User();
        // user.language = (String) json["email"]["language"];
        // user.nick = (String) json["email"]["nick"];
        //  user.puntos = (int) json["email"]["points"];
        user.language = (String)json["language"];
        user.nick = (String)json["nick"];
        user.puntos = (int)json["points"];

        Debug.Log("ESTO ES EL OBJETO CREADO: " + user.ToString());

        //user.
        // Convert to object
        /*List<Post> posts = new List<Post>();
        foreach (var x in json)
        {
            Post post = new Post(x.Value["user"].ToString(), x.Value["text"].ToString());
            posts.Add(post);
        }
        return new Muro(posts);*/
    }

}
