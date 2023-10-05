public class PlayerAttackingIdleState : PlayerAttackingState
{
    public PlayerAttackingIdleState(PlayerAttackingStateMachine playerAttackingStateMachine) : base(playerAttackingStateMachine)
    {
    }

    public override void Enter()
    {
        stateMachine.Player.IsAttacking = false;

        base.Enter();

        StopAnimation(stateMachine.Player.AnimationData.AttackParameterHash);

        DisableWeaponObject();
    }

    public override void Exit()
    {
        stateMachine.Player.IsAttacking = true;

        base.Exit();

        StartAnimation(stateMachine.Player.AnimationData.AttackParameterHash);
    }

    protected override void AddInputActionsCallbacks()
    {
        base.AddInputActionsCallbacks();

        stateMachine.Player.Input.PlayerActions.Attack.started += OnAttackStarted;
    }

    protected override void RemoveInputActionsCallbacks()
    {
        base.RemoveInputActionsCallbacks();

        stateMachine.Player.Input.PlayerActions.Attack.started -= OnAttackStarted;
    }
}