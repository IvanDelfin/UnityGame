using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapearFeedback : MonoBehaviour
{
    public GameObject FeedbackImage;
    public void DisapearFeed()
    {
        FeedbackImage.SetActive(false);
    }
}
