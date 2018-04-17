using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class youWin : MonoBehaviour
{

    public Text myText;
    public static bool isWin;

    // Use this for initialization
    void Start()
    {
        myText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (isWin)
        {
            myText.text = "You Win!";
        }
    }
}