using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtObject : MonoBehaviour
{
    [SerializeField] int startHp;

    [SerializeField] int collisionDamage;

    int currentHp;
    bool isSetup = false;

    public void Damage(int damage)
    {
        if (!isSetup) return;
        damage = damage < 0 ? 0 : damage;   //egyik megoldás

        /* if (damage < 0)     //2. megoldás
             damage = 0;

         damage = Mathf.Max(0, damage);   // 3. megoldás

         if (damage < 0)     //4. megoldás
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
        isSetup = true;
    }

}
