using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Keypad : MonoBehaviour
{
    public GameObject keypad;
    public GameObject PoemPanel;
    public GameObject PoemButton;
    public GameObject ChestButton;
    public GameObject ChestImage;
    public TextMeshProUGUI text;
    public string answer;

    public AudioSource button;
    public AudioSource correct;
    public AudioSource wrong;

    public void Number(int number)
    {
        text.text += number.ToString();
        //button.Play();
    }

    public void Enter()
    {
        if (text.text == answer)
        {
            correct.Play();
            text.text = "Right";
            PoemPanel.SetActive(true);
            PoemButton.SetActive(true);
            keypad.SetActive(false);
            ChestButton.SetActive(false);
            ChestImage.SetActive(true);
        }
        else
        {
            {
                wrong.Play();
                text.text = "Wrong";
            }
        }
    }    

    public void Clear()
    {
        {
            text.text = "";
            //button.Play();
        }
    }
}
