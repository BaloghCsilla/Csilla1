using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEditor;
using UnityEngine;

public class Projectitle : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float lifetime = 2;
    [SerializeField] float damage = 10;

    float time;

    void Start()
    {
        Destroy(gameObject, lifetime); 
    }

    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
                           
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

}
