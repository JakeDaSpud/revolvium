
using UnityEngine;


[CreateAssetMenu(fileName = "LevelRotateDirection",
            menuName = "RUB/level/rotateDir")]
public class levelRotationDirection : ScriptableObject
{
    [SerializeField]
    [Tooltip("Rotation Direction For The Selected Part Of The Cube")]
    public Vector3 dir = Vector3.up;
}
