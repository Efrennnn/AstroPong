using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public  int PlayerScoreL = 0;
    public  int PlayerScoreR = 0;

    //Buat UI Text
    public TMP_Text txtPlayerScoreL;
    public TMP_Text txtPlayerScoreR;
    
    public static GameManager instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        //Mengisikan nilai integer PlayerScore ke UI
        txtPlayerScoreL.text = PlayerScoreL.ToString();
        txtPlayerScoreR.text = PlayerScoreR.ToString();
    }


    //Method penyeleksi untuk menambah score
    public void Score(string wallID)
    {
        if (wallID == "LeftGoal")
        {
            PlayerScoreR = PlayerScoreR + 1; //Menambah score
            txtPlayerScoreR.text = PlayerScoreR.ToString(); //Mengisikan nilai integer PlayerScore ke UI
	    ScoreCheck();
        }
        else
        {
            PlayerScoreL = PlayerScoreL + 1;
            txtPlayerScoreL.text = PlayerScoreL.ToString();
	    ScoreCheck();
           
        }
    }

    public void ScoreCheck()
    {
        if (PlayerScoreL == 5)
        {
            Debug.Log("playerL win");
            this.gameObject.SendMessage("ChangeScene","MenuScreen");
        }
        else if (PlayerScoreR == 5)
        {
            Debug.Log("playerR win");
            this.gameObject.SendMessage("ChangeScene", "MenuScreen");
        }
    }

}