using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TikkuSpawniSkripti saa TikkuSpawnaajan spawnaamaan uudet tikut tikku-prefabist‰ halutulla tiheydell‰ ja keskipoikkeamalla
public class TikkuSpawniSkripti : MonoBehaviour
{

    public GameObject tikku;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 24;

    // Start is called before the first frame update
    void Start()
    {
        SpawnStick();
    }

    // Update is called once per frame
    void Update()
    {
        //k‰ynnist‰‰ tikun spawnauksen frameratesta riippumattomasti spawnRaten m‰‰ritt‰min v‰lein
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnStick();
            timer = 0;
        }


        
    }
    //SpawnStick() spawnaa uudet tikut 
    void SpawnStick()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(tikku, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }

}
