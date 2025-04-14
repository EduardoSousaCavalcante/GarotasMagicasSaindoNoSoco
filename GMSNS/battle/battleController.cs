public class BattleController : Personagens
{
    public Fighter player1;
    public Fighter player2;
    public float roundTime = 99f;

    void Update() {
        HandleTimer();
        HandleInputs();
        CheckCollisions();
        CheckWinCondition();
    }

    void CheckCollisions() {
        if (player1.IsAttacking && player1.Hitbox.Overlaps(player2.Hurtbox)) {
            player2.TakeDamage(player1.CurrentAttackDamage);
        }
        // Vice-versa
    }

    void CheckWinCondition() {
        if (player1.Health <= 0) EndRound(player2);
        if (player2.Health <= 0) EndRound(player1);
    }

    // Outros métodos: controle de tempo, inputs, eventos visuais etc.
}
