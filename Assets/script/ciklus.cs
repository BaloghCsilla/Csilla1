using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ciklus : MonoBehaviour
{
    
    void Start()
    {
        int i = 1;
        while (i <= 100) 
        {
            Debug.Log(i);
            i++;
        }
        Debug.Log("v�GE");


        //-------
        for (int j = 0; j <= 100; j++)
        {
            Debug.Log(j);
        }
    }
}
