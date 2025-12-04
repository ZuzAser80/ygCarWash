using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public List<CarHandler> cars = new List<CarHandler>();
    public Animator anim;
    public Transform startPos;
    private CarHandler _temp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnRandomCar();
    }

    private void spawnRandomCar()
    {        
        var toSpawn = cars.Where(x => x.weight >= Random.Range(1f, 100f)).First();
        _temp = Instantiate(toSpawn, startPos.position, startPos.rotation);
        anim.SetTrigger("GoIn");
        //TODO: activate car here
    }

    private void finishWorking()
    {
        Destroy(_temp.gameObject);
        _temp = null;
        anim.SetTrigger("GetOut");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
