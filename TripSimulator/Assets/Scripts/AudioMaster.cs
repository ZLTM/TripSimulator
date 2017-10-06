using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMaster : MonoBehaviour {

    uint BankId;
    // Use this for initialization
    void awake ()
    {
        AkSoundEngine.SetRTPCValue("DistanciaBongo", 100);
        AkSoundEngine.SetRTPCValue("DistanciaGuit", 100);
        AkSoundEngine.SetRTPCValue("DistanciaPand", 100);
        AkSoundEngine.SetRTPCValue("DistanciaMalTrip", 100);
    }
    protected void LoadBank() {
        AkSoundEngine.LoadBank("Music", AkSoundEngine.AK_DEFAULT_POOL_ID, out BankId);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void PlayEvent (string eventName)
    {
        AkSoundEngine.PostEvent(eventName, gameObject);
    }

    public void StopEvent (string eventName, int fadeout)
    {
        uint eventId;
        eventId = AkSoundEngine.GetIDFromString(eventName);
        AkSoundEngine.ExecuteActionOnEvent(eventId, AkActionOnEventType.AkActionOnEventType_Stop, gameObject, fadeout * 1000, AkCurveInterpolation.AkCurveInterpolation_Sine);
    }

    public void PauseEvent(string eventName, int fadeout)
    {
        uint eventId;
        eventId = AkSoundEngine.GetIDFromString(eventName);
        AkSoundEngine.ExecuteActionOnEvent(eventId, AkActionOnEventType.AkActionOnEventType_Pause, gameObject, fadeout * 1000, AkCurveInterpolation.AkCurveInterpolation_Sine);
    }

    public void ResumeEvent(string eventName, int fadeout)
    {
        uint eventId;
        eventId = AkSoundEngine.GetIDFromString(eventName);
        AkSoundEngine.ExecuteActionOnEvent(eventId, AkActionOnEventType.AkActionOnEventType_Resume, gameObject, fadeout * 1000, AkCurveInterpolation.AkCurveInterpolation_Sine);
    }

}
