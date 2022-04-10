using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio13 : MonoBehaviour
{
    const float cuaHoras = 16;
    const float mcuaHoras = 20;
    public int horas;

    // Start is called before the first frame update
    void Start()
    {
        if (horas <= 40)
        {
            Debug.Log("Usted tiene un sueldo correspondiente de $"+ horas * cuaHoras + " por semana.");
        }

        else
        {
            Debug.Log("Usted tiene un sueldo correspondiente de $" + ((horas-40) * mcuaHoras + 40 * cuaHoras)+ " por semana.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
