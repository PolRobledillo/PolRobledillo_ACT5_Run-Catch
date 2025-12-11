using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(fileName = "ChargeAttackSO", menuName = "Scriptable Objects/EnemyStates/ChargeAttackSO")]
public class ChargeAttackSO : AStateSO
{
    public override void OnStateEnter(EnemyStateMachine enemy)
    {
        Sequence sequence = DOTween.Sequence();
        sequence.AppendCallback(() =>
                {
                    enemy.finishedTelegraphingChargeAttack = false;
                    enemy.chargeAttackCollider.enabled = true;
                    enemy.performingChargeAttack = true;
                })
                .Append(enemy.transform.DOMoveZ(enemy.transform.position.z + enemy.chargeDistance, enemy.chargeTime));
    }
    public override void OnStateUpdate(EnemyStateMachine enemy)
    {
    }
    public override void OnStateExit(EnemyStateMachine enemy)
    {
        enemy.chargeAttackCollider.enabled = false;
        enemy.performingChargeAttack = false;
    }
}
