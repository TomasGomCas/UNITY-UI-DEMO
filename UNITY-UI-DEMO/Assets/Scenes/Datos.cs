using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Datos
{
    public static string nombre;
    public static float volumen;
    public static List<string> options = new List<string>();

    public static void metodoStatico() {
        Debug.Log("Esto es un log ESTATICO");
    }

}
