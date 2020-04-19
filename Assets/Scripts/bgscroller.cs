using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bgscroller : MonoBehaviour
{

    public float scrollSpeed;
    public float tileSizeZ;
    

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        scrollSpeed = -1;
    }

    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        transform.position = startPosition + Vector3.forward * newPosition;
    }
}