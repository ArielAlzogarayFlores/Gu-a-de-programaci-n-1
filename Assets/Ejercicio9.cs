using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    public string nombre1;
    public string nombre2;
    public string nombre3;

    public float cap1;
    public float cap2;
    public float cap3;

    // Start is called before the first frame update
    void Start()
    {
        float capitalTotal = cap1 + cap2 + cap3;

        float porc1 = (cap1 * 100) / capitalTotal;
        float porc2 = (cap2 * 100) / capitalTotal;
        float porc3 = (cap3 * 100) / capitalTotal;

        Debug.Log("Monto total aportado: $" + capitalTotal);

        Debug.Log("Nombre: " + nombre1 + " , capital aportado: $" + cap1 + " , porcentaje del total: %" + porc1 + " .");
        Debug.Log("Nombre: " + nombre2 + " , capital aportado: $" + cap2 + " , porcentaje del total: %" + porc2 + " .");
        Debug.Log("Nombre: " + nombre3 + " , capital aportado: $" + cap3 + " , porcentaje del total: %" + porc3 + " .");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
