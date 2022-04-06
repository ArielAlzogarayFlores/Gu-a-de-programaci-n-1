using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{
    public string fechaCompra;
    public string nombreComprador;
    public string nombreProducto;

    public int cantProducto;
    public int precioUnidad;

    // Start is called before the first frame update
    void Start()
    {
        int precioTotal = cantProducto * precioUnidad;

        Debug.Log("Modelo de ticket:\nFecha de compra:" + fechaCompra + "\nNombre del comprador: " + nombreComprador + "\nProducto solicitado: " + nombreProducto + "\nCantidad solicitada: " + cantProducto + "\nPrecio unitario:$" + precioUnidad + "\nTotal a pagar:$" + precioTotal);








    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
