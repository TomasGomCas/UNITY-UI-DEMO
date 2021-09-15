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
        getPosts();
    }

    public void getPosts()
    {

        HttpWebRequest request;
        request = WebRequest.Create("https://curriculum-213a8.firebaseio.com/Muro.json") as HttpWebRequest;
        request.Method = "GET";
        request.ContentType = "application/json; charset=utf-8";

        HttpWebResponse response = request.GetResponse() as HttpWebResponse;
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string body = reader.ReadToEnd();

        JObject json = JObject.Parse(body);

        Debug.Log("LLAMADA API: " + json.ToString());

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
