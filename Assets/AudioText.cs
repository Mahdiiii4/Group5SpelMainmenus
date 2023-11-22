using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AudioText : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] TMP_Text audioText;
    
    void Update()
    {
        audioText.text = ("" + (volumeSlider.value)).ToString();
    }
}
