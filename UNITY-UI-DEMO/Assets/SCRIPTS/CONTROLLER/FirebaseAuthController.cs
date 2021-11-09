using UnityEngine;
using System.Threading.Tasks;
using System.Collections;

public class FirebaseAuthController : MonoBehaviour
{
    Firebase.Auth.FirebaseAuth auth;

    void Start()
    {
        auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
    }

    void Update()
    {
        
    }

    public static async Task Method1()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                //Console.WriteLine(" Method 1");
                // Do something
                Task.Delay(100).Wait();
            }
        });
    }


    public async Task<string> signinWithEmailPassword(string email,string password) {

        //await StartCoroutine(Example());
        string returnValue = "BIEN";

        await auth.SignInWithEmailAndPasswordAsync(email, password).ContinueWith(tarea =>  {
            if (tarea.IsCanceled)
            {
                Debug.LogError("SignInWithEmailAndPasswordAsync was canceled.");
                returnValue = "MAL1";
            }
            if (tarea.IsFaulted)
            {
                Debug.LogError("SignInWithEmailAndPasswordAsync encountered an error: " + tarea.Exception);
                returnValue = "MAL2";
                //return "BIEN";
            } 
        });
        return returnValue;
    }

    IEnumerator Example()
    {
        yield return new WaitForSecondsRealtime(5);
        //SceneManager.LoadScene("scene_mainmenu");
    }

    public bool signupWithEmailPassword(string email, string password) {

        auth.CreateUserWithEmailAndPasswordAsync(email, password).ContinueWith(task => {
            if (task.IsCanceled)
            {
                Debug.LogError("signupWithEmailPassword was canceled.");
                return false;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("signupWithEmailPassword encountered an error: " + task.Exception);
                return false;
            }
            return true;
        });

        return true;
    }
}
