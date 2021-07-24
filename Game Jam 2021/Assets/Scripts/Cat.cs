using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    private float speed;
    private string ability;

    public Cat()
    {
        speed = 6.0f;
        ability = "sight";
    }

    public float Speed { get => speed; set => speed = value; }
    public string Ability { get => ability; set => ability = value; }
}
