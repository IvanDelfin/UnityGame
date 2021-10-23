using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class saveFeedbackData : MonoBehaviour
{
    public FeedbackManagement feedback;
    public Player player;
    string JSONUrl;
    public void saveFeedbackNow()
    {
        StartCoroutine(updateFeedback());
    }
    public void addFirstFeedback()
    {
        StartCoroutine(addFeedbackFirstTime());
    }
    IEnumerator updateFeedback()
    {
        FeedbackObjectDB feedbackData = new FeedbackObjectDB();
 
            feedbackData.furnaceFeedback = feedback.furnaceFeedback;
            feedbackData.energyFeedback = feedback.energyFeedback;
            feedbackData.friendFeedback = feedback.friendFeedback;

        string JSONData = JsonUtility.ToJson(feedbackData);
        Debug.Log("SI VINO AL QUERY DE ACTUALIZAR");
        JSONUrl = "http://localhost:4000/api/updateFeedback/" + player.IDPlayer;
        using (UnityWebRequest www = UnityWebRequest.Put(JSONUrl, JSONData))
        {
            www.method = UnityWebRequest.kHttpVerbPUT;
            www.SetRequestHeader("Content-type", "application/json");
            www.SetRequestHeader("Accept", "application/json");
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
                Debug.Log("FALLO EL ACTUALIZAR");
            }
            else
            {
            }
        }
    }
    IEnumerator addFeedbackFirstTime()
    {
        FeedbackObjectDB feedbackData = new FeedbackObjectDB();

        feedbackData.furnaceFeedback = true;
        feedbackData.energyFeedback = true;
        feedbackData.friendFeedback = true;
        
        string JSONData = JsonUtility.ToJson(feedbackData);
        Debug.Log("SI VINO AL QUERY DE AGREGAR LOS PRIMEROS");
        JSONUrl = "http://localhost:4000/api/addFirstFeedback/" + player.IDPlayer;
        using (UnityWebRequest www = UnityWebRequest.Put(JSONUrl, JSONData))
        {
            www.method = UnityWebRequest.kHttpVerbPUT;
            www.SetRequestHeader("Content-type", "application/json");
            www.SetRequestHeader("Accept", "application/json");
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
                Debug.Log("FALLO EL AGREGAR PRIMEROS");
            }
            else
            {
            }
        }
    }
}
