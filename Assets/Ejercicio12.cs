using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio12 : MonoBehaviour
{
    public int dado1;
    public int dado2;
    public int dado3;

    // Start is called before the first frame update
    void Start()
    {
        //Áca empiezán los "Excelente.".

        if (dado1 == 6 && dado1 == dado2 && dado2 == dado3)
        {
            Debug.Log("Excelente.");
        }

        else if (dado2 == 6 && dado2 == dado1 && dado1 == dado3)
        {
            Debug.Log("Excelente.");
        }

        else if (dado3 == 6 && dado3 == dado2 && dado2 == dado1)
        {
            Debug.Log("Excelente.");
        }

        //Áca empiezán los "Muy bien.".

        else if (dado1 == 6 && dado1 == dado2 && dado2 != dado3)
        {
            Debug.Log("Muy bien.");
        }

        else if (dado2 == 6 && dado2 == dado3 && dado3 != dado1)
        {
            Debug.Log("Muy bien.");
        }

        else if (dado3 == 6 && dado3 == dado1 && dado1 != dado2)
        {
            Debug.Log("Muy bien.");
        }

        //Áca empiezán los "Regular.".

        else if (dado1 == 6 && dado1 != dado2 && dado1 != dado3)
        {
            Debug.Log("Regular.");
        }

        else if (dado2 == 6 && dado2 != dado1 && dado2 != dado3)
        {
            Debug.Log("Regular.");
        }

        else if (dado3 == 6 && dado3 != dado2 && dado3 != dado1)
        {
            Debug.Log("Regular.");
        }

        else
        {
            Debug.Log("Insuficiente.");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
