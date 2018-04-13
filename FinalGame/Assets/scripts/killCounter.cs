using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class killCounter : MonoBehaviour
{
    public GameObject duck;
    public Text myText;
    public int numKilled;
    private bool add1;
    // Use this for initialization
    void Start()
    {
        myText.text = "Ducks Liberated: " + numKilled.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(add1)
        {
            numKilled++;
        }
        myText.text = "Ducks Liberated: " + numKilled.ToString();
    }
}
