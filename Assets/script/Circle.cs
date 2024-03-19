
using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] float radius;

    void Start()
    {
        float r = radius;
        float K = 2 * r * 3.14f;
        float T = Mathf.Pow(r, 2) * 3.14f; 
        Debug.Log("Kerület: " + K);
        Debug.Log("Terület: " + T);
    }        
}
