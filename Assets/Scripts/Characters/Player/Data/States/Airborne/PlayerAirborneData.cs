using System;
using UnityEngine;

[Serializable]
public class PlayerAirborneData
{
    [field: SerializeField] public PlayerJumpData JumpData { get; private set; }
    [field: SerializeField] public PlayerAirJumpData AirJumpData { get; private set; }
    [field: SerializeField] public PlayerFallData FallData { get; private set; }
}
