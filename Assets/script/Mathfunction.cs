using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mathfunction : MonoBehaviour
{
    [SerializeField] float in1, in2;
    [SerializeField] float power, absolute, sign, rounded, cailed, floored;
    [SerializeField] float min, max, sqrt;
    
    void Start()
    {
        power = Mathf.Pow(in1, in2);
        absolute = Mathf.Abs(in1);
        sign = Mathf.Sign(in1);
        rounded = Mathf.Round(in1);
        cailed = Mathf.Ceil(in1);
        floored = Mathf.Floor(in1);
        min = Mathf.Min(in1);
;       max = Mathf.Max(in1);
        sqrt = Mathf.Sqrt(in1);
    }       
}
