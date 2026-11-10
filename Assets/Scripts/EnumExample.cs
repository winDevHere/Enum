using UnityEngine;

public enum Direction
{
    North,
    East,
    South,
    West
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
        };

        Debug.Log($"{direction} has value {(int)direction}");
    }
}
