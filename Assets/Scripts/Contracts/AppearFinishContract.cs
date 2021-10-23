using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AppearFinishContract : MonoBehaviour
{
    public Button FinishContract;
    public GameObject AnalizeContract;



    public void appearFinishButton()
    {
        StartCoroutine(Wait());
       
        
    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(10);
        FinishContract.gameObject.SetActive(true);
        AnalizeContract.gameObject.SetActive(false);
        
    }
}
