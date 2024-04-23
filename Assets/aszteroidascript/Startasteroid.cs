
using UnityEngine;

public class Startasteroid : MonoBehaviour
{
    [SerializeField] float maxSpeed = 5;
    [SerializeField] float maxAngularSpeed =90;

    
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        rb.angularVelocity = Random.Range(-maxAngularSpeed, maxAngularSpeed);

        Vector2 v = Random.insideUnitCircle * maxSpeed;
       
        rb.velocity = v;
    }

    
    void Update()
    {
        
    }
}
