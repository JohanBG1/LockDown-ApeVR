public interface IPlayerState
{
    void Enter();
    void Tick(float deltaTime);
    void Exit();
}