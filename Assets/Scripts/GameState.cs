using System.Collections;
using UnityEngine;

public enum GameState0
{
    Menu,
    Playing,
    Paused,
    GameOver
}

public class GameState : MonoBehaviour
{
    [SerializeField] GameState0 state0;
    [SerializeField] int stateNumber;

    void Start()
    {
        //switch (state0)
        //{
        //    case GameState0.Menu:       Debug.Log("Menu");      break;
        //    case GameState0.Playing:    Debug.Log("Playing");   break;
        //    case GameState0.Paused:     Debug.Log("Paused");    break;
        //    case GameState0.GameOver:   Debug.Log("GameOver");  break;
        //}
        //StartCoroutine(ChangeStateSequence());
        stateNumber = (int)state0;
        Debug.Log(stateNumber); 
    }

    //IEnumerator ChangeStateSequence()
    //{
    //    stateNumber = (int)state0;
    //    yield return null;
    //}


}
