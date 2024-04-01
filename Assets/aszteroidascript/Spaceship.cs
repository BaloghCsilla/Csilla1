using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    [SerializeField] float Maxspeed = 5;
    [SerializeField] float anglespeed;
    [SerializeField] float acceleration = 5;  // gyorsulás
    Vector3 velocity;   // ha tehetetlenséget akarok, ak el kell tárolnom a vektort

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (y!=0)
        velocity += transform.up * y * Time.deltaTime * acceleration;    // azert transform.up mert y irányba megy a hajo elore
                                                                        // ha transform.forward lenne akkor a z irányba menne elore
                                                                        // ez a gyorsulasa az urhajopnak
        velocity = Vector3.ClampMagnitude(velocity,Maxspeed);    // vektorbol levágunk, (mibõl, mi fölött vágunk)
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
