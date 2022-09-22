using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class player
    {
        public int at = 10;
        public int hp = 100;

        public void Addat(int _at)
        {
            //공격력 증가하기 위한 함수
            at += _at;
        }

        public void Fight(int monsterAt )
        {
            hp -= monsterAt;
        }
    }
}
