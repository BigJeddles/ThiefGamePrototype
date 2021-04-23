 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Mentor : MonoBehaviour
{
    public Animator MentorAnim;
    public TextMeshPro EntryText;
    public string displaytext;
    void Start()
    {
        EntryText.text = displaytext;
        ShowText();
    }



    void ShowText()
    {
        displaytext = "Hey, you know the drill. To get on the train we need to find a new passport";
        EntryText.text = "";
        StartCoroutine(AnimateText());
        Invoke("ShowText1", 5f);
        
    }
    void ShowText1()
    {
        displaytext = "Your goal is to steal the golden passport from this guy, He should be in the market here.";
        //Show the icon of the guy with the passport
      //  if (AIMove.aiWithPassport = ()


        EntryText.text = "";
        StartCoroutine(AnimateText());
        Invoke("ShowText2", 5f);
    }
    void ShowText2()
    {
        
        displaytext = "once you have it, bring it to me";
        EntryText.text = "";
        StartCoroutine(AnimateText());
        MentorAnim.SetTrigger("MoveAway");
    }
    IEnumerator AnimateText()
    {

        foreach (char letter in displaytext)
        {

            EntryText.text += letter;
            yield return new WaitForSeconds(0.05f);

        }
    }    
}
