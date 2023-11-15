using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class AudioSlider : MonoBehaviour
{
    int n;
    public TMP_Text Audio_text;
    public Slider Slider;
    
    void update()
    {
        Audio_text.text = Slider.value.ToString();
        Debug.Log("" + Audio_text.text);
    }
    
    public void Confirm_Button()
    {
    }
}
