

using UnityEngine;

public class asteroidspawner : MonoBehaviour
{
    [SerializeField] int spawnCount;

    [SerializeField] Startasteroid[] asteroidPrefabs;


     void Start()
    {
        Spawn(); 
    }

     void Spawn()
    {
        for (int i = 0; i < spawnCount; i++) 
        {
            int randomIndex = Random.Range(0, asteroidPrefabs.Length);
            Startasteroid prefab = asteroidPrefabs[randomIndex];
            Startasteroid newAsterois = Instantiate(prefab);

            Vector2 position = Random.insideUnitCircle;
            position.Normalize();
            position *= spawnDistance;

            newStartasteroid.transform.position = position;
                
                
        }
    }
}
