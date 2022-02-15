using UnityEngine;
using System.Threading.Tasks;
using System.Collections;

public class FirebaseAuthController : MonoBehaviour
{
    public Firebase.Auth.FirebaseAuth auth;
    private const string ClientId = "273164695455-il78ngdte4fm5jvu5untud0j7k9e63bp.apps.googleusercontent.com"; //TODO: Change [CLIENT_ID] to your CLIENT_ID
    private const string ClientSecret = "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"; //TODO: Change [CLIENT_SECRET] to your CLIENT_SECRET
    private const string url = "https://unity-ui-demo-default-rtdb.europe-west1.firebasedatabase.app/"; //TODO: Change [CLIENT_SECRET] to your CLIENT_SECRET
    private const string key = "AIzaSyCjAYewjY8HS2Z5m5SvgZXaYbydBfvRjEw"; //TODO: Change [CLIENT_SECRET] to your CLIENT_SECRET

    void Start()
    {
        //auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
         auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        //googleAuth();
        // ExchangeAuthCodeWithIdToken();

        Debug.Log("ENTRA EN FIREBASE AUTH");
        
        Firebase.Auth.Credential credential =
        Firebase.Auth.GoogleAuthProvider.GetCredential(ClientId, ClientSecret);
        auth.SignInWithCredentialAsync(credential).ContinueWith(task => {
            if (task.IsCanceled)
            {
                Debug.LogError("SignInWithCredentialAsync was canceled.");
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("SignInWithCredentialAsync encountered an error: " + task.Exception);
                return;
            }

            Firebase.Auth.FirebaseUser newUser = task.Result;
            Debug.LogFormat("User signed in successfully: {0} ({1})",
                newUser.DisplayName, newUser.UserId);
        });
    }


    void Update()
    {
        
    }

    public void googleAuth() {

        Firebase.Auth.Credential credential =
        Firebase.Auth.GoogleAuthProvider.GetCredential("1:273164695455:android:46e7c1ad2b261e0b32afaa", null);
        //Firebase.Auth.GoogleAuthProvider.GetCredential(googleIdToken, googleAccessToken);
        auth.SignInWithCredentialAsync(credential).ContinueWith(task => {
            if (task.IsCanceled)
            {
                Debug.LogError("SignInWithCredentialAsync was canceled.");
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("SignInWithCredentialAsync encountered an error: " + task.Exception);
                return;
            }

            Firebase.Auth.FirebaseUser newUser = task.Result;
            Debug.LogFormat("User signed in successfully: {0} ({1})",
                newUser.DisplayName, newUser.UserId);
        });

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


    public async Task<bool> signinWithEmailPassword(string email,string password) {

        //await StartCoroutine(Example());
        bool returnValue = true;

        await auth.SignInWithEmailAndPasswordAsync(email, password).ContinueWith(tarea =>  {
            if (tarea.IsCanceled)
            {
                Debug.LogError("SignInWithEmailAndPasswordAsync was canceled.");
                returnValue = false;
            }
            if (tarea.IsFaulted)
            {
                Debug.LogError("SignInWithEmailAndPasswordAsync encountered an error: " + tarea.Exception);
                returnValue = false;
                //return "BIEN";
            } 
        });
        Debug.Log("SETEA EMAIL CACHE: " + email);
        Cache.email = email;

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

        Debug.Log("SETEA EMAIL CACHE: " + email);
        Cache.email = email;

        return true;
    }
}
