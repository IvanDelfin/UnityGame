using SimpleJSON;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class loadDataFeedback : MonoBehaviour
{
    public FeedbackManagement feedback;
    public saveFeedbackData saveFeedbackData;
    public Player player;

    IEnumerator connectDataBaseFeedback()
    {
        string JSONurl = "http://localhost:4000/api/getFeedback/" + player.IDPlayer;
        UnityWebRequest web = UnityWebRequest.Get(JSONurl);
        web.useHttpContinue = false;

        yield return web.SendWebRequest();

        if (web.isNetworkError || web.isHttpError)
        {
            Debug.Log("Error API: " + web.error);
        }
        else
        {
            JSONNode userData = SimpleJSON.JSON.Parse(web.downloadHandler.text);
            Debug.Log("Esto es userData");
            Debug.Log(userData);
            Debug.Log("Esto es userData[0]");
            Debug.Log(userData[0]);
            Debug.Log("Esto es userData.Count");
            Debug.Log(userData.Count);
            if (userData.Count == 0)
            {
                Debug.Log("Entro al agregar los primeros");
                feedback.energyFeedback = true;
                feedback.friendFeedback = true;
                feedback.furnaceFeedback = true;
                saveFeedbackData.addFirstFeedback();
            }
            else{
                Debug.Log("Entro a cargar nomas");
                feedback.furnaceFeedback = userData[0]["activated"];
                feedback.energyFeedback = userData[1]["activated"];
                feedback.friendFeedback = userData[2]["activated"];

                Debug.Log("Este bro es el de furnace tras cargarlo");
                Debug.Log(feedback.furnaceFeedback);
            }
        }
    }
    public void loadFeedback(){
        StartCoroutine(connectDataBaseFeedback());
    }
}
