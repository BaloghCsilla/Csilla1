using System.Collections.Generic;
using UnityEngine;

public class asteroidSpawner : MonoBehaviour
{
    [SerializeField] int spawnCount;

    [SerializeField] asteroid[] asteroidPrefabs;  // azt tudjuk berakni, amin rajta van az asteroid script.
    [SerializeField]  float spawnDistance = 5;

    
    List<asteroid> asteroids = new();  //amik a scene-ben léteznek aszteroidak, azokat tárolja
     void Start()
    {
        Spawn(); 
    }

     void Spawn()
    {
        for (int i = 0; i < spawnCount; i++) 
        {
            int randomIndex = Random.Range(0, asteroidPrefabs.Length);    //kisorsolom
            asteroid prefab = asteroidPrefabs[randomIndex];   //kiveszem
            asteroid newAsteroid = Instantiate(prefab);  //másolatot hozok létre
            asteroids.Add(newAsteroid);

            Vector2 position = Random.insideUnitCircle;
            position.Normalize();
            position *= spawnDistance;

            newAsteroid.transform.position = position;
                
                
        }
    }

     public void Removeasteroid(asteroid asteroid)
    {
        asteroids.Remove(asteroid);
        if (asteroids.Count == 0)
        {
            Debug.Log("STAGE CLEARED!");
        }
    }
}
