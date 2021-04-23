using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinOrLose : MonoBehaviour
{
    public GameObject WinCheck;
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player" && Player.HasPassport == true)
        {
            Debug.Log("this");
            SceneManager.LoadScene("Win");
        }
        if (Player.HasWrongPassport == true)
        {
            SceneManager.LoadScene("You lose");
        }
    }
}
