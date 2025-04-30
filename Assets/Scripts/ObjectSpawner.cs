using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objToSpawn;
    public PlacementMarker placement;

    void Start()
    {
        placement = FindAnyObjectByType<PlacementMarker>();
    }     
    

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantiate(objToSpawn, placement.transform.position,
                placement.transform.rotation);
        }
    }
}
