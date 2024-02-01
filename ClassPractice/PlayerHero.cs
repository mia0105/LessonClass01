using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    /// <summary>
    /// 英雄类
    /// </summary>
    public class PlayerHero
    {
        /// <summary>
        /// 英雄名字
        /// </summary>
        public string name; //英雄名字，对名字没有过多操作就不使用属性
        /// <summary>
        /// 最大生命值
        /// </summary>
        public int liveMax;
        /// <summary>
        /// 当前生命值
        /// </summary>
        public int currentLive;
        /// <summary>
        /// 攻击力
        /// </summary>
        public int attack = 1000;
        /// <summary>
        /// 防御力
        /// </summary>
        public int defined = 500;

        //想要这些属性都从外部给它一个值，那么就可以写一个构造函数
        /// <summary>
        /// 创建英雄对象
        /// </summary>
        /// <param name="name">英雄姓名</param>
        /// <param name="liveMax">最大生命值</param>
        /// <param name="currenLive">当前生命值</param>
        /// <param name="attack">攻击力</param>
        /// <param name="defined">防御力</param>
        public PlayerHero(string name,int liveMax,int currenLive,int attack,int defined) 
        {
            //this关键字的作用是：参数名和变量名重复，为了避免冲突
            this.name = name;
            this.liveMax = liveMax;
            this.currentLive = currentLive;
            this.attack = attack;
            this.defined = defined;
        }

        /// <summary>
        /// 攻击敌人的方法
        /// </summary>
        public void AttackEnemy()
        {

        }
        /// <summary>
        /// 移动的方法
        /// </summary>
        public void Move()
        {

        }
        /// <summary>
        /// 受到伤害的方法
        /// </summary>
        public void Demaged()
        {

        }
        /// <summary>
        /// 是否死亡的方法
        /// </summary>
        public bool isDead() //返回值bool类型
        {
            return true;
        }
        /// <summary>
        /// 打印信息
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine("英雄的名字是{0},当前的生命值是{1},攻击力是{2},防御力是{3}", name, currentLive, attack, defined);
        }
    }
}
