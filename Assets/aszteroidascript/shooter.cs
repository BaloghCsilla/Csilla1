
using System.Net;
using UnityEngine;

public class shooter : MonoBehaviour
{
    [SerializeField] GameObject projectileprototype;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newProjectile = Instantiate(projectileprototype);
            newProjectile.transform.position = transform.position;
            newProjectile.transform.rotation = transform.rotation;

        }
    }
}
