using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScores : MonoBehaviour
{
    public float player_scores=0;
    public float player_health=100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PickCola()
    {
        player_scores += 5;
        Debug.Log(player_scores);
    }
}
