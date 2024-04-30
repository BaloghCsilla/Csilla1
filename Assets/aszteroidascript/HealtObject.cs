using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealtObject : MonoBehaviour
{
    [SerializeField] int startHp;

    [SerializeField] int collisionDamage;

    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] List<Sprite> sprites;
    [SerializeField] TMP_Text healthText;

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

        UpdateSprite();
        UpdateHealthText();

        if (currentHp <= 0)
            Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Damage(collisionDamage);
    }

    void Start()
    {
        currentHp = startHp;
        isSetup = true;

        UpdateHealthText();
    }

    void UpdateHealthText()
    {
            if (healthText != null)
            healthText.text = "Health:" + currentHp;
    }

    private void OnValidate()
    {
        if (spriteRenderer == null)
            spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void UpdateSprite() 
    {
        if (spriteRenderer == null) return;
        if (sprites == null || sprites.Count == 0) return;

        float healthRate = (float)currentHp / startHp;    //0-1

        healthRate = 1 - healthRate;    //1-0

        int index = Mathf.RoundToInt(healthRate * (sprites.Count - 1));   // (sprites.Count - 1) -tõl megyunk0-ig
        spriteRenderer.sprite = sprites[index];
    }
}
