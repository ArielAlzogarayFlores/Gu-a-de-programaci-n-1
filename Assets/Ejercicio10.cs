using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio10 : MonoBehaviour
{
    const int HORA_APERTURA = 10;
    const int HORA_CIERRE = 18;

    public int HORA_ACTUAL;

    // Start is called before the first frame update
    void Start()
    {
        if(HORA_ACTUAL < 0 || HORA_ACTUAL > 24 )
        {
            Debug.Log("Ha ingresado una hora incorrecta, un día tiene 24 hs.");
        }

        bool estaAbierto = HORA_ACTUAL > HORA_APERTURA && HORA_ACTUAL < HORA_CIERRE;
        Debug.Log(estaAbierto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
