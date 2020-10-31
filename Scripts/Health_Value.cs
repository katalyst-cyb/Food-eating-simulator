using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Value : MonoBehaviour
{
    public static Text txt;
    public static int value = 100;

    // Start is called before the first frame update
    void Start()
    {
        txt = GameObject.Find("Health_Value").GetComponent<Text>();
        txt.text = value.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
