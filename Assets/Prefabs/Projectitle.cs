using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEditor;
using UnityEngine;

public class Projectitle : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float lifeTime = 2;
    [SerializeField] int damage = 10;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        HealtObject healthObject = other.GetComponent<HealtObject>();
        if (healthObject != null)
        {
            healthObject.Damage(damage);
            Destroy(gameObject);
        }
    }

}
