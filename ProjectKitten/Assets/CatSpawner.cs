using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawner : MonoBehaviour
{
    public GameObject[] cats;
    public float Timercat1;
    public float Timercat2;
    public float Timercat3;
    public float Timercat4;
    public float Timercat5;




    void Start()
    {
        Spawn();
    }

    void Update()
    {
        Spawn();
        Spawn2();
        Spawn3();
        Spawn4();
        Spawn5();
    }

    public void Spawn()
    {
        if (Timercat1 > 0)
        {
            Timercat1 -= Time.deltaTime;
        }
        if (Timercat1 < 0)
        {
          Instantiate(cats[0].transform, new Vector2(5.79f, 2.25f), cats[0].transform.rotation);
            Timercat1 = 0;
        }
    }
    public void Spawn2()
    {
        if (Timercat2 > 0)
        {
            Timercat2 -= Time.deltaTime;
        }
        if (Timercat2 < 0)
        {
            Instantiate(cats[1].transform,new Vector2(2.9f,3.2f), cats[1].transform.rotation);
            Timercat2 = 0;
        }
    }
    public void Spawn3()
    {
        if (Timercat3 > 0)
        {
            Timercat3 -= Time.deltaTime;
        }
        if (Timercat3 < 0)
        {
            Instantiate(cats[2].transform, new Vector2(3.2f,1.4f), cats[2].transform.rotation);
            Timercat3 = 0;
        }
    }
    public void Spawn4()
    {
        if (Timercat4 > 0)
        {
            Timercat4 -= Time.deltaTime;
        }
        if (Timercat4 < 0)
        {
            Instantiate(cats[3].transform, new Vector2(0.9f, 1.6f), cats[3].transform.rotation);
            Timercat4 = 0;
        }
    }
    public void Spawn5()
    {
        if (Timercat5 > 0)
        {
            Timercat5 -= Time.deltaTime;
        }
        if (Timercat5 < 0)
        {
            Instantiate(cats[4].transform, new Vector2(-2.25f, 3.2f), cats[4].transform.rotation);
            Instantiate(cats[5].transform, new Vector2(-0.92f, 2.2f), cats[5].transform.rotation);
            Instantiate(cats[6].transform, new Vector2(0.55f, 3.18f), cats[6].transform.rotation);
            Timercat5 = 0;
        }
    }
}
