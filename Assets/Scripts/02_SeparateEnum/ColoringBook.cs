using UnityEngine;

public class ColoringBook : MonoBehaviour
{
    [SerializeField] ColorState colorState;

    void Start()
    {
        Debug.Log(colorState);
    }
}
