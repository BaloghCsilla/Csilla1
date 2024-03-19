using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vektorpractice : MonoBehaviour
{
    
    void Start()
    {
        Vector2 myVector = new(2, 3);
        float x = myVector.x;
        float y = myVector.y;

        Vector2 myherVector = new(4, 9);

        Vector2 summa = myVector + myherVector;    // (6,12)

        Vector2 diff = myVector - myherVector;     // (-2,-6)

        Vector2 szor = 5* diff;    //  (-10-30)

        Vector2 div = summa / 2;   // (3,6)

        float vectorLenght = summa.magnitude;     // magnitude hossza a vektornak, piotagorasz tetelt csinal a program.

        Vector2 normalized = summa.normalized;
    }
}
