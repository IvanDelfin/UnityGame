using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
/**public class CollisionVars
{
    public GameObject flecha;
    public GameObject flecha2;
    public GameObject flecha3;
}
**/

public class AnimaciónTutorial : MonoBehaviour
{
    public Animator animatorTutorial;
    public GameObject tutorialBotGO;
    public GameObject camaraGO;

    public Player player;

    /**
    public GameObject flecha;
    public GameObject flecha2;
    public GameObject flecha3;

    public GameObject flechaIz;
    public GameObject flechaIz2;
    public GameObject flechaIz3;
    **/
    //public CollisionVars flechasTutorial;

    private float timer;
    private float timer2;
    private int nextAni = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.tutorial)
        {
            camaraGO.GetComponent<CameraMovement>().enableMove = false;
            timer += 1 * Time.deltaTime;
            timer2 += 1 * Time.deltaTime;
            if((timer >= 5) && (nextAni == 1))
            {
                Debug.Log("ya muevete");
                transform.position += new Vector3(10, -3, 0) * Time.deltaTime * 8;
                animatorTutorial.SetInteger("AnimationStage", 1);
            }
            else if((timer >= 10) && (nextAni == 2))
            {
                animatorTutorial.SetInteger("AnimationStage", 2);
                /**
                flechaIz.SetActive(true);
                flechaIz2.SetActive(true);
                flechaIz3.SetActive(true);
                **/
            }
            else if((timer >= 15) && (nextAni == 3))
            {
                transform.position += new Vector3(-20, 0, 0) * Time.deltaTime * 8;
                animatorTutorial.SetInteger("AnimationStage", 3);
                /**
                flechaIz.SetActive(false);
                flechaIz2.SetActive(false);
                flechaIz3.SetActive(false);
                **/
            }
            else if ((timer >= 20) && (nextAni == 4))
            {
                //flechasStuffXD.SetInteger("FlechasAnimation", 1);
                animatorTutorial.SetInteger("AnimationStage", 4);
                /**
                flecha.SetActive(true);
                flecha2.SetActive(true);
                flecha3.SetActive(true);
                **/
            }
            else if (timer >= 30)
            {
                tutorialBotGO.SetActive(false);
                /**
                flecha.SetActive(false);
                flecha2.SetActive(false);
                flecha3.SetActive(false);
                **/
                camaraGO.GetComponent<CameraMovement>().enableMove = true;
            }

            if(timer2 >= 5)
            {
                nextAni++;
                timer2 = 0;
            }
        }

    }
}
