using UnityEngine;

public class XYMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(0.01f, 0, 0);
        transform.position = transform.position + pos;
    }
}
