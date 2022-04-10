using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio15 : MonoBehaviour
{
    public int num;

    // Start is called before the first frame update
    void Start()
    {
        bool estaEnA = num < 10 && num > (-10);
        bool estaEnB = num % 2 == 1;
        bool estaEnAmbos = num < 10 && num > (-10) && num % 2 == 1;
        bool noEstaEnNinguno = num > 10 && num < (-10) && num % 2 == 0;

        Debug.Log("Regla A : " + estaEnA + " \n Regla B : " + estaEnB + "\n Ambos : " + estaEnAmbos + "\n Ninguno : " + noEstaEnNinguno );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
