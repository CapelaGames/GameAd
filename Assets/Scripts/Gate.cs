using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gate : MonoBehaviour
{
    public TMP_Text texts;
    public int multiply = 1;
    public int add = 0;

    void Start()
    {
        int choice = Random.Range(0, 5);
        if (choice == 0)
        {
            multiply = Random.Range(2, 5);
            text.text = x " + multiply.ToString();
        }
        else
        {
            add = Random.Range(1, 5,);
            text.text = "+ " + add.ToString();
        }
    }

}


