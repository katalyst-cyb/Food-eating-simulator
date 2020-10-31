using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery_Scr : MonoBehaviour
{
    int damage = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Health_Value.value -= damage;
            Health_Value.txt.text = Health_Value.value.ToString();
        }
        Destroy(this.gameObject);
    }
}
