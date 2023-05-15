using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Zombie : MonoBehaviour
{
    public GameObject zombieChunks;
    public int chunks = 5;
    public CountManager countManager;//it won't let me assign a gameobject to the prefab.


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Blade")
        {
            for (int i = 0; i < chunks; i++)
            {
                Instantiate(zombieChunks, transform.position, transform.rotation);
                countManager.IncreaseCount();
            }
            
            Destroy(gameObject);

        }
    }

    private void OnEnable()
    {
        countManager = FindObjectOfType<CountManager>();
    }




}
