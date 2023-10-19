using System;
using UnityEngine;

[Serializable]
public class PlayerAnimationData
{
    [Header("State Group Parameter Names")]
    [SerializeField] private string groundedParameterName = "Grounded";
    [SerializeField] private string movingParameterName = "Moving";
    [SerializeField] private string stoppingParameterName = "Stopping";
    [SerializeField] private string landingParameterName = "Landing";
    [SerializeField] private string airborneParameterName = "Airborne";
    [SerializeField] private string attackParameterName = "Attacking";

    [Header("Grounded Parameter Names")]
    [SerializeField] private string idleParameterName = "isIdling";
    [SerializeField] private string dashParameterName = "isDashing";
    [SerializeField] private string walkParameterName = "isWalking";
    [SerializeField] private string runParameterName = "isRunning";
    [SerializeField] private string sprintParameterName = "isSprinting";
    [SerializeField] private string mediumStopParameterName = "isMediumStopping";
    [SerializeField] private string hardStopParameterName = "isHardStopping";
    [SerializeField] private string rollParameterName = "isRolling";
    [SerializeField] private string hardLandParameterName = "isHardLanding";

    [Header("Airborne Parameter Names")]
    [SerializeField] private string fallParameterName = "isFalling";

    [field: Header("Attacking Parameter Names")]
    [field: SerializeField] public string SwordAttackParameterName { get; private set; } = "swordAttackState";
    [field: SerializeField] public string SpearAttackParameterName { get; private set; } = "spearAttackState";
    [SerializeField] private string spearEquippedParameterName = "hasEquippedSpear";

    [SerializeField] private string chargeAttackParameterName = "chargeAttack";

    [SerializeField] private string bowEquippedParameterName = "hasEquippedBow";
    [SerializeField] private string hasShotBowParameterName = "hasShotBow";

    public int GroundedParameterHash { get; private set; }
    public int MovingParameterHash { get; private set; }
    public int StoppingParameterHash { get; private set; }
    public int LandingParameterHash { get; private set; }
    public int AirborneParameterHash { get; private set; }
    public int AttackParameterHash { get; private set; }

    public int IdleParameterHash { get; private set; }
    public int DashParameterHash { get; private set; }
    public int WalkParameterHash { get; private set; }
    public int RunParameterHash { get; private set; }
    public int SprintParameterHash { get; private set; }
    public int MediumStopParameterHash { get; private set; }
    public int HardStopParameterHash { get; private set; }
    public int RollParameterHash { get; private set; }
    public int HardLandParameterHash { get; private set; }
    
    public int FallParameterHash { get; private set; }

    public int SpearEquippedParameterHash {  get; private set; }

    public int ChargeAttackParameterHash { get; private set; }

    public int BowEquippedParameterHash { get; private set; }
    public int BowShotParameterHash { get; private set; }

    public void Initialize()
    {
        GroundedParameterHash = Animator.StringToHash(groundedParameterName);
        MovingParameterHash = Animator.StringToHash(movingParameterName);
        StoppingParameterHash = Animator.StringToHash(stoppingParameterName);
        LandingParameterHash = Animator.StringToHash(landingParameterName);
        AirborneParameterHash = Animator.StringToHash(airborneParameterName);
        AttackParameterHash = Animator.StringToHash(attackParameterName);

        IdleParameterHash = Animator.StringToHash(idleParameterName);
        DashParameterHash = Animator.StringToHash(dashParameterName);
        WalkParameterHash = Animator.StringToHash(walkParameterName);
        RunParameterHash = Animator.StringToHash(runParameterName);
        SprintParameterHash = Animator.StringToHash(sprintParameterName);
        MediumStopParameterHash = Animator.StringToHash(mediumStopParameterName);
        HardStopParameterHash = Animator.StringToHash(hardStopParameterName);
        RollParameterHash = Animator.StringToHash(rollParameterName);
        HardLandParameterHash = Animator.StringToHash(hardLandParameterName);

        FallParameterHash = Animator.StringToHash(fallParameterName);

        SpearEquippedParameterHash = Animator.StringToHash(spearEquippedParameterName);

        ChargeAttackParameterHash = Animator.StringToHash(chargeAttackParameterName);

        BowEquippedParameterHash = Animator.StringToHash(bowEquippedParameterName);
        BowShotParameterHash = Animator.StringToHash(hasShotBowParameterName);
    }
}
