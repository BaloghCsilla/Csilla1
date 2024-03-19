using UnityEngine;

public class ControlStructures : MonoBehaviour
{
    [SerializeField] int ammo = 10;
    
    void Update()   //folyamatosan fut le
    {
        bool pressKey = Input.GetKeyDown(KeyCode.Space); 
        
        if (pressKey)
        if (ammo > 0)
        {
            Debug.Log("BANG!");
            ammo--;
        }
        else 
        {
            Debug.Log("Klikk!");
        }
    }    
}

