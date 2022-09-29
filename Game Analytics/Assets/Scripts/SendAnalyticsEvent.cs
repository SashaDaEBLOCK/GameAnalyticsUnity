using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameAnalyticsSDK;

public class SendAnalyticsEvent : MonoBehaviour
{
    string eventName = "Button presses.";
    float eventValue;
    public void SendAnalytics()
    {
        Debug.Log("Send Analytics");
        GameAnalytics.NewDesignEvent(eventName, eventValue++);
    }
}
