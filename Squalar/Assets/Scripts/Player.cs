using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 5.0f;
    public float ScaleSpeed = 0.05f;
    public float MaxSize = 50f;
    public float MinSize = 1.5f;
    public Renderer sprite;

    // Use this for initialization
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Character();
        //Commands();
        Commands2();
    }

    void Commands()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.UpArrow)) //Enlarge Scales
        {
            transform.localScale += new Vector3(ScaleSpeed, ScaleSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow)) // Shrink Scales
        {
            transform.localScale -= new Vector3(ScaleSpeed, ScaleSpeed, 0);
        }
    }
    void Commands2()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float PosX = horizontal * 2;
        transform.position = new Vector3(PosX, 2f, 0);
    }
     void Character()
    {
        transform.localScale=  new Vector3(Mathf.Clamp(1.5f, 0, 100.0f), 1.5f, 0); // Clamp both X and Y Scales to 7
    }
}
