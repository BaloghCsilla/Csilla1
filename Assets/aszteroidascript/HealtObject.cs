using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtObject : MonoBehaviour
{
    [SerializeField] int startHp;

    void Start()
    {
        currentHp = startHp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
