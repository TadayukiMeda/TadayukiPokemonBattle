using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoUI : MonoBehaviour
{
    public Text nameText;
    public Image background, slider;
    public void SetHpPersent(float persent)
    {
        slider.fillAmount = persent;
    }
}
