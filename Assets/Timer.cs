using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    Text text;
    
    float theTime;
    public float speed = 1;
    private EGameState _gameState;
    public EPlayer CurrentPlayer { get; private set; }

    public EGameState GameState
    {
        get { return _gameState; }
        set { _gameState = value; }
    }

    // Use this for initialization
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        text = GetComponent<Text>();
 
        theTime += Time.deltaTime * speed;
            string hours = Mathf.Floor((theTime % 216000) / 3600).ToString("00");
            string minutes = Mathf.Floor((theTime % 3600) / 60).ToString("00");
            string seconds = (theTime % 60).ToString("00");
            text.text = hours + ":" + minutes + ":" + seconds;
           
        

        
        }
    

   
}