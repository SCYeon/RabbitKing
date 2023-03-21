using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData : MonoBehaviour
{
    int _hp = 3;
    int _coin = 0;

    bool _stage2 = false;
    bool _stage3 = false;

    bool _crwon = false;

    public void AddHP() { ++_hp; }
    public int GetHP() { return _hp; }
    public void AddCoin(int coin) { _coin += coin; }
    public bool UseCoin(int coin) 
    {
        int tmp_coin = _coin - coin;

        if(tmp_coin >= 0)
        {
            _coin = tmp_coin;
            return true;
        }
        return false;
    }
    public int GetCoin() { return _coin; }
    public void BuyStage(int num) 
    {
        if (num == 2)
            _stage2 = true;
        else if (num == 3)
            _stage3 = true;
    }
    public void BuyCrwon() { _crwon = true; }

    public int CheckStage()
    {
        /* 
         * 구매한 Stage 확인
         * 0 : stage2, stage3 비구매
         * 1 : stage2 구매, stage3 비구매
         * 2 : stage2 비구매, stage3 구매
         * 3 : stage2, stage3 구매
        */

        int stageStatus;

        if (_stage2 && !_stage3)
            stageStatus = 1;
        else if (!_stage2 && _stage3)
            stageStatus = 2;
        else if (_stage2 && _stage3)
            stageStatus = 3;
        else
            stageStatus = 0;

        return stageStatus;
    }
}
