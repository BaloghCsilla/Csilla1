using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    [SerializeField] float Maxspeed = 5;
    [SerializeField] float anglespeed;
    [SerializeField] float acceleration = 5;  // gyorsul�s
    Vector3 velocity;   // ha tehetetlens�get akarok, ak el kell t�rolnom a vektort

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (y!=0)
        velocity += transform.up * y * Time.deltaTime * acceleration;    // azert transform.up mert y ir�nyba megy a hajo elore
                                                                        // ha transform.forward lenne akkor a z ir�nyba menne elore
                                                                        // ez a gyorsulasa az urhajopnak
        velocity = Vector3.ClampMagnitude(velocity,Maxspeed);    // vektorbol lev�gunk, (mib�l, mi f�l�tt v�gunk)
        // direction.Normalize();

        Vector3 step = velocity * Time.deltaTime;
        transform.position += step;

        transform.Rotate(0,0,anglespeed * -x * Time.deltaTime);   // itt adom meg h a jobbra balra nyilall forogjak x tengelyen

        //Vector3 rot = transform.rotation.eulerAngles;//
        /*float rotaion2D = transform.rotation.eulerAngles.z;
        float targetrotation  = Vector2.SignedAngle(direction,Vector2.up);
        float nextRotation = Mathf.MoveTowardsAngle(rotaion2D, targetrotation, Time.deltaTime * anglespeed);
        transform.rotation= Quaternion.Euler(0,0, targetrotation);*/
    }


}
