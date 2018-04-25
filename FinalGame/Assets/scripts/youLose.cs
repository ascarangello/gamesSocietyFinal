using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class youLose : MonoBehaviour
{

    public Text myText;
    public static bool isLose;

    // Use this for initialization
    void Start()
    {
        isLose = false;
        myText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (isLose)
        {
            myText.text = "You Lose!";
        }
    }
}
