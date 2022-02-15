using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Proyecto26;
using UnityEngine.Networking;

public class RestController : MonoBehaviour
{

    private const string ClientId = "273164695455-il78ngdte4fm5jvu5untud0j7k9e63bp.apps.googleusercontent.com"; //TODO: Change [CLIENT_ID] to your CLIENT_ID
    private const string ClientSecret = "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"; //TODO: Change [CLIENT_SECRET] to your CLIENT_SECRET
    private const string url = "https://unity-ui-demo-default-rtdb.europe-west1.firebasedatabase.app/"; //TODO: Change [CLIENT_SECRET] to your CLIENT_SECRET
    private const string key = "AIzaSyCjAYewjY8HS2Z5m5SvgZXaYbydBfvRjEw"; //TODO: Change [CLIENT_SECRET] to your CLIENT_SECRET

    void Start()
    {
        ExchangeAuthCodeWithIdToken();
        //getUser("email","token");
    }

    /*public static void dineor()
    {
        Debug.Log("ME CAGO EN LA PUTA");

        Dictionary<string, string> content = new Dictionary<string, string>();
        //Fill key and value
        content.Add("grant_type", "client_credentials");
        content.Add("client_id", "login-secret");
        content.Add("client_secret", "secretpassword");

        UnityWebRequest www = UnityWebRequest.Post("https://accounts.google.com/o/oauth2/v2/auth?client_id=273164695455-il78ngdte4fm5jvu5untud0j7k9e63bp.apps.googleusercontent.com&redirect_uri=urn:ietf:wg:oauth:2.0:oob&response_type=code&scope=email", content);
        //Send request
        yield return www.Send();

        if (!www.isError)
        {
            string resultContent = www.downloadHandler.text;
            //TokenClassName json = JsonUtility.FromJson<TokenClassName>(resultContent);

            //Return result
            //result(json.access_token);
        }
        else
        {
            //Return null
            //result("");
        }
    }*/

    public static void ExchangeAuthCodeWithIdToken()
    {
        Debug.Log("-kik EN REST SERVICE");
        //jj();

       //String url = "https://accounts.google.com/o/oauth2/v2/auth?client_id=273164695455-il78ngdte4fm5jvu5untud0j7k9e63bp.apps.googleusercontent.com&redirect_uri=urn:ietf:wg:oauth:2.0:oob&response_type=code&scope=email";
       // UnityWebRequest www = UnityWebRequest.Get(url);
       // www.Send();

        //RestClient.Get("https://accounts.google.com/o/oauth2/v2/auth?client_id=273164695455-il78ngdte4fm5jvu5untud0j7k9e63bp.apps.googleusercontent.com&redirect_uri=urn:ietf:wg:oauth:2.0:oob&response_type=code&scope=email");
        //Application.OpenURL($"https://accounts.google.com/o/oauth2/v2/auth?client_id=273164695455-il78ngdte4fm5jvu5untud0j7k9e63bp.apps.googleusercontent.com&redirect_uri=urn:ietf:wg:oauth:2.0:oob&response_type=code&scope=email");
        //Application.ur

        /*RestClient.Post($"https://oauth2.googleapis.com/token?code={code}&client_id={ClientId}&client_secret={ClientSecret}&redirect_uri=urn:ietf:wg:oauth:2.0:oob&grant_type=authorization_code", null).Then(
        response => {
            //var data = StringSerializationAPI.Deserialize(typeof(GoogleIdTokenResponse), response.Text) as GoogleIdTokenResponse;
            //callback(data.id_token);
        }).Catch(Debug.Log);*/

        /*
        Debug.Log("DENTRO DE URL REDIRECT");
        HttpWebRequest request;
        request = WebRequest.Create("https://accounts.google.com/o/oauth2/v2/auth?client_id=273164695455-il78ngdte4fm5jvu5untud0j7k9e63bp.apps.googleusercontent.com&redirect_uri=urn:ietf:wg:oauth:2.0:oob&response_type=code&scope=email") as HttpWebRequest;
        request.Method = "GET";
        request.ContentType = "application/json; charset=utf-8";
        request.AllowAutoRedirect = true;

        HttpWebResponse response = request.GetResponse() as HttpWebResponse;*/
        //StreamReader reader = new StreamReader(response.GetResponseStream());
        //string body = reader.ReadToEnd();

        //JObject json = JObject.Parse(body);
        //Debug.Log("LOGIN : " + json.ToString());*/
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

        HttpWebResponse response = request.GetResponse() as HttpWebResponse;
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string body = reader.ReadToEnd();

        JObject json = JObject.Parse(body);

        user.language = (String)json["language"];
        user.nick = (String)json["nick"];
        user.puntos = (int)json["points"];

    }

    public async Task<bool> getUserInfo()
    {
        Debug.Log("CACHE EN GETUSERINFOR: " + Cache.email);
        string email = Cache.email;
        Debug.Log("OJOLOCO: " + email.ToString());
        string url = "https://firestore.googleapis.com/v1/projects/unity-ui-demo/databases/(default)/documents/user/" + email + "?key=vqTmPpVxIZRQE2YI8324";
        User user = new User();

        HttpWebRequest request;
        request = WebRequest.Create(url) as HttpWebRequest;
        request.Method = "GET";
        request.ContentType = "application/json; charset=utf-8";

        HttpWebResponse response = request.GetResponse() as HttpWebResponse;
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string body = reader.ReadToEnd();

        JObject json = JObject.Parse(body);
        Cache.email = email;
        Cache.language = (String)json["fields"]["language"]["stringValue"];
        Cache.nick = (String)json["fields"]["nick"]["stringValue"];
        Cache.points = (String)json["fields"]["points"]["stringValue"];
        Debug.Log("JSON: " + json);
        Debug.Log("LANGUAGE USUARIO: " + (String) json["fields"]["language"]["stringValue"]);
        Debug.Log("NICK USUARIO: " + (String)json["fields"]["nick"]["stringValue"]);
        Debug.Log("POINTS USUARIO: " + (String)json["fields"]["points"]["stringValue"]);

        return true;

    }

}
