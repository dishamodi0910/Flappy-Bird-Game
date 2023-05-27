using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public static UIManager inst { set; get;}      //We use get and set method so that it can be accessed from the other C# files also.
   public GameObject GameOverMenu;

   private void Start()
   {
        inst = this;
   }

   public void PlayGame()
   {
    SceneManager.LoadScene(1);
   }

   public void GameOver()
   {
    Time.timeScale = 0;
    GameOverMenu.SetActive(true);
   }

   public void restart()
   {
    Time.timeScale = 1;
    SceneManager.LoadScene(1);
   }
}

