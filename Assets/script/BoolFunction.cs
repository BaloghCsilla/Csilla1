using UnityEngine;

public class BoolFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool f1 = true;
        bool f2 = false;

        int ammo = 10;
        bool havegun = true;

        bool haveAmmo = ammo > 0;
        bool canWeShoot = havegun && haveAmmo;  // és

        //---------

        bool isOnGround = false;
        bool canAirJump = true;

        bool CANjUMP = isOnGround || canAirJump;  // vagy

        //------

        bool isInTheAir = !isOnGround;   //Negálás
        
    }        
}
