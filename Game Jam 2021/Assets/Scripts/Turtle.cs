using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : MonoBehaviour
{
    private float speed;
    private string ability;

    public Turtle()
    {
        speed = 3.0f;
        ability = "swim";
    }

    public float Speed { get => speed; set => speed = value; }
    public string Ability { get => ability; set => ability = value; }
}
