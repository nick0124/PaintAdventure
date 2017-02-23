using UnityEngine;
using System.Collections;

public class PlayerCarSpawner : MonoBehaviour {

    public GameObject[] cars;
    private int carID;

	// Use this for initialization
	void Start () {
        carID = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    void Spawn()
    {
        // Instantiate a random enemy.

        Instantiate(cars[carID], transform.position, transform.rotation);

    }
     
}
