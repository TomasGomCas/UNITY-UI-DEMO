using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaSingleton : MonoBehaviour
{
    public static PruebaSingleton instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
}
