using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTutorialBot : MonoBehaviour
{
    public Animator RobotAni;
    public Animator flechasIzq;

    public Player player;

    public GameObject flecha00;
    public GameObject flecha01;
    public GameObject flecha02;

    public GameObject flechaiz00;
    public GameObject flechaiz01;
    public GameObject flechaiz02;
    public GameObject flechaiz03;
    public GameObject flechaoz04;

    public GameObject flechaB00;
    public GameObject flechaB01;
    public GameObject flechaB02;
    public GameObject flechaB03;
    public GameObject flechaB04;
    public GameObject flechaB05;

    public GameObject TextoTut00;
    public GameObject TextoTut01;
    public GameObject TextoTut02;
    public GameObject TextoTut03;
    public GameObject TextoTut04;
    public GameObject TextoTut05;
    public GameObject TextoTut06;
    public GameObject TextoTut07;
    public GameObject TextoTutFaltante;
    public GameObject TextoTut08;
    public GameObject TextoTut09;
    public GameObject TextoTut10;
    public GameObject TextoTut11;
    public GameObject TextoTut12;
    public GameObject TextoTut13;
    public GameObject TextoTut14;
    public GameObject TextoTut15;
    public GameObject TextoTut16;
    public GameObject TextoTut17;
    public GameObject TextoTut18;
    public GameObject TextoTut19;
    public GameObject TextoTut20;
    public GameObject TextoTut21;
    public GameObject TextoTut22;

    private float timer;
    private float timer2;

    private int nextAni = 1;

    //public Animator flechasAnimar;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    // Si estan continuando el proyecto, esta parte del codigo fue hecho por Ivan Delfin A01024265 (No tengan miendo de contactarme :D)
    // Son puros IFs, checa el timer para ver si le toca a la animación
    // utilizo nextAni para que la animation solo pase una vez
    // la condicion es >= porque timer nunca llega a ser un numero exacto
    void Update()
    {
        timer += 1 * Time.deltaTime;
        timer2 += 1 * Time.deltaTime;
        if (timer >= 3 && player.tutorial)
        {
            if ((timer >= 5) && (nextAni == 1))
            {
                RobotAni.SetTrigger("Wave");
                nextAni++;
                TextoTut00.SetActive(true);
                //"Bienvenido, soy TerniBot..."
            }
            if ((timer >= 10) && (nextAni == 2))
            {
                RobotAni.SetTrigger("Breathing IDLE");
                nextAni++;
                TextoTut00.SetActive(false);
                TextoTut01.SetActive(true);
                //"A continuación te enseñaré..."
            }
            if ((timer >= 15) && (nextAni == 3))
            {
                RobotAni.SetTrigger("Breathing IDLE");
                nextAni++;
                TextoTut01.SetActive(false);
                TextoTut02.SetActive(true);
                //"Lo primero que debes..."
            }

            if ((timer >= 20) && (nextAni == 4))
            {
                Debug.Log("lol XD1");
                transform.Rotate(0, 350f, 0);

                RobotAni.SetTrigger("Walk");

                nextAni++;
                TextoTut02.SetActive(false);
                //Caminar a la derecha
            }
            if ((timer >= 22) && (nextAni == 5))
            {
                RobotAni.SetTrigger("Look And Point Right");

                flecha00.SetActive(true);
                nextAni++;
                TextoTut03.SetActive(true);
                //"Estos son los TernCoins..."
            }
            if ((timer >= 27) && (nextAni == 6))
            {
                RobotAni.SetTrigger("Look And Point Right");
                flecha00.SetActive(false);
                flecha01.SetActive(true);
                nextAni++;
                TextoTut03.SetActive(false);
                TextoTut04.SetActive(true);
                //"Este es el acero que..."
            }
            if ((timer >= 32) && (nextAni == 7))
            {
                RobotAni.SetTrigger("Look And Point Right");

                flecha01.SetActive(false);
                flecha02.SetActive(true);
                nextAni++;
                TextoTut04.SetActive(false);
                TextoTut05.SetActive(true);
                //"Este es tu energía..."
            }
            if ((timer >= 37) && (nextAni == 8))
            {
                RobotAni.SetTrigger("Talk1");

                flecha02.SetActive(false);
                nextAni++;
                TextoTut05.SetActive(false);
                TextoTut06.SetActive(true);
                //"Mientras más de estos recursos..."
            }
            if ((timer >= 42) && (nextAni == 9))
            {
                RobotAni.SetTrigger("Walk");
                transform.Rotate(0, 170f, 0);

                nextAni++;
                TextoTut06.SetActive(false);
                //Camina para atras
            }
            if ((timer >= 44) && (nextAni == 10))
            {
                RobotAni.SetTrigger("Talk2");
                transform.Rotate(0, 190f, 0);
                nextAni++;
                TextoTutFaltante.SetActive(true);
                //"Ahora que ya conoces..."
            }
            if ((timer >= 49) && (nextAni == 11))
            {
                RobotAni.SetTrigger("Talk1");

                nextAni++;
                TextoTutFaltante.SetActive(false);
                TextoTut07.SetActive(true);
                //"Estos son los edificios..."
            }
            if ((timer >= 54) && (nextAni == 12))
            {
                RobotAni.SetTrigger("Kneel Down");

                flechaB00.SetActive(true);
                nextAni++;
                TextoTut07.SetActive(false);
                TextoTut08.SetActive(true);
                //"Este es la mina..."
            }
            if ((timer >= 59) && (nextAni == 13))
            {
                RobotAni.SetTrigger("Kneel Down");

                flechaB01.SetActive(true);
                flechaB00.SetActive(false);
                nextAni++;
                TextoTut08.SetActive(false);
                TextoTut09.SetActive(true);
                //"Este es el horno..."
            }
            if ((timer >= 64) && (nextAni == 14))
            {
                RobotAni.SetTrigger("Kneel Down");

                flechaB02.SetActive(true);
                flechaB01.SetActive(false);
                nextAni++;
                TextoTut09.SetActive(false);
                TextoTut10.SetActive(true);
                //"Este es la empacadora..."
            }
            if ((timer >= 69) && (nextAni == 15))
            {
                RobotAni.SetTrigger("Kneel Down");

                flechaB03.SetActive(true);
                flechaB02.SetActive(false);
                nextAni++;
                TextoTut10.SetActive(false);
                TextoTut11.SetActive(true);
                //"Este el el [...] ventas..."
            }
            if ((timer >= 74) && (nextAni == 16))
            {
                RobotAni.SetTrigger("Kneel Down");

                flechaB04.SetActive(true);
                flechaB03.SetActive(false);
                nextAni++;
                TextoTut11.SetActive(false);
                TextoTut12.SetActive(true);
                //"Este es el generador electrico..."
            }
            if ((timer >= 79) && (nextAni == 17))
            {
                RobotAni.SetTrigger("Kneel Down");

                flechaB05.SetActive(true);
                flechaB04.SetActive(false);
                nextAni++;
                TextoTut12.SetActive(false);
                TextoTut13.SetActive(true);
                //"Estas son las calles..."
            }
            if ((timer >= 84) && (nextAni == 18))
            {
                RobotAni.SetTrigger("Talk1");
                flechaB05.SetActive(false);
                nextAni++;
                TextoTut13.SetActive(false);
                TextoTut14.SetActive(true);
                //"Puedes construir cada edificio..."
            }
            if ((timer >= 89) && (nextAni == 19))
            {
                RobotAni.SetTrigger("Talk2");
                nextAni++;
                TextoTut14.SetActive(false);
                TextoTut15.SetActive(true);
                //"Por ultimo tenemos la seccion..."
            }
            if ((timer >= 94) && (nextAni == 20))
            {
                RobotAni.SetTrigger("Walk");
                transform.Rotate(0, 10f, 0);
                nextAni++;
                TextoTut15.SetActive(false);
            }
            if ((timer >= 96) && (nextAni == 21))
            {
                RobotAni.SetTrigger("Look And Point Left");
                flechasIzq.SetBool("XPbool", true);

                flechaiz00.SetActive(true);
                nextAni++;
                TextoTut16.SetActive(true);
                //"En la parte superior..."
            }
            if ((timer >= 101) && (nextAni == 22))
            {
                flechasIzq.SetBool("XPbool", false);
                RobotAni.SetTrigger("Look And Point Left");

                flechaiz01.SetActive(true);
                flechaiz00.SetActive(false);
                nextAni++;
                TextoTut16.SetActive(false);
                TextoTut17.SetActive(true);
                //"En seguida [..] amigos..."
            }
            if ((timer >= 106) && (nextAni == 23))
            {
                RobotAni.SetTrigger("Look And Point Left");

                flechaiz02.SetActive(true);
                flechaiz01.SetActive(false);
                nextAni++;
                TextoTut17.SetActive(false);
                TextoTut18.SetActive(true);
                //"Este es el boton de pausa..."
            }
            if ((timer >= 111) && (nextAni == 24))
            {
                RobotAni.SetTrigger("Talk1");
                flechaiz02.SetActive(false);
                nextAni++;
                TextoTut18.SetActive(false);
                TextoTut19.SetActive(true);
                //"Es importante guardar tu progreso..."
            }
            if ((timer >= 116) && (nextAni == 25))
            {
                RobotAni.SetTrigger("Look And Point Left");

                flechaiz03.SetActive(true);
                nextAni++;
                TextoTut19.SetActive(false);
                TextoTut20.SetActive(true);
                //"Este es el botón de minijuegos..."
            }
            if ((timer >= 121) && (nextAni == 26))
            {
                RobotAni.SetTrigger("Look And Point Left");
                flechaiz03.SetActive(false);
                flechaoz04.SetActive(true);
                nextAni++;
                TextoTut20.SetActive(false);
                TextoTut21.SetActive(true);
            }
            if ((timer >= 126) && (nextAni == 27))
            {
                flechaoz04.SetActive(false);
                RobotAni.SetTrigger("Charge");
                TextoTut21.SetActive(false);
                TextoTut22.SetActive(true);
                nextAni++;
            }
            if ((timer >= 131) && (nextAni == 28))
            {
                TextoTut22.SetActive(false);
                nextAni++;
            }
            if (nextAni == 29)
            {
                player.tutorial = false;
            }

            /*
            if (timer2 >= 5)
            {
                nextAni++;
                timer2 = 0;
            }
            */
        }

    }
}
