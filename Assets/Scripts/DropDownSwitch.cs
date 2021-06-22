using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDownSwitch : MonoBehaviour
{
    // Start is called before the first frame update


    public TMPro.TMP_Dropdown dd;
    public TapToPlace tapToPlaceScript;
    public ImageTracking imageTrackingScript;


    public void DropDownChange()
    {

        if (dd.captionText.text == "Rozpozn�n� vzoru")
        {
            foreach (Subtitle i in Subtitle.allSubtitles)
            {
                i.StopAllCoroutines();
            }
            foreach (AudioSource i in Subtitle.allAudios)
            {
                i.Stop();
            }
            Subtitle.allAudios.Clear();
            Subtitle.allSubtitles.Clear();

            tapToPlaceScript.enabled = false;
            imageTrackingScript.enabled = true;
            
            TapToPlace.planesEnabled = true;
            TapToPlace.ChangePlanes();

        }
        else if (dd.captionText.text == "Um�st�n� na rovinu")
        {
            foreach (Subtitle i in Subtitle.allSubtitles)
            {
                i.StopAllCoroutines();
            }
            foreach (AudioSource i in Subtitle.allAudios)
            {
                i.Stop();
            }
            Subtitle.allAudios.Clear();
            Subtitle.allSubtitles.Clear();

            imageTrackingScript.enabled = false;
            tapToPlaceScript.enabled = true;

            TapToPlace.planesEnabled = false;
            TapToPlace.ChangePlanes();

        }


    }

    
}
