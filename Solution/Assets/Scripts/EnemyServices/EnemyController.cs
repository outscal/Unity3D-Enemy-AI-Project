using UnityEngine;
using UnityEngine.AI;
using VFXServices;
using BulletServices;

namespace EnemyServices
{
    public class EnemyController
    {
        public EnemyModel model { get; private set; }
        public EnemyView view { get; private set; }

        private float timer;
        private float canFire = 0f;
        public EnemyController(EnemyView _view, EnemyModel _model)
        {
            model = _model;
            view = GameObject.Instantiate<EnemyView>(_view, GetRandomPosition(), Quaternion.identity);
            model.SetEnemyController(this);
            view.SetEnemyController(this);

        }
        public Vector3 GetRandomPosition()
        {
            Vector3 randDir = Random.insideUnitSphere * model.patrollingRadius;
            randDir += EnemyService.instance.enemy.enemyView.transform.position;
            NavMeshHit navHit;
            NavMesh.SamplePosition(randDir, out navHit, model.patrollingRadius, NavMesh.AllAreas);
            return navHit.position;
        }


        public void Attack()
        {
            if (canFire < Time.time)
            {
                canFire = model.fireRate + Time.time;
                BulletService.instance.CreateBullet(view.shootingPoint.position, GetFiringAngle(), model.bullet);
            }
        }

        private Quaternion GetFiringAngle()
        {
            return view.transform.rotation;
        }

        public void Patrol()
        {
            timer += Time.deltaTime;
            if (timer > model.patrolTime)
            {
                SetPatrolingDestination();
                timer = 0;
            }
        }

        private void SetPatrolingDestination()
        {
            Vector3 newDestination = GetRandomPosition();
            view.navMeshAgent.SetDestination(newDestination);
        }
        private void Dead()
        {
            EnemyService.instance.DestroyEnemy(this);
        }
        public void ApplyDamage(float damage)
        {
            if (model.health - damage <= 0)
                Dead();
            else
                model.health -= damage;
        }
        public void DestoryController()
        {
            VFXService.instance.InstantiateEffects(view.TankDestroyVFX, view.transform.position);
            model.DestroyModel();
            view.DestroyView();
            model = null;
            view = null;
        }
    }
}