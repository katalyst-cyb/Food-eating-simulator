using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameover_TextScr : MonoBehaviour
{
    public static Text txt1;
    public static string value1 = "游戏结束";
    public static Text txt2;
    public static string value2 = "按R键刷新游戏，按B键返回主场景";
    bool isEnded = false;

    // Start is called before the first frame update
    void Start()
    {
        txt1 = GameObject.Find("Gameover").GetComponent<Text>();
        txt1.text = value1;
        txt2 = GameObject.Find("Gameover1").GetComponent<Text>();
        txt2.text = value2;
    }

    // Update is called once per frame
    void Update()
    {
        isEnded = PlayerController.isEnded;
        if(isEnded)
        {
            value1 = "游戏结束";
            txt1.text = value1;
            value2 = "按R键刷新游戏，按B键返回主场景";
            txt2.text = value2;
       }
        else
        {
            value1 = "";
            txt1.text = value1;
            value2 = "";
            txt2.text = value2;
        }
    }
}
