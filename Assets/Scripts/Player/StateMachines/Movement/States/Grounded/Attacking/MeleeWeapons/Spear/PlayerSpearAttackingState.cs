using UnityEngine;

public class PlayerSpearAttackingState : PlayerMeleeAttackingState
{
    private PlayerSpearAttackData spearAttackData;

    public PlayerSpearAttackingState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
    {
        spearAttackData = movementData.SpearAttackData;
    }

    public override void Enter()
    {
        base.Enter();

        //StartAnimation(stateMachine.Player.AnimationData.SpearEquippedParameterHash);

        Debug.Log(stateMachine.Player.Animator.GetBool(stateMachine.Player.AnimationData.SpearEquippedParameterHash));
    }

    public override void Exit()
    {
        base.Exit();

        StopAnimation(stateMachine.Player.AnimationData.SpearEquippedParameterHash);
    }

    public override void OnAnimationExitEvent()
    {
        base.OnAnimationExitEvent();

        if (useNextConcurrentAttack)
        {
            return;
        }

        ResetAnimationIndex(stateMachine.Player.AnimationData.SpearAttackParameterName);
        stateMachine.ChangeState(stateMachine.IdlingState);
    }

    public override void OnAnimationTransitionEvent()
    {
        base.OnAnimationTransitionEvent();

        if (useNextConcurrentAttack)
        {
            useNextConcurrentAttack = false;
            NextConcurrentAttack(stateMachine.Player.AnimationData.SpearAttackParameterName);
            if (!IsNextAttackConcurrent(spearAttackData.StartingSpearAttackAnimationIndex, spearAttackData.LastConcurrentSpearAttackAnimationIndex, stateMachine.Player.AnimationData.SpearAttackParameterName))
            {
                stateMachine.Player.Input.PlayerActions.Attack.started -= OnAttackStarted;
            }
            return;
        }
    }

}
