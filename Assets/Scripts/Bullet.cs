using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public enum direction { North, South, East, Weast }

    public float Speed;
    public direction Direction;
    public float Damage;

    private Vector3 traslation;
    // Start is called before the first frame update
    void Start()
    {
        switch (Direction)
        {
            case (direction.North):
                traslation = Vector3.forward;
                break;
            case (direction.South):
                traslation = Vector3.back;
                break;
            case (direction.East):
                traslation = Vector3.right;
                break;
            case (direction.Weast):
                traslation = Vector3.left;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(traslation * Speed * Time.deltaTime);
    }
}
