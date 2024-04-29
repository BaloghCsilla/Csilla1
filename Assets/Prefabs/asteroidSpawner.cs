

using UnityEngine;

public class asteroidSpawner : MonoBehaviour
{
    [SerializeField] int spawnCount;

    [SerializeField] asteroid[] asteroidPrefabs;  // azt tudjuk berakni, amin rajta van az asteroid script.
    [SerializeField]  float spawnDistance = 5;

    list<asteroid> asteroids = new();  //amik a scene-ben l�teznek aszteroidak, azokat t�rolja
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
            asteroid newAsteroid = Instantiate(prefab);  //m�solatot hozok l�tre
            asteroids.add(newAsteroid);

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
