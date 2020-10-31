using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Value : MonoBehaviour
{
    public static Text txt;
    public static int value = 0;

    // Start is called before the first frame update
    void Start()
    {
        txt = GameObject.Find("Score_Value").GetComponent<Text>();
        txt.text = value.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
