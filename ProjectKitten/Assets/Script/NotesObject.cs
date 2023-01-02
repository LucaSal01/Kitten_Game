using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesObject : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPress;
    public GameObject colliderS;
    public GameObject hitEffect,goodEffect,perfectEffect,missEffect;

    void Start()
    {
    }

    void Update()
    {
        float dist = Vector2.Distance(colliderS.transform.position,transform.position);
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)
            {
                gameObject.SetActive(false);
                if (dist < 0.15f)
                {
                    Instantiate(perfectEffect,new Vector2(-9f,7.39f), 
                        perfectEffect.transform.rotation);
                    Debug.Log("Perfect");
                    GameManager.instance.PerfectHit();
                }
                else if (dist < 0.25f )
                {
                    Instantiate(goodEffect, new Vector2(-9f, 7.39f), 
                        goodEffect.transform.rotation);
                    Debug.Log("Good");
                    GameManager.instance.GoodHit();
                }
                else if (dist < 0.4f)
                {
                    Instantiate(hitEffect, new Vector2(-9f, 7.39f),
                        hitEffect.transform.rotation);
                    Debug.Log("Hit on time");
                    GameManager.instance.NormalHit();
                }
                else
                {
                    Instantiate(missEffect, new Vector2(-9f, 7.39f), missEffect.
                        transform.rotation);
                    GameManager.instance.NoteMissed();
                }

            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;
            GameManager.instance.NoteMissed();
        }
    }
}
