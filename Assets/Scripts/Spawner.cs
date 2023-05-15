using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPrefab;
    public Transform parentObject;
    public void SpawnObject()
    {
        Instantiate(spawnPrefab,
            parentObject.position,
            parentObject.rotation,
            parentObject
            );                
    }
}
