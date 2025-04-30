using UnityEngine;

[CreateAssetMenu(menuName = "Movement Data")]
public class PlayerMovementData : ScriptableObject
{
    [Header("Gravity")]
    public float maxFallSpeed;
}
