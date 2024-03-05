using UnityEngine;

public class Myfirstscript : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity!");
        Debug.Log("T'm" + name);
    }

    void Update()
    {
        transform.position += Vector3.up * Time.deltaTime;
    }
}