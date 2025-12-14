using UnityEngine;

[CreateAssetMenu(fileName = "InRangeSpinAttackSO", menuName = "Scriptable Objects/Conditions/InRangeSpinAttackSO")]
public class InRangeSpinAttackSO : AConditionSO
{
    public override bool CheckCondition(EnemyStateMachine enemy)
    {
        float distanceToPlayer = Vector3.Distance(enemy.transform.position, enemy.playerTransform.position);
        if (distanceToPlayer <= enemy.spinAttackRange && enemy.performAttack == 0 && enemy.cooldownTimerSpinAttack <= 0) Debug.Log("Attack spin condition met");
        return distanceToPlayer <= enemy.spinAttackRange && enemy.performAttack == 0 && enemy.cooldownTimerSpinAttack <= 0; //Enemy performAttack is hardcoded make a list of attacks in a enumerator later
    }
}