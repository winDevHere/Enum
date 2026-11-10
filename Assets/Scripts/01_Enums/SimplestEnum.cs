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
        Debug.Log(myDirection + " " + (int)myDirection);
    }
}
