using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 4.20f;
    public CharacterController myController;

    // Start is called before the first frame update
    void Start()
    {
        print("Ello Mofo!");
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myController.Move(Vector3.up * speed);
            print("Giggity Hop!");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            myController.Move(Vector3.left * speed);
            print("moved left!");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            myController.Move(Vector3.forward * speed);
            print("moved forward!");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            myController.Move(Vector3.right * speed);
            print("moved right!");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            myController.Move(Vector3.back * speed);
            print("Giggity Bottom");
        }

    }
}
