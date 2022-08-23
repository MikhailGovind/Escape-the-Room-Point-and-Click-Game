using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsScript : MonoBehaviour
{
    public AudioSource water;
    public AudioSource door;

    public void Water()
    {
        water.Play();
    }

    public void Door()
    {
        door.Play();
    }
}
