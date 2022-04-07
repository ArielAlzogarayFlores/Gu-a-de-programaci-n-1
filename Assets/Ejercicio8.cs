using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{
    public int numD;

    // Start is called before the first frame update
    void Start()
    {
        switch (numD)
        {
            case 1:

                Debug.Log("Día domingo.");
                break;

            case 2:

                Debug.Log("Día lunes.");
                break;

            case 3:

                Debug.Log("Día martes.");
                break;

            case 4:

                Debug.Log("Día miercoles.");
                break;

            case 5:

                Debug.Log("Día jueves.");
                break;

            case 6:

                Debug.Log("Día viernes.");
                break;

            case 7:

                Debug.Log("Día sabado.");
                break;

            default :

                Debug.Log("El día ingresado no es válido.");
                break;

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
