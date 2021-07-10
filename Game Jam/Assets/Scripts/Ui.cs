using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui : MonoBehaviour
{

    public Text lifesText;

    public Heart heart;

    // Update is called once per frame
    void Update()
    {
        lifesText.text = "Lifes: " + heart.lifes;
    }
}
