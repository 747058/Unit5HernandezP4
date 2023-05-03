using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class difficultybutton : MonoBehaviour
{
    private Button button;
    private Gamemanager gameManager;
  
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("Game Manager").GetComponent<Gamemanager>();

        button.onClick.AddListener(SetDifficulty);
    }

    void SetDifficulty()
    {
        Debug.Log(gameObject + " was clicked");
        gameManager.StartGame();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
