﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fries_Scr : MonoBehaviour
{
    int addscore = 7;
    int damage = 5;

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
            Score_Value.value += addscore;
            Score_Value.txt.text = Score_Value.value.ToString();
        }
        else
        {
            Health_Value.value -= damage;
            Health_Value.txt.text = Health_Value.value.ToString();
        }
        Destroy(this.gameObject);
    }
}
