using UnityEngine;
using UnityEngine.InputSystem;

// The game can be in exactly one of these states at a time.
public enum GameState_
{
    Menu,      // 0
    Playing,   // 1
    Paused,    // 2
    GameOver   // 3
}

public class GameStateExample_ : MonoBehaviour
{
    public GameState_ state = GameState_.Menu;

    void Update()
    {
        // Press Space to move through the states in order.
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            state = (GameState_)(((int)state + 1) % 4);
            Debug.Log($"State changed to {state} ({(int)state})");
        }

        // Only run gameplay while Playing.
        if (state == GameState_.Playing)
        {
            // gameplay code would go here
        }
    }
}
