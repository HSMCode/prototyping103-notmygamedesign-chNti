﻿
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded;
   public void EndGame (){

       if(gameHasEnded == false){
       gameHasEnded = true;
        Debug.Log("GAME OVER");
        Restart();
       }
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Win(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}

