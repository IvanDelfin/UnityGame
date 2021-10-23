using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationFlechas : MonoBehaviour
{
    private float timer;
    private float timer2;

    private int nextAni = 0;

    public Animator flechasAnimar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;
        timer2 += 1 * Time.deltaTime;
        if ((timer >= 5) && (nextAni == 1))
        {
            Debug.Log("lol XD");
            //animatorTutorial.SetInteger("AnimationStage", 1);
        }
        else if ((timer >= 10) && (nextAni == 2))
        {
            //animatorTutorial.SetInteger("AnimationStage", 2);
        }

        if (timer2 >= 5)
        {
            nextAni++;
            timer2 = 0;
        }
    }
}
