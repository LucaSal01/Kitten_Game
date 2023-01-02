using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesScroller : MonoBehaviour
{
    public float beatTempo;

    public bool hasStarted;

    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted)
        {
        }else
        {
            transform.position -= new Vector3(beatTempo * Time.deltaTime,0f,0f);
        }
    }
}
