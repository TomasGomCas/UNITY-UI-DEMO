using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoaderService : MonoBehaviour
{
    Image imagen;
    int rotation;
    // Start is called before the first frame update
    void Start()
    {
        imagen = GameObject.Find("image_load").GetComponent<Image>();
        rotation = 10;
        InvokeRepeating("OutputTime", 0.0f, 0.1f);  //1s delay, repeat every 1s

    }
    void OutputTime()
    {
        imagen.rectTransform.Rotate(new Vector3(0, 0, rotation));
        rotation = rotation - 1;
        if (rotation <= 0) { 
        rotation = 10;
        }
        Debug.Log("LOG ROTATION: " + rotation);
    }

    public void rotate() {
        imagen = GameObject.Find("image_load").GetComponent<Image>();
        rotation = 10;
        InvokeRepeating("OutputTime", 0.0f, 0.1f);  //1s delay, repeat every 1s
    }

    // Update is called once per frame
    void Update()
    {

        //imagen.rectTransform.Rotate(new Vector3(0, 0, rotation));
        //rotation++;
       // RectTransform rectTransform = GetComponent<RectTransform>();
        //rectTransform.Rotate(new Vector3(0, 0, 45));
        /*  rotationEuler += Vector3.forward * 30 * Time.deltaTime; //increment 30 degrees every second
          transform.rotation = Quaternion.Euler(rotationEuler);

          //To convert Quaternion -> Euler, use eulerAngles
          print(transform.rotation.eulerAngles); */


    }
}
