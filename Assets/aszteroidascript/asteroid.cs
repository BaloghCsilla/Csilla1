
using UnityEngine;

public class asteroid : MonoBehaviour
{
    [SerializeField] float maxSpeed = 5;
    [SerializeField] float maxAngularSpeed =90;

    
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        rb.angularVelocity = Random.Range(-maxAngularSpeed, maxAngularSpeed); //itt sorsolom h melyik ketto kozott sorsol

        Vector2 v = Random.insideUnitCircle * maxSpeed;
       
        rb.velocity = v;
    }

    
    void OnDestroy()
    {
        FindObjectOfType<asteroidSpawner>().Removeasteroid(this);
    }

    
}


