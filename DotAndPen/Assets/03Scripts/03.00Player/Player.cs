using UnityEngine;

public class Player : MonoSingleton<Player>
{
    protected Player() { }

    public PlayerMovementData movementData;

    public float maxLife;
    public float currentLife;

    private Rigidbody2D _RB;

    private void Awake()
    {
        _RB = GetComponent<Rigidbody2D>();

        currentLife = maxLife;
    }

    private void Update()
    {
        #region GRAVITY
        if (_RB.linearVelocity.y < 0)
        {
            _RB.linearVelocity = new Vector2(_RB.linearVelocity.x, Mathf.Max(_RB.linearVelocity.y, -movementData.maxFallSpeed));
        }
        #endregion
    }

    private void LateUpdate()
    {
        if (_RB.linearVelocity.y < 0)
        {
            CMAFollow.Instance.StartLerpYDamping();
            TrapSpawner.Instance.StartLerpYDamping();
        }
    }

    public bool IsGameOver()
    {
        if (currentLife <= 0)
            return true;
        else
            return false;
    }
}
