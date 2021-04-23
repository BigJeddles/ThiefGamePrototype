using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetMugShot : MonoBehaviour
{
    public static TargetMugShot instance;
    public Image mugShotImage;

    void Awake()
    {
        instance = this;
    }

    public void UpdateMugShot()
    {

        mugShotImage.sprite = AIMove.aiWithPassport.mugShot;
    }

 
}
