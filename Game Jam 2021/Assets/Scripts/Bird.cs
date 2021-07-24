using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private float speed;
    private string ability;

    public Bird()
    {
        speed = 5.0f;
        ability = "fly";
    }

    public float Speed { get => speed; set => speed = value; }
    public string Ability { get => ability; set => ability = value; }
}
