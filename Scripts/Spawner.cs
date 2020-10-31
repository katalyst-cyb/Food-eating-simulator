using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float time = 30;
    public GameObject spawnobject;
    bool isAvailable = true;
    private float passedtime = 0;


    void Generate()
    {
        GameObject.Instantiate(spawnobject, this.gameObject.GetComponent<Transform>());
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Repeat()
    {
        if(passedtime>=time)
        {
            passedtime = 0;
            Generate();
        }
        passedtime += Time.deltaTime;
    }

    private void FixedUpdate()
    {
        Repeat();
    }
}
