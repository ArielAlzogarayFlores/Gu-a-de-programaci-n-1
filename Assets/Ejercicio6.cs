using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    public int num1;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 <= 0)
        {
            Debug.Log("El número que ha ingresado no es válido.");
        }

        else if (num1 % 2 == 0)
        {
            Debug.Log("El número es par.");
        }

        else
        {
            Debug.Log("El número es impar.");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
