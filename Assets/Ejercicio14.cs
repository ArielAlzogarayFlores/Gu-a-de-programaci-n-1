using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio14 : MonoBehaviour
{
    public char letra;
    public int num1;
    public int num2;

    // Start is called before the first frame update
    void Start()
    {
        switch (letra)
        {
            case 's':

                Debug.Log(num1 + num2);
                break;

            case 'r':

                Debug.Log(num1 - num2);
                break;

            case 'p':

                Debug.Log(num1 * num2);
                break;

            case 'd':

                Debug.Log(num1 / num2);
                break;

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
