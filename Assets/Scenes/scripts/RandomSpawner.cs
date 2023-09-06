using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cabbagePrefab; 

   

    // Update is called once per frame
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10,11)); 
            Instantiate(cabbagePrefab, randomSpawnPosition, Quaternion.identity); 
        }
    }



}
