using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Text.Interface
{
    public class HumanContainer : MonoBehaviour
    {
        [SerializeField] GameObject _human;
        IHuman _iHuman => _human.GetComponent<IHuman>();//_humanからIHumanをゲットコンポーネントしたものを_iHumanにしている。
        public void Eat() => _iHuman.Eat();//Eatが呼び出されたとき_iHumanのEatが呼び出される
        public void Sleep() => _iHuman.Sleep();//Sleepが呼び出されたとき_iHumanのSleeoが呼び出される
    }
}
