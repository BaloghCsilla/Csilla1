using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtObject : MonoBehaviour
{
    [SerializeField] int startHp;

    [SerializeField] int collisionDamage;

    int currentHp;

    public void Damage(int damage)
    {
        damage = damage < 0 ? 0 : damage;   //egyik megold�s

        /* if (damage < 0)     //2. megold�s
             damage = 0;

         damage = Mathf.Max(0, damage);   // 3. megold�s

         if (damage < 0)     //4. megold�s
             return;
        */

        currentHp = Mathf.Max(0, currentHp - damage);



        if (currentHp <= 0)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Damage(collisionDamage);
    }

    void Start()
    {
        currentHp = startHp;
    }

}
