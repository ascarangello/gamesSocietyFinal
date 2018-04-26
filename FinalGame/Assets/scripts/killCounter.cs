using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class killCounter : MonoBehaviour
{

    public Text myText;
    public static int start = 0;
    public int numToWin;

    // Use this for initialization
    void Start()
    {
        start = 0;
        myText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!youWin.isWin)
        {
            myText.text = "Score: " + start;
        }
        if(start >= numToWin)
        {
            youWin.isWin = true;
        }
    }
}
