using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackManagement : MonoBehaviour
{
    public saveFeedbackData saveFeedbackData;
    
    public GameObject furnaceFeedbackImage;
    public GameObject energyFeedbackImage;
    public GameObject friendFeedbackImage;

    public bool furnaceFeedback = false;
    public bool energyFeedback = false;
    public bool friendFeedback = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void showFurnaceFeedback()
    {
        Debug.Log("furnace dentro del show");
        Debug.Log(furnaceFeedback);

        if (furnaceFeedback)
        {
            furnaceFeedbackImage.SetActive(true);
            furnaceFeedback = false;
            //saveFeedbackData.saveFeedbackNow();
        }
            
    }
    public void completeFurnaceFeedback()
    {
        furnaceFeedbackImage.SetActive(false);
    }

    public void showEnergyFeedback()
    {
        if (energyFeedback)
        {
            energyFeedbackImage.SetActive(true);
            energyFeedback = false;
            //saveFeedbackData.saveFeedbackNow();
        }
    }
    public void completeEnergyFeedback()
    {
        energyFeedbackImage.SetActive(false);
    }

    public void showFriendFeedback()
    {
        if (friendFeedback)
        {
            friendFeedbackImage.SetActive(true);
            friendFeedback = false;
            Debug.Log("BRO CUANDO MUESTRAS EL FRIEND");
            Debug.Log(friendFeedback);
            //saveFeedbackData.saveFeedbackNow();
        }
         
    }
    public void completeFriendFeedback()
    {
        Debug.Log("Se llamo el complete de friend");
        friendFeedbackImage.SetActive(false);
    }
}
