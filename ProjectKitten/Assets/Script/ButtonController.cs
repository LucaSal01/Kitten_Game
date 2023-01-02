using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer TheSR;
    public Sprite defaultImage;
    public Sprite pressedImage;
    public KeyCode keyToPress;

    void Start()
    {
        TheSR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            TheSR.sprite = pressedImage;
        }
        
        if(Input.GetKeyUp(keyToPress))
        {
            TheSR.sprite = defaultImage;
        }
    }
}
