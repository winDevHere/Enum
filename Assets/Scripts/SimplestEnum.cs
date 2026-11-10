using UnityEngine;

public enum MyDirection
{
    North,
    East,
    South,
    West
}

public class SimplestEnum : MonoBehaviour
{
    [SerializeField] MyDirection myDirection;

    void Start()
    {
        switch (myDirection)
        {
            case MyDirection.North: Debug.Log("My direction is" + myDirection); break;
            case MyDirection.East:  Debug.Log("My direction is" + myDirection); break;
            case MyDirection.South: Debug.Log("My direction is" + myDirection); break;
            case MyDirection.West:  Debug.Log("My direction is" + myDirection); break;
        }
    }
}
