using UnityEngine;

public enum Direction
{
    North = 90,
    East = 0,
    South = 270,
    West = 180
}

public class EnumExample : MonoBehaviour
{
    public Direction direction;
    
    void Start()
    {
        switch (direction)
        {
            case Direction.North:   Debug.Log("Heading " + direction); break;
            case Direction.East:    Debug.Log("Heading " + direction); break;
            case Direction.South:   Debug.Log("Heading " + direction); break;
            case Direction.West:    Debug.Log("Heading " + direction); break;
        }

        Debug.Log($"{direction} has value {(int)direction}");
    }
}
