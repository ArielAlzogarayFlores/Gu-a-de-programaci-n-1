using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EP4 : MonoBehaviour
{
    public int cantFlota;
    public int diasTotal;
    public int diasLluvia;

    // Start is called before the first frame update
    void Start()
    {
        int cantLitrosNoLluvia = (cantFlota * 90 * diasTotal) / 15;
        int cantLitrosLluvia = (cantFlota * 120 * diasLluvia) / 15;
        int cantLitrosTotal = cantLitrosNoLluvia - cantLitrosLluvia;

        int costoTotal = cantLitrosTotal / 130;

        if (diasTotal<5 && diasLluvia < 0)
        {
            Debug.Log("Error");
        }
        else
        {
            Debug.Log("Una flota de "+cantFlota+" unidades trabajando durante "+diasTotal+" días implicará un gasto de "+ costoTotal +" pesos en concepto de combustible.");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
