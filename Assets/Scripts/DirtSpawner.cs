using System.Collections.Generic;
using UnityEngine;

public class DirtSpawner : MonoBehaviour
{
    public List<GameObject> dirtVariants = new List<GameObject>();
    public List<Transform> spawnPoints = new List<Transform>();
    private List<GameObject> dirtTemp = new List<GameObject>();

    public void Spawn()
    { 
        foreach (Transform t in spawnPoints)
        {
            GameObject g = Instantiate(dirtVariants[Random.Range(0, dirtVariants.Count)], t);
            dirtTemp.Add(g);
        }
    }    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
