using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenTeleporter : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    new Collider2D collider2D;
    new Camera camera;


    void Start()
    {
        camera = Camera.main;
        spriteRenderer = GetComponent<SpriteRenderer>();
        collider2D = GetComponent<Collider2D>();
    }

    void Update()
    {
        Vector2 cameraPoint = camera.transform.position;
        Vector2 cameraSize = new Vector2(camera.orthographicSize * camera.aspect, camera.orthographicSize);
        Rect cameraRect = new Rect(cameraPoint - cameraSize, cameraSize * 2);
        Bounds ObjectBounds = collider2D.bounds;
    }

    void OnDrawGizmos()
    {
        if (collider2D == null) return;

        Bounds bounds = collider2D.bounds;  // Befoglaló téglatest

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(bounds.center, bounds.size);
    }


    //
}

