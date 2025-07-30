using UnityEngine;
using StarterAssets;

public class PlayerStateMachine : MonoBehaviour
{
    public CharacterController CharacterController { get; private set; }
    public ThirdPersonController ThirdPersonController { get; private set; }
    public BasicRigidBodyPush BasicRigidBodyPush { get; private set; }

    private IPlayerState playerState;

    private void Awake()
    {
        CharacterController = GetComponent<CharacterController>();
        ThirdPersonController = GetComponent<ThirdPersonController>();
        BasicRigidBodyPush = GetComponent<BasicRigidBodyPush>();
    }

    private void Start()
    {

    }

    private void Update()
    {
        playerState?.Tick(Time.deltaTime);
    }

    private void SwitchState(IPlayerState playerState)
    {
        this.playerState?.Exit();
        this.playerState = playerState;
        this.playerState?.Enter();
    }
}
