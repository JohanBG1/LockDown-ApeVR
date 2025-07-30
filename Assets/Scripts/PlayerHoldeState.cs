using UnityEngine;

public class PlayerHoldeState : IPlayerState
{
    private PlayerStateMachine playerStateMachine;

    public void Enter()
    {
        playerStateMachine.CharacterController.enabled = false;
        //playerStateMachine.ThirdPersonController.enabled = false;
        //playerStateMachine.BasicRigidBodyPush.enabled = false;
        //playerStateMachine.StarterAssetsInputs.enabled = false;
    }

    public void Tick(float deltaTime)
    {

    }

    public void Exit()
    {

    }

    public PlayerHoldeState(PlayerStateMachine playerStateMachine)
    {
        this.playerStateMachine = playerStateMachine;
    }
}
